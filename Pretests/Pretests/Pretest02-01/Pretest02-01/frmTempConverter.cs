using System;
using System.Windows.Forms;

/*
 *  C# Chapters 1 - 5 Pretest 2 Problem 1
 *  
 *  Write a C# GUI app to convert either a 
 *	temp inputted in Fahrenheit to Celsius 
 *	temp inputted in Fahrenheit to Celsius 
 *	temp inputted in Celsius to Fahrenheit:
 *
 *	Verify that either input is: 
 *	    a)	Not empty. 
 *	    b)	Is numeric.  
 *	    c)	Within range.
 *
 *	a)	Set the Tab Order, AcceptButton, 
 *		CancelButton, and Start Position.
 *
 *	b) 	Change the name of the form
 *		and the form text as well.  
 *
 *	c) 	Create a program prologue at the 
 *		beginning of the code.  
 *
 *	Create consts MINFAHR (-212), MAXFAHR 
 *	(212), MINCELSIUS (-100), MAXCELSIUS (100).  
 *		
 *	OPTIONAL: 	Modularize your program.
 *		
 *				Here are the conversion formulas:
 *
 *			    celsius = (fahrenheit - 32) / 1.8
 *			    fahrenheit = (celsius * 1.8) + 32
 */

namespace Pretest02_01
{
    public partial class frmTempConverter : Form
    {
        public frmTempConverter()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const decimal MINFAHR    = -212;        //  Min F temp allowed
        const decimal MAXFAHR    =  212;        //  Max F temp allowed
        const decimal MINCELSIUS = -100;        //  Min C temp allowed
        const decimal MAXCELSIUS =  100;        //  Max C temp allowed

        //  Global (class-level) variables
        decimal temp;                           //  Inputted temp made #
        decimal celsius;                        //  Calculated celsius temp
        decimal fahrenheit;                     //  Calculated fahr temp

        //  This code executes when Clear button clicked.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFahrTemp.Text = "";
            txtCelTemp.Text  = "";
            txtFahrTemp.Focus();
        }

        //  This code executes when Exit button clicked.
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

        //  This method is executed when the
        //  F To C button is clicked.
        private void btnConvertFToC_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;      //  flag

            //  Call routine to validate F To C textbox not empty
            keepGoing = validateFahrTempNotEmpty();

            //  F To C textbox validated not empty
            if (keepGoing)
            {
                //  Validate F To C textbox numeric.
                keepGoing = validateFahrTempIsNumeric();
            }
            //  F To C textbox validated empty
            else
            {
                return;
            }

            //  F To C textbox validated numeric
            if (keepGoing)
            {
                //  Validate F To C textbox within input range.
                keepGoing = validateFahrTempIsWithinRange();
            }
            //  F To C textbox validated non-numeric
            else
            {
                return;
            }

            //  F To C textbox validated within input range.
            if (keepGoing)
            {
                celsius         = (temp - 32.0m) / 1.8m;
                txtCelTemp.Text = celsius.ToString("n2");
                temp            = 0m;
            }
            //  F To C textbox validated out of range.
            else
            {
                return;
            }
        }

        //  This method validates that the
        //  F To C texbox is not empty.
        private bool validateFahrTempNotEmpty()
        {
            bool retVal = true;

            if (txtFahrTemp.Text.Trim() == "")
            {
                showMessage("TextBox Cannot Be Empty",
                            "EMPTY FAHRENHEIT TEMP");
                retVal = false;
                txtFahrTemp.Focus();
            }

            return retVal;
        }

        //  This method validates that the
        //  F To C texbox value is numeric.
        private bool validateFahrTempIsNumeric()
        {
            bool retVal = true;
            bool result;

            result = Decimal.TryParse(txtFahrTemp.Text, out temp);

            if (!result)
            {
                showMessage("TextBox Must Be Numeric",
                            "NON-NUMERIC FAHRENHEIT TEMP");
                retVal = false;
                txtFahrTemp.Text = "";
                txtFahrTemp.Focus();
            }

            return retVal;
        }

        private bool validateFahrTempIsWithinRange()
        {
            bool retVal = true;

            if ((temp < MINFAHR) || (temp > MAXFAHR))
            {
                showMessage("Temperature Inputted Out-Of-Range",
                            "OOR FAHRENHEIT TEMP");
                retVal = false;
                txtFahrTemp.Text = "";
                txtFahrTemp.Focus();
            }
 
            return retVal;
        }

        //  This method is executed when the
        //  C To F button is clicked.
        private void btnConvertCToF_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;      //  flag

            //  Call routine to validate C To F textbox not empty
            keepGoing = validateCelTempNotEmpty();

            //  C To F textbox validated not empty
            if (keepGoing)
            {
                //  Validate C To F textbox numeric
                keepGoing = validateCelTempIsNumeric();
            }
            //  C To F textbox empty
            else
            {
                return;
            }

            //  C To F textbox validated numeric
            if (keepGoing)
            {
                keepGoing = validateCelTempIsWithinRange();
            }
            //  C To F textbox validated non-numeric
            else
            {
                return;
            }

            if (keepGoing)
            {
                fahrenheit = (temp * 1.8m) + 32m;
                txtFahrTemp.Text = fahrenheit.ToString("n2");
                temp = 0m;
            }
            else
            {
                return;
            }
        }

        //  This method validates that the
        //  C To F texbox is not empty.
        private bool validateCelTempNotEmpty()
        {
            bool retVal = true;

            if (txtCelTemp.Text.Trim() == "")
            {
                showMessage("TextBox Cannot Be Empty",
                            "EMPTY CELSIUS TEMP");
                retVal = false;
                txtCelTemp.Focus();
            }

            return retVal;
        }

        //  This method validates that the
        //  C To F texbox value is numeric.
        private bool validateCelTempIsNumeric()
        {
            bool retVal = true;
            bool result;

            result = Decimal.TryParse(txtCelTemp.Text, out temp);

            if (!result)
            {
                showMessage("TextBox Must Be Numeric",
                            "NON-NUMERIC CELSIUS TEMP");
                retVal = false;
                txtCelTemp.Text = "";
                txtCelTemp.Focus();
            }

            return retVal;
        }

        //  This method validates that the
        //  C To F texbox >= -100 and <= +100.
        private bool validateCelTempIsWithinRange()
        {
            bool retVal = true;

            if ((temp < MINCELSIUS) || (temp > MAXCELSIUS))
            {
                showMessage("Temperature Inputted Out-Of-Range",
                            "OOR CELSIUS TEMP");
                retVal = false;
                txtCelTemp.Text = "";
                txtCelTemp.Focus();
            }

            return retVal;
        }

        //  This routine writes a custom MessageBox
        private void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, title, 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
        }
    }
}
