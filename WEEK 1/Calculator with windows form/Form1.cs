using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_with_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "=";
            button1.Text = "选择不同运算符进行计算";
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");


            void Form1_Load(object sender, EventArgs e)
            {

            }

           void label1_Click(object sender, EventArgs e)
            {

            }

           
           void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c;
            a = Convert.ToSingle(textBox1.Text);
            b = Convert.ToSingle(textBox2.Text);
            if (comboBox1.Text == "+")
            {
                c = a + b;
                textBox3.Text = c.ToString();
            }
            else if (comboBox1.Text == "-")
            {
                c = a - b;
                textBox3.Text = c.ToString();
            }
            else if (comboBox1.Text == "*")
            {
                c = a * b;
                textBox3.Text = c.ToString();

            }
            else
            {
                c = a / b;
                textBox3.Text = c.ToString();
            }
        }
    }


}
    
