namespace GuiLayer
{
    partial class GraphicalDisplay
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
            this.boxPanel = new System.Windows.Forms.Panel();
            this.ColorKeyListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // boxPanel
            // 
            this.boxPanel.BackColor = System.Drawing.Color.White;
            this.boxPanel.Location = new System.Drawing.Point(12, 172);
            this.boxPanel.Name = "boxPanel";
            this.boxPanel.Size = new System.Drawing.Size(838, 384);
            this.boxPanel.TabIndex = 0;
            // 
            // ColorKeyListView
            // 
            this.ColorKeyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ColorKeyListView.Location = new System.Drawing.Point(12, 24);
            this.ColorKeyListView.Name = "ColorKeyListView";
            this.ColorKeyListView.Size = new System.Drawing.Size(838, 97);
            this.ColorKeyListView.TabIndex = 1;
            this.ColorKeyListView.UseCompatibleStateImageBehavior = false;
            this.ColorKeyListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "BibNumber";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Color";
            // 
            // GraphicalDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 568);
            this.Controls.Add(this.ColorKeyListView);
            this.Controls.Add(this.boxPanel);
            this.Name = "GraphicalDisplay";
            this.Text = "GraphicalDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boxPanel;
        private System.Windows.Forms.ListView ColorKeyListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}