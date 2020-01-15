using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {

        Random randomizer = new Random();

        //These integer variables store the numbers
        // for the addition problem
        int addend1;
        int addend2;

        //This interger variable keeps track of
        //remaining time
        int timeLeft;


        /// <summary>
        /// Start the quiz by filling in all of the problems
        /// and starting the timer.
        /// </summary>
        public void StartTheQuiz()
        {

            //<summary>
            //Fill in the addition problem
            //and start the timer.
            //</summary>

            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //Convert the two randomly generated numbers
            //into strings so that they can be displayed
            //in the label controls
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            //'sum' is the name of the NumericUpDown control.
            //This step makes sure its value is zero before
            //adding any values to it.
            sum.Value = 0;

            //start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                //Display the new time left
                //by updating the Time Left Label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() return false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                //If the user ran out of time, stop the time show
                //a Message Box, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's Up!";
                MessageBox.Show("You didn't finish in time. ", "Sorry");
                sum.Value = addend1 + addend2;
                startButton.Enabled = true;

            }
        }

        /// <summary>
        /// Check the answer to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        private bool CheckTheAnswer()
        {
            if (addend1 + addend2 == sum.Value)
                return true;
            else
                return false;
        }
    }
}
