using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MyHost.Utils;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace MyHost.reports.excel
{
    class Cheque
    {
        private string templateName = FileUtils.filePathBase + "/reports/excel/templates/Cheque.xls";
        ApplicationClass ac;
        Workbook wb;
        Worksheet ws;
        int currentRow = 7;
        float total = 0;

        public Cheque()
        {
            ac = new ApplicationClass();
            wb = ac.Workbooks.Add(templateName);
            ac.Visible = true;
            ws = (Worksheet)wb.ActiveSheet;

            Type typ = this.GetType();


        }

        public void writeChequeNumber(string number)
        {
            ws.get_Range("B4", "B4").Value2 = number;
        }

        public void writeFromDate(string from)
        {
            ws.get_Range("B5", "B5").Value2 = from;
        }

        public void writeCustomer(string customer)
        {
            ws.get_Range("B6", "B6").Value2 = customer;
        }

        public void writeItogo(string itogo)
        {
            ws.get_Range("D9", "D9").Value2 = itogo;
        }

        public void writeNDS(string nds)
        {
            ws.get_Range("D10", "D10").Value2 = nds;
        }

        public void writeVsego(string vsego)
        {
            ws.get_Range("D11", "D11").Value2 = vsego;
        }
        public void writeSkidka(string vsego)
        {
            ws.get_Range("D12", "D12").Value2 = vsego;
        }

        public void writeValues(string[][] data)
        {
            int dataLength = data.Length;
            int offset = 9 + dataLength;
            int currentPosition = 9;
            Range range = ws.get_Range("A" + offset, "J" + (offset + 4));
            ws.get_Range("A9", "J13").Cut(range);

            foreach (string[] row in data)
            {
                string rowId = currentPosition + ":" + currentPosition;
                range = ws.get_Range(rowId, rowId);
                ws.get_Range("8:8", "8:8").Copy(range);
                ws.get_Range("A" + currentPosition, "A" + currentPosition).Value2 = row[0];
                ws.get_Range("B" + currentPosition, "B" + currentPosition).Value2 = row[1];
                ws.get_Range("C" + currentPosition, "C" + currentPosition).Value2 = row[2];
                ws.get_Range("D" + currentPosition, "D" + currentPosition).Value2 = row[3];
                currentPosition++;
            }

            //range = ws.get_Range("G9", "J" + (currentPosition - 1));
            //ws.get_Range("A9", "D" + (currentPosition - 1)).Copy(range);
            ws.get_Range("8:8", "8:8").Delete(XlDeleteShiftDirection.xlShiftUp);
        }

        private void getRoomTotal( string bookingID)
        {
            SqlConnection conn = Utils.DBConnection.GetConnection();
            SqlCommand command = null;
            SqlDataAdapter adapter = null;
            string sql = "SELECT (1 - 0.01*d.discount_value)*(DATEDIFF ( day , rb.arrived_date , rb.departure_date ))*rr.room_rate_daycost " +
                " FROM room_booking rb," +
                " room_rates rr,discounts d" +
                " WHERE rr.room_rate_id = rb.room_rate " +
                " AND d.discount_id = rb.discount_id " +
                " AND room_booking_id = " + bookingID;
            try
            {
                command = new SqlCommand(sql, conn);
                Object o = command.ExecuteScalar();
                string roomBill = o.ToString();
                MessageBox.Show(roomBill);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void getServisesTotal()
        {

        }
        public void print()
        {
            getRoomTotal("1");
        }

    }
}
