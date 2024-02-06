using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace checkbox_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Dorucak.Checked && Rucak.Checked)
            {
                textBox1.Text = "Netočno";
            }
            else if (Dorucak.Checked && Vecera.Checked)
            {
                textBox1.Text = "Tocno";
            }

            else if (Vecera.Checked && Rucak.Checked)
            {
                textBox1.Text = "Netocno";
            }
            else
            {
                textBox1.Text = "Poruka odgovarajuceg sadrzaja.";
            }

            textBox1.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox1.Visible = false;
            }
            else 
            {
                textBox1.Visible = true;
            }
        }
    } 
}
