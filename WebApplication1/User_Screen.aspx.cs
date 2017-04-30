using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class User_Screen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int number = rand.Next(1000,9999);
            SECURITY_number.Text = ""+number;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EROR_LABEL.Text = "";
            string user_id = Text_UserID.Text;
            string user_birth = Text_UserBirth.Text;
            string user_phone = Text_UserPhone.Text;
            string user_name = Text_UserName.Text;
            string user_surname = Text_UserSurname.Text;
            string user_father_name = Text_UserFaterName.Text;
            string result=null;
            OracleDB db = new OracleDB("Ata");
            db.openConnection();
            string sql = "SELECT CHECK_PATIENT_INFO('"+user_id+"','"+user_birth+"','"+user_name+"','"+user_surname+"','"+user_father_name+"') FROM DUAL";
            OracleDataReader reader = db.getDataFromDB(sql);
            while (reader.Read())
            {
                result = reader.GetString(0);
            }

            if (result.Equals("TRUE"))
            {
                db.closeConnection();
                Response.Redirect("~/Reservation_Screen.aspx?user_id_label=" + user_id + "&user_birth_label=" + user_birth + "&user_phone_label="
                + user_phone + "&user_name_label=" + user_name + "&user_surname_label=" + user_surname + "&user_fathername_label=" + user_father_name); 
            }
            else
            {
                EROR_LABEL.Text = "CHECK YOUR INFORMATION !";
                db.closeConnection();
            }

            
        }
    }
}