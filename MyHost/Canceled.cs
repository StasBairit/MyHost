using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyHost
{
    public partial class Canceled : Form
    {
        public Canceled()
        {
            InitializeComponent();
        }

        private void Canceled_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable canceled = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(@"SELECT     dbo.cancelation.cancelation_id AS ID, dbo.cancelation.room_booking_id AS Бронь, 
                      dbo.customers.customer_lname + '  ' + dbo.customers.customer_fname AS Гость, dbo.cancelation.forfeit_retained AS [Должен быть уплачен щтраф], 
                      dbo.cancelation.forfeit AS Штраф, dbo.cancelation.cancelation_date AS [Дата отмены], dbo.cancelation.forfeit_redeemed AS [Штраф уплачен], 
                      dbo.cancelation.forfeit_redeemed_date AS [Дата уплаты штрафа]
FROM         dbo.cancelation INNER JOIN
                      dbo.room_booking ON dbo.cancelation.room_booking_id = dbo.room_booking.room_booking_id INNER JOIN
                      dbo.customers ON dbo.room_booking.customer_id = dbo.customers.customer_id"
                          , Utils.DBConnection.GetConnection());
                adapter.Fill(canceled);

                DataSet ds = new DataSet();
                ds.Tables.Add(canceled);
                bindingNavigator1.BindingSource = new BindingSource(ds, ds.Tables[0].TableName);
                dataGridView1.DataSource = bindingNavigator1.BindingSource;
            }
            catch
            { }
            finally
            {
                Utils.DBConnection.Close();
            }
        }

        private void Canceled_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.canceled = null;
        }
    }
}