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
        protected void Page_Load(object sender, EventArgs e)
        {
                Label2.Text= Request.QueryString["id"].ToString();
                Label3.Text = Request.QueryString["birth"].ToString();
                Label4.Text = Request.QueryString["phone"].ToString();
                Label5.Text = Request.QueryString["name"].ToString();
                Label6.Text = Request.QueryString["surname"].ToString();
                Label7.Text = Request.QueryString["father_name"].ToString();
                Label8.Text = "ORACLE den gelicek";
                Label9.Text= Request.QueryString["polyclinic"].ToString();
        }
    }
}