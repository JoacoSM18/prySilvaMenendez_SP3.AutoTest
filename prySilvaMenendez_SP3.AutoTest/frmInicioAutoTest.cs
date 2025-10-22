using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_SP3.AutoTest
{
    public partial class frmInicioAutoTest : Form
    {
        public frmInicioAutoTest()
        {
            InitializeComponent();
        }
        private void frmInicioAutoTest_Load(object sender, EventArgs e)
        {
            txtDominio.CharacterCasing = CharacterCasing.Upper;
        }
        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDominio.Text.Trim().Length >= 6 &&
                txtTitular.Text.Trim().Length >= 2 &&
                mtbNumeroTurno.Text.Trim() != "" &&
                numAño.Value > 0)
            {
                MessageBox.Show("Registro Exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faltan Datos o Hay Campos Inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtDominio_Validating(object sender, CancelEventArgs e)
        {
            if (txtDominio.Text.Length < 6)
            {
                MessageBox.Show("Debe Ingresar al Menos 6 Caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
        private void mtbNumeroTurno_Click(object sender, EventArgs e)
        {
            mtbNumeroTurno.SelectionStart = 0;
        }
        private void txtTitular_Validating(object sender, CancelEventArgs e)
        {
            if (txtTitular.Text.Trim().Length < 2)
            {
                MessageBox.Show("El Titular Debe Tener al Menos Dos Caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
        private void numAño_Click(object sender, EventArgs e)
        {
            numAño.Select(0, 0);
        }
        private void numAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mtbCantidadTurnos_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbCantidadTurnos_Click(object sender, EventArgs e)
        {
            mtbCantidadTurnos.SelectionStart = 0;
        }

        private void mtbAñoAntiguedad_Click(object sender, EventArgs e)
        {
            mtbAñoAntiguedad.SelectionStart = 0;
        }

        private void mtbCantidadDominio_Click(object sender, EventArgs e)
        {
            mtbCantidadDominio.SelectionStart = 0;
        }
    }
}
