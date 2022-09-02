using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCasaleSP1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ouch, presionaste el botón");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hey, esto es una caja de texto! -_-");
        }

        private void rbAdmRed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAdmRed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hace click sobre admin de red","clickeando",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
        }
    }
}
