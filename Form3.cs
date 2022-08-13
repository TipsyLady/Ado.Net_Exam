using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado.Net_Exam
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TaxiDB"].ConnectionString))
            {
                conn.Open();
                SqlCommand addD = new SqlCommand("stp_Add_Driver", conn);
                addD.CommandType = CommandType.StoredProcedure;
                addD.Parameters.AddWithValue("First_Name", textBox1.Text);
                addD.Parameters.AddWithValue("Last_Name", textBox2.Text);
                addD.Parameters.AddWithValue("DateOfBirth", dateTimePicker1.Value);
                addD.Parameters.AddWithValue("Rate_index", numericUpDown1.Value);
                addD.Parameters.AddWithValue("Id", 1);
                addD.ExecuteNonQuery();
                conn.Close();
                Close();
            }
        }
    }
}
