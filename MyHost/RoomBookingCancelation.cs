using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace MyHost
{
    public partial class RoomBookingCancelation : Form
    {
        int BookingId = -1;
        public static int CancelationId = -1;
        string CommandText = @"SELECT     dbo.room_booking.room_booking_id, dbo.rooms.room_number, dbo.customers.customer_fname, dbo.customers.customer_lname, 
                        dbo.room_booking.arrived_date, dbo.room_booking.departure_date, dbo.room_booking.applieddate, dbo.room_booking.deposite_paid, 
                        dbo.room_booking.deposite_value
                      FROM         dbo.room_booking INNER JOIN
                        dbo.rooms ON dbo.room_booking.room_id = dbo.rooms.room_id INNER JOIN
                        dbo.customers ON dbo.room_booking.customer_id = dbo.customers.customer_id
                      WHERE     (dbo.room_booking.room_booking_id ={0})";

        string inscmdText = @" SET DATEFORMAT dmy 
            INSERT INTO [host].[dbo].[cancelation]
            ([room_booking_id],[forfeit_retained],[forfeit],[cancelation_date],[forfeit_redeemed],[forfeit_redeemed_date])
            VALUES({0},{1},{2},'{3}',{4},'{5}')";

        private int NewCancelation()
        {
            try
            {
                string cmdText = String.Format(inscmdText
                    , BookingId
                    , ((checkBox1.Checked) ? "1" : "0")
                    , ((checkBox1.Checked) ? textBox1.Text.Trim() : "")
                    , dateTimePicker1.Value.ToShortDateString()
                    , ((checkBox2.Checked) ? "1" : "0")
                    , ((checkBox2.Checked) ? dateTimePicker2.Value.ToShortDateString() : ""));
                SqlCommand cm = new SqlCommand(cmdText, Utils.DBConnection.GetConnection());
                cm.ExecuteNonQuery();
                CancelationId = Utils.DBConnection.GetIdentity();
                Utils.DBConnection.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message + "\n" + exc.StackTrace);
            }
            return CancelationId;
        }

        private bool IsValid()
        {
            Regex money = new Regex(@"^([0-9]+(.|,){1}[0-9]*)$");
            if (checkBox1.Checked && !money.IsMatch(textBox1.Text))
            {
                MessageBox.Show("Неправильный формат данных!");
                textBox1.Select();
                return false;
            }

            if (checkBox2.Checked && dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Дата выбрана неправильно!");
                dateTimePicker2.Select();
                return false;
            }

            return true;
        }

        private void GetBookingInfo(int Id)
        {
            SqlCommand cm = null;
            SqlDataReader dr = null;
            try
            {
                string cmdText = String.Format(CommandText, Id);
                cm = new SqlCommand(cmdText, Utils.DBConnection.GetConnection());
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    lblnum.Text = dr["room_number"].ToString();
                    lblFIO.Text = dr["customer_lname"].ToString() 
                        + " " 
                        + dr["customer_fname"].ToString();
                    lblDates.Text = DateTime.Parse(dr["arrived_date"].ToString()).ToShortDateString() 
                        + " - " 
                        + DateTime.Parse(dr["departure_date"].ToString()).ToShortDateString();
                    lblApll.Text = DateTime.Parse(dr["applieddate"].ToString()).ToShortDateString();
                    if (dr["deposite_paid"].ToString() == "True")
                        lblDeposit.Text =" Оплачена. Сумма " + dr["deposite_value"].ToString();
                    else
                        lblDeposit.Text = " Не оплачена.";
                    break;
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message + "\n" + exc.StackTrace);
            }
            finally
            {
                dr.Close();
                Utils.DBConnection.Close();
            }
        }

        public RoomBookingCancelation()
        {
            InitializeComponent();
        }

        private void RoomBookingCancelation_Load(object sender, EventArgs e)
        {
            lblnum.Text = "";
            lblFIO.Text = "";
            lblDates.Text = "";
            lblApll.Text = "";
            lblDeposit.Text = "";
            BookingId = RoomBooking.BookingId;
            this.GetBookingInfo(BookingId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                this.NewCancelation();
                this.Close();
            }
        }

        private void RoomBookingCancelation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MainForm.roombooking != null)
                MainForm.roombooking.Activate();
        }
    }
}