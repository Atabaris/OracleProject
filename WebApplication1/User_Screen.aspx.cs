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
        {   //Buralara Security kod kontrolu girilebilir !
            Response.Redirect("~/Reservation_Screen.aspx?user_id_label=" + Text_UserID.Text+"&user_birth_label="+Text_UserBirth.Text+"&user_phone_label="+Text_UserPhone.Text+"&user_name_label="+Text_UserName.Text+"&user_surname_label="+Text_UserSurname.Text+"&user_fathername_label="+Text_UserFaterName.Text);

        }
    }
}