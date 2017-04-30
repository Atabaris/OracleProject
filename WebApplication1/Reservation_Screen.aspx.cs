using Oracle.DataAccess.Client;
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
        string id = null, birth = null, phone = null, name = null, surname = null, father_name = null, pol_name = null, doctor_name = null;
        OracleDB db;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["user_id_label"].ToString();
            birth = Request.QueryString["user_birth_label"].ToString();
            phone = Request.QueryString["user_phone_label"].ToString();
            name = Request.QueryString["user_name_label"].ToString();
            surname = Request.QueryString["user_surname_label"].ToString();
            father_name = Request.QueryString["user_fathername_label"].ToString();
            db = new OracleDB("Ata");
            db.openConnection();
        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            pol_name = "Otology";
            getOracle(pol_name);
        }
        protected void ImageButton1_Click2(object sender, ImageClickEventArgs e)
        {
            pol_name = "Ophthalmology";
            getOracle(pol_name);
        }
        protected void ImageButton1_Click3(object sender, ImageClickEventArgs e)
        {
            pol_name = "Dentalogy";
            getOracle(pol_name);
        }
        protected void ImageButton1_Click4(object sender, ImageClickEventArgs e)
        {
            pol_name = "Oralogy";
            getOracle(pol_name);
        }
        protected void ImageButton1_Click5(object sender, ImageClickEventArgs e)
        {
            pol_name = "Orthopedy";
            getOracle(pol_name);
        }
        protected void ImageButton1_Click6(object sender, ImageClickEventArgs e)
        {
            pol_name = "Dermatology";
            getOracle(pol_name);
        }
        protected void ImageButton1_Click7(object sender, ImageClickEventArgs e)
        {
            pol_name = "Dermatology";
            getOracle(pol_name);
        }
        protected void ImageButton1_Click8(object sender, ImageClickEventArgs e)
        {
            pol_name = "Rhinology";
            getOracle(pol_name);
        }

        private void send_Info(string pol_name)
        {
            Response.Redirect("~/Information_Screen.aspx?id=" + id + "&birth=" + birth + "&phone=" + phone + "&name=" + name + "&surname=" + surname + "&father_name=" + father_name
                + "&polyclinic=" + pol_name + "&doctor_name" + doctor_name);
        }
        private void getOracle(string pol_name)
        {

            string doc_id = get_Doc_id(pol_name);

            string sql = "SELECT NAME,SURNAME FROM DOCTOR WHERE ID='" + doc_id + "'";
            string d_name = null, d_surname = null;
            OracleDataReader reader = db.getDataFromDB(sql);
            while (reader.Read())
            {
                d_name = reader.GetString(0);
                d_surname = reader.GetString(1);
            }
            doctor_name = d_name + " " + d_surname;
            string result = null;
            sql = "SELECT CREATE_PDP_FUNC('" + doc_id + "','" + pol_name + "','" + id + "') FROM DUAL";
            System.Diagnostics.Debug.WriteLine("ERROR!!!!!!!!   " + sql);
            
            while (reader.Read())
            {
                result = reader.GetString(0);
            }
            System.Diagnostics.Debug.WriteLine("ERROR!!!!!!!! READER  " + result);
            if (result.Equals("TRUE"))
            {

                sql = "SELECT CREATE_RESERVATION_FUNC('" + id + "') FROM DUAL";
                reader = db.getDataFromDB(sql);
                while (reader.Read())
                {
                    result = reader.GetString(0);
                }
                if (result.Equals("TRUE"))
                {
                    db.closeConnection();
                    send_Info(pol_name);
                }
                else
                {
                    Error_Label.Text = "Could not take reservation !";
                }
            }
            else
            {
                Error_Label.Text = "Database Error";
            }

        }
        private string get_Doc_id(string pol_name)
        {
            string title = find_job(pol_name);
            string doc_id = null;
            string sql = "SELECT  ID FROM ( SELECT ID FROM DOCTOR WHERE DOCTOR.TİTLE='" + title + "' ORDER BY DBMS_RANDOM.RANDOM) WHERE  rownum <2";
            OracleDataReader reader = db.getDataFromDB(sql);
            while (reader.Read())
            {
                doc_id = reader.GetString(0);
            }
            return doc_id;
        }

        private string find_job(string pol_name)
        {
            Random rnd = new Random();
            string job_name;

            if (pol_name.Equals("Otology"))
            {
                job_name = "Otologist";
            }
            else if (pol_name.Equals("Ophthalmology"))
            {
                job_name = "Oculist";
            }
            else if (pol_name.Equals("Rhinology"))
            {
                job_name = "Otologist";
            }
            else if (pol_name.Equals("Dentalogy"))
            {
                job_name = "Dentist";
            }
            else if (pol_name.Equals("Oralogy"))
            {
                int number = rnd.Next(2);
                if (number == 0)
                {
                    job_name = "Endocrinologist";
                }
                else
                {
                    job_name = "Dentist";
                }
            }
            else if (pol_name.Equals("Dermatology"))
            {
                job_name = "Dermatologist";
            }
            else if (pol_name.Equals("Orthopedy"))
            {
                job_name = "Chiropractic";
            }
            else
            {
                job_name = "ERROR ON FIND_JOB";
            }

            return job_name;
        }
    }
}