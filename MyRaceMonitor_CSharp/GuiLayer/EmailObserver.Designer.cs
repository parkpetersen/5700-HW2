namespace GuiLayer
{
    partial class EmailObserver
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
            this.AthleteListview = new System.Windows.Forms.ListView();
            this.BibNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailEntryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubscribeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AthleteListview
            // 
            this.AthleteListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BibNumber,
            this.FirstName});
            this.AthleteListview.Location = new System.Drawing.Point(12, 142);
            this.AthleteListview.MultiSelect = false;
            this.AthleteListview.Name = "AthleteListview";
            this.AthleteListview.Size = new System.Drawing.Size(296, 107);
            this.AthleteListview.TabIndex = 0;
            this.AthleteListview.UseCompatibleStateImageBehavior = false;
            this.AthleteListview.View = System.Windows.Forms.View.Details;
            // 
            // BibNumber
            // 
            this.BibNumber.Text = "Bib Number";
            this.BibNumber.Width = 122;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 125;
            // 
            // EmailEntryBox
            // 
            this.EmailEntryBox.Location = new System.Drawing.Point(12, 78);
            this.EmailEntryBox.Name = "EmailEntryBox";
            this.EmailEntryBox.Size = new System.Drawing.Size(260, 20);
            this.EmailEntryBox.TabIndex = 1;
            this.EmailEntryBox.Text = "Enter email here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your email and select athlete to receive email updates.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Athlete";
            // 
            // SubscribeButton
            // 
            this.SubscribeButton.Location = new System.Drawing.Point(81, 260);
            this.SubscribeButton.Name = "SubscribeButton";
            this.SubscribeButton.Size = new System.Drawing.Size(125, 23);
            this.SubscribeButton.TabIndex = 4;
            this.SubscribeButton.Text = "Subscribe";
            this.SubscribeButton.UseVisualStyleBackColor = true;
            this.SubscribeButton.Click += new System.EventHandler(this.SubscribeButton_Click);
            // 
            // EmailObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 295);
            this.Controls.Add(this.SubscribeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailEntryBox);
            this.Controls.Add(this.AthleteListview);
            this.Name = "EmailObserver";
            this.Text = "EmailObserver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AthleteListview;
        private System.Windows.Forms.ColumnHeader BibNumber;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.TextBox EmailEntryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubscribeButton;
    }
}