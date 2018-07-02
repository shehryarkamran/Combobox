using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                label1.ForeColor = Color.Red;
            else
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                label1.ForeColor = Color.Black;
              
            }
            if (radioButton1.Checked == true)
                label3.BackColor = Color.Red;
            else if (radioButton2.Checked == true)
                label3.BackColor = Color.Green;
            else if (radioButton3.Checked == true)
                label3.BackColor = Color.Blue;
            if (checkBox1.Checked == false)
                MessageBox.Show("Please check the Terms & condition!!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
                MessageBox.Show("Thanks for your corporation!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "Male";
            radioButton5.Checked = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "FeMale";
            radioButton4.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //label2.BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //label2.BackColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //label2.BackColor = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                label3.BackColor = Color.Red;
            else if(radioButton2.Checked == true)
                label3.BackColor = Color.Green;
            else if (radioButton3.Checked == true)
                label3.BackColor = Color.Blue;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
        }
    }
}
