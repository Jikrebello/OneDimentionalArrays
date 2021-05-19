using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace OneDimentionalArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * 1. a) Load in ten numbers (12,14,23,2,56,3,78,88,143,54) into an array called num.
         * b) Display, in two columns, the index and the contents of each element in the array.
         * As a result , you should understand the distinction between the array subscript
         * (index) and the contents of the array .
         */
        private void BtnDisplayArrayIndex_Click(object sender, EventArgs e)
        {
            int[] marks = { 12, 14, 23, 2, 56, 3, 78, 88, 143, 54 };
            TxtDisplay.Text = "";

            TxtDisplay.Text += "Index:\tValue:" + Environment.NewLine;

            for (int i = 0; i < marks.Length; i++)
            {
                TxtDisplay.Text += Array.IndexOf(marks, marks[i]).ToString() + "\t" + marks[i].ToString() + Environment.NewLine;
            }
        }

        /*
         * 2. a) Load in eight marks into an array called mark.
         * b) Display only the passing marks
         * c) Calculate the sum of every other mark.
         * d) Calculate the sum of the passing marks only.
         */
        private void BtnPassingMarks_Click(object sender, EventArgs e)
        {
            int[] marks = { 50, 60, 76, 43, 23, 66, 56, 78 };
            float sumOfPassedMarks = 0;
            int totalOfPassedMarks = 0;

            float sumOfFailedMarks = 0;
            int totalOfFaileddMarks = 0;
            TxtDisplay.Text = "";

            TxtDisplay.Text += "Passed Marks:" + Environment.NewLine;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] >= 50)
                {
                    totalOfPassedMarks++;
                    sumOfPassedMarks += marks[i];
                    TxtDisplay.Text += marks[i] + Environment.NewLine;
                }
            }

            TxtDisplay.Text += Environment.NewLine + "Failed Marks:" + Environment.NewLine;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 50)
                {
                    totalOfFaileddMarks++;
                    sumOfFailedMarks += marks[i];
                    TxtDisplay.Text += marks[i] + Environment.NewLine;
                }
            }

            TxtDisplay.Text += Environment.NewLine + "Average For Passed Marks: " + Math.Round(sumOfPassedMarks / totalOfPassedMarks, 2);
            TxtDisplay.Text += Environment.NewLine + "Average For Failed Marks: " + Math.Round(sumOfFailedMarks / totalOfFaileddMarks, 2);
        }

        /*
         * 3. St. Jean de Brebeuf is conducting a survey of their students to find out if doing well in
         * Math has anything to do with doing well in French.
         * a) Write an event procedure to load in 25 pairs of marks. The first mark in each pair
         * is the Math mark, the second is the French mark.
         * b) Write a separate event procedure that counts all those students who have 80% or
         * higher in both Math and French and displays the final count .
         */
        private List<string> frenchList = new List<string>();
        private List<string> mathList = new List<string>();
        private void LoadInMathsAndFrench(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Math_and_French_Marks.txt";

            // Gets the marks from the file and places them into the respective list based off whether the line is odd or even (French is even, Maths is odd)
            using (StreamReader reader = new StreamReader(path))
            {
                bool lineNumberEven = false; // french marks are odd

                while (!reader.EndOfStream)
                {
                    if (!lineNumberEven)
                    {
                        frenchList.Add(reader.ReadLine());
                        lineNumberEven = !lineNumberEven;
                    }
                    else
                    {
                        mathList.Add(reader.ReadLine());
                        lineNumberEven = !lineNumberEven;
                    }
                }

                reader.Close();
            }

            // Display the French and Maths marks in the text box
            string header = "French marks:\tMaths Marks:" + Environment.NewLine;
            TxtDisplay.Text = "";
            TxtDisplay.Text += header;

            for (int i = 0; i < frenchList.Count; i++)
            {
                TxtDisplay.Text += frenchList[i].ToString() + "\t\t" + mathList[i].ToString() + Environment.NewLine;
            }
        }
        private void ViewTopAchieverTotal(object sender, EventArgs e)
        {
            int totalAchievers = 0;

            for (int i = 0; i < frenchList.Count; i++)
            {
                if (Convert.ToInt32(frenchList[i]) >= 80 && Convert.ToInt32(mathList[i]) >= 80)
                {
                    totalAchievers++;
                }
            }

            TxtDisplay.Text = "";
            TxtDisplay.Text = "Total Achievers:\t" + totalAchievers;
        }
    }
}