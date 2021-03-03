namespace SportCity_Test
{
    partial class FormCuotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCuotas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exit = new System.Windows.Forms.PictureBox();
            this.Grid_Cuota = new System.Windows.Forms.DataGridView();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnguardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtCuota = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mover = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.redndear = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Cuota)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.label2);
            this.PanelTop.Controls.Add(this.exit);
            this.PanelTop.Size = new System.Drawing.Size(931, 76);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(876, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 40);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Grid_Cuota
            // 
            this.Grid_Cuota.AllowUserToAddRows = false;
            this.Grid_Cuota.AllowUserToDeleteRows = false;
            this.Grid_Cuota.AllowUserToResizeColumns = false;
            this.Grid_Cuota.AllowUserToResizeRows = false;
            this.Grid_Cuota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Cuota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Cuota.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_Cuota.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Grid_Cuota.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid_Cuota.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Grid_Cuota.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Cuota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Cuota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Cuota.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_Cuota.Location = new System.Drawing.Point(26, 158);
            this.Grid_Cuota.Name = "Grid_Cuota";
            this.Grid_Cuota.ReadOnly = true;
            this.Grid_Cuota.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Grid_Cuota.RowHeadersVisible = false;
            this.Grid_Cuota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Cuota.Size = new System.Drawing.Size(407, 272);
            this.Grid_Cuota.TabIndex = 94;
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
            this.btnUsuarios.Location = new System.Drawing.Point(674, 120);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnUsuarios.OnHovercolor = System.Drawing.Color.Gray;
            this.btnUsuarios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsuarios.selected = true;
            this.btnUsuarios.Size = new System.Drawing.Size(181, 51);
            this.btnUsuarios.TabIndex = 95;
            this.btnUsuarios.Text = "Limpiar Campos";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUsuarios.Textcolor = System.Drawing.Color.White;
            this.btnUsuarios.TextFont = new System.Drawing.Font("Comfortaa", 12.25F);
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
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
            this.btneditar.Location = new System.Drawing.Point(26, 458);
            this.btneditar.Name = "btneditar";
            this.btneditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btneditar.OnHovercolor = System.Drawing.Color.Gray;
            this.btneditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneditar.selected = true;
            this.btneditar.Size = new System.Drawing.Size(152, 51);
            this.btneditar.TabIndex = 96;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneditar.Textcolor = System.Drawing.Color.White;
            this.btneditar.TextFont = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
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
            this.btneliminar.Location = new System.Drawing.Point(243, 458);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btneliminar.OnHovercolor = System.Drawing.Color.Gray;
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = true;
            this.btneliminar.Size = new System.Drawing.Size(176, 51);
            this.btneliminar.TabIndex = 97;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneliminar.Textcolor = System.Drawing.Color.White;
            this.btneliminar.TextFont = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
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
            this.btnguardar.Location = new System.Drawing.Point(492, 458);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnguardar.OnHovercolor = System.Drawing.Color.Gray;
            this.btnguardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnguardar.selected = true;
            this.btnguardar.Size = new System.Drawing.Size(396, 51);
            this.btnguardar.TabIndex = 99;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnguardar.Textcolor = System.Drawing.Color.White;
            this.btnguardar.TextFont = new System.Drawing.Font("Comfortaa", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtCuota
            // 
            this.txtCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtCuota.Font = new System.Drawing.Font("Bahnschrift", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuota.ForeColor = System.Drawing.Color.White;
            this.txtCuota.Location = new System.Drawing.Point(562, 300);
            this.txtCuota.Mask = "00.00";
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(188, 35);
            this.txtCuota.TabIndex = 100;
            this.txtCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comfortaa", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(619, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 101;
            this.label1.Text = "Cuota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(344, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 44);
            this.label2.TabIndex = 102;
            this.label2.Text = "PANEL CUOTAS";
            // 
            // mover
            // 
            this.mover.Fixed = true;
            this.mover.Horizontal = true;
            this.mover.TargetControl = this.PanelTop;
            this.mover.Vertical = true;
            // 
            // redndear
            // 
            this.redndear.ElipseRadius = 12;
            this.redndear.TargetControl = this;
            // 
            // FormCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.Grid_Cuota);
            this.Name = "FormCuotas";
            this.Text = "FormCuotas";
            this.Load += new System.EventHandler(this.FormCuotas_Load);
            this.Controls.SetChildIndex(this.PanelTop, 0);
            this.Controls.SetChildIndex(this.Grid_Cuota, 0);
            this.Controls.SetChildIndex(this.btnUsuarios, 0);
            this.Controls.SetChildIndex(this.btneditar, 0);
            this.Controls.SetChildIndex(this.btneliminar, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.txtCuota, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Cuota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.DataGridView Grid_Cuota;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuarios;
        private Bunifu.Framework.UI.BunifuFlatButton btneditar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuFlatButton btnguardar;
        private System.Windows.Forms.MaskedTextBox txtCuota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl mover;
        private Bunifu.Framework.UI.BunifuElipse redndear;
    }
}