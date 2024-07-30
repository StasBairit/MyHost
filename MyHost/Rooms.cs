using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace MyHost
{
    public partial class Rooms : Form
    {
        public static int RoomId = -1;
        public static int RoomNumber = 0;
        public static DateTime SelectedDate = DateTime.Today;
        public static DateTime[] bookedDays;

        string cfilter = "";
        string ffilter = "";
        string filter = "";

        private int RowIndex = -1;
        private DataView dvRoomCost = null;
        private DataView dvRooms = null;
        
        string daysCommandText = "SELECT arrived_date, departure_date  "
                                 + " FROM dbo.room_booking"
                                 + " WHERE     (room_id = {0}) AND (arrived_date > GETDATE()) AND (canceled = 0) AND (booked_out = 0) "
                                 + " OR "
                                 + " (room_id = {0}) AND (departure_date > GETDATE()) AND (canceled = 0) AND (booked_out = 0)";

        private void GetCurrentRoomFeatures()
        {
            ArrayList aList = new ArrayList();
            if (RoomId != -1)
            {
                SqlCommand cm = null;
                SqlDataReader dr = null;
                try
                {
                    room_featuresTableAdapter.Fill(myDataSet.room_features, RoomId);
                    dvRoomCost = new DataView(myDataSet.room_rates);
                    dvRoomCost.RowFilter = " room_rate_roomcategory = "
                                    + dataGridView1.Rows[RowIndex].Cells[3].Value.ToString();
                    dataGridView3.DataSource = dvRoomCost;
                    cm = new SqlCommand(String.Format(daysCommandText, RoomId)
                                                      , Utils.DBConnection.GetConnection());
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        DateTime start = DateTime.Parse(dr[0].ToString());
                        DateTime end = DateTime.Parse(dr[1].ToString());
                        TimeSpan ts = end - start;
                        for (int i = 0; i < ts.Days + 1; i++)
                        {
                            TimeSpan t = new TimeSpan(i, 0, 0, 0);
                            DateTime d = start + t;
                            aList.Add(d.ToShortDateString());
                        }
                    }
                    if (aList.Count > 0)
                    {
                        bookedDays = new DateTime[aList.Count];
                        for (int i = 0; i < aList.Count; i++)
                            bookedDays[i] = DateTime.Parse(aList[i].ToString());
                        monthCalendar1.BoldedDates = bookedDays;
                    }
                    else
                        monthCalendar1.BoldedDates = new DateTime[] { };
                }
                catch (Exception exc)
                {
                    
                }
                finally
                {
                    dr.Close();
                    Utils.DBConnection.Close();
                }
            }
        }

        private bool IsIn(DateTime date, DateTime[] datetimecollection)
        {
            for (int i = 0; i < datetimecollection.Length; i++)
                if (date == datetimecollection[i])
                    return true;
            return false;
        }

        public static int GetRoomNumberById(int RoomId)
        {
            try
            {
                string cmText = "SELECT room_number FROM rooms WHERE room_id = " + RoomId.ToString();
                SqlCommand cm = new SqlCommand(cmText, Utils.DBConnection.GetConnection());
                RoomNumber = Convert.ToInt32(cm.ExecuteScalar());
                Utils.DBConnection.Close();
            }
            catch
            { }
            return RoomNumber;
        }

        public static int GetRoomCategoryById(int RoomId)
        {
            int RoomCategory = -1;
            try
            {
                string cmText = "SELECT room_category FROM rooms WHERE room_id = " + RoomId.ToString();
                SqlCommand cm = new SqlCommand(cmText, Utils.DBConnection.GetConnection());
                RoomCategory = Convert.ToInt32(cm.ExecuteScalar());
                Utils.DBConnection.Close();
            }
            catch
            { }
            return RoomCategory;
        }

        public static int GetRoomRateById(int RoomId)
        {
            int RoomRate = -1;
            try
            {
                string cmText = "SELECT room_rate_id FROM room_rates WHERE room_rate_roomcategory = " + GetRoomCategoryById(RoomId).ToString();
                SqlCommand cm = new SqlCommand(cmText, Utils.DBConnection.GetConnection());
                RoomRate = Convert.ToInt32(cm.ExecuteScalar());
                Utils.DBConnection.Close();
            }
            catch
            { }
            return RoomRate;
        }

        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.rooms = null;
        }       

        private void Rooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.room_rates' table. You can move, or remove it, as needed.
            this.room_ratesTableAdapter.Fill(this.myDataSet.room_rates);
            // TODO: This line of code loads data into the 'myDataSet.extra_features' table. You can move, or remove it, as needed.
            this.extra_featuresTableAdapter.Fill(this.myDataSet.extra_features);
            // TODO: This line of code loads data into the 'dsCategories.room_categories' table. You can move, or remove it, as needed.
            this.room_categoriesTableAdapter1.Fill(this.dsCategories.room_categories);
            // TODO: This line of code loads data into the 'myDataSet.room_categories' table. You can move, or remove it, as needed.
            this.room_categoriesTableAdapter.Fill(this.myDataSet.room_categories);
            // TODO: This line of code loads data into the 'myDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.myDataSet.rooms);

            //------------------------------------------------
            panel1.Height = 0;
            dataGridView1.Select();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = this.checkBox1.Checked;
            if (!checkBox1.Checked)
            {
                cfilter = "";
                if (checkBox2.Checked)
                    comboBox2_SelectedIndexChanged(sender, e);
                else
                    dataGridView1.DataSource = roomsBindingSource;
            }
            else
                comboBox1_SelectedIndexChanged(sender, e);
                
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.comboBox2.Enabled = this.checkBox2.Checked;
            if (!checkBox2.Checked)
            {
                ffilter = "";
                if (checkBox1.Checked)
                    comboBox1_SelectedIndexChanged(sender, e);
                else
                    dataGridView1.DataSource = roomsBindingSource;
            }
            else
                comboBox2_SelectedIndexChanged(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 0)
                panel1.Height = 54;
            else 
                panel1.Height = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowIndex = dataGridView1.CurrentCell.RowIndex;
                RoomId = Int32.Parse(dataGridView1.Rows[RowIndex].Cells[0].Value.ToString());
                GetCurrentRoomFeatures();
            }
            catch
            {
 
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                RowIndex = dataGridView1.CurrentRow.Index;
                RoomId = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                GetCurrentRoomFeatures();
            }
            catch
            {

            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowIndex = dataGridView1.CurrentRow.Index;
                RoomId = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                GetCurrentRoomFeatures();
            }
            catch
            {}
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                dataGridView2.Update();
                room_featuresTableAdapter.Update(myDataSet.room_features);
            }
            catch
            {
                MainForm.ShowSaveError();
            }
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.CurrentRow.Cells[1].Value = RoomId.ToString();
            }
            catch
            { }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            NewBooking f = new NewBooking();
            f.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedDate = monthCalendar1.SelectionStart;
                if (SelectedDate < DateTime.Today)
                    MessageBox.Show("Выбрана неправильная дата!");
                else
                {
                    if (IsIn(SelectedDate, monthCalendar1.BoldedDates))
                        MessageBox.Show("Номер уже занят!");
                    else
                        this.toolStripButton4_Click(sender, e);
                }
            }
            catch
            { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cfilter = " room_category = " + comboBox1.SelectedValue.ToString();
                filter = cfilter
                    + ((checkBox2.Checked) ? " AND " + ffilter : "");
                dvRooms = new DataView(myDataSet.rooms);
                dvRooms.RowFilter = filter;
                dataGridView1.DataSource = dvRooms;
            }
            catch
            { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ffilter = " room_floor = " + comboBox2.Text;
                filter = ffilter
                    + ((checkBox1.Checked) ? " AND " + cfilter : "");
                dvRooms = new DataView(myDataSet.rooms);
                dvRooms.RowFilter = filter;
                dataGridView1.DataSource = dvRooms;
            }
            catch
            { }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DateReport dr = new DateReport();
            dr.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                dataGridView1.Update();
                roomsTableAdapter.Update(myDataSet.rooms);
            }
            catch
            { }

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}