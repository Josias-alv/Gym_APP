namespace SportCity_Test.FormsBases
{
    partial class FormDefault
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDefault));
            this.pictureGym = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGym)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.lbHora);
            this.PanelTop.Controls.Add(this.lbFecha);
            this.PanelTop.Size = new System.Drawing.Size(1057, 165);
            // 
            // pictureGym
            // 
            this.pictureGym.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureGym.Image = ((System.Drawing.Image)(resources.GetObject("pictureGym.Image")));
            this.pictureGym.Location = new System.Drawing.Point(0, 165);
            this.pictureGym.Name = "pictureGym";
            this.pictureGym.Size = new System.Drawing.Size(1057, 499);
            this.pictureGym.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGym.TabIndex = 1;
            this.pictureGym.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(326, 41);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(415, 35);
            this.lbFecha.TabIndex = 5;
            this.lbFecha.Text = "fecha";
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHora
            // 
            this.lbHora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHora.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.White;
            this.lbHora.Location = new System.Drawing.Point(326, 101);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(415, 35);
            this.lbHora.TabIndex = 6;
            this.lbHora.Text = "hora";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 664);
            this.Controls.Add(this.pictureGym);
            this.Name = "FormDefault";
            this.Text = "FormDefault";
            this.Controls.SetChildIndex(this.PanelTop, 0);
            this.Controls.SetChildIndex(this.pictureGym, 0);
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGym)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureGym;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbFecha;
    }
}