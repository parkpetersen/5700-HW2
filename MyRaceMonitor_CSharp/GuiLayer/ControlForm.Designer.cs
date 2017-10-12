namespace GuiLayer
{
    partial class ControlForm
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
            this.ObserverListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmailButton = new System.Windows.Forms.Button();
            this.AthleteDescriptionButton = new System.Windows.Forms.Button();
            this.GraphicDisplayButton = new System.Windows.Forms.Button();
            this.ListDisplayButton = new System.Windows.Forms.Button();
            this.SubscribedListView = new System.Windows.Forms.ListView();
            this.Athlete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObservedAthletesLabel = new System.Windows.Forms.Label();
            this.AthleteListView = new System.Windows.Forms.ListView();
            this.BibNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AthleteListLabel = new System.Windows.Forms.Label();
            this.SubscribeButton = new System.Windows.Forms.Button();
            this.UnsubscribeButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.LengthEntryBox = new System.Windows.Forms.TextBox();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ObserverListView
            // 
            this.ObserverListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title});
            this.ObserverListView.Location = new System.Drawing.Point(11, 25);
            this.ObserverListView.Name = "ObserverListView";
            this.ObserverListView.Size = new System.Drawing.Size(383, 169);
            this.ObserverListView.TabIndex = 0;
            this.ObserverListView.UseCompatibleStateImageBehavior = false;
            this.ObserverListView.View = System.Windows.Forms.View.Details;
            this.ObserverListView.SelectedIndexChanged += new System.EventHandler(this.ObserverListView_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "";
            this.Title.Width = 372;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Observers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmailButton);
            this.groupBox1.Controls.Add(this.AthleteDescriptionButton);
            this.groupBox1.Controls.Add(this.GraphicDisplayButton);
            this.groupBox1.Controls.Add(this.ListDisplayButton);
            this.groupBox1.Location = new System.Drawing.Point(452, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 169);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Observer";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // EmailButton
            // 
            this.EmailButton.Location = new System.Drawing.Point(135, 114);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(77, 37);
            this.EmailButton.TabIndex = 3;
            this.EmailButton.Text = "Email Observer";
            this.EmailButton.UseVisualStyleBackColor = true;
            this.EmailButton.Click += new System.EventHandler(this.EmailButton_Click);
            // 
            // AthleteDescriptionButton
            // 
            this.AthleteDescriptionButton.Location = new System.Drawing.Point(29, 114);
            this.AthleteDescriptionButton.Name = "AthleteDescriptionButton";
            this.AthleteDescriptionButton.Size = new System.Drawing.Size(83, 37);
            this.AthleteDescriptionButton.TabIndex = 2;
            this.AthleteDescriptionButton.Text = "Athlete Description";
            this.AthleteDescriptionButton.UseVisualStyleBackColor = true;
            this.AthleteDescriptionButton.Click += new System.EventHandler(this.AthleteDescriptionButton_Click);
            // 
            // GraphicDisplayButton
            // 
            this.GraphicDisplayButton.Location = new System.Drawing.Point(135, 44);
            this.GraphicDisplayButton.Name = "GraphicDisplayButton";
            this.GraphicDisplayButton.Size = new System.Drawing.Size(78, 38);
            this.GraphicDisplayButton.TabIndex = 1;
            this.GraphicDisplayButton.Text = "Graphic Display";
            this.GraphicDisplayButton.UseVisualStyleBackColor = true;
            this.GraphicDisplayButton.Click += new System.EventHandler(this.GraphicDisplayButton_Click);
            // 
            // ListDisplayButton
            // 
            this.ListDisplayButton.Location = new System.Drawing.Point(29, 44);
            this.ListDisplayButton.Name = "ListDisplayButton";
            this.ListDisplayButton.Size = new System.Drawing.Size(84, 39);
            this.ListDisplayButton.TabIndex = 0;
            this.ListDisplayButton.Text = "List Display";
            this.ListDisplayButton.UseVisualStyleBackColor = true;
            this.ListDisplayButton.Click += new System.EventHandler(this.ListDisplayButton_Click);
            // 
            // SubscribedListView
            // 
            this.SubscribedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Athlete,
            this.columnHeader1,
            this.columnHeader2});
            this.SubscribedListView.Location = new System.Drawing.Point(12, 267);
            this.SubscribedListView.Name = "SubscribedListView";
            this.SubscribedListView.Size = new System.Drawing.Size(294, 196);
            this.SubscribedListView.TabIndex = 3;
            this.SubscribedListView.UseCompatibleStateImageBehavior = false;
            this.SubscribedListView.View = System.Windows.Forms.View.Details;
            // 
            // Athlete
            // 
            this.Athlete.Text = "Bib";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "1st Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "LastName";
            // 
            // ObservedAthletesLabel
            // 
            this.ObservedAthletesLabel.AutoSize = true;
            this.ObservedAthletesLabel.Location = new System.Drawing.Point(42, 251);
            this.ObservedAthletesLabel.Name = "ObservedAthletesLabel";
            this.ObservedAthletesLabel.Size = new System.Drawing.Size(79, 13);
            this.ObservedAthletesLabel.TabIndex = 4;
            this.ObservedAthletesLabel.Text = "Subscribed To:";
            // 
            // AthleteListView
            // 
            this.AthleteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BibNumber,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.Age});
            this.AthleteListView.Location = new System.Drawing.Point(417, 265);
            this.AthleteListView.Name = "AthleteListView";
            this.AthleteListView.Size = new System.Drawing.Size(490, 198);
            this.AthleteListView.TabIndex = 5;
            this.AthleteListView.UseCompatibleStateImageBehavior = false;
            this.AthleteListView.View = System.Windows.Forms.View.Details;
            // 
            // BibNumber
            // 
            this.BibNumber.Text = "BibNumber";
            this.BibNumber.Width = 102;
            // 
            // FirstName
            // 
            this.FirstName.Text = "1st Name";
            this.FirstName.Width = 89;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 105;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 90;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 92;
            // 
            // AthleteListLabel
            // 
            this.AthleteListLabel.AutoSize = true;
            this.AthleteListLabel.Location = new System.Drawing.Point(449, 249);
            this.AthleteListLabel.Name = "AthleteListLabel";
            this.AthleteListLabel.Size = new System.Drawing.Size(45, 13);
            this.AthleteListLabel.TabIndex = 6;
            this.AthleteListLabel.Text = "Athletes";
            // 
            // SubscribeButton
            // 
            this.SubscribeButton.Location = new System.Drawing.Point(335, 298);
            this.SubscribeButton.Name = "SubscribeButton";
            this.SubscribeButton.Size = new System.Drawing.Size(59, 37);
            this.SubscribeButton.TabIndex = 7;
            this.SubscribeButton.Text = "<";
            this.SubscribeButton.UseVisualStyleBackColor = true;
            this.SubscribeButton.Click += new System.EventHandler(this.SubScribeButton_Click);
            // 
            // UnsubscribeButton
            // 
            this.UnsubscribeButton.Location = new System.Drawing.Point(332, 393);
            this.UnsubscribeButton.Name = "UnsubscribeButton";
            this.UnsubscribeButton.Size = new System.Drawing.Size(62, 44);
            this.UnsubscribeButton.TabIndex = 8;
            this.UnsubscribeButton.Text = ">";
            this.UnsubscribeButton.UseVisualStyleBackColor = true;
            this.UnsubscribeButton.Click += new System.EventHandler(this.UnsubscribeButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(768, 169);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(104, 25);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start Simulation";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(768, 237);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(109, 22);
            this.RefreshButton.TabIndex = 10;
            this.RefreshButton.Text = "Refresh Athletes";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // LengthEntryBox
            // 
            this.LengthEntryBox.Location = new System.Drawing.Point(735, 126);
            this.LengthEntryBox.Name = "LengthEntryBox";
            this.LengthEntryBox.Size = new System.Drawing.Size(172, 20);
            this.LengthEntryBox.TabIndex = 11;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Location = new System.Drawing.Point(704, 94);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(221, 13);
            this.InstructionLabel.TabIndex = 12;
            this.InstructionLabel.Text = "Enter course length and click Start Simulation";
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 495);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.LengthEntryBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.UnsubscribeButton);
            this.Controls.Add(this.SubscribeButton);
            this.Controls.Add(this.AthleteListLabel);
            this.Controls.Add(this.AthleteListView);
            this.Controls.Add(this.ObservedAthletesLabel);
            this.Controls.Add(this.SubscribedListView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObserverListView);
            this.Name = "ControlForm";
            this.Text = "Control Form";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ObserverListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.Button AthleteDescriptionButton;
        private System.Windows.Forms.Button GraphicDisplayButton;
        private System.Windows.Forms.Button ListDisplayButton;
        private System.Windows.Forms.ListView SubscribedListView;
        private System.Windows.Forms.Label ObservedAthletesLabel;
        private System.Windows.Forms.ListView AthleteListView;
        private System.Windows.Forms.Label AthleteListLabel;
        private System.Windows.Forms.Button SubscribeButton;
        private System.Windows.Forms.Button UnsubscribeButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ColumnHeader BibNumber;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Athlete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox LengthEntryBox;
        private System.Windows.Forms.Label InstructionLabel;
    }
}

