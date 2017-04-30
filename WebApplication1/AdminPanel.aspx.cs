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
        string[] doctor_table_names = { "ID", "NAME", "SURNAME", "TITLE" };
        string[] pdp_table_names = { "ID", "DOCTOR_ID", "POLYCLINIC_NAME", "PATIENT_ID" };
        string[] reservation_table_names = { "ID", "RESERVATION_TIME", "RESERVARTION_INFO", "ADMIN_ID", "PDP_ID" };
        string admin_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            admin_id = Request.QueryString["id"].ToString();
            createTable(Doctor_table, doctor_table_names);
            createTable(PDP_table, pdp_table_names);
            createTable(Reservation_Table, reservation_table_names);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OracleDB db = new OracleDB("Ata");
            db.openConnection();
            string[] array = new string[doctor_table_names.Length];
            string sql = "SELECT * FROM DOCTOR ";


            OracleDataReader reader = db.getDataFromDB(sql);
            while (reader.Read())
            {
                array[0] = reader.GetString(0);
                array[1] = reader.GetString(1);
                array[2] = reader.GetString(2);
                array[3] = reader.GetString(3);
                fillTable(Doctor_table, array);
            }
            db.closeConnection();
        }

        private void createTable(Table table, string[] names)
        {
            if (table.Rows.Count > 0)
            {
                table.Rows.Clear();
            }
            TableRow r = new TableRow();
            for (int i = 0; i < names.Length; i++)
            {
                TableCell c = new TableCell();
                c.Controls.Add(new LiteralControl(names[i]));
                r.Cells.Add(c);
            }
            table.Controls.Add(r);
        }
        private void fillTable(Table table, string[] array)
        {
            TableRow tRow = new TableRow();
            for (int i = 0; i < array.Length; i++)
            {
                TableCell tCell1 = new TableCell();
                tCell1.Text = array[i];
                tRow.Cells.Add(tCell1);
            }
            table.Rows.Add(tRow);
        }

        protected void Btn_Add_Doctor_Click(object sender, EventArgs e)
        {
            Lbl_Doctor_Error.Text = "";
            string doc_name = Txt_Doctor_Name.Text;
            string doc_surname = Txt_Doctor_Surname.Text;
            string doc_title = Txt_Doctor_Title.Text;
            string sql = "SELECT ADD_DOCTOR('" + doc_name + "','" + doc_surname + "','" + doc_title + "') FROM DUAL";
            string inserted = null;
            OracleDB db = new OracleDB("Ata");
            db.openConnection();
            OracleDataReader reader = db.getDataFromDB(sql);
            while (reader.Read())
            {
                inserted = reader.GetString(0);
            }
            if (inserted.Equals("TRUE"))
            {
                Lbl_Doctor_Error.Text = "DOCTOR INSERTED REFRESH TABLE";
            }
            else
            {
                Lbl_Doctor_Error.Text = "DOCTOR NOT INSERTED CHECK INFO";
            }
            db.closeConnection();

        }

        protected void Btn_Remove_Doctor_Click(object sender, EventArgs e)
        {
            Lbl_Doctor_Error.Text = "";
            string doc_name = Txt_Doctor_Name.Text;
            string doc_surname = Txt_Doctor_Surname.Text;
            string doc_title = Txt_Doctor_Title.Text;
            string sql = "SELECT REMOVE_DOCTOR('" + doc_name + "','" + doc_surname + "','" + doc_title + "') FROM DUAL";
            string deleted = null;
            OracleDB db = new OracleDB("Ata");
            db.openConnection();
            OracleDataReader reader = db.getDataFromDB(sql);
            while (reader.Read())
            {
                deleted = reader.GetString(0);
            }
            if (deleted.Equals("TRUE"))
            {
                Lbl_Doctor_Error.Text = "DOCTOR DELETED";
            }
            else
            {
                Lbl_Doctor_Error.Text = "DOCTOR NOT DELETED CHECK INFO";
            }
            db.closeConnection();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            OracleDB db = new OracleDB("Ata");
            db.openConnection();
            string[] array = new string[pdp_table_names.Length];
            string sql = "SELECT * FROM PDP_VIEW ";

            OracleDataReader reader = db.getDataFromDB(sql);
            while (reader.Read())
            {
                array[0] = reader.GetString(0);
                array[1] = reader.GetString(1);
                array[2] = reader.GetString(2);
                array[3] = reader.GetString(3);
                fillTable(PDP_table, array);
            }
            db.closeConnection();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            OracleDB db = new OracleDB("Ata");
            db.openConnection();
            string[] array = new string[reservation_table_names.Length];
            string sql = "SELECT * FROM RESERVATION_VIEW ";

            OracleDataReader reader = db.getDataFromDB(sql);
            while (reader.Read())
            {
                array[0] = reader.GetString(0);
                array[1] = reader.GetOracleTimeStamp(1).ToString();
                array[2] = reader.GetString(2);
                array[3] = reader.GetString(3);
                array[4] = reader.GetString(4);
                fillTable(Reservation_Table, array);
            }
            db.closeConnection();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Lbl_System.Text = "";
            OracleDB db = new OracleDB("Ata");
            db.openConnection();
            string reset = null;
            string sql = "SELECT RESET_SYSTEM() FROM DUAL";

            OracleDataReader reader = db.getDataFromDB(sql);
            while (reader.Read())
            {
                reset = reader.GetString(0);
            }

            if (reset.Equals("TRUE"))
            {
                Lbl_System.Text = "System Tables cleared";
                sql = "SELECT SET_SYSTEM('" + admin_id + "') FROM DUAL";
                OracleDataReader reader1 = db.getDataFromDB(sql);
                while (reader1.Read())
                {
                    reset = reader1.GetString(0);
                }
                if (reset.Equals("TRUE"))
                {
                    Lbl_System.Text = "System resetted completly";
                }
                else
                {
                    Lbl_System.Text = "System parameters not resetted";
                }
            }
            else
            {
                Lbl_System.Text = "System tables not cleared";
            }
            db.closeConnection();
        }
    }
}