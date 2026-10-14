
namespace Proyecto_de_Inventario
{
    partial class frmGestionEquipos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDatosEquipos = new System.Windows.Forms.GroupBox();
            this.cboUbicacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.lblBuscarCodigo = new System.Windows.Forms.Label();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.cboFiltroEstado = new System.Windows.Forms.ComboBox();
            this.cboFiltroUbicacion = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatosEquipos.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosEquipos
            // 
            this.gbDatosEquipos.Controls.Add(this.cboUbicacion);
            this.gbDatosEquipos.Controls.Add(this.label1);
            this.gbDatosEquipos.Controls.Add(this.cboEstado);
            this.gbDatosEquipos.Controls.Add(this.txtModelo);
            this.gbDatosEquipos.Controls.Add(this.txtMarca);
            this.gbDatosEquipos.Controls.Add(this.lblEstado);
            this.gbDatosEquipos.Controls.Add(this.lblModelo);
            this.gbDatosEquipos.Controls.Add(this.lblMarca);
            this.gbDatosEquipos.Controls.Add(this.cboTipo);
            this.gbDatosEquipos.Controls.Add(this.lblTipo);
            this.gbDatosEquipos.Controls.Add(this.txtCodigo);
            this.gbDatosEquipos.Controls.Add(this.lblCodigo);
            this.gbDatosEquipos.Location = new System.Drawing.Point(9, 10);
            this.gbDatosEquipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosEquipos.Name = "gbDatosEquipos";
            this.gbDatosEquipos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatosEquipos.Size = new System.Drawing.Size(269, 245);
            this.gbDatosEquipos.TabIndex = 0;
            this.gbDatosEquipos.TabStop = false;
            this.gbDatosEquipos.Text = "Datos del Equipo";
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.FormattingEnabled = true;
            this.cboUbicacion.Items.AddRange(new object[] {
            "Aula 401",
            "Aula 402",
            "Aula 403",
            "Aula 404",
            "Aula 405",
            "Aula 408",
            "Aula 411",
            "Laboratorio 1",
            "Laboratorio 2",
            "Laboratorio 5",
            "Taller de Mantenimiento"});
            this.cboUbicacion.Location = new System.Drawing.Point(101, 164);
            this.cboUbicacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(139, 21);
            this.cboUbicacion.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ubicación:";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Operativo",
            "Inoperativo",
            "Mantenimiento",
            "Prestado",
            "De baja"});
            this.cboEstado.Location = new System.Drawing.Point(101, 201);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(139, 21);
            this.cboEstado.TabIndex = 9;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(101, 130);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(139, 20);
            this.txtModelo.TabIndex = 8;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(101, 96);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(139, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 206);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(16, 134);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(45, 13);
            this.lblModelo.TabIndex = 5;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(16, 100);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "CPU",
            "MONITOR",
            "LAPTOP",
            "PROYECTOR",
            "TECLADO",
            "SWITCH",
            "CAJA NEGRA",
            "ESTABILIZADOR",
            "ECRAM",
            "LECTORA EXTERNA",
            "CAMARA DE SEGURIDAD"});
            this.cboTipo.Location = new System.Drawing.Point(101, 63);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(139, 21);
            this.cboTipo.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(16, 69);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(101, 32);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(139, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 37);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(16, 268);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(74, 36);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(110, 268);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(74, 36);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(204, 268);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(74, 36);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.btnBuscar);
            this.gbBusqueda.Controls.Add(this.txtBuscarCodigo);
            this.gbBusqueda.Controls.Add(this.lblBuscarCodigo);
            this.gbBusqueda.Location = new System.Drawing.Point(9, 323);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbBusqueda.Size = new System.Drawing.Size(269, 105);
            this.gbBusqueda.TabIndex = 13;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Búsqueda Rápida";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(195, 30);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(69, 26);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(101, 34);
            this.txtBuscarCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(81, 20);
            this.txtBuscarCodigo.TabIndex = 1;
            this.txtBuscarCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblBuscarCodigo
            // 
            this.lblBuscarCodigo.AutoSize = true;
            this.lblBuscarCodigo.Location = new System.Drawing.Point(4, 34);
            this.lblBuscarCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarCodigo.Name = "lblBuscarCodigo";
            this.lblBuscarCodigo.Size = new System.Drawing.Size(84, 13);
            this.lblBuscarCodigo.TabIndex = 0;
            this.lblBuscarCodigo.Text = "Ingresar Código:";
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Location = new System.Drawing.Point(296, 10);
            this.dgvEquipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.RowHeadersWidth = 51;
            this.dgvEquipos.RowTemplate.Height = 24;
            this.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipos.Size = new System.Drawing.Size(653, 276);
            this.dgvEquipos.TabIndex = 14;
            this.dgvEquipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipos_CellClick);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(348, 95);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(144, 24);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Aplicar Filtros";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportarExcel);
            this.groupBox1.Controls.Add(this.cboFiltroEstado);
            this.groupBox1.Controls.Add(this.cboFiltroUbicacion);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Location = new System.Drawing.Point(296, 304);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(653, 124);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "📍 FILTROS AVANZADOS";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(520, 95);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(129, 24);
            this.btnExportarExcel.TabIndex = 16;
            this.btnExportarExcel.Text = "📊 Exportar a Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // cboFiltroEstado
            // 
            this.cboFiltroEstado.FormattingEnabled = true;
            this.cboFiltroEstado.Items.AddRange(new object[] {
            "[Todos]",
            "Operativo",
            "Inoperativo",
            "Mantenimiento",
            "Prestado",
            "De baja"});
            this.cboFiltroEstado.Location = new System.Drawing.Point(389, 55);
            this.cboFiltroEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboFiltroEstado.Name = "cboFiltroEstado";
            this.cboFiltroEstado.Size = new System.Drawing.Size(185, 21);
            this.cboFiltroEstado.TabIndex = 14;
            // 
            // cboFiltroUbicacion
            // 
            this.cboFiltroUbicacion.FormattingEnabled = true;
            this.cboFiltroUbicacion.Items.AddRange(new object[] {
            "[Todos]",
            "Aula 401",
            "Aula 402",
            "Aula 403",
            "Aula 404",
            "Aula 405",
            "Aula 408",
            "Aula 411",
            "Laboratorio 1",
            "Laboratorio 2",
            "Laboratorio 5",
            "Taller de Mantenimiento"});
            this.cboFiltroUbicacion.Location = new System.Drawing.Point(76, 55);
            this.cboFiltroUbicacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboFiltroUbicacion.Name = "cboFiltroUbicacion";
            this.cboFiltroUbicacion.Size = new System.Drawing.Size(185, 21);
            this.cboFiltroUbicacion.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(801, 532);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(144, 24);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmGestionEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 630);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbDatosEquipos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGestionEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Equipos Tecnológicos - IESTP Argentina";
            this.Load += new System.EventHandler(this.frmGestionEquipos_Load);
            this.gbDatosEquipos.ResumeLayout(false);
            this.gbDatosEquipos.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosEquipos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Label lblBuscarCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.ComboBox cboUbicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboFiltroEstado;
        private System.Windows.Forms.ComboBox cboFiltroUbicacion;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnSalir;
    }
}

