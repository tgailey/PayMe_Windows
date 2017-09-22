namespace SigningIn_DatabaseV2
{
    partial class OpeningForm
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
            this.BlankPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // BlankPanel
            // 
            this.BlankPanel.Location = new System.Drawing.Point(0, 0);
            this.BlankPanel.Name = "BlankPanel";
            this.BlankPanel.Size = new System.Drawing.Size(285, 410);
            this.BlankPanel.TabIndex = 0;
            // 
            // OpeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.BlankPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OpeningForm";
            this.Text = "OpeningForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BlankPanel;
    }
}

