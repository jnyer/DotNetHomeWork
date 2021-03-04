using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1._2
{
    public partial class Form1 : Form
    {
        double a, b;
        char c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
            double i = 0;
            if (double.TryParse(textBox1.Text, out i))
            {
                a = double.Parse(textBox1.Text);
            }
            else
            {
                a = 0;
            }
        }
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            double j = 0;
            if (double.TryParse(textBox2.Text, out j))
            {
                b = double.Parse(textBox2.Text);
            }
            else
            {
                b = 0;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            c = '-';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = '+';
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = '*';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c = '/';
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
                DialogResult result = MessageBox.Show("请输入数字！", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8 && e.KeyChar != '.')
            {
                e.Handled = true;
                DialogResult result = MessageBox.Show("请输入整数！", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case '+':this.textBox3.Text = (a + b).ToString();break;
                case '-':this.textBox3.Text = (a - b).ToString();break;
                case '*':this.textBox3.Text = (a * b).ToString();break;
                case '/':
                    if (b == 0) { this.textBox3.Text = "数字错误"; break; }
                    else { this.textBox3.Text = (a / b).ToString(); break; }

            }
        }
    }
}
