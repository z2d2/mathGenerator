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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Method to generate random highest number as inputed by user.
         * 
         */
        public int randomHighNumber()
        {
            int highNumber = 0;
            int.TryParse(textBoxHighestNumber.Text, out highNumber); // tryParse input to varable high number
            Random rand = new Random(); //new random object
            int randomHighNumber = rand.Next(highNumber);//generate random high number
            return randomHighNumber; //return results
        }
      
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Pass Data to form 2

            // Open form2
            Form2 form = new Form2(randomHighNumber()); 
            form.Show();
            this.Hide();
        }
    }
}
