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
    public partial class Form5 : Form
    {
        public DataSet ds;
        public int index;

        public Form5(DataSet ds, int index)
        {
            InitializeComponent();
            CB_Fill_Drivers();
            CB_Fill_Clients();
            this.ds = ds;
            this.index = index;
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
                        TB_Vehicle.Text = dataReader[0] + "." + dataReader[1] + " " + dataReader[2] + " " + dataReader[4];
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

        private void Form5_Shown(object sender, EventArgs e)
        {
            TB_AdressFrom.Text = ds.Tables[0].Rows[index].Field<string>("Address_from");
            TB_AdressTo.Text = ds.Tables[0].Rows[index].Field<string>("Address_to");
            dateTimePicker1.Value = ds.Tables[0].Rows[index].Field<DateTime>("Order_time");
            CB_Client.SelectedIndex = ds.Tables[0].Rows[index].Field<int>("ClientsId") - 1;
            CB_Driver.SelectedIndex = ds.Tables[0].Rows[index].Field<int>("DriversId") - 1;
            CB_Fill_Cars();
            TB_Cost.Text = (ds.Tables[0].Rows[index].Field<double>("Order_cost")).ToString();
            CB_Status.Text = ds.Tables[0].Rows[index].Field<string>("Order_status");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TaxiDB"].ConnectionString))
            {
                conn.Open();
                SqlDataAdapter Adapter = new SqlDataAdapter("Select *from [dbo].[OrderSet]", conn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(Adapter);
                DataSet dataSet = new DataSet();
                Adapter.Fill(dataSet, "OrderSet");
                DataTable orders = dataSet.Tables["OrderSet"];
                Adapter.UpdateCommand = new SqlCommand("stp_OrderUpdate", conn);
                Adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
                Adapter.UpdateCommand.Parameters.AddWithValue("Address_from", TB_AdressFrom.Text);
                Adapter.UpdateCommand.Parameters.AddWithValue("Address_to", TB_AdressTo.Text);
                Adapter.UpdateCommand.Parameters.AddWithValue("Order_time", dateTimePicker1.Value);
                Adapter.UpdateCommand.Parameters.AddWithValue("Order_cost", (float)Convert.ToDouble(TB_Cost.Text));
                Adapter.UpdateCommand.Parameters.AddWithValue("Order_status", CB_Status.SelectedItem);
                Adapter.UpdateCommand.Parameters.AddWithValue("ClientsId", CB_Client.SelectedItem.ToString().Substring(0, 1));
                Adapter.UpdateCommand.Parameters.AddWithValue("DriversId", CB_Driver.SelectedItem.ToString().Substring(0, 1));
                Adapter.UpdateCommand.Parameters.AddWithValue("VehicleId", TB_Vehicle.Text.Substring(0, 1));
                Adapter.UpdateCommand.Parameters.AddWithValue("Id", ds.Tables[0].Rows[index].Field<int>("Id"));
                Adapter.UpdateCommand.Parameters.Add("@Result", SqlDbType.Int).Direction = ParameterDirection.Output;

                Adapter.UpdateCommand.ExecuteNonQuery();
                orders.Clear();
                Adapter.Fill(dataSet, "OrderSet");
                conn.Close();
                Close();
            }

        }
    }
}
