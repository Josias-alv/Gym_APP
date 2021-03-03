namespace SportCity_Test.FormsBases
{
    partial class FormPregunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregunta));
            this.LBCONTENIDO = new System.Windows.Forms.Label();
            this.LBTITULO = new System.Windows.Forms.Label();
            this.BTNACEPTAR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.PanelTop.Controls.Add(this.pictureBox1);
            this.PanelTop.Controls.Add(this.LBTITULO);
            this.PanelTop.Size = new System.Drawing.Size(518, 223);
            // 
            // LBCONTENIDO
            // 
            this.LBCONTENIDO.BackColor = System.Drawing.Color.Transparent;
            this.LBCONTENIDO.Font = new System.Drawing.Font("Comfortaa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBCONTENIDO.ForeColor = System.Drawing.Color.Black;
            this.LBCONTENIDO.Location = new System.Drawing.Point(31, 239);
            this.LBCONTENIDO.Name = "LBCONTENIDO";
            this.LBCONTENIDO.Size = new System.Drawing.Size(453, 180);
            this.LBCONTENIDO.TabIndex = 8;
            this.LBCONTENIDO.Text = "CONTENIDO";
            this.LBCONTENIDO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBTITULO
            // 
            this.LBTITULO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.LBTITULO.Font = new System.Drawing.Font("Comfortaa", 16.25F);
            this.LBTITULO.ForeColor = System.Drawing.Color.White;
            this.LBTITULO.Location = new System.Drawing.Point(35, 168);
            this.LBTITULO.Name = "LBTITULO";
            this.LBTITULO.Size = new System.Drawing.Size(449, 44);
            this.LBTITULO.TabIndex = 9;
            this.LBTITULO.Text = "TITULO";
            this.LBTITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.BTNACEPTAR.Location = new System.Drawing.Point(35, 429);
            this.BTNACEPTAR.Name = "BTNACEPTAR";
            this.BTNACEPTAR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.BTNACEPTAR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(62)))), ((int)(((byte)(49)))));
            this.BTNACEPTAR.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNACEPTAR.selected = true;
            this.BTNACEPTAR.Size = new System.Drawing.Size(193, 51);
            this.BTNACEPTAR.TabIndex = 10;
            this.BTNACEPTAR.Text = "Aceptar";
            this.BTNACEPTAR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BTNACEPTAR.Textcolor = System.Drawing.Color.White;
            this.BTNACEPTAR.TextFont = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACEPTAR.Click += new System.EventHandler(this.BTNACEPTAR_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.BorderRadius = 7;
            this.btncancelar.ButtonText = "Cancelar";
            this.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btncancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btncancelar.Iconimage = null;
            this.btncancelar.Iconimage_right = null;
            this.btncancelar.Iconimage_right_Selected = null;
            this.btncancelar.Iconimage_Selected = null;
            this.btncancelar.IconMarginLeft = 0;
            this.btncancelar.IconMarginRight = 0;
            this.btncancelar.IconRightVisible = true;
            this.btncancelar.IconRightZoom = 0D;
            this.btncancelar.IconVisible = true;
            this.btncancelar.IconZoom = 90D;
            this.btncancelar.IsTab = false;
            this.btncancelar.Location = new System.Drawing.Point(295, 429);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(92)))), ((int)(((byte)(94)))));
            this.btncancelar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(62)))), ((int)(((byte)(49)))));
            this.btncancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btncancelar.selected = true;
            this.btncancelar.Size = new System.Drawing.Size(193, 51);
            this.btncancelar.TabIndex = 11;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancelar.Textcolor = System.Drawing.Color.White;
            this.btncancelar.TextFont = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 12;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(518, 492);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.BTNACEPTAR);
            this.Controls.Add(this.LBCONTENIDO);
            this.Name = "FormPregunta";
            this.Text = "FormPregunta";
            this.Controls.SetChildIndex(this.PanelTop, 0);
            this.Controls.SetChildIndex(this.LBCONTENIDO, 0);
            this.Controls.SetChildIndex(this.BTNACEPTAR, 0);
            this.Controls.SetChildIndex(this.btncancelar, 0);
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBCONTENIDO;
        private System.Windows.Forms.Label LBTITULO;
        private Bunifu.Framework.UI.BunifuFlatButton BTNACEPTAR;
        private Bunifu.Framework.UI.BunifuFlatButton btncancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}