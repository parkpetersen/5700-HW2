using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLayer;
using System.Net;
using System.Net.Mail;

namespace GuiLayer
{
    public partial class EmailObserver : AthleteObserver
    {
        NetworkCredential credentials = new NetworkCredential("programemail1234@gmail.com", "jimsemail1234");
        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        string toEmail;
        Athlete emailedAthlete;
        int counter = 0;

        public EmailObserver(Dictionary<int, Athlete> AthleteList)
        {
            ObservedAthleteList = new List<Athlete>();
            InitializeComponent();
            foreach (int key in AthleteList.Keys)
            {
                ListViewItem item = new ListViewItem(AthleteList[key].BibNumber.ToString()) { Tag = AthleteList[key] };
                AthleteListview.Items.Add(item);
            }
            client.Credentials = credentials;
            client.EnableSsl = Enabled;
        }
        

        public void sendMessage()
        {
            string messageBody = $"{emailedAthlete.FirstName} {emailedAthlete.Lastname}, racer number {emailedAthlete.BibNumber} has traveled {emailedAthlete.Location} meters.";
            MailMessage message = new MailMessage();
            message.To.Add(toEmail);
            message.From = new MailAddress("Programemail1234@gmail.com");
            message.Subject = "Race Update";
            message.Body = messageBody;
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                            ex.ToString());
            }


        }

        private bool ValidateEmail(string email)
        {
            try
            {
                var address = new MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            toEmail = EmailEntryBox.Text;
            if (ValidateEmail(toEmail))
            {
                foreach (ListViewItem item in AthleteListview.SelectedItems)
                {
                    emailedAthlete = item.Tag as Athlete;
                }
                emailedAthlete.registerObserver(this);
                this.Hide();
            }
            else
            {
                label1.Text = "Invalid Email.";
            }
        }

        public override void RefreshObserver()
        {
            if(counter % 60 == 0)
            {
                sendMessage();
            }
            counter++;
        }
    }
}
