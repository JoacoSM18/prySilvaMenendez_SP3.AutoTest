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
        struct Turno
        {
            public int numeroturno;
            public string dominio;
            public int añofabricacion;
            public string titular;
        }

        int turnos = 0;
        int indice = 0;
        int añomasantiguo = 0;
        int dominiomas6caracteres = 0;
        int menor = 2026;
        Turno[] vecTurnos = new Turno[100];

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

        private void txtDominio_Validating(object sender, CancelEventArgs e)
        {
            if (txtDominio.Text.Length < 6)
            {
                MessageBox.Show("Debe Ingresar al Menos 6 Caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void txtTitular_Validating(object sender, CancelEventArgs e)
        {
            if (txtTitular.Text.Trim().Length < 2)
            {
                MessageBox.Show("El Titular Debe Tener al Menos Dos Caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void mtbNumeroTurno_Click(object sender, EventArgs e)
        {
            mtbNumeroTurno.SelectionStart = 0;
        }

        private void numAño_Click(object sender, EventArgs e)
        {
            numAño.Select(0, 0);
        }

        private void numAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (mtbNumeroTurno.Text == "" || txtDominio.Text == "" || numAño.Value == 0 ||txtTitular.Text == "")
            {
                MessageBox.Show("Datos Incompletos, Por Favor Complete Todos los Campos","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtDominio.Text.Trim().Length >= 6 &&
                txtTitular.Text.Trim().Length >= 2 &&
                mtbNumeroTurno.Text.Trim() != "" &&
                numAño.Value > 0)
            {
                if (!int.TryParse(mtbNumeroTurno.Text, out int numeroTurno))
                {
                    MessageBox.Show("El Número de Turno Debe ser un Número Entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtbNumeroTurno.Focus();
                    return;
                }
                for (int i = 0; i < indice; i++)
                {
                    if (vecTurnos[i].numeroturno == numeroTurno)
                    {
                        MessageBox.Show("El Número de Turno Ya Existe. Ingrese Otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mtbNumeroTurno.Focus();
                        return;
                    }
                }
                if ((int)numAño.Value < menor)
                {
                    menor = (int)numAño.Value;
                }
                if(txtDominio.Text.Trim().Length == 6)
                {
                    dominiomas6caracteres++;
                }
                vecTurnos[indice].numeroturno = numeroTurno;
                vecTurnos[indice].dominio = txtDominio.Text.Trim().ToUpper();
                vecTurnos[indice].añofabricacion = (int)numAño.Value;
                vecTurnos[indice].titular = txtTitular.Text.Trim();
                turnos++;
                indice++;
                MessageBox.Show("Registro Exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDominio.Clear();
                txtTitular.Clear();
                mtbNumeroTurno.Clear();
                numAño.Value = 2025;
                mtbNumeroTurno.Focus();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (indice <= 0)
            {
                MessageBox.Show("No Existen Turnos Cargados Para Consultar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblRCantidadTurnos.Visible = true;
                lblRCantidadTurnos.Text = turnos.ToString();
                lblRAñoMasAntiguo.Visible = true;
                lblRAñoMasAntiguo.Text = menor.ToString();
                lblRDominio6Caracteres.Visible = true; 
                lblRDominio6Caracteres.Text = dominiomas6caracteres.ToString();
            }
        }
    }
}
