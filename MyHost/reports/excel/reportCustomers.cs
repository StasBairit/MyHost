using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using MyHost.Utils;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace MyHost.reports.excel
{
    
    class reportCustomers
    {
        private string reportName = FileUtils.filePathBase+ "/reports/excel/templates/Customers.xls";
        ApplicationClass ac;
        Workbook wb;
        Worksheet ws;
        public reportCustomers()
        {
            ac = new ApplicationClass();
            wb = ac.Workbooks.Add(reportName);
            ac.Visible = true;
            ws = (Worksheet)wb.ActiveSheet;
        }

        public void printReport( string start, string end )
        {

            SqlConnection connection = null;
            SqlDataReader adapter = null;
            SqlCommand command = null;
            try
            {
                /*connection = DBConnection.GetConnection();
                string sql = "select "
                command = new*/
            }
            catch (Exception e)
            { }
            finally 
            { }
        }
        public void setDate(string from, string to)
        {
            ws.get_Range("B3", "B3").Value2 = from;
            ws.get_Range("D3", "D3").Value2 = to;

        }

        public void printReport( DataGridView v )
        {
            
            
            

            int startPosition = 6;

            

            

            for (int i = 0; i < v.Rows.Count; i++)
            {
                Range range = ws.get_Range("A" + (6 + i), "D" + (6 + i));
                ws.get_Range("A6", "D6").Copy(range);

                ws.get_Range("A" + (6 + i), "A" + (6 + i)).Value2 = v.Rows[i].Cells[1].Value;
                ws.get_Range("B" + (6 + i), "B" + (6 + i)).Value2 = v.Rows[i].Cells[2].Value;
                ws.get_Range("C" + (6 + i), "C" + (6 + i)).Value2 = v.Rows[i].Cells[3].Value;
                ws.get_Range("D" + (6 + i), "D" + (6 + i)).Value2 = v.Rows[i].Cells[4].Value;
            }
        
        }

    }
}
