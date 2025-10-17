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

        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
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
    }
}
