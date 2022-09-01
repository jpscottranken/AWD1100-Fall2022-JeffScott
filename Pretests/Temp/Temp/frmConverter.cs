using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            int x = 7;
            int y = 5;
            int z = x / y;
            MessageBox.Show(z.ToString());
        }

        private void txtMiles_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMiles_Click(object sender, EventArgs e)
        {

        }

        private void frmConverter_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Enter(object sender, EventArgs e)
        {
            MessageBox.Show("Hi From Calculate Button",
                            "Calculate Button Enter Event",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
