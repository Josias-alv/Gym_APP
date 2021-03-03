namespace SportCity_Test.FormsBases
{
    partial class FormError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormError));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LBTITULO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBCONTENIDO = new System.Windows.Forms.Label();
            this.BTNACEPTAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.PanelTop.Controls.Add(this.LBTITULO);
            this.PanelTop.Controls.Add(this.pictureBox1);
            this.PanelTop.Size = new System.Drawing.Size(482, 226);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 12;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LBTITULO
            // 
            this.LBTITULO.Font = new System.Drawing.Font("Comfortaa", 16.25F);
            this.LBTITULO.ForeColor = System.Drawing.Color.White;
            this.LBTITULO.Location = new System.Drawing.Point(60, 171);
            this.LBTITULO.Name = "LBTITULO";
            this.LBTITULO.Size = new System.Drawing.Size(356, 44);
            this.LBTITULO.TabIndex = 7;
            this.LBTITULO.Text = "TITULO";
            this.LBTITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(144, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LBCONTENIDO
            // 
            this.LBCONTENIDO.BackColor = System.Drawing.Color.Transparent;
            this.LBCONTENIDO.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCONTENIDO.ForeColor = System.Drawing.Color.Black;
            this.LBCONTENIDO.Location = new System.Drawing.Point(12, 241);
            this.LBCONTENIDO.Name = "LBCONTENIDO";
            this.LBCONTENIDO.Size = new System.Drawing.Size(453, 180);
            this.LBCONTENIDO.TabIndex = 7;
            this.LBCONTENIDO.Text = "CONTENIDO";
            this.LBCONTENIDO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNACEPTAR
            // 
            this.BTNACEPTAR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.BTNACEPTAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNACEPTAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.BTNACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNACEPTAR.BorderRadius = 7;
            this.BTNACEPTAR.ButtonText = "Aceptar";
            this.BTNACEPTAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNACEPTAR.DisabledColor = System.Drawing.Color.Gray;
            this.BTNACEPTAR.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNACEPTAR.Iconimage = null;
            this.BTNACEPTAR.Iconimage_right = null;
            this.BTNACEPTAR.Iconimage_right_Selected = null;
            this.BTNACEPTAR.Iconimage_Selected = null;
            this.BTNACEPTAR.IconMarginLeft = 0;
            this.BTNACEPTAR.IconMarginRight = 0;
            this.BTNACEPTAR.IconRightVisible = true;
            this.BTNACEPTAR.IconRightZoom = 0D;
            this.BTNACEPTAR.IconVisible = true;
            this.BTNACEPTAR.IconZoom = 90D;
            this.BTNACEPTAR.IsTab = false;
            this.BTNACEPTAR.Location = new System.Drawing.Point(144, 432);
            this.BTNACEPTAR.Name = "BTNACEPTAR";
            this.BTNACEPTAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.BTNACEPTAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(62)))), ((int)(((byte)(49)))));
            this.BTNACEPTAR.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNACEPTAR.selected = true;
            this.BTNACEPTAR.Size = new System.Drawing.Size(193, 51);
            this.BTNACEPTAR.TabIndex = 8;
            this.BTNACEPTAR.Text = "Aceptar";
            this.BTNACEPTAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTNACEPTAR.Textcolor = System.Drawing.Color.White;
            this.BTNACEPTAR.TextFont = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACEPTAR.Click += new System.EventHandler(this.BTNACEPTAR_Click);
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(482, 495);
            this.Controls.Add(this.BTNACEPTAR);
            this.Controls.Add(this.LBCONTENIDO);
            this.Name = "FormError";
            this.Text = "FormError";
            this.Controls.SetChildIndex(this.PanelTop, 0);
            this.Controls.SetChildIndex(this.LBCONTENIDO, 0);
            this.Controls.SetChildIndex(this.BTNACEPTAR, 0);
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label LBTITULO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBCONTENIDO;
        private Bunifu.Framework.UI.BunifuFlatButton BTNACEPTAR;
    }
}