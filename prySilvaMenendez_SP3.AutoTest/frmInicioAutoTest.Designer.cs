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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioAutoTest));
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
            this.lblRDominio6Caracteres = new System.Windows.Forms.Label();
            this.lblRAñoMasAntiguo = new System.Windows.Forms.Label();
            this.lblRCantidadTurnos = new System.Windows.Forms.Label();
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
            this.mrcTurnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTurnos.Location = new System.Drawing.Point(12, 22);
            this.mrcTurnos.Name = "mrcTurnos";
            this.mrcTurnos.Size = new System.Drawing.Size(490, 274);
            this.mrcTurnos.TabIndex = 0;
            this.mrcTurnos.TabStop = false;
            this.mrcTurnos.Text = "Registro de Turnos";
            // 
            // mtbNumeroTurno
            // 
            this.mtbNumeroTurno.Location = new System.Drawing.Point(206, 43);
            this.mtbNumeroTurno.Mask = "99999";
            this.mtbNumeroTurno.Name = "mtbNumeroTurno";
            this.mtbNumeroTurno.Size = new System.Drawing.Size(100, 28);
            this.mtbNumeroTurno.TabIndex = 0;
            this.mtbNumeroTurno.ValidatingType = typeof(int);
            this.mtbNumeroTurno.Click += new System.EventHandler(this.mtbNumeroTurno_Click);
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(206, 111);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(100, 28);
            this.txtDominio.TabIndex = 1;
            this.txtDominio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDominio_KeyPress);
            this.txtDominio.Validating += new System.ComponentModel.CancelEventHandler(this.txtDominio_Validating);
            // 
            // numAño
            // 
            this.numAño.Location = new System.Drawing.Point(206, 163);
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
            this.numAño.Size = new System.Drawing.Size(76, 28);
            this.numAño.TabIndex = 2;
            this.numAño.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numAño.Click += new System.EventHandler(this.numAño_Click);
            this.numAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numAño_KeyPress);
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(206, 222);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(266, 28);
            this.txtTitular.TabIndex = 3;
            this.txtTitular.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitular_Validating);
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.Location = new System.Drawing.Point(22, 228);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(61, 22);
            this.lblTitular.TabIndex = 3;
            this.lblTitular.Text = "Titular";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(22, 169);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(165, 22);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año de Fabricación";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDominio.Location = new System.Drawing.Point(22, 117);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(75, 22);
            this.lblDominio.TabIndex = 1;
            this.lblDominio.Text = "Dominio";
            // 
            // lblNumeroTurno
            // 
            this.lblNumeroTurno.AutoSize = true;
            this.lblNumeroTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTurno.Location = new System.Drawing.Point(22, 46);
            this.lblNumeroTurno.Name = "lblNumeroTurno";
            this.lblNumeroTurno.Size = new System.Drawing.Size(156, 22);
            this.lblNumeroTurno.TabIndex = 0;
            this.lblNumeroTurno.Text = "Número de Turno ";
            // 
            // mrcEstadisticas
            // 
            this.mrcEstadisticas.Controls.Add(this.lblRDominio6Caracteres);
            this.mrcEstadisticas.Controls.Add(this.lblRAñoMasAntiguo);
            this.mrcEstadisticas.Controls.Add(this.lblRCantidadTurnos);
            this.mrcEstadisticas.Controls.Add(this.lblCantidadDominio);
            this.mrcEstadisticas.Controls.Add(this.lblAñoAntiguedad);
            this.mrcEstadisticas.Controls.Add(this.lblCantidadTurnos);
            this.mrcEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcEstadisticas.Location = new System.Drawing.Point(12, 335);
            this.mrcEstadisticas.Name = "mrcEstadisticas";
            this.mrcEstadisticas.Size = new System.Drawing.Size(490, 218);
            this.mrcEstadisticas.TabIndex = 1;
            this.mrcEstadisticas.TabStop = false;
            this.mrcEstadisticas.Text = "Estadisticas";
            // 
            // lblRDominio6Caracteres
            // 
            this.lblRDominio6Caracteres.Location = new System.Drawing.Point(350, 173);
            this.lblRDominio6Caracteres.Name = "lblRDominio6Caracteres";
            this.lblRDominio6Caracteres.Size = new System.Drawing.Size(100, 23);
            this.lblRDominio6Caracteres.TabIndex = 5;
            this.lblRDominio6Caracteres.Text = " ";
            this.lblRDominio6Caracteres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRDominio6Caracteres.Visible = false;
            // 
            // lblRAñoMasAntiguo
            // 
            this.lblRAñoMasAntiguo.Location = new System.Drawing.Point(350, 111);
            this.lblRAñoMasAntiguo.Name = "lblRAñoMasAntiguo";
            this.lblRAñoMasAntiguo.Size = new System.Drawing.Size(100, 20);
            this.lblRAñoMasAntiguo.TabIndex = 4;
            this.lblRAñoMasAntiguo.Text = " ";
            this.lblRAñoMasAntiguo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRAñoMasAntiguo.Visible = false;
            // 
            // lblRCantidadTurnos
            // 
            this.lblRCantidadTurnos.Location = new System.Drawing.Point(350, 47);
            this.lblRCantidadTurnos.Name = "lblRCantidadTurnos";
            this.lblRCantidadTurnos.Size = new System.Drawing.Size(100, 23);
            this.lblRCantidadTurnos.TabIndex = 3;
            this.lblRCantidadTurnos.Text = " ";
            this.lblRCantidadTurnos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRCantidadTurnos.Visible = false;
            // 
            // lblCantidadDominio
            // 
            this.lblCantidadDominio.AutoSize = true;
            this.lblCantidadDominio.Location = new System.Drawing.Point(22, 174);
            this.lblCantidadDominio.Name = "lblCantidadDominio";
            this.lblCantidadDominio.Size = new System.Drawing.Size(319, 22);
            this.lblCantidadDominio.TabIndex = 2;
            this.lblCantidadDominio.Text = "Cantidad con Dominio de 6 Caracteres";
            // 
            // lblAñoAntiguedad
            // 
            this.lblAñoAntiguedad.AutoSize = true;
            this.lblAñoAntiguedad.Location = new System.Drawing.Point(22, 111);
            this.lblAñoAntiguedad.Name = "lblAñoAntiguedad";
            this.lblAñoAntiguedad.Size = new System.Drawing.Size(175, 22);
            this.lblAñoAntiguedad.TabIndex = 1;
            this.lblAñoAntiguedad.Text = "Año del Más Antiguo";
            // 
            // lblCantidadTurnos
            // 
            this.lblCantidadTurnos.AutoSize = true;
            this.lblCantidadTurnos.Location = new System.Drawing.Point(22, 48);
            this.lblCantidadTurnos.Name = "lblCantidadTurnos";
            this.lblCantidadTurnos.Size = new System.Drawing.Size(169, 22);
            this.lblCantidadTurnos.TabIndex = 0;
            this.lblCantidadTurnos.Text = "Cantidad de Turnos";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(525, 22);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(130, 42);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(525, 98);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 42);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(525, 335);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(130, 45);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmInicioAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(687, 595);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.mrcEstadisticas);
            this.Controls.Add(this.mrcTurnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.NumericUpDown numAño;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.MaskedTextBox mtbNumeroTurno;
        private System.Windows.Forms.Label lblRDominio6Caracteres;
        private System.Windows.Forms.Label lblRAñoMasAntiguo;
        private System.Windows.Forms.Label lblRCantidadTurnos;
    }
}

