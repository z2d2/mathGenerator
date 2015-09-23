using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class Form2 : Form
    {
        public Form2(int randomHighNumber , int numberOfQuestions) //randomHighNumber returns to this value.
        {
            InitializeComponent();
            //create a new random object to generate bottom number BASED on the highest value
            Random Bottom = new Random();
            int botNumber = Bottom.Next(randomHighNumber - 1);
            labelFirstNumber.Text = randomHighNumber.ToString(); //output the top number
            labelSecondNumber.Text = botNumber.ToString();} //output the bottom number
            

            private void checkAnswer(int randomTotal ,int botNumber , int randomHighNumber)
            {
                if (randomTotal == botNumber + randomHighNumber)
                {
                   MessageBox.Show("That's Right!");
                }
                else
                {
                    MessageBox.Show("I'm sorry, that is wrong. The correct answer is " + randomTotal);
                }
            }
           
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            checkAnswer();
            
        }
    }
}
