using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcuate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= 48 && e.KeyChar <= 57) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.");
            }
        }

        private void calcuateButton_Click(object sender, EventArgs e)
        {
            int Number1 = int.Parse(numTextBox1.Text);
            int Number2 = int.Parse(numTextBox2.Text);
            int Number3 = int.Parse(numTextBox3.Text);
            int Number4 = int.Parse(numTextBox4.Text);

            int Total = Number1 + Number2 + Number3 + Number4;
            MessageBox.Show("Total : " + Total.ToString());
        }

        private void numTextBox1_Leave(object sender, EventArgs e)
        {
            int number;
            bool canConvert = int.TryParse(((TextBox)(sender)).Text, out number);
            if (canConvert == false)
            {
                MessageBox.Show(string.Format("{0} is not a valid int", ((TextBox)(sender)).Text));
                ((TextBox)(sender)).Text = "";
                ((TextBox)(sender)).Focus();
                return;
            }
        }
    }
}