namespace prySilvaMenendez_SP3.AutoTest
{
    partial class frmInicioAutoTest
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
            this.mrcTurnos = new System.Windows.Forms.GroupBox();
            this.mrcEstadisticas = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblNumeroTurno = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblCantidadTurnos = new System.Windows.Forms.Label();
            this.lblAñoAntiguedad = new System.Windows.Forms.Label();
            this.lblCantidadDominio = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.mskNumeroTurno = new System.Windows.Forms.MaskedTextBox();
            this.mskDominio = new System.Windows.Forms.MaskedTextBox();
            this.mskCantidadTurnos = new System.Windows.Forms.MaskedTextBox();
            this.mskAñoAntiguedad = new System.Windows.Forms.MaskedTextBox();
            this.mskCantidadDominio = new System.Windows.Forms.MaskedTextBox();
            this.numAño = new System.Windows.Forms.NumericUpDown();
            this.mrcTurnos.SuspendLayout();
            this.mrcEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAño)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcTurnos
            // 
            this.mrcTurnos.Controls.Add(this.numAño);
            this.mrcTurnos.Controls.Add(this.mskDominio);
            this.mrcTurnos.Controls.Add(this.mskNumeroTurno);
            this.mrcTurnos.Controls.Add(this.txtTitular);
            this.mrcTurnos.Controls.Add(this.lblTitular);
            this.mrcTurnos.Controls.Add(this.lblAño);
            this.mrcTurnos.Controls.Add(this.lblDominio);
            this.mrcTurnos.Controls.Add(this.lblNumeroTurno);
            this.mrcTurnos.Location = new System.Drawing.Point(12, 22);
            this.mrcTurnos.Name = "mrcTurnos";
            this.mrcTurnos.Size = new System.Drawing.Size(490, 274);
            this.mrcTurnos.TabIndex = 0;
            this.mrcTurnos.TabStop = false;
            this.mrcTurnos.Text = "Registro de Turnos";
            // 
            // mrcEstadisticas
            // 
            this.mrcEstadisticas.Controls.Add(this.mskCantidadDominio);
            this.mrcEstadisticas.Controls.Add(this.mskAñoAntiguedad);
            this.mrcEstadisticas.Controls.Add(this.mskCantidadTurnos);
            this.mrcEstadisticas.Controls.Add(this.lblCantidadDominio);
            this.mrcEstadisticas.Controls.Add(this.lblAñoAntiguedad);
            this.mrcEstadisticas.Controls.Add(this.lblCantidadTurnos);
            this.mrcEstadisticas.Location = new System.Drawing.Point(12, 336);
            this.mrcEstadisticas.Name = "mrcEstadisticas";
            this.mrcEstadisticas.Size = new System.Drawing.Size(490, 218);
            this.mrcEstadisticas.TabIndex = 1;
            this.mrcEstadisticas.TabStop = false;
            this.mrcEstadisticas.Text = "Estadisticas";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(525, 22);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(154, 42);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(525, 88);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(154, 41);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(525, 336);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(150, 41);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblNumeroTurno
            // 
            this.lblNumeroTurno.AutoSize = true;
            this.lblNumeroTurno.Location = new System.Drawing.Point(23, 46);
            this.lblNumeroTurno.Name = "lblNumeroTurno";
            this.lblNumeroTurno.Size = new System.Drawing.Size(136, 20);
            this.lblNumeroTurno.TabIndex = 0;
            this.lblNumeroTurno.Text = "Número de Turno ";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(23, 110);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(67, 20);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(23, 169);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(146, 20);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año de Fabricación";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(23, 227);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(52, 20);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // lblCantidadTurnos
            // 
            this.lblCantidadTurnos.AutoSize = true;
            this.lblCantidadTurnos.Location = new System.Drawing.Point(23, 47);
            this.lblCantidadTurnos.Name = "lblCantidadTurnos";
            this.lblCantidadTurnos.Size = new System.Drawing.Size(148, 20);
            this.lblCantidadTurnos.TabIndex = 0;
            this.lblCantidadTurnos.Text = "Cantidad de Turnos";
            // 
            // lblAñoAntiguedad
            // 
            this.lblAñoAntiguedad.AutoSize = true;
            this.lblAñoAntiguedad.Location = new System.Drawing.Point(23, 113);
            this.lblAñoAntiguedad.Name = "lblAñoAntiguedad";
            this.lblAñoAntiguedad.Size = new System.Drawing.Size(156, 20);
            this.lblAñoAntiguedad.TabIndex = 1;
            this.lblAñoAntiguedad.Text = "Año del Más Antiguo";
            // 
            // lblCantidadDominio
            // 
            this.lblCantidadDominio.AutoSize = true;
            this.lblCantidadDominio.Location = new System.Drawing.Point(23, 174);
            this.lblCantidadDominio.Name = "lblCantidadDominio";
            this.lblCantidadDominio.Size = new System.Drawing.Size(282, 20);
            this.lblCantidadDominio.TabIndex = 2;
            this.lblCantidadDominio.Text = "Cantidad con Dominio de 6 Caracteres";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(185, 221);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(267, 26);
            this.txtTitular.TabIndex = 4;
            // 
            // mskNumeroTurno
            // 
            this.mskNumeroTurno.Location = new System.Drawing.Point(185, 40);
            this.mskNumeroTurno.Name = "mskNumeroTurno";
            this.mskNumeroTurno.Size = new System.Drawing.Size(100, 26);
            this.mskNumeroTurno.TabIndex = 7;
            // 
            // mskDominio
            // 
            this.mskDominio.Location = new System.Drawing.Point(185, 110);
            this.mskDominio.Name = "mskDominio";
            this.mskDominio.Size = new System.Drawing.Size(100, 26);
            this.mskDominio.TabIndex = 8;
            // 
            // mskCantidadTurnos
            // 
            this.mskCantidadTurnos.Location = new System.Drawing.Point(320, 41);
            this.mskCantidadTurnos.Name = "mskCantidadTurnos";
            this.mskCantidadTurnos.Size = new System.Drawing.Size(77, 26);
            this.mskCantidadTurnos.TabIndex = 3;
            // 
            // mskAñoAntiguedad
            // 
            this.mskAñoAntiguedad.Location = new System.Drawing.Point(320, 107);
            this.mskAñoAntiguedad.Name = "mskAñoAntiguedad";
            this.mskAñoAntiguedad.Size = new System.Drawing.Size(77, 26);
            this.mskAñoAntiguedad.TabIndex = 4;
            // 
            // mskCantidadDominio
            // 
            this.mskCantidadDominio.Location = new System.Drawing.Point(320, 168);
            this.mskCantidadDominio.Name = "mskCantidadDominio";
            this.mskCantidadDominio.Size = new System.Drawing.Size(77, 26);
            this.mskCantidadDominio.TabIndex = 5;
            // 
            // numAño
            // 
            this.numAño.Location = new System.Drawing.Point(185, 163);
            this.numAño.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numAño.Name = "numAño";
            this.numAño.Size = new System.Drawing.Size(77, 26);
            this.numAño.TabIndex = 9;
            // 
            // frmInicioAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 595);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcEstadisticas);
            this.Controls.Add(this.mrcTurnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmInicioAutoTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Test";
            this.Load += new System.EventHandler(this.frmInicioAutoTest_Load);
            this.mrcTurnos.ResumeLayout(false);
            this.mrcTurnos.PerformLayout();
            this.mrcEstadisticas.ResumeLayout(false);
            this.mrcEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcTurnos;
        private System.Windows.Forms.GroupBox mrcEstadisticas;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblNumeroTurno;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblCantidadDominio;
        private System.Windows.Forms.Label lblAñoAntiguedad;
        private System.Windows.Forms.Label lblCantidadTurnos;
        private System.Windows.Forms.MaskedTextBox mskNumeroTurno;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.MaskedTextBox mskDominio;
        private System.Windows.Forms.MaskedTextBox mskCantidadDominio;
        private System.Windows.Forms.MaskedTextBox mskAñoAntiguedad;
        private System.Windows.Forms.MaskedTextBox mskCantidadTurnos;
        private System.Windows.Forms.NumericUpDown numAño;
    }
}

