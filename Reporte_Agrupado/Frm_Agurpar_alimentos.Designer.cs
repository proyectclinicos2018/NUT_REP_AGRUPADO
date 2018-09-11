namespace Reporte_Agrupado
{
    partial class Frm_Agurpar_alimentos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Agurpar_alimentos));
            this.grilla_alimentos = new System.Windows.Forms.DataGridView();
            this.ALIMENTOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.btn_estado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.btn_tipo_comida = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txttipo_comida = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.Ayuda = new AyudaSpreadNet.AyudaSprNet();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_alimentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grilla_alimentos
            // 
            this.grilla_alimentos.AllowUserToAddRows = false;
            this.grilla_alimentos.AllowUserToDeleteRows = false;
            this.grilla_alimentos.AllowUserToResizeColumns = false;
            this.grilla_alimentos.AllowUserToResizeRows = false;
            this.grilla_alimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_alimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ALIMENTOS,
            this.CANTIDAD,
            this.OBSERVACION,
            this.ESTADO});
            this.grilla_alimentos.Location = new System.Drawing.Point(8, 181);
            this.grilla_alimentos.Name = "grilla_alimentos";
            this.grilla_alimentos.ReadOnly = true;
            this.grilla_alimentos.RowHeadersVisible = false;
            this.grilla_alimentos.Size = new System.Drawing.Size(722, 239);
            this.grilla_alimentos.TabIndex = 227;
            this.grilla_alimentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_alimentos_CellContentClick);
            this.grilla_alimentos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grilla_comida_CellPainting);
            // 
            // ALIMENTOS
            // 
            this.ALIMENTOS.DataPropertyName = "ALIMENTOS";
            this.ALIMENTOS.HeaderText = "ALIMENTOS";
            this.ALIMENTOS.Name = "ALIMENTOS";
            this.ALIMENTOS.ReadOnly = true;
            this.ALIMENTOS.Width = 200;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CANTIDAD.DefaultCellStyle = dataGridViewCellStyle1;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 60;
            // 
            // OBSERVACION
            // 
            this.OBSERVACION.DataPropertyName = "OBSERVACION";
            this.OBSERVACION.HeaderText = "OBSERVACION";
            this.OBSERVACION.Name = "OBSERVACION";
            this.OBSERVACION.ReadOnly = true;
            this.OBSERVACION.Width = 350;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfecha);
            this.groupBox1.Controls.Add(this.btn_estado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtestado);
            this.groupBox1.Controls.Add(this.btn_tipo_comida);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txttipo_comida);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(5, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 101);
            this.groupBox1.TabIndex = 225;
            this.groupBox1.TabStop = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(619, 67);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(77, 28);
            this.btn_buscar.TabIndex = 205;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 204;
            this.label2.Text = "Fecha";
            // 
            // txtfecha
            // 
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(546, 41);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(150, 20);
            this.txtfecha.TabIndex = 203;
            this.txtfecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfecha_KeyPress);
            // 
            // btn_estado
            // 
            this.btn_estado.Image = ((System.Drawing.Image)(resources.GetObject("btn_estado.Image")));
            this.btn_estado.Location = new System.Drawing.Point(414, 69);
            this.btn_estado.Name = "btn_estado";
            this.btn_estado.Size = new System.Drawing.Size(27, 23);
            this.btn_estado.TabIndex = 191;
            this.btn_estado.UseVisualStyleBackColor = true;
            this.btn_estado.Click += new System.EventHandler(this.btn_estado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 190;
            this.label1.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.BackColor = System.Drawing.Color.White;
            this.txtestado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtestado.Location = new System.Drawing.Point(78, 69);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(330, 20);
            this.txtestado.TabIndex = 189;
            this.txtestado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtestado_KeyPress);
            // 
            // btn_tipo_comida
            // 
            this.btn_tipo_comida.Image = ((System.Drawing.Image)(resources.GetObject("btn_tipo_comida.Image")));
            this.btn_tipo_comida.Location = new System.Drawing.Point(414, 40);
            this.btn_tipo_comida.Name = "btn_tipo_comida";
            this.btn_tipo_comida.Size = new System.Drawing.Size(27, 23);
            this.btn_tipo_comida.TabIndex = 183;
            this.btn_tipo_comida.UseVisualStyleBackColor = true;
            this.btn_tipo_comida.Click += new System.EventHandler(this.btn_tipo_comida_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo Comida";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(714, 25);
            this.label7.TabIndex = 79;
            this.label7.Text = "Configuración de Menú";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttipo_comida
            // 
            this.txttipo_comida.BackColor = System.Drawing.Color.White;
            this.txttipo_comida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttipo_comida.Location = new System.Drawing.Point(78, 42);
            this.txttipo_comida.Name = "txttipo_comida";
            this.txttipo_comida.Size = new System.Drawing.Size(330, 20);
            this.txttipo_comida.TabIndex = 3;
            this.txttipo_comida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttipo_comida_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 2;
            // 
            // LblUsuario
            // 
            this.LblUsuario.BackColor = System.Drawing.Color.Silver;
            this.LblUsuario.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(6, 5);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(131, 25);
            this.LblUsuario.TabIndex = 224;
            this.LblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Ayuda
            // 
            this.Ayuda.AnchoColumnas = null;
            this.Ayuda.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Ayuda.Location = new System.Drawing.Point(536, -6);
            this.Ayuda.Multi_Seleccion = false;
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Nombre_BD_Datos = null;
            this.Ayuda.NombreColumnas = null;
            this.Ayuda.Package = null;
            this.Ayuda.Pass = null;
            this.Ayuda.Procedimiento = null;
            this.Ayuda.Size = new System.Drawing.Size(58, 66);
            this.Ayuda.TabIndex = 228;
            this.Ayuda.TipoBase = 0;
            this.Ayuda.TituloConsulta = null;
            this.Ayuda.User = null;
            this.Ayuda.UseWaitCursor = true;
            this.Ayuda.Visible = false;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.Location = new System.Drawing.Point(8, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(721, 25);
            this.label13.TabIndex = 226;
            this.label13.Text = "Listado";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_limpiar.Location = new System.Drawing.Point(376, 4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(98, 43);
            this.btn_limpiar.TabIndex = 223;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Image = global::Reporte_Agrupado.Properties.Resources.reportes;
            this.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_imprimir.Location = new System.Drawing.Point(280, 5);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(90, 43);
            this.btn_imprimir.TabIndex = 222;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // Frm_Agurpar_alimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 430);
            this.Controls.Add(this.Ayuda);
            this.Controls.Add(this.grilla_alimentos);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_imprimir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Agurpar_alimentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes Cantidades  Alimentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_alimentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla_alimentos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Button btn_tipo_comida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttipo_comida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_imprimir;
        private AyudaSpreadNet.AyudaSprNet Ayuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALIMENTOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.Button btn_buscar;
    }
}

