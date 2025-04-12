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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exam_demo.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\BCA_SEM-4\SEM_4_PRACTICAL\B_416_C#\Win_Application\exam_demo.cs\exam_demo.cs\stationery.mdf;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)//update
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE STATIONERYINFO SET book_name='" 
                + textBox1.Text+"',book_price='"+textBox3.Text+"' WHERE book_id ='"+textBox2.Text+"' ", Con);
            cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Updated Successfully");
        }
        private void button2_Click(object sender, EventArgs e)//insert
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO STATIONERYINFO VALUES('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')", Con);
            cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Data Inserted Successfully");

        }

        private void button3_Click(object sender, EventArgs e)//select
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SELECT *FROM STATIONERYINFO", Con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)//delete
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM STATIONERYINFO WHERE book_id='" + textBox2.Text + "'", Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Data Deleted Successfully");
        }
    }
}
