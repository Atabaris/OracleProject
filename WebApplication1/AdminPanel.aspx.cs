using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdminPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            createTable();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (Doctor_table.Rows.Count > 0)
            {
                Doctor_table.Rows.Clear();
                createTable();
            }
            int counter = 0;
            string sql = "SELECT * FROM DOCTOR ";
            OracleDB db = new OracleDB("Ata");
            db.openConnection();
            OracleDataReader reader = db.getDataFromDB(sql);
            while (reader.Read())
            {
                TableRow tRow = new TableRow();
                TableCell tCell1 = new TableCell();
                TableCell tCell2 = new TableCell();
                TableCell tCell3 = new TableCell();
                TableCell tCell4 = new TableCell();
                tCell1.Text = reader.GetString(0);//id
                tCell2.Text = reader.GetString(1);//name
                tCell3.Text = reader.GetString(2);//surname
                tCell4.Text = reader.GetString(3);//title 
                tRow.Cells.Add(tCell1);
                tRow.Cells.Add(tCell2);
                tRow.Cells.Add(tCell3);
                tRow.Cells.Add(tCell4);               
                Doctor_table.Rows.Add(tRow);
                counter++;
            }
            db.closeConnection();
        }
        private void createTable()
        {
            
            string[] names = { "ID", "NAME", "SURNAME", "TITLE" };
            TableRow r = new TableRow();
            for (int i = 0; i < names.Length; i++)
            {
                TableCell c = new TableCell();
                c.Controls.Add(new LiteralControl(names[i]));
                r.Cells.Add(c);
            }
            Doctor_table.Controls.Add(r);
        }
    }
}