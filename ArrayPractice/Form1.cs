using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // Create 2 arrays to hold 10 values each
            int[] values = new int[10];//correct
            int[] numbers = new int[10];

            // variables that can be used to determine outcomes of questions
            int samePosition;
            int max = 6;
            int average;
            int sum;

            Random randGen = new Random();

            //1. Generate random values for both pre-created arrays

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = randGen.Next(0, max);//array 1
                numbers[i] = randGen.Next(0, max);//array 2 

            }
            //2. Display array 1

            array1Output.Text = "";
            for (int i = 0; i < values.Length; i++)
            {
                array1Output.Text += values[i] + " ";
            }

            array2Output.Text = "";
            for (int i = 0; i < numbers.Length; i++)
            {

                array2Output.Text += $"{numbers[i]} "; //3. Display array 2
            }



            //4. Display array 1 in reverse order
            reverseOutput.Text = "";

            for (int i = values.Length - 1; i >= 0; i--)// instead of being less that the length of the values, it is greater or equal to 0, and then subtra
            {
                reverseOutput.Text += values[i] + " ";
            }


            //5. Determine and display the largest value in array 1          
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
            }
            maxOutput.Text = max + "";

            //6.Determine and display the average of all values in array 1
            sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            average = sum / values.Length;
            averageOutput.Text = average + "";

            //7. Determine and display the sum of all even values in array 1

            //divisible by 2 w remainder of 0, otherwise don't display
            int sumEven = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    sumEven += values[i];
                }
            }
            evenOutput.Text = sumEven + "";


            //8. Determine and display the number of 3s in array 1
            int numThrees = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == 3)
                {
                    numThrees++;
                }
            }

            threeOutput.Text = numThrees + "";

            //9. Determine and display how many matching numbers in matching positions between the 2 arrays there are
            samePosition = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (values[i] == numbers[i])
                {
                    samePosition++;
                }
            }
            matchOutput.Text = samePosition + "";

            // ----------------------
            // ##### ENRICHMENT #####
            // ----------------------


            //1. Determine and display at what index is the first 0 in array 1, (show "null" if no 0 exists)
            int index = -1;

            for (int i = values.Length - 1; i >= 0; i--)
            {
                if (values[i] == 0)
                {
                    index = i;
                }
            }
            if (index >= 0)
            {
                zeroOutput.Text = index + "";
            }
            else
            {
                zeroOutput.Text = "null";
            }

            //2. swap and display all values between array1 and array2
            int temp;

            for (int i = 0; i < values.Length; i++)
            {
                temp = values[i];
                values[i] = numbers[i];
                numbers[i] = temp;
            }

            swap1Output.Text = "";
            for (int i = 0; i < values.Length; i++)
            {
                swap1Output.Text += values[i] + " ";
            }

            swap2Output.Text = "";
            for (int i = 0; i < values.Length; i++)
            {
                swap2Output.Text += numbers[i] + " ";
            }
        }
    }
}

