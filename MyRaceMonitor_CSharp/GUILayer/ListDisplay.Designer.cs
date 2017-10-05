namespace GuiLayer
{
    partial class ListDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AthleteDisplayView = new System.Windows.Forms.ListView();
            this.BibNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Started = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Distance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Finished = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // AthleteDisplayView
            // 
            this.AthleteDisplayView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BibNumber,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.Age,
            this.Started,
            this.Distance,
            this.Finished});
            this.AthleteDisplayView.Location = new System.Drawing.Point(12, 12);
            this.AthleteDisplayView.Name = "AthleteDisplayView";
            this.AthleteDisplayView.Size = new System.Drawing.Size(672, 485);
            this.AthleteDisplayView.TabIndex = 0;
            this.AthleteDisplayView.UseCompatibleStateImageBehavior = false;
            this.AthleteDisplayView.View = System.Windows.Forms.View.Details;
            // 
            // BibNumber
            // 
            this.BibNumber.Text = "BibNumber";
            this.BibNumber.Width = 86;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 83;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 87;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            // 
            // Age
            // 
            this.Age.Text = "Age";
            // 
            // Started
            // 
            this.Started.Text = "Started";
            // 
            // Distance
            // 
            this.Distance.Text = "Distance";
            // 
            // Finished
            // 
            this.Finished.Text = "Finished";
            // 
            // ListDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 509);
            this.Controls.Add(this.AthleteDisplayView);
            this.Name = "ListDisplay";
            this.Text = "ListDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView AthleteDisplayView;
        private System.Windows.Forms.ColumnHeader BibNumber;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader Started;
        private System.Windows.Forms.ColumnHeader Distance;
        private System.Windows.Forms.ColumnHeader Finished;
    }
}