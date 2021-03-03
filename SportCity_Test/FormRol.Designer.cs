namespace SportCity_Test
{
    partial class FormRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRol));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.PictureBox();
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Grid_Rol = new System.Windows.Forms.DataGridView();
            this.txtfiltro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombrerol = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Rol)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.exit);
            this.PanelTop.Controls.Add(this.label2);
            this.PanelTop.Size = new System.Drawing.Size(931, 83);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(365, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 44);
            this.label2.TabIndex = 103;
            this.label2.Text = "PANEL ROL";
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(883, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 40);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 104;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.BorderRadius = 7;
            this.btnguardar.ButtonText = "Guardar";
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnguardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnguardar.Iconimage = null;
            this.btnguardar.Iconimage_right = null;
            this.btnguardar.Iconimage_right_Selected = null;
            this.btnguardar.Iconimage_Selected = null;
            this.btnguardar.IconMarginLeft = 0;
            this.btnguardar.IconMarginRight = 0;
            this.btnguardar.IconRightVisible = true;
            this.btnguardar.IconRightZoom = 0D;
            this.btnguardar.IconVisible = true;
            this.btnguardar.IconZoom = 90D;
            this.btnguardar.IsTab = false;
            this.btnguardar.Location = new System.Drawing.Point(497, 472);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnguardar.OnHovercolor = System.Drawing.Color.Gray;
            this.btnguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardar.selected = true;
            this.btnguardar.Size = new System.Drawing.Size(396, 51);
            this.btnguardar.TabIndex = 104;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnguardar.Textcolor = System.Drawing.Color.White;
            this.btnguardar.TextFont = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.BorderRadius = 7;
            this.btneliminar.ButtonText = "Eliminar";
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btneliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btneliminar.Iconimage = null;
            this.btneliminar.Iconimage_right = null;
            this.btneliminar.Iconimage_right_Selected = null;
            this.btneliminar.Iconimage_Selected = null;
            this.btneliminar.IconMarginLeft = 0;
            this.btneliminar.IconMarginRight = 0;
            this.btneliminar.IconRightVisible = true;
            this.btneliminar.IconRightZoom = 0D;
            this.btneliminar.IconVisible = true;
            this.btneliminar.IconZoom = 90D;
            this.btneliminar.IsTab = false;
            this.btneliminar.Location = new System.Drawing.Point(262, 472);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btneliminar.OnHovercolor = System.Drawing.Color.Gray;
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = true;
            this.btneliminar.Size = new System.Drawing.Size(176, 51);
            this.btneliminar.TabIndex = 103;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneliminar.Textcolor = System.Drawing.Color.White;
            this.btneliminar.TextFont = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btneditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneditar.BorderRadius = 7;
            this.btneditar.ButtonText = "Editar";
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.DisabledColor = System.Drawing.Color.Gray;
            this.btneditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btneditar.Iconimage = null;
            this.btneditar.Iconimage_right = null;
            this.btneditar.Iconimage_right_Selected = null;
            this.btneditar.Iconimage_Selected = null;
            this.btneditar.IconMarginLeft = 0;
            this.btneditar.IconMarginRight = 0;
            this.btneditar.IconRightVisible = true;
            this.btneditar.IconRightZoom = 0D;
            this.btneditar.IconVisible = true;
            this.btneditar.IconZoom = 90D;
            this.btneditar.IsTab = false;
            this.btneditar.Location = new System.Drawing.Point(31, 472);
            this.btneditar.Name = "btneditar";
            this.btneditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btneditar.OnHovercolor = System.Drawing.Color.Gray;
            this.btneditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneditar.selected = true;
            this.btneditar.Size = new System.Drawing.Size(152, 51);
            this.btneditar.TabIndex = 102;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneditar.Textcolor = System.Drawing.Color.White;
            this.btneditar.TextFont = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.BorderRadius = 7;
            this.btnUsuarios.ButtonText = "Limpiar Campos";
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Iconimage = null;
            this.btnUsuarios.Iconimage_right = null;
            this.btnUsuarios.Iconimage_right_Selected = null;
            this.btnUsuarios.Iconimage_Selected = null;
            this.btnUsuarios.IconMarginLeft = 0;
            this.btnUsuarios.IconMarginRight = 0;
            this.btnUsuarios.IconRightVisible = true;
            this.btnUsuarios.IconRightZoom = 0D;
            this.btnUsuarios.IconVisible = true;
            this.btnUsuarios.IconZoom = 90D;
            this.btnUsuarios.IsTab = false;
            this.btnUsuarios.Location = new System.Drawing.Point(712, 112);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnUsuarios.OnHovercolor = System.Drawing.Color.Gray;
            this.btnUsuarios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsuarios.selected = true;
            this.btnUsuarios.Size = new System.Drawing.Size(181, 51);
            this.btnUsuarios.TabIndex = 101;
            this.btnUsuarios.Text = "Limpiar Campos";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsuarios.Textcolor = System.Drawing.Color.White;
            this.btnUsuarios.TextFont = new System.Drawing.Font("Comfortaa", 12.25F);
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // Grid_Rol
            // 
            this.Grid_Rol.AllowUserToAddRows = false;
            this.Grid_Rol.AllowUserToDeleteRows = false;
            this.Grid_Rol.AllowUserToResizeColumns = false;
            this.Grid_Rol.AllowUserToResizeRows = false;
            this.Grid_Rol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Rol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Rol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_Rol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Grid_Rol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid_Rol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Grid_Rol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Rol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Rol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Rol.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_Rol.Location = new System.Drawing.Point(31, 176);
            this.Grid_Rol.Name = "Grid_Rol";
            this.Grid_Rol.ReadOnly = true;
            this.Grid_Rol.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Grid_Rol.RowHeadersVisible = false;
            this.Grid_Rol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Rol.Size = new System.Drawing.Size(407, 272);
            this.Grid_Rol.TabIndex = 100;
            // 
            // txtfiltro
            // 
            this.txtfiltro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtfiltro.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltro.ForeColor = System.Drawing.Color.White;
            this.txtfiltro.HintForeColor = System.Drawing.Color.White;
            this.txtfiltro.HintText = "Filtro por Rol";
            this.txtfiltro.isPassword = false;
            this.txtfiltro.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtfiltro.LineIdleColor = System.Drawing.Color.Gray;
            this.txtfiltro.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtfiltro.LineThickness = 4;
            this.txtfiltro.Location = new System.Drawing.Point(31, 109);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(407, 54);
            this.txtfiltro.TabIndex = 105;
            this.txtfiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtfiltro.OnValueChanged += new System.EventHandler(this.txtfiltro_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(492, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 30);
            this.label1.TabIndex = 107;
            this.label1.Text = "Nombre del Rol:";
            // 
            // txtnombrerol
            // 
            this.txtnombrerol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtnombrerol.BorderColorFocused = System.Drawing.Color.Gray;
            this.txtnombrerol.BorderColorIdle = System.Drawing.Color.DimGray;
            this.txtnombrerol.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtnombrerol.BorderThickness = 3;
            this.txtnombrerol.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombrerol.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrerol.ForeColor = System.Drawing.Color.White;
            this.txtnombrerol.isPassword = false;
            this.txtnombrerol.Location = new System.Drawing.Point(497, 274);
            this.txtnombrerol.Margin = new System.Windows.Forms.Padding(5);
            this.txtnombrerol.Name = "txtnombrerol";
            this.txtnombrerol.Size = new System.Drawing.Size(396, 47);
            this.txtnombrerol.TabIndex = 108;
            this.txtnombrerol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 548);
            this.Controls.Add(this.txtnombrerol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.Grid_Rol);
            this.Name = "FormRol";
            this.Text = "FormRol";
            this.Load += new System.EventHandler(this.FormRol_Load);
            this.Controls.SetChildIndex(this.PanelTop, 0);
            this.Controls.SetChildIndex(this.Grid_Rol, 0);
            this.Controls.SetChildIndex(this.btnUsuarios, 0);
            this.Controls.SetChildIndex(this.btneditar, 0);
            this.Controls.SetChildIndex(this.btneliminar, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.txtfiltro, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtnombrerol, 0);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Rol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox exit;
        private Bunifu.Framework.UI.BunifuFlatButton btnguardar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btneditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuarios;
        private System.Windows.Forms.DataGridView Grid_Rol;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtfiltro;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtnombrerol;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}