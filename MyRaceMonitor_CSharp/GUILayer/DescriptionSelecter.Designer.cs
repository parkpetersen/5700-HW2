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
            this.ShowNameBox = new System.Windows.Forms.CheckBox();
            this.ShowLocationBox = new System.Windows.Forms.CheckBox();
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
            // ShowNameBox
            // 
            this.ShowNameBox.AutoSize = true;
            this.ShowNameBox.Location = new System.Drawing.Point(105, 39);
            this.ShowNameBox.Name = "ShowNameBox";
            this.ShowNameBox.Size = new System.Drawing.Size(84, 17);
            this.ShowNameBox.TabIndex = 3;
            this.ShowNameBox.Text = "Show Name";
            this.ShowNameBox.UseVisualStyleBackColor = true;
            // 
            // ShowLocationBox
            // 
            this.ShowLocationBox.AutoSize = true;
            this.ShowLocationBox.Location = new System.Drawing.Point(247, 39);
            this.ShowLocationBox.Name = "ShowLocationBox";
            this.ShowLocationBox.Size = new System.Drawing.Size(97, 17);
            this.ShowLocationBox.TabIndex = 4;
            this.ShowLocationBox.Text = "Show Location";
            this.ShowLocationBox.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.ShowLocationBox);
            this.Controls.Add(this.ShowNameBox);
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
        private System.Windows.Forms.CheckBox ShowNameBox;
        private System.Windows.Forms.CheckBox ShowLocationBox;
        private System.Windows.Forms.CheckBox ShowAgeBox;
    }
}