using System;
using System.Windows.Forms;

/*
 *      1-2a.	Write C# GUI program Pretest01-02 
 *              that converts distances from miles to kilometers and:
 *              
 *              ●	Declare a named constant named KM_PER_MILE 
 *                  which holds the number of kilometers in a mile 
 *                  (1.6 km per mile).
 *                  
 *              ●	Prompt the user for a distance in miles.
 *              
 *              ●	Display the distance in both kilometers and miles. 
 *                  For example: "3.0 miles is 4.8 kilometers"
 *                  
 *              ●	Set the AcceptButton, CancelButton, StartPosition, 
 *                  and Tab Order accordingly. 
 */

namespace Pretest01_02GUI
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }

        const decimal KM_PER_MILE = 1.6m;

        //  This code runs when the Calculate button is clicked.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //  Declare variables
            decimal miles = Convert.ToDecimal(txtMiles.Text);
            decimal kilos = miles * KM_PER_MILE;

            txtKilometers.Text = kilos.ToString("n2");
        }

        //  This code runs when the Clear button is clicked.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMiles.Text      = "";
            txtKilometers.Text = "";
            txtMiles.Focus();
        }

        //  This code runs when the Exit button is clicked.
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                    "Do You Really Want To Exit The Program?",
                    "EXIT NOW?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
