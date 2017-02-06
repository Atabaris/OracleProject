using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_start_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source=ORCL;User Id=hr;Password=hr;";

            OracleConnection conn = new OracleConnection(oradb); // C#

            conn.Open();
            if (conn != null)
            {
                Label1.Text = "You are connected to DB!";
            }else
            {
                Label1.Text = "You could not  connected to DB!";
            }
            conn.Dispose();
        }
    }
}