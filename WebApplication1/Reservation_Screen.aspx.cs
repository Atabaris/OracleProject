using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Reservation_Screen : System.Web.UI.Page
    {
        string id=null,birth=null,phone=null,name=null,surname=null,father_name=null;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["user_id_label"].ToString();
            birth = Request.QueryString["user_birth_label"].ToString();
            phone = Request.QueryString["user_phone_label"].ToString();
            name = Request.QueryString["user_name_label"].ToString();
            surname = Request.QueryString["user_surname_label"].ToString();
            father_name = Request.QueryString["user_fathername_label"].ToString();
        }



        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Information_Screen.aspx?id="+id+"&birth="+birth+"&phone="+phone+"&name="+name+"&surname="+surname+"&father_name="+father_name + "&polyclinic=Otology");
        }
        protected void ImageButton1_Click2(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Information_Screen.aspx?id=" + id + "&birth=" + birth + "&phone=" + phone + "&name=" + name + "&surname=" + surname + "&father_name=" + father_name+ "&polyclinic=Ophthalmology");
        }   
        protected void ImageButton1_Click3(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Information_Screen.aspx?id=" + id + "&birth=" + birth + "&phone=" + phone + "&name=" + name + "&surname=" + surname + "&father_name=" + father_name + "&polyclinic=Dentalogy");
        }
        protected void ImageButton1_Click4(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Information_Screen.aspx?id=" + id + "&birth=" + birth + "&phone=" + phone + "&name=" + name + "&surname=" + surname + "&father_name=" + father_name + "&polyclinic=Oralogy");
        }
        protected void ImageButton1_Click5(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Information_Screen.aspx?id=" + id + "&birth=" + birth + "&phone=" + phone + "&name=" + name + "&surname=" + surname + "&father_name=" + father_name + "&polyclinic=Orthopedy");
        }
        protected void ImageButton1_Click6(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Information_Screen.aspx?id=" + id + "&birth=" + birth + "&phone=" + phone + "&name=" + name + "&surname=" + surname + "&father_name=" + father_name + "&polyclinic=Dermatology");
        }
        protected void ImageButton1_Click7(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Information_Screen.aspx?id=" + id + "&birth=" + birth + "&phone=" + phone + "&name=" + name + "&surname=" + surname + "&father_name=" + father_name + "&polyclinic=Dermatology");
        }
        protected void ImageButton1_Click8(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Information_Screen.aspx?id=" + id + "&birth=" + birth + "&phone=" + phone + "&name=" + name + "&surname=" + surname + "&father_name=" + father_name + "&polyclinic=Rhinology");
        }
    }
}