namespace GuiLayer
{
    partial class DescriptionSelecter
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
            this.AthleteListView = new System.Windows.Forms.ListView();
            this.BibNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateButton = new System.Windows.Forms.Button();
            this.ShowFirstNameBox = new System.Windows.Forms.CheckBox();
            this.ShowLastNameBox = new System.Windows.Forms.CheckBox();
            this.ShowAgeBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AthleteListView
            // 
            this.AthleteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BibNumber});
            this.AthleteListView.Location = new System.Drawing.Point(105, 150);
            this.AthleteListView.MultiSelect = false;
            this.AthleteListView.Name = "AthleteListView";
            this.AthleteListView.Size = new System.Drawing.Size(344, 99);
            this.AthleteListView.TabIndex = 1;
            this.AthleteListView.UseCompatibleStateImageBehavior = false;
            this.AthleteListView.View = System.Windows.Forms.View.Details;
            // 
            // BibNumber
            // 
            this.BibNumber.Text = "Bib Number";
            this.BibNumber.Width = 241;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(247, 121);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ShowFirstNameBox
            // 
            this.ShowFirstNameBox.AutoSize = true;
            this.ShowFirstNameBox.Location = new System.Drawing.Point(105, 39);
            this.ShowFirstNameBox.Name = "ShowFirstNameBox";
            this.ShowFirstNameBox.Size = new System.Drawing.Size(106, 17);
            this.ShowFirstNameBox.TabIndex = 3;
            this.ShowFirstNameBox.Text = "Show First Name";
            this.ShowFirstNameBox.UseVisualStyleBackColor = true;
            // 
            // ShowLastNameBox
            // 
            this.ShowLastNameBox.AutoSize = true;
            this.ShowLastNameBox.Location = new System.Drawing.Point(247, 39);
            this.ShowLastNameBox.Name = "ShowLastNameBox";
            this.ShowLastNameBox.Size = new System.Drawing.Size(107, 17);
            this.ShowLastNameBox.TabIndex = 4;
            this.ShowLastNameBox.Text = "Show Last Name";
            this.ShowLastNameBox.UseVisualStyleBackColor = true;
            // 
            // ShowAgeBox
            // 
            this.ShowAgeBox.AutoSize = true;
            this.ShowAgeBox.Location = new System.Drawing.Point(403, 39);
            this.ShowAgeBox.Name = "ShowAgeBox";
            this.ShowAgeBox.Size = new System.Drawing.Size(75, 17);
            this.ShowAgeBox.TabIndex = 5;
            this.ShowAgeBox.Text = "Show Age";
            this.ShowAgeBox.UseVisualStyleBackColor = true;
            // 
            // DescriptionSelecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 261);
            this.Controls.Add(this.ShowAgeBox);
            this.Controls.Add(this.ShowLastNameBox);
            this.Controls.Add(this.ShowFirstNameBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.AthleteListView);
            this.Name = "DescriptionSelecter";
            this.Text = "DescriptionSelecter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView AthleteListView;
        private System.Windows.Forms.ColumnHeader BibNumber;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.CheckBox ShowFirstNameBox;
        private System.Windows.Forms.CheckBox ShowLastNameBox;
        private System.Windows.Forms.CheckBox ShowAgeBox;
    }
}