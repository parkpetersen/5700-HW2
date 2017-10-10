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
            this.SuspendLayout();
            // 
            // boxPanel
            // 
            this.boxPanel.BackColor = System.Drawing.Color.White;
            this.boxPanel.Location = new System.Drawing.Point(12, 12);
            this.boxPanel.Name = "boxPanel";
            this.boxPanel.Size = new System.Drawing.Size(838, 544);
            this.boxPanel.TabIndex = 0;
            // 
            // GraphicalDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 568);
            this.Controls.Add(this.boxPanel);
            this.Name = "GraphicalDisplay";
            this.Text = "GraphicalDisplay";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel boxPanel;
    }
}