using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Ado.Net_Exam
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxiDBDataSet.OrderSet' table. You can move, or remove it, as needed.
            this.orderSetTableAdapter.Fill(this.taxiDBDataSet.OrderSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            int index = dataGridView1.CurrentRow.Index;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TaxiDB"].ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(" SELECT * FROM OrderSet", conn);
                conn.Open();
                dataAdapter.Fill(ds, "OrderSet");
                conn.Close();
            };
            Form5 form5 = new Form5(ds, index);
            form5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TaxiDB"].ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(" SELECT * FROM DriversSet", conn);
                conn.Open();
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "DriversSet");
                dataGridView1.DataSource = dataSet.Tables["DriversSet"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TaxiDB"].ConnectionString))
            {
                conn.Open();
                SqlCommand addD = new SqlCommand("stp_Order_by_Date", conn);
                addD.CommandType = CommandType.StoredProcedure;
                addD.Parameters.AddWithValue("Order_time", dateTimePicker1.Value);
                addD.ExecuteNonQuery();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(addD);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TaxiDB"].ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(" SELECT * FROM OrderSet", conn);
                conn.Open();
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "OrderSet");
                dataGridView1.DataSource = dataSet.Tables["OrderSet"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TaxiDB"].ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(" SELECT * FROM ClientsSet", conn);
                conn.Open();
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "ClientsSet");
                dataGridView1.DataSource = dataSet.Tables["ClientsSet"];
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
    }
}
