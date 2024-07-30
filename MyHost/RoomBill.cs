using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyHost.Utils;
using System.Data.SqlClient;
using MyHost.reports.excel;

namespace MyHost
{
    public partial class RoomBill : Form
    {
        int RoomBookingId = -1;
        public const float duty = 20;
        private float roomBill = 0;
        private float serviceBill = 0;
        private float discount = 0;
        private int roomBook = 0;
        private string fio="";

        float total = 0;

        int GetRoomBookingDiscount(int BookingId)
        {
            return 1;
        }

        int GetRoomBookingRate(int BookingId)
        {
            return BookingId;
        }

        public RoomBill()
        {
            InitializeComponent();
            roomBook = RoomBooking.BookingId;
        }
        public RoomBill( string id )
        {
            InitializeComponent();
            roomBook = RoomBooking.BookingId;
            
            SqlConnection conn = null;
            SqlCommand comm = null;
            string sql = "SELECT " +
                " (customer_fname + ' ' + customer_lname ) " +
                " FROM " +
                " customers " +
                " WHERE " + 
                " customer_id = " + id;
            try
            {
                comm = new SqlCommand(sql, DBConnection.GetConnection());
                fio = comm.ExecuteScalar().ToString();
            }
            catch (Exception e)
            { }
            finally 
            {
                DBConnection.Close();
            }

        }

        private void RoomBill_Load(object sender, EventArgs e)
        {
            getServisesTotal(roomBook.ToString());
            getRoomTotal(roomBook.ToString());
            dutyLabel.Text = "Налог:" + duty.ToString() + "%";

            total = roomBill + serviceBill;
            float total_nds = total * (float)(1 + 0.01 * duty);
            totalBillLabel.Text = "Обшее : " + total_nds.ToString();


        }
        private void getServisesTotal( string bookingID )
        {
            SqlConnection conn =  DBConnection.GetConnection();
            SqlCommand command = null;
            SqlDataAdapter adapter = null;
            SqlDataReader reader = null;
            string sql = "SELECT " +
                " es.extra_service AS Услуга, " +
                " es.extra_service_description AS Описание," +
                " rb.adults + rb.children AS Люди, " +
                " es.extra_service_cost AS Цена, " +
                " (rb.adults + rb.children + 1)*( DATEDIFF( day , rb.arrived_date , GETDATE() ) + 1) AS Количество, " +
                " ( DATEDIFF( day , rb.arrived_date , GETDATE() ))*(rb.adults + rb.children + 1)*es.extra_service_cost AS Обшее " +
                " FROM extra_services es, " +
                " room_booking rb, "+
                " room_booking_extra_service rbes" +
                " WHERE " +
                " es.extra_service_id = rbes.extra_service_id " +
                " AND rb.room_booking_id = rbes.room_booking_id " +
                " AND rb.room_booking_id = " + bookingID;
            try 
            {
                
                adapter = new SqlDataAdapter();
                command = new SqlCommand(sql, conn);
                DataTable table = new DataTable();
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                //command.
                adapter.Fill(table);
                DataSet ds = new DataSet();

                //adapter.Fill(ds, "servises");
                servisesDataGridView1.DataSource = table;
                float tot = 0;
                for (int i = 0; i < servisesDataGridView1.Rows.Count - 1; i++)
                {
                    //MessageBox.Show(servisesDataGridView1.Rows[i].Cells["Обшее"].Value.ToString());
                    tot = tot + float.Parse(servisesDataGridView1.Rows[i].Cells["Обшее"].Value.ToString());
                }
                serviceBill = tot;
                    //total = total + tot;
                //servisesDataGridView1.DataSource = ds.Tables["servises"].DefaultView;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace);
                
            }
            finally
            {
                conn.Close();
            }
           
        }

        private void getRoomTotal(string bookingId)
        {
            SqlCommand command = null;
            SqlDataAdapter adapter = null;
            SqlDataReader reader = null;            
            string sql = "SELECT " +
                " r.room_name AS Комната, " +
                " rr.room_rate_daycost AS Стоимость, " +
                " d.discount_value AS Скидка, " +
                " rb.deposite_value AS Предоплата, " +
                " DATEDIFF ( day , rb.arrived_date , GETDATE()  + 1 ) AS Дни, " +
                " (1 - 0.01*d.discount_value)*(DATEDIFF ( day , rb.arrived_date , GETDATE() ) + 1 )*rr.room_rate_daycost - rb.deposite_value AS Обшее " +
                " FROM room_booking rb," +
                " room_rates rr, " +
                " rooms r, " +
                " discounts d" +
                " WHERE rr.room_rate_id = rb.room_rate " +
                " AND d.discount_id = rb.discount_id " +
                " AND r.room_id = rb.room_id " +
                " AND room_booking_id = " + bookingId;
            try
            {

                adapter = new SqlDataAdapter();
                command = new SqlCommand(sql, DBConnection.GetConnection());
                DataTable table = new DataTable();
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                //command.
                adapter.Fill(table);
                DataSet ds = new DataSet();

                //adapter.Fill(ds, "servises");
                roomDataGridView1.DataSource = table;

                roomBill = float.Parse(roomDataGridView1.Rows[0].Cells["Обшее"].Value.ToString());
                discount = float.Parse(roomDataGridView1.Rows[0].Cells["Скидка"].Value.ToString());
                //total = total + float.Parse(roomDataGridView1.Rows[0].Cells["Обшее"].Value.ToString());
                //servisesDataGridView1.DataSource = ds.Tables["servises"].DefaultView;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + "\n" + e.StackTrace);
                
            }
            finally
            {
                DBConnection.Close();
            }
        }

        private void servisesDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = null;
            SqlDataAdapter adapter = null;
            SqlDataReader reader = null;

            string sql = "INSERT INTO bill" +
                " (room_booking_id " +
            " ,room_bill " +
            " ,extra_service_bill " +
            " ,discount " +
            " ,duty " +
            " ,total) " +
            " VALUES " +
            "( " +
            roomBook.ToString() + ", " +
            roomBill.ToString() + ", " +
            serviceBill.ToString() + ", " +
            discount.ToString() + ", " +
            duty.ToString() + ", " +
            total.ToString() + " " + 
            ")";
            int id = 0;
            try
            {
                command = new SqlCommand(sql, DBConnection.GetConnection());
                command.ExecuteNonQuery();
                id = DBConnection.GetIdentity();
            }
            /*catch (Exception ex)
            { }*/
            finally
            {
                DBConnection.Close();
            }

            Cheque chec = new Cheque();
            chec.writeChequeNumber(id.ToString());
            chec.writeFromDate(dateTimePicker1.Value.ToString());
            chec.writeCustomer(fio);
            double totalNDS = total*(0.01*duty);
            chec.writeNDS(totalNDS.ToString());

            chec.writeItogo(total.ToString());

            float total_nds = total * (float)(1 + 0.01 * duty);
            chec.writeVsego(total_nds.ToString());
            chec.writeSkidka(discount.ToString());
            int matrixLength = servisesDataGridView1.Rows.Count;
            string[][] generalMatrix = new string[matrixLength][];
            string prise = roomDataGridView1.Rows[0].Cells["Стоимость"].Value.ToString();
            string[] roomMatrix = new string[] { "Сьем Комнаты", "1", prise, roomBill.ToString() };
            generalMatrix[0] = roomMatrix;
            
            for (int i = 0; i < servisesDataGridView1.Rows.Count-1; i++)
            {
                string ser0 = servisesDataGridView1.Rows[i].Cells["Услуга"].Value.ToString();
                string ser1 = servisesDataGridView1.Rows[i].Cells["Количество"].Value.ToString();
                string ser2 = servisesDataGridView1.Rows[i].Cells["Цена"].Value.ToString();
                string ser3 = servisesDataGridView1.Rows[i].Cells["Обшее"].Value.ToString();
                roomMatrix = new string[] { ser0, ser1, ser2, ser3 };
                generalMatrix[1 + i] = roomMatrix;
            }
            chec.writeValues(generalMatrix);
            this.Close();
            if (MainForm.roombooking != null)
            {
                MainForm.roombooking.Activate();
            }
        }

        private void canselButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}