namespace SportCity_Test.FormsBases
{
    partial class FormPrincipalBase
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.paneTop = new System.Windows.Forms.Panel();
            this.PanelFIll = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(297, 658);
            this.panelMenu.TabIndex = 0;
            // 
            // paneTop
            // 
            this.paneTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.paneTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneTop.Location = new System.Drawing.Point(297, 0);
            this.paneTop.Name = "paneTop";
            this.paneTop.Size = new System.Drawing.Size(1023, 100);
            this.paneTop.TabIndex = 1;
            // 
            // PanelFIll
            // 
            this.PanelFIll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PanelFIll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFIll.Location = new System.Drawing.Point(297, 100);
            this.PanelFIll.Name = "PanelFIll";
            this.PanelFIll.Size = new System.Drawing.Size(1023, 558);
            this.PanelFIll.TabIndex = 2;
            // 
            // FormPrincipalBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 658);
            this.Controls.Add(this.PanelFIll);
            this.Controls.Add(this.paneTop);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1211, 677);
            this.Name = "FormPrincipalBase";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipalBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipalBase_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelMenu;
        protected System.Windows.Forms.Panel paneTop;
        protected System.Windows.Forms.Panel PanelFIll;
    }
}