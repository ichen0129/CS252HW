using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheGender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            string name = nameTextBox.Text;
            string gender = (randomNumber == 0) ? "Girl" : "Boy";

            //MessageBox.Show(string.Format("Hello {0}!, you are a {1} ", name, gender));
            DialogResult messageResult =
                MessageBox.Show(string.Format("Hello {0}, you are {1}.", name, gender),
                "Guess", MessageBoxButtons.YesNo);

            if (messageResult == DialogResult.Yes)
                MessageBox.Show("Guessed !");
            else
                MessageBox.Show("Wrong Guesses !");
        }
    }
}