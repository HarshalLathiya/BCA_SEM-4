using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace First
{
    public partial class Form1 : Form
    {   
        //sql connection file
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\BCA_SEM-4\\SEM_4_PRACTICAL\\B_416_C#\\Win_Application\\First\\First\\mydatabase.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        //Textbox1(First name)
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.ForeColor = Color.Red;// Change text color to red when any key is pressed
            textBox1.BackColor = Color.LightGreen; // Change textbox back color to white when any key is pressed
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            textBox1.BackColor = Color.White; // Change textbox backcolor when any key is up
            if (e.KeyCode == Keys.Enter)//To move next textbox when user click on Enter
            {
                textBox2.Focus();         // Move focus to textbox2
                e.Handled = true;         // Prevent ding sound
                e.SuppressKeyPress = true;
            }
        }
        //Textbox2(Middle name)
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.ForeColor = Color.Red;
            textBox2.BackColor = Color.LightGreen;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            textBox2.BackColor = Color.White;
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        //Textbox3(Last name)
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox3.ForeColor = Color.Red;
            textBox3.BackColor = Color.LightGreen;
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            textBox3.BackColor = Color.White;
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        //Textbox4 (Age)
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox4.ForeColor = Color.Red;
            textBox4.BackColor = Color.LightGreen;
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            textBox4.BackColor= Color.White;
        }
        //Textbox5(ID)
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox5.ForeColor = Color.Red;
            textBox5.BackColor = Color.LightGreen;
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        //Submit button
        private void button1_Click(object sender, EventArgs e)
        {
            // Check which radio button is selected and display the value in the label
            if (radioButton1.Checked)
            {
                label4.Text = "Selected: Male";
            }
            else if (radioButton2.Checked)
            {
                label4.Text = "Selected: Female";
            }
            else
            {
                label4.Text = "No gender selected!";
            }
            // checkbox into combobox !
            comboBox1.Items.Clear();
            foreach (CheckBox cb in this.Controls.OfType<CheckBox>())
            {
                if (cb.Checked)
                {
                    comboBox1.Items.Add(cb.Text);
                }
            }
        }
        //menustrip for Calculator form
        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calcForm = new Calculator();
            calcForm.MdiParent = this;
            calcForm.Show();
        }
        //Reset button
        private void button2_Click(object sender, EventArgs e)
        {
            // Reset Textbox
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            // Uncheck RadioButtons
            label4.Text = "Value:";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            // Uncheck CheckBoxes
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            // Reset ComboBox selection
            comboBox1.SelectedIndex = -1;
            textBox1.Focus();
            
        }
        //Insert Button
        private void button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO INFOTABLE VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')", Con);
            cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Inserted Successfully");
        }
        //update Button
        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE INFOTABLE SET First_name = '" + textBox1.Text +
                                            "', Middle_name = '" + textBox2.Text +
                                            "', Last_name = '" + textBox3.Text +
                                            "', Age = '" + textBox4.Text +
                                            "' WHERE Id = '" + textBox5.Text + "'", Con);
            cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Updated Successfully");
        }

        //Select Button
        private void button6_Click(object sender, EventArgs e)
        {
            Con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM INFOTABLE", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            Con.Close();
        }
        //Delete Button
        private void button5_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM INFOTABLE WHERE Id = '" + textBox5.Text + "'", Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Data Deleted Successfully");

        }
        // Reset identity seed
        private void button7_Click(object sender, EventArgs e)
        {
            Con.Open();

            // Delete all rows
            SqlCommand deleteCmd = new SqlCommand("DELETE FROM INFOTABLE", Con);
            deleteCmd.ExecuteNonQuery();

            // Reset identity seed
            SqlCommand resetCmd = new SqlCommand("DBCC CHECKIDENT ('INFOTABLE', RESEED, 0)", Con);
            resetCmd.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("All data deleted and ID reset to 1.");
        }
    }
}
