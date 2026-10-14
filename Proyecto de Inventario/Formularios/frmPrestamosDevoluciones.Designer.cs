
namespace Proyecto_de_Inventario.Formularios
{
    partial class frmPrestamosDevoluciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoEquipo = new System.Windows.Forms.TextBox();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.cboOperacion = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarMovimiento = new System.Windows.Forms.Button();
            this.btnLimpiarMovimiento = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarSolicitante = new System.Windows.Forms.TextBox();
            this.btnBuscarPrestamo = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Plum;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "                    \r\n                           REGISTRO DE PRÉSTAMOS Y DEVOLUCI" +
    "ONES                         \r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código Equipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Docente / Alumno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo Operación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha:";
            // 
            // txtCodigoEquipo
            // 
            this.txtCodigoEquipo.Location = new System.Drawing.Point(148, 83);
            this.txtCodigoEquipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoEquipo.Name = "txtCodigoEquipo";
            this.txtCodigoEquipo.Size = new System.Drawing.Size(136, 20);
            this.txtCodigoEquipo.TabIndex = 5;
            this.txtCodigoEquipo.TextChanged += new System.EventHandler(this.txtCodigoEquipo_TextChanged);
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(148, 121);
            this.txtSolicitante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(136, 20);
            this.txtSolicitante.TabIndex = 6;
            this.txtSolicitante.TextChanged += new System.EventHandler(this.txtSolicitante_TextChanged);
            // 
            // cboOperacion
            // 
            this.cboOperacion.FormattingEnabled = true;
            this.cboOperacion.Items.AddRange(new object[] {
            "préstamos",
            "devolución"});
            this.cboOperacion.Location = new System.Drawing.Point(148, 157);
            this.cboOperacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboOperacion.Name = "cboOperacion";
            this.cboOperacion.Size = new System.Drawing.Size(136, 21);
            this.cboOperacion.TabIndex = 7;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(148, 225);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(136, 20);
            this.dtpFecha.TabIndex = 8;
            // 
            // btnRegistrarMovimiento
            // 
            this.btnRegistrarMovimiento.Location = new System.Drawing.Point(20, 333);
            this.btnRegistrarMovimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            this.btnRegistrarMovimiento.Size = new System.Drawing.Size(116, 37);
            this.btnRegistrarMovimiento.TabIndex = 9;
            this.btnRegistrarMovimiento.Text = "Registrar Movimiento";
            this.btnRegistrarMovimiento.UseVisualStyleBackColor = true;
            this.btnRegistrarMovimiento.Click += new System.EventHandler(this.btnRegistrarMovimiento_Click);
            // 
            // btnLimpiarMovimiento
            // 
            this.btnLimpiarMovimiento.Location = new System.Drawing.Point(160, 333);
            this.btnLimpiarMovimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarMovimiento.Name = "btnLimpiarMovimiento";
            this.btnLimpiarMovimiento.Size = new System.Drawing.Size(116, 37);
            this.btnLimpiarMovimiento.TabIndex = 10;
            this.btnLimpiarMovimiento.Text = "Limpiar";
            this.btnLimpiarMovimiento.UseVisualStyleBackColor = true;
            this.btnLimpiarMovimiento.Click += new System.EventHandler(this.btnLimpiarMovimiento_Click);
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(458, 39);
            this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.RowTemplate.Height = 24;
            this.dgvPrestamos.Size = new System.Drawing.Size(547, 331);
            this.dgvPrestamos.TabIndex = 11;
            this.dgvPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Buscar Solicitante:";
            // 
            // txtBuscarSolicitante
            // 
            this.txtBuscarSolicitante.Location = new System.Drawing.Point(148, 295);
            this.txtBuscarSolicitante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarSolicitante.Name = "txtBuscarSolicitante";
            this.txtBuscarSolicitante.Size = new System.Drawing.Size(136, 20);
            this.txtBuscarSolicitante.TabIndex = 13;
            // 
            // btnBuscarPrestamo
            // 
            this.btnBuscarPrestamo.Location = new System.Drawing.Point(296, 333);
            this.btnBuscarPrestamo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            this.btnBuscarPrestamo.Size = new System.Drawing.Size(116, 37);
            this.btnBuscarPrestamo.TabIndex = 14;
            this.btnBuscarPrestamo.Text = "Buscar";
            this.btnBuscarPrestamo.UseVisualStyleBackColor = true;
            this.btnBuscarPrestamo.Click += new System.EventHandler(this.btnBuscarPrestamo_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(860, 436);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(118, 24);
            this.btnExportarExcel.TabIndex = 15;
            this.btnExportarExcel.Text = "📊 Exportar a Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(148, 260);
            this.dtpHora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(136, 20);
            this.dtpHora.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(887, 488);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(118, 24);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // textEstado
            // 
            this.textEstado.Location = new System.Drawing.Point(148, 191);
            this.textEstado.Margin = new System.Windows.Forms.Padding(2);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(136, 20);
            this.textEstado.TabIndex = 21;
            this.textEstado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Location = new System.Drawing.Point(17, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Estado:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmPrestamosDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 534);
            this.Controls.Add(this.textEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.btnBuscarPrestamo);
            this.Controls.Add(this.txtBuscarSolicitante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnLimpiarMovimiento);
            this.Controls.Add(this.btnRegistrarMovimiento);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboOperacion);
            this.Controls.Add(this.txtSolicitante);
            this.Controls.Add(this.txtCodigoEquipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrestamosDevoluciones";
            this.Text = "frmPrestamosDevoluciones";
            this.Load += new System.EventHandler(this.frmPrestamosDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoEquipo;
        private System.Windows.Forms.TextBox txtSolicitante;
        private System.Windows.Forms.ComboBox cboOperacion;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnRegistrarMovimiento;
        private System.Windows.Forms.Button btnLimpiarMovimiento;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscarSolicitante;
        private System.Windows.Forms.Button btnBuscarPrestamo;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.Label label8;
    }
}