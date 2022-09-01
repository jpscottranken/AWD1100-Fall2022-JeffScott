using System;
using System.Windows.Forms;

/*
 *      1-3b.	Write C# GUI program Pretest01-03 
 *              that lets a user enter a number grade 
 *              and displays the associated letter grade. 
 *              
 *              Include constants MINGRADE (0) and 
 *              MAXGRADE (100).  
 *              
 *              The associated letter grade code we used 
 *              is shown below:
 *              
 *              < 0 or > 100 = "Invalid"
 *              90 - 100 = A
 *              80 -  89 = B
 *              70 -  79 = C
 *              60 -  69 = D
 *               0 -  59 = F
 *               
 *              Display the number grade and the letter grade.
 *              
 *              Set the AcceptButton, CancelButton, StartPosition, 
 *              and Tab Order accordingly.
 *
 *      As a GUI Program
 */

namespace Pretest01_03GUI
{
    public partial class frmGrades : Form
    {
        public frmGrades()
        {
            InitializeComponent();
        }

        //  Program constants
        const int MINGRADE  =   0;   //  Lowest  possible grade
        const int MAXGRADE  = 100;   //  Highest possible grade

        //  This code executes when the Calculate button is clicked.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int grade = Convert.ToInt32(txtNumberGrade.Text);
            string letterGrade = "";

            if ((grade > MAXGRADE) ||
                (grade < MINGRADE))
            {
                letterGrade = "Invalid";
            }
            else if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else if (grade >= MINGRADE)
            {
                letterGrade = "F";
            }

            txtLetterGrade.Text = letterGrade;
        }

        //  This code executes when the Clear button is clicked.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberGrade.Text = "";
            txtLetterGrade.Text = "";
            txtNumberGrade.Focus();
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
    }
}

/*
            int grade = Convert.ToInt32(Console.ReadLine());
            string letterGrade = "";

            if ((grade > MAXGRADE) ||
                (grade < MINGRADE))
            {
                letterGrade = "Invalid Number Grade";
            }
            else if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80)
            {
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else if (grade >= MINGRADE)
            {
                letterGrade = "F";
            }

            Console.WriteLine("\nNumber Grade was: " + grade.ToString() +
                              "\nLetter Grade was: " + letterGrade);

            Console.ReadLine();

 */
