using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example
{
    public class HighScore  
    {
        public HighScore() 
        {
            InitializeComponent();
        }


        /// <summary>
        /// Calculates Score based on the Input in Text Boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInput(); //Check if All Input Fields are having Proper Values
                CalculateScores(); // Calculate Scores
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter Numeric Values only");
            }
        }

        //Check if Score is Numeric
        private void CheckInput()
        {
            if (txtScore1.Text.Trim() == string.Empty) txtScore1.Text = "0"; //If Text Box is Emply then Show 0
            if (txtScore2.Text.Trim() == string.Empty) txtScore2.Text = "0";
            if (txtScore3.Text.Trim() == string.Empty) txtScore3.Text = "0";
            if (txtScore4.Text.Trim() == string.Empty) txtScore4.Text = "0";
            if (txtScore5.Text.Trim() == string.Empty) txtScore5.Text = "0";

        }

        /// <summary>
        /// Gets the Score - Descending Order
        /// </summary>
        private void CalculateScores(String Score1, String Score2, String Score3, String Score4, String Score4)
        {


         

            //Create a 2 dimensional Array (Name, Score)
            string[,] a = new string[,]
	            {
	                {"Jon", Score1},
	                {"Scott", Score2},
	                {"Jim", Score3},
	                {"Kim", Score4},
	                {"Lily", Score5}
	            };


            

            // Separate Person and Score in Two Different Array

            // Declare Separate Array for  Score 
            int[] scoreArray = new int[a.Length / 2];

            // Declare Separate Array for  Person
            string[] personArray = new string[a.Length / 2];


            // Store Person in Array i.e Person Array
            for (int i = 0; i < a.Length / 2; i++)
            {
                scoreArray[i] = Convert.ToInt32(a[i, 1]);
                personArray[i] = a[i, 0];
            }

            // Do the Sorting (Sort Score and then Arrange Person as per Score)
            Array.Sort(scoreArray, personArray);

            // Declare Result Array
            string[,] Result = new string[5, 2];


            //Store Person and Score in 2D Array (Result)
            int k = 0;
            for (int i = (a.Length / 2) - 1; i >= 0; i--)
            {
                Result[k, 0] = personArray[i];
                Result[k, 1] = scoreArray[i].ToString();
                k++;
            }

            // Store Values in String so that we can Save
            StringBuilder resultText = new StringBuilder();
            resultText.Append("Sorted values - " + Environment.NewLine);

            for (int i = 0; i < Result.Length / 2; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    string arrayValue = Result[i, j];
                     if(j==1)
                         resultText.Append(arrayValue+Environment.NewLine);
                     else
                         resultText.Append(arrayValue+" : ");

                }

            }

            //Location Where we need to Store File {Change as Per your Computer Location}
            string filePath = @"C:\cert\Example\Example\Results\Results.txt";

            // Check if File Exists. If Exists then Delete
            if (File.Exists(filePath)) File.Delete("Result.txt");

            
            // Write Scores to File
            File.WriteAllText(filePath, resultText.ToString());

            //Display Message Where File is Saved
            MessageBox.Show("File is Saved at " + filePath);


        }
        public static void PrintKeysAndValues(String[] myKeys, int[] myValues)
        {
            for (int i = 0; i < myKeys.Length; i++)
            {
                Console.WriteLine("   {0,-10}: {1}", myKeys[i], myValues[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public class myReverserClass : IComparer
        {

            // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
            int IComparer.Compare(Object x, Object y)
            {
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}

