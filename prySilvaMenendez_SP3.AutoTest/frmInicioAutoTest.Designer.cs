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
            this.mtbNumeroTurno = new System.Windows.Forms.MaskedTextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.numAño = new System.Windows.Forms.NumericUpDown();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblNumeroTurno = new System.Windows.Forms.Label();
            this.mrcEstadisticas = new System.Windows.Forms.GroupBox();
            this.mskCantidadDominio = new System.Windows.Forms.MaskedTextBox();
            this.mskAñoAntiguedad = new System.Windows.Forms.MaskedTextBox();
            this.mskCantidadTurnos = new System.Windows.Forms.MaskedTextBox();
            this.lblCantidadDominio = new System.Windows.Forms.Label();
            this.lblAñoAntiguedad = new System.Windows.Forms.Label();
            this.lblCantidadTurnos = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.mrcTurnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAño)).BeginInit();
            this.mrcEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcTurnos
            // 
            this.mrcTurnos.Controls.Add(this.mtbNumeroTurno);
            this.mrcTurnos.Controls.Add(this.txtDominio);
            this.mrcTurnos.Controls.Add(this.numAño);
            this.mrcTurnos.Controls.Add(this.txtTitular);
            this.mrcTurnos.Controls.Add(this.lblTitular);
            this.mrcTurnos.Controls.Add(this.lblAño);
            this.mrcTurnos.Controls.Add(this.lblDominio);
            this.mrcTurnos.Controls.Add(this.lblNumeroTurno);
            this.mrcTurnos.Location = new System.Drawing.Point(8, 14);
            this.mrcTurnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcTurnos.Name = "mrcTurnos";
            this.mrcTurnos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcTurnos.Size = new System.Drawing.Size(327, 178);
            this.mrcTurnos.TabIndex = 0;
            this.mrcTurnos.TabStop = false;
            this.mrcTurnos.Text = "Registro de Turnos";
            // 
            // mtbNumeroTurno
            // 
            this.mtbNumeroTurno.Location = new System.Drawing.Point(123, 30);
            this.mtbNumeroTurno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbNumeroTurno.Mask = "99999";
            this.mtbNumeroTurno.Name = "mtbNumeroTurno";
            this.mtbNumeroTurno.Size = new System.Drawing.Size(68, 20);
            this.mtbNumeroTurno.TabIndex = 0;
            this.mtbNumeroTurno.ValidatingType = typeof(int);
            this.mtbNumeroTurno.Click += new System.EventHandler(this.mtbNumeroTurno_Click);
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(123, 72);
            this.txtDominio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(68, 20);
            this.txtDominio.TabIndex = 1;
            this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            this.txtDominio.Validating += new System.ComponentModel.CancelEventHandler(this.txtDominio_Validating);
            // 
            // numAño
            // 
            this.numAño.Location = new System.Drawing.Point(123, 106);
            this.numAño.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numAño.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numAño.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numAño.Name = "numAño";
            this.numAño.Size = new System.Drawing.Size(51, 20);
            this.numAño.TabIndex = 2;
            this.numAño.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numAño.Click += new System.EventHandler(this.numAño_Click);
            this.numAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numAño_KeyPress);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(123, 144);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(179, 20);
            this.txtTitular.TabIndex = 3;
            this.txtTitular.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitular_Validating);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(15, 148);
            this.lblTitular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(15, 110);
            this.lblAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(99, 13);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año de Fabricación";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(15, 72);
            this.lblDominio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblNumeroTurno
            // 
            this.lblNumeroTurno.AutoSize = true;
            this.lblNumeroTurno.Location = new System.Drawing.Point(15, 30);
            this.lblNumeroTurno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeroTurno.Name = "lblNumeroTurno";
            this.lblNumeroTurno.Size = new System.Drawing.Size(93, 13);
            this.lblNumeroTurno.TabIndex = 0;
            this.lblNumeroTurno.Text = "Número de Turno ";
            // 
            // mrcEstadisticas
            // 
            this.mrcEstadisticas.Controls.Add(this.mskCantidadDominio);
            this.mrcEstadisticas.Controls.Add(this.mskAñoAntiguedad);
            this.mrcEstadisticas.Controls.Add(this.mskCantidadTurnos);
            this.mrcEstadisticas.Controls.Add(this.lblCantidadDominio);
            this.mrcEstadisticas.Controls.Add(this.lblAñoAntiguedad);
            this.mrcEstadisticas.Controls.Add(this.lblCantidadTurnos);
            this.mrcEstadisticas.Location = new System.Drawing.Point(8, 218);
            this.mrcEstadisticas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcEstadisticas.Name = "mrcEstadisticas";
            this.mrcEstadisticas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mrcEstadisticas.Size = new System.Drawing.Size(327, 142);
            this.mrcEstadisticas.TabIndex = 1;
            this.mrcEstadisticas.TabStop = false;
            this.mrcEstadisticas.Text = "Estadisticas";
            // 
            // mskCantidadDominio
            // 
            this.mskCantidadDominio.Location = new System.Drawing.Point(213, 109);
            this.mskCantidadDominio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskCantidadDominio.Name = "mskCantidadDominio";
            this.mskCantidadDominio.Size = new System.Drawing.Size(53, 20);
            this.mskCantidadDominio.TabIndex = 6;
            // 
            // mskAñoAntiguedad
            // 
            this.mskAñoAntiguedad.Location = new System.Drawing.Point(213, 68);
            this.mskAñoAntiguedad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskAñoAntiguedad.Name = "mskAñoAntiguedad";
            this.mskAñoAntiguedad.Size = new System.Drawing.Size(53, 20);
            this.mskAñoAntiguedad.TabIndex = 5;
            // 
            // mskCantidadTurnos
            // 
            this.mskCantidadTurnos.Location = new System.Drawing.Point(213, 27);
            this.mskCantidadTurnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskCantidadTurnos.Name = "mskCantidadTurnos";
            this.mskCantidadTurnos.Size = new System.Drawing.Size(53, 20);
            this.mskCantidadTurnos.TabIndex = 4;
            // 
            // lblCantidadDominio
            // 
            this.lblCantidadDominio.AutoSize = true;
            this.lblCantidadDominio.Location = new System.Drawing.Point(15, 113);
            this.lblCantidadDominio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadDominio.Name = "lblCantidadDominio";
            this.lblCantidadDominio.Size = new System.Drawing.Size(189, 13);
            this.lblCantidadDominio.TabIndex = 2;
            this.lblCantidadDominio.Text = "Cantidad con Dominio de 6 Caracteres";
            // 
            // lblAñoAntiguedad
            // 
            this.lblAñoAntiguedad.AutoSize = true;
            this.lblAñoAntiguedad.Location = new System.Drawing.Point(15, 72);
            this.lblAñoAntiguedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAñoAntiguedad.Name = "lblAñoAntiguedad";
            this.lblAñoAntiguedad.Size = new System.Drawing.Size(105, 13);
            this.lblAñoAntiguedad.TabIndex = 1;
            this.lblAñoAntiguedad.Text = "Año del Más Antiguo";
            // 
            // lblCantidadTurnos
            // 
            this.lblCantidadTurnos.AutoSize = true;
            this.lblCantidadTurnos.Location = new System.Drawing.Point(15, 31);
            this.lblCantidadTurnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadTurnos.Name = "lblCantidadTurnos";
            this.lblCantidadTurnos.Size = new System.Drawing.Size(100, 13);
            this.lblCantidadTurnos.TabIndex = 0;
            this.lblCantidadTurnos.Text = "Cantidad de Turnos";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(350, 14);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(87, 27);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(350, 64);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 27);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(350, 218);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(87, 29);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmInicioAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(458, 387);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcEstadisticas);
            this.Controls.Add(this.mrcTurnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInicioAutoTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-Test";
            this.Load += new System.EventHandler(this.frmInicioAutoTest_Load);
            this.mrcTurnos.ResumeLayout(false);
            this.mrcTurnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAño)).EndInit();
            this.mrcEstadisticas.ResumeLayout(false);
            this.mrcEstadisticas.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.MaskedTextBox mskCantidadDominio;
        private System.Windows.Forms.MaskedTextBox mskAñoAntiguedad;
        private System.Windows.Forms.MaskedTextBox mskCantidadTurnos;
        private System.Windows.Forms.NumericUpDown numAño;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.MaskedTextBox mtbNumeroTurno;
    }
}

