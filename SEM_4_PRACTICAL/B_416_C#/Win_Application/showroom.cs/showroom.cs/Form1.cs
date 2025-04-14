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

namespace showroom.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\BCA_SEM-4\\SEM_4_PRACTICAL\\B_416_C#\\Win_Application\\showroom.cs\\showroom.cs\\showroom.mdf;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)//select button
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand ("SELECT *FROM CARINFO",Con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
           dataGridView1.DataSource = DT;
           Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO CARINFO VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Data Inserted Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE CARINFO SET car_name ='"+textBox1.Text+"',car_price='"+textBox2.Text+"' WHERE car_id='"+textBox3.Text+"'",Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Data Updated Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM CARINFO WHERE car_id = '"+textBox3.Text+"'",Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Data Deleted Successfully");
        }
    }
}
