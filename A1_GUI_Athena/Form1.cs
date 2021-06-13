using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1_GUI_Athena
{
    public partial class Form1 : Form
    {
        int min, max;

        public Form1()
        {
            InitializeComponent();
        }

        //Method to determine which of the 2 user inputs is lower/higher than the other
        public void GetMinMax()
        {
            int num1 = int.Parse(UserInput1.Text);
            int num2 = int.Parse(UserInput2.Text);

            if (num1 < num2)
            {
                min = num1;
                max = num2;
            }
            else
            {
                min = num2;
                max = num1;
            }
        }

        // Method to check if the number is prime
        private Boolean BooleanNum(int n)
        {
            Boolean b = true;
            int squareRoot = (int)Math.Sqrt(n);
            // double sqrtRoot = Math.Sqrt(n);
            for (int i = 2; i <= squareRoot; i++)
            {
                if ((n % i) == 0)
                {
                    b = false;
                    break;
                }
            }
            return (b);
        }

        //Method that will display all prime numbers in the textbox
        public void PrimeFinder(int low, int high)
        {
            int num_per_row = 0;
            for (int i = low; i <= high; i++)
            {
                if (BooleanNum(i))
                {
                    num_per_row++;
                    Output.Text += i.ToString() + "\t";
                    if (num_per_row == 5)
                    {
                        Output.Text += "\r\n";
                        num_per_row = 0;
                    }
                }
            }
        }

        //Button that will process the user's input
        private void GetPrime_Click(object sender, EventArgs e)
        {
            GetMinMax();
            PrimeFinder(min, max);
        }

        //Button to reset the textboxes to its initial state
        private void Reset_Click(object sender, EventArgs e)
        {
            UserInput1.Clear();
            UserInput2.Clear();
            Output.Text = "";
        }
    }
}