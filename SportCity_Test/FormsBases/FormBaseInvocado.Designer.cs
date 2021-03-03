namespace SportCity_Test.FormsBases
{
    partial class FormBaseInvocado
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
            this.PanelTop = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1057, 89);
            this.PanelTop.TabIndex = 0;
            // 
            // FormBaseInvocado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1057, 664);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaseInvocado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaseInvocado";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel PanelTop;
    }
}