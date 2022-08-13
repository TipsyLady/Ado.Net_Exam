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
    public partial class Form2 : Form
    { 
        public Form2()
        {
            InitializeComponent();
            CB_Fill_Clients();
            CB_Fill_Drivers();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TaxiDB"].ConnectionString))
            {
                conn.Open();
                SqlCommand AddOrder = new SqlCommand("stp_Add_Order", conn);
                AddOrder.CommandType = CommandType.StoredProcedure;
                AddOrder.Parameters.AddWithValue("Address_from", TB_AdressFrom.Text);
                AddOrder.Parameters.AddWithValue("Address_to", TB_AdressTo.Text);
                AddOrder.Parameters.AddWithValue("Order_time", dateTimePicker1.Value);
                AddOrder.Parameters.AddWithValue("Order_cost", (float)Convert.ToDouble(TB_Cost.Text));
                AddOrder.Parameters.AddWithValue("Order_status", CB_Status.SelectedItem);
                AddOrder.Parameters.AddWithValue("ClientsId", CB_Client.SelectedItem.ToString().Substring(0,1));
                AddOrder.Parameters.AddWithValue("DriversId", CB_Driver.SelectedItem.ToString().Substring(0, 1));
                AddOrder.Parameters.AddWithValue("VehicleId", TB_Vehicle.Text.Substring(0,1));
                AddOrder.Parameters.AddWithValue("Id", 1);

                AddOrder.ExecuteNonQuery();
                conn.Close();
                Close();
            }
        }

        private void CB_Fill_Clients()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TaxiDB"].ConnectionString))
            {
                conn.Open();
                SqlCommand fill = new SqlCommand("SELECT * FROM dbo.ClientsSet", conn);
                SqlDataReader dataReader = fill.ExecuteReader();
                while (dataReader.Read())
                {
                    CB_Client.Items.Add(dataReader[0] + "." + dataReader[1].ToString() + " " + dataReader[2].ToString());
                }
                dataReader.Close();
                conn.Close();
            }
        }

        private void CB_Fill_Drivers()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TaxiDB"].ConnectionString))
            {
                conn.Open();
                SqlCommand fill = new SqlCommand("SELECT * FROM dbo.DriversSet", conn);
                SqlDataReader dataReader = fill.ExecuteReader();
                while (dataReader.Read())
                {
                    CB_Driver.Items.Add(dataReader[0] + "." + dataReader[1].ToString() + " " + dataReader[2].ToString());
                }
                dataReader.Close();
                conn.Close();
            }

            
        }

        private void CB_Fill_Cars()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TaxiDB"].ConnectionString))
            {
                conn.Open();
                SqlCommand fill = new SqlCommand("SELECT * FROM dbo.VehicleSet", conn);
                SqlDataReader dataReader = fill.ExecuteReader();
                while (dataReader.Read())
                {
                    if (CB_Driver.SelectedItem.ToString().Substring(0, 1) == dataReader[5].ToString())
                    {
                        TB_Vehicle.Text =dataReader[0]+ "." + dataReader[1] + " " + dataReader[2] + " " + dataReader[4];
                    }
                }
                dataReader.Close();
                conn.Close();
            }
        }

        private void CB_Driver_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_Fill_Cars();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
