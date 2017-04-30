using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Admin : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_enter_Click(object sender, EventArgs e)
        {
            int value = get_Info();
            give_Message(value);

        }
        private bool check_Information()
        {
            bool found = false;
            string user_id = text_UserID.Text;
            string user_password = text_Password.Text;

            /*SQL code part for check info */
            string sql = "SELECT  TO_CHAR(COUNT(*)) FROM ADMİN WHERE ID='" + user_id + "' AND PASSWORD='"+user_password+"'";
            string exist=null;
            OracleDB db = new OracleDB("Ata");
            db.openConnection();
            OracleDataReader reader = db.getDataFromDB(sql);
            while (reader.Read())
            {
                exist = reader.GetString(0);
            }
            if (exist.Equals("1"))
            {
                found = true;
            }
            db.closeConnection();
            return found;
        }
        private bool check_Pattern()
        {
            bool matched = false;
            string pattern = @"^[a-zA-Z0-9]+$";
            string user_id = text_UserID.Text.ToString();
            string user_password = text_Password.Text.ToString();
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(user_id))
            {
                matched = true;
            }

            return matched;

        }
        private void give_Message(int key_value)
        {
            if (key_value == 0)
            {
                label_error.Text = "";
            }
            else if (key_value == 1)
            {
                label_error.Text = "Do not use Non English characters!";
            }
            else if (key_value == 2)
            {
                label_error.Text = " ID or Password wrong !";
            }
            else
            {
                label_error.Text = " Error check the code !key value = " + key_value + "";
            }
        }
        private int get_Info()
        {
            int key_value = 0;
            bool passed = check_Pattern();
            if (passed == true)
            {
                passed = check_Information();
                if (passed == true)
                {
                    Response.Redirect("~/AdminPanel.aspx");
                }
                else
                {
                    key_value = 2;
                }
            }
            else
            {
                key_value = 1;
            }
            return key_value;
        }
    }
}