using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string id;
        string birth;
        string phone;
        string name;
        string surname;
        string father_name;
        string doctor_name;
        string pol_name;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Label2.Text = Request.QueryString["id"].ToString();
            birth = Label3.Text = Request.QueryString["birth"].ToString();
            phone = Label4.Text = Request.QueryString["phone"].ToString();
            name = Label5.Text = Request.QueryString["name"].ToString();
            surname = Label6.Text = Request.QueryString["surname"].ToString();
            father_name = Label7.Text = Request.QueryString["father_name"].ToString();
            doctor_name = Label8.Text = Request.QueryString["doctor_name"].ToString();
            pol_name = Label9.Text = Request.QueryString["polyclinic"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Reservation_Screen.aspx?id=" + id + "&birth=" + birth + "&phone=" + phone + "&name=" + name + "&surname=" + surname + "&father_name=" + father_name);
        }
    }
}