namespace GuiLayer
{
    partial class AthleteDescriber
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
            this.DescriptionListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // DescriptionListView
            // 
            this.DescriptionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.DescriptionListView.Location = new System.Drawing.Point(12, 12);
            this.DescriptionListView.Name = "DescriptionListView";
            this.DescriptionListView.Size = new System.Drawing.Size(717, 126);
            this.DescriptionListView.TabIndex = 0;
            this.DescriptionListView.UseCompatibleStateImageBehavior = false;
            this.DescriptionListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description:";
            this.columnHeader1.Width = 694;
            // 
            // AthleteDescriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 150);
            this.Controls.Add(this.DescriptionListView);
            this.Name = "AthleteDescriber";
            this.Text = "AthleteDescriber";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ListView DescriptionListView;
    }
}