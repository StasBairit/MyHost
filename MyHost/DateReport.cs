using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyHost.reports.excel;
using MyHost.Utils;
using System.Data.SqlClient;

namespace MyHost
{
    public partial class DateReport : Form
    {
        public DateReport()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string from = fromDateTimePicker1.Value.ToString();
            string to = toDateTimePicker2.Value.ToString();
            

            DataGridView view= new DataGridView();

            SqlConnection conn = DBConnection.GetConnection();
            SqlCommand comm = null;
            string sql = @"SELECT     dbo.room_booking.room_id, dbo.customers.customer_fname, dbo.customers.customer_lname, dbo.customers.customer_passport, 
                      dbo.customers.customer_phone
                      FROM         dbo.room_booking INNER JOIN
                      dbo.customers ON dbo.room_booking.customer_id = dbo.customers.customer_id
                      WHERE     (dbo.room_booking.arrived_date > CAST( '" +
                      from + "' AS datetime) ) AND (dbo.room_booking.canceled = 0) AND (dbo.room_booking.arrived_date < CAST( '" +
                      to + "' AS datetime) ) ";
            
            

            reportCustomers rc = new reportCustomers();

            try
            {
                DataTable table = new DataTable();
                comm = new SqlCommand(sql, conn);
                SqlDataAdapter adap = new SqlDataAdapter();
                adap.SelectCommand = comm;

                adap.Fill(table);

                view.DataSource = table;
            }
            /*catch (Exception ex)
            { }*/
            finally
            {
                conn.Close();
            }
            

            rc.setDate(from, to);
            rc.printReport(view);
            
            
        }
    }
}