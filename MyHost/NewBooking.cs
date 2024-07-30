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
    public partial class NewBooking : Form
    {
        static int RoomNumber = -1;
        static int CustomerId = -1;

        DataView dv = null;
        string fs = "";
        string ls = "";
        string ps = "";
        string filter = "";

        string newCustCommandText = @"INSERT INTO [host].[dbo].[customers] "
            + " ([customer_fname],[customer_lname],[customer_passport],[customer_phone]) "
            + "VALUES ('{0}','{1}','{2}','{3}') ";

        string newBookingCommandtext = @"SET DATEFORMAT dmy 

            INSERT INTO [host].[dbo].[room_booking]
           ([room_id],[customer_id],[adults],[children],[room_rate],[arrived_date]
           ,[departure_date],[booking_length],[deposite_paid],[deposite_value],[canceled]
           ,[booked_out],[discount_id],[applieddate])
            VALUES
           ({0},{1},{2},{3},{4},'{5}','{6}',DATEDIFF(day,'{5}','{6}'),{7},{8},0,0,{9},GETDATE())";

        private int InsertNewCustomer()
        {
            string lname = tbxLName.Text.Trim();
            string fname = tbxFName.Text.Trim();
            string pasprt = tbxPasprt.Text.Trim();
            string phone = mtbxPhone.Text.Trim();

            string cmText = String.Format(newCustCommandText, fname, lname, pasprt, phone);

            SqlCommand cm = null;

            try
            {
                cm = new SqlCommand(cmText, Utils.DBConnection.GetConnection());
                cm.ExecuteNonQuery();
                CustomerId = Utils.DBConnection.GetIdentity();
            }
            catch
            { }
            finally
            {
                Utils.DBConnection.Close();
            }
            return CustomerId;
        }

        private bool isValidData()
        {
            if (CustomerId == -1)
            {
                if (tbxLName.Text.Trim().Length == 0)
                    return false;
                if(tbxLName.Text.Trim().Length == 0)
                    return false;
                if (tbxPasprt.Text.Trim().Length == 0)
                    return false;
                if (mtbxPhone.Text.Trim().Length == 0)
                    return false;
            }
            if (dateTimePicker1.Value > dateTimePicker2.Value)
                return false;

            Regex num = new Regex(@"^([0-9])$");
            if (!num.IsMatch(tbxAdults.Text.Trim()) || !num.IsMatch(tbxChildren.Text.Trim()))
                return false;
            Regex money = new Regex(@"^([0-9]+(.|,){1}[0-9]*)$");
            if (tbxDeposite.Enabled && !money.IsMatch(tbxDeposite.Text.Trim()))
                return false;
            return true;
        }

        public NewBooking()
        {
            InitializeComponent();
        }

        private void SelectCustomer()
        {
            try
            {
                CustomerId = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            { }
        }

        private void NewBooking_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDiscounts.discounts' table. You can move, or remove it, as needed.
            this.discountsTableAdapter1.Fill(this.myDiscounts.discounts);
            // TODO: This line of code loads data into the 'myDataSet.discounts' table. You can move, or remove it, as needed.
            this.discountsTableAdapter.Fill(this.myDataSet.discounts);
            // TODO: This line of code loads data into the 'myDataSet.customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.myDataSet.customers);
            ///////////////////////////////////////////////////////////////
            dateTimePicker1.Value = Rooms.SelectedDate;
            dateTimePicker2.Value = Rooms.SelectedDate;
            RoomNumber = Rooms.GetRoomNumberById(Rooms.RoomId);
            lblRoomNumber.Text += RoomNumber.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectCustomer();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectCustomer();
        }

        private void dataGridView1_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {
            this.SelectCustomer();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbxDeposite.Enabled = checkBox1.Checked;
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            CustomerId = -1;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            //MessageBox.Show("2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть форму?"
                , "Потверждение"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                if (CustomerId == -1)
                    this.InsertNewCustomer();

                string CommandText = String.Format(newBookingCommandtext
                                                    , Rooms.RoomId
                                                    , CustomerId
                                                    , tbxAdults.Text
                                                    , tbxChildren.Text
                                                    , Rooms.GetRoomRateById(Rooms.RoomId)
                                                    , dateTimePicker1.Value.ToShortDateString()
                                                    , dateTimePicker2.Value.ToShortDateString()
                                                    , ((checkBox1.Checked) ? 1 : 0)
                                                    , ((checkBox1.Checked) ? tbxDeposite.Text.Trim() : "0")
                                                    , comboBox1.SelectedValue.ToString()
                                       );
                
                SqlCommand cm = null;
                try
                {
                    cm = new SqlCommand(CommandText, Utils.DBConnection.GetConnection());
                    cm.ExecuteNonQuery();
                    RoomBooking.BookingId = Utils.DBConnection.GetIdentity();
                    
                }
                catch (Exception exc)
                {

                }
                finally
                {
                    Utils.DBConnection.Close();
                }
            }
            
            
            this.Close();
            if (MainForm.roombooking != null)
            {
                MainForm.roombooking.Show();
                MainForm.roombooking.Activate();
            }
            else
            {
                RoomBooking rb = new RoomBooking();
                rb.ShowDialog();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            tbxLS.Enabled = checkBox2.Checked;
            if (!checkBox2.Checked)
            {
                ls = "";
                if (checkBox3.Checked)
                    tbxFS_Leave(sender, e);
                else
                    if (checkBox4.Checked)
                        tbxPS_Leave(sender, e);
                    else
                        dataGridView1.DataSource = myDataSet.customers;
            }
            else
                tbxLS_Leave(sender, e);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            tbxFS.Enabled = checkBox3.Checked;
            if (!checkBox3.Checked)
            {
                fs = "";
                if (checkBox2.Checked)
                    tbxLS_Leave(sender, e);
                else
                    if (checkBox4.Checked)
                        tbxPS_Leave(sender, e);
                    else
                        dataGridView1.DataSource = myDataSet.customers;
            }
            else
                tbxFS_Leave(sender, e);

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            tbxPS.Enabled = checkBox4.Checked;
            if (!checkBox4.Checked)
            {
                ps = "";
                if (checkBox2.Checked)
                    tbxLS_Leave(sender, e);
                else
                    if (checkBox3.Checked)
                        tbxFS_Leave(sender, e);
                    else
                        dataGridView1.DataSource = myDataSet.customers;
            }
            else
                tbxFS_Leave(sender, e);
        }

        private void tbxLS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbxLS_Leave(object sender, EventArgs e)
        {
            ls = " customer_lname LIKE '" + tbxLS.Text.Trim() + "%'";
            filter = ls
                + ((checkBox3.Checked) ? " AND " + fs : "")
                + ((checkBox4.Checked) ? " AND " + ps : "");
            dv = new DataView(myDataSet.customers);
            dv.RowFilter = filter;
            dataGridView1.DataSource = dv;
        }

        private void tbxFS_Leave(object sender, EventArgs e)
        {
            fs = " customer_fname LIKE '" + tbxFS.Text.Trim() + "%'";
            filter = fs
               + ((checkBox2.Checked) ? " AND " + ls : "")
               + ((checkBox4.Checked) ? " AND " + ps : "");
            dv = new DataView(myDataSet.customers);
            dv.RowFilter = filter;
            dataGridView1.DataSource = dv;
        }

        private void tbxPS_Leave(object sender, EventArgs e)
        {
            ps = " customer_phone LIKE '" + tbxPS.Text.Trim() + "%'";
            filter = ps
               + ((checkBox2.Checked) ? " AND " + ls : "")
               + ((checkBox3.Checked) ? " AND " + fs : "");
            dv = new DataView(myDataSet.customers);
            dv.RowFilter = filter;
            dataGridView1.DataSource = dv;
        }

        private void tbxLS_KeyPress(object sender, KeyPressEventArgs e)
        {
           // MessageBox.Show(e.);
        }

        private void tbxLS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
                dataGridView1.Select();
        }

        private void tbxFS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
                dataGridView1.Select();
        }

        private void tbxPS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
                dataGridView1.Select();
        }
    }
}