using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fermat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            int number = textBox1.Text == "" ? 0 : int.Parse(textBox1.Text);
            //Kaç kez deneneceği
            int k = textBox2.Text == "" ? 20 : int.Parse(textBox2.Text); ;  

            if (myFermatPrimalityTest1.isPrime(number,k))
            {
                checkBox1.BackColor = Color.Green;
                checkBox1.Checked = true;
                checkBox2.BackColor = Color.White;
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.BackColor = Color.Red;
                checkBox2.Checked = true;
                checkBox1.BackColor = Color.White;
                checkBox1.Checked = false;
            }

        }
    }
}
