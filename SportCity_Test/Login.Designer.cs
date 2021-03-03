namespace SportCity_Test
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelINfo = new System.Windows.Forms.Panel();
            this.txtcontra = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtuser = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            this.panelINfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.panel1.Controls.Add(this.pictureBox1);
            // 
            // panelINfo
            // 
            this.panelINfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panelINfo.Controls.Add(this.txtcontra);
            this.panelINfo.Controls.Add(this.txtuser);
            this.panelINfo.Controls.Add(this.label3);
            this.panelINfo.Controls.Add(this.label2);
            this.panelINfo.Controls.Add(this.btnlogin);
            this.panelINfo.Controls.Add(this.label1);
            this.panelINfo.Location = new System.Drawing.Point(720, 61);
            this.panelINfo.Name = "panelINfo";
            this.panelINfo.Size = new System.Drawing.Size(452, 503);
            this.panelINfo.TabIndex = 1;
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtcontra.BorderColorFocused = System.Drawing.Color.Silver;
            this.txtcontra.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtcontra.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.txtcontra.BorderThickness = 3;
            this.txtcontra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontra.ForeColor = System.Drawing.Color.Silver;
            this.txtcontra.isPassword = true;
            this.txtcontra.Location = new System.Drawing.Point(17, 305);
            this.txtcontra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(416, 54);
            this.txtcontra.TabIndex = 8;
            this.txtcontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcontra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontra_KeyPress);
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtuser.BorderColorFocused = System.Drawing.Color.Silver;
            this.txtuser.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.txtuser.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.txtuser.BorderThickness = 3;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.Silver;
            this.txtuser.isPassword = false;
            this.txtuser.Location = new System.Drawing.Point(17, 173);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(416, 58);
            this.txtuser.TabIndex = 7;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comfortaa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(154, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(166, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // btnlogin
            // 
            this.btnlogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogin.BorderRadius = 7;
            this.btnlogin.ButtonText = "Iniciar Sesion";
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnlogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnlogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnlogin.Iconimage")));
            this.btnlogin.Iconimage_right = null;
            this.btnlogin.Iconimage_right_Selected = null;
            this.btnlogin.Iconimage_Selected = null;
            this.btnlogin.IconMarginLeft = 0;
            this.btnlogin.IconMarginRight = 0;
            this.btnlogin.IconRightVisible = true;
            this.btnlogin.IconRightZoom = 0D;
            this.btnlogin.IconVisible = true;
            this.btnlogin.IconZoom = 90D;
            this.btnlogin.IsTab = false;
            this.btnlogin.Location = new System.Drawing.Point(88, 388);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnlogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnlogin.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnlogin.selected = false;
            this.btnlogin.Size = new System.Drawing.Size(275, 48);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Iniciar Sesion";
            this.btnlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlogin.Textcolor = System.Drawing.Color.White;
            this.btnlogin.TextFont = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(102, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicia Sesion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(653, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 12;
            this.bunifuElipse1.TargetControl = this.panelINfo;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1210, 640);
            this.Controls.Add(this.panelINfo);
            this.Name = "Login";
            this.Text = "Login";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panelINfo, 0);
            this.panel1.ResumeLayout(false);
            this.panelINfo.ResumeLayout(false);
            this.panelINfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelINfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtcontra;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtuser;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}