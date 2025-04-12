using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        double value1, value2, result;
            string operation;

        private void button1_Click(object sender, EventArgs e)
        {
            operation = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operation = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation = "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation = "/";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            operation = "";
            textBox1.Focus();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                value1 = Convert.ToDouble(textBox1.Text);
                value2 = Convert.ToDouble(textBox2.Text);

                switch (operation)
                {
                    case "+":
                        result = value1 + value2;
                        break;
                    case "-":
                        result = value1 - value2;
                        break;
                    case "*":
                        result = value1 * value2;
                        break;
                    case "/":
                        if (value2 != 0)
                            result = value1 / value2;
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Please select an operation first.");
                        return;
                }

                textBox3.Text = result.ToString(); // Show the result
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }
    }
}
