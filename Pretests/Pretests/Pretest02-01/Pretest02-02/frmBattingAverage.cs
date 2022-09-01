using System;
using System.Windows.Forms;

/*
 *  C# Chapters 1 - 5 Pretest 2 Problem 2
 *      
 *      In baseball, a player's average is 
 *		calculated by dividing hits by at bats.
 *		
 *		For example, a player with 4 hits in 10
 *		at bats has an average, of .400, 
 *		typically stated as a 400 average.
 *
 *		Write a C# GUI windows forms program that
 *		lets a user input at bats and hits.  From
 *		that, calculate the associated batting average.
 *
 *		Keep track of the highest batting average, 
 *		lowest batting average, and total number 
 *		of averages calculated.  Store these value 
 *		in read-only textboxes.
 *
 *		For both hits and at bats, verify that:
 *
 *		a) 	Value inputted is not empty.
 *		b) 	Value inputted is not non-numeric.
 *		c) 	Value inputted is 0 or more.
 *		d) 	For hits, the value is <= the value 
 *			for at bats.
 *
 *		a)	Set the Tab Order, AcceptButton, 
 *			CancelButton, and Start Position.  
 *
 *		b) 	Change the name of the form and the 
 *			form text as well.  
 *
 *		c) 	Create a program prologue at the start
 *			of the code.  
 */

namespace Pretest02_02
{
    public partial class frmBattingAverage : Form
    {
        public frmBattingAverage()
        {
            InitializeComponent();
        }

        //  Declare global (class-level) variables
        int totalNumberOfAverages    = 0;
        double highestBattingAverage = 0;
        double lowestBattingAverage  = 1.000;
        int atBats = 0;
        int hits   = 0;
        double avg = 0.00;

        //  This code executes when the Calculate button is clicked.
        //  It is the program "driver" calling other routines.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = true;      //  Flag

            keepGoing = validateAtBatsNotEmpty();

            //  At bats validated to not be empty
            //  Validate at bats is numeric
            if (keepGoing)
            {
                keepGoing = validateAtBatsIsNumeric();
            }
            //  At bats was empty
            else
            {
                return;
            }

            //  At bats validated to be numeric
            //  Validate at bats is >= 0
            if (keepGoing)
            {
                keepGoing = validateAtBatsIsPositive();
            }
            //  At bats was not numeric
            else
            {
                return;
            }

            //  At bats validated to be >= 0
            //  Validate hits not empty
            if (keepGoing)
            {
                keepGoing = validateHitsNotEmpty();
            }
            //  At bats was negative
            else
            {
                return;
            }

            //  Hits validated to not be empty
            //  Validate hits is numeric
            if (keepGoing)
            {
                keepGoing = validateHitsIsNumeric();
            }
            //  Hits was empty
            else
            {
                return;
            }

            //  Hits validated to be numeric
            //  Validate hits <= at bats
            if (keepGoing)
            {
                keepGoing = validateHitLessThanOrEqualToAtBats();
            }
            //  Hits was not numeric
            else
            {
                return;
            }

            //  Hits validated <= at bats
            //  OK to do all calculations now
            if (keepGoing)
            {
                doTheCalculations();
            }
        }

        //  Validate at bats not empty
        private bool validateAtBatsNotEmpty()
        {
            bool retVal = true;

            if (txtAtBats.Text.Trim() == "")
            {
                showMessage("At Bats Cannot Be Empty!!!",
                            "EMPTY AT BATS");
                txtAtBats.Focus();
                retVal = false;
            }

            return retVal;
        }

        //  Validate at bats numeric
        private bool validateAtBatsIsNumeric()
        {
            bool retVal = true;
            bool result;

            result = Int32.TryParse(txtAtBats.Text, out atBats);

            if (!result)
            {
                showMessage("At Bats Must Be Numeric!!!",
                            "NON-NUMERIC AT BATS INPUTTED");
                retVal = false;
                txtAtBats.Text = "";
                txtAtBats.Focus();
            }

            return retVal;
        }

        //  Validate at bats is >= 0
        private bool validateAtBatsIsPositive()
        {
            bool retVal = true;

            if (atBats < 0)
            {
                showMessage("At Bats Must Be >= 0",
                            "NEGATIVE AT BATS INPUTTED");
                retVal = false;
                txtAtBats.Text = "";
                txtAtBats.Focus();
            }

            return retVal;
        }

        //  Validate hits not empty
        private bool validateHitsNotEmpty()
        {
            bool retVal = true;

            if (txtHits.Text.Trim() == "")
            {
                showMessage("Hits Cannot Be Empty!!!",
                            "EMPTY HITS");
                txtHits.Focus();
                retVal = false;
            }

            return retVal;
        }

        //  Validate hits is numeric
        private bool validateHitsIsNumeric()
        {
            bool retVal = true;
            bool result;

            result = Int32.TryParse(txtHits.Text, out hits);

            if (!result)
            {
                showMessage("Hits Must Be Numeric!!!",
                            "NON-NUMERIC HITS INPUTTED");
                retVal = false;
                txtHits.Text = "";
                txtHits.Focus();
            }

            return retVal;
        }

        //  Validate hits <= at bats
        private bool validateHitLessThanOrEqualToAtBats()
        {
            bool retVal = true;

            if (hits > atBats)
            {
                showMessage("Hits Cannot Be Greater Than At Bats",
                            "IMPOSSIBLE SITUATION");
                retVal = false;
                txtHits.Text = "";
                txtHits.Focus();
            }

            return retVal;
        }

        //  Both at bats and hits are valid
        //  Do all necessary calculations    
        private void doTheCalculations()
        {
            //  Calculate average
            //  Display in appropriate textbox
            avg = (double)hits / (double)atBats;
            txtAverage.Text = avg.ToString("n3");

            //  Incrmenet total number of averages
            //  Display in appropriate textbox
            ++totalNumberOfAverages;
            txtlTotalNumberAverages.Text = totalNumberOfAverages.ToString();

            //  Calculate possible new highest batting average
            //  Display in appropriate textbox
            if (avg > highestBattingAverage)
            {
                highestBattingAverage = avg;
            }

            txtHighestAverage.Text = highestBattingAverage.ToString("n3");

            //  Calculate possible new lowest batting average
            //  Display in appropriate textbox
            if (avg < lowestBattingAverage)
            {
                lowestBattingAverage = avg;
            }

            txtLowestAverage.Text = lowestBattingAverage.ToString("n3");
        }

        //  This code executes when the Clear button is clicked.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAtBats.Text  = "";
            txtHits.Text    = "";
            txtAverage.Text = "";
            txtAtBats.Focus();
        }

        //  This code executes when the Exit button is clicked.
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

        //  This code displays a customer MessageBox.
        private void showMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
