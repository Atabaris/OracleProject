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
            ////DOCTOR TABLe FILLED
            //string[] names = { "Yvonne Gutierrez","Josh Moody","Janie Patton","Jacob Watson","Peter Mckenzie","Caroline Bridges","Nina Day","Sandra Dean",
            //    "Cathy Alvarado","Carrie White","Guy Vaughn","Justin Andrews","Dennis Jimenez","Louis Bates","Jay Fuller","Earl Rodriquez","Clint Chapman","Terrance Barrett",
            //    "Nettie Meyer","Nick Paul","Sandy Salazar","Elizabeth Wong","April Allison","Janice Garrett","Lynne Ramirez","Steven Nguyen","Erika Harrington","Marcella Perkins",
            //    "Mable Moore","Courtney Harris","Kelley Nichols","Katrina Mcguire","Garrett Schultz","Sherri Spencer","Judith Flores","Wanda Lowe","Joshua Mccoy","Gustavo Hanson",
            //    "Vanessa Sherman","Joey Mclaughlin","Lucy Holland","Kate French","Leroy Wood","Esther Hampton","Kristopher Christensen","Krystal Carter","Ramona Jenkins","Ricky Huff",
            //    "Dave Black","Jamie Wolfe"};
            ////                 kulak,burun göz      diş,ağız surat, saç        bel sırt       saç,ağız
            //string[] jobs = { "Otologist", "Oculist", "Dentist", "Dermatologist", "Chiropractic", "Endocrinologist" };
            //Random rnd = new Random();
            //OracleDB db = new OracleDB("Ata");
            //db.openConnection();

            ////INSERT INTO DOCTOR(ID,NAME,SURNAME,TİTLE) VALUES ('100','Ata','Ay','Doctor');
            //for (int i = 0; i < names.Length; i++)
            //{
            //    string[] a = names[i].Split(' ');
            //    int num = rnd.Next(6);
            //    string sql = "INSERT INTO DOCTOR(ID,NAME,SURNAME,TİTLE) VALUES('" + (i + 100) + "','" + a[0] + "','" + a[1] + "','" + jobs[num] + "')";
            //    db.updateDataFromDB(sql);

            //}
            //Label2.Text = "Disconnected";
            //db.closeConnection();

            //PATİENT TABLE FİLLED
            //INSERT INTO PATİENT(ID,BİRTH,PHONE,NAME,SURNAME,FATHERS_NAME) VALUES('123','20/10/1995','123','a','b','c');
            //string[] names = { "Ben Guerrero","Carlton Parker","Marlene Ball","Stewart Chapman","Freda Rice","Corey Ferguson","Taylor Silva","Elijah Kim","Mark Lowe","Nora Barrett","Terrence Chavez",
            //                    "Casey Williams","Mathew Leonard","Nicholas Hayes","Lynda Quinn","Sadie Hanson","Colleen Perez","Marcella White","Jim Lynch","Albert Clarke","Isaac Coleman",
            //                "Bryan Harvey","Floyd Paul","Ollie Collier","Jimmie Pittman","Jan Fitzgerald","Beverly Hernandez","Patti Armstrong","Elmer Mcbride","Max Robertson","Melba Norton",
            //                "Lee Bowman","Christy Hodges","Derek Fisher","Timmy Hunter","Crystal Lane","Frederick Bishop","Gertrude Meyer","Ken Webb","Pauline Hines","Stacey Bridges",
            //                "Alvin Lindsey","Lynn Wong","Adrian Cannon","Randy Summers","Roger Long","Marcos Cooper","Lela Watkins","Alejandro Jackson","Joel Mendez","Jamie Brady","Jo Diaz",
            //                "Veronica Fleming","Sally Tran","Jeanette Cortez","Myrtle Graham","Jorge Wolfe","Boyd Colon","Harriet Wagner","Neil Jacobs","Julian Burton","Delbert Arnold",
            //                "Erin Lamb","Karla Swanson","Douglas Wallace","Everett Carroll","Ignacio Roberts","Luke Hopkins","Guadalupe Ward","Courtney Freeman","Lamar Shelton","Charlotte Yates",
            //                "Theodore Watson","Jean Larson","Shelly Jennings","Donnie Abbott","Dan Jensen","Derrick Haynes","Kenneth Nguyen","Byron Russell","Wilma Hughes","Francis Moran",
            //                "Glenn Klein","Sonya Thomas","Wendy Rodgers","Roy Young","Jessie Elliott","Robert Stewart","Mike Davidson","Marian Mccoy","Jody Singleton","Thelma Gregory",
            //                "Anita Thornton","Leona Burns","Javier Bailey","Travis Bryan","Randolph Sandoval","Tricia Peterson","Billie Owens","Marty Moss" };

            //string[] f_names ={ "Lee","Cedric","Forrest","Aubrey","Blake","Salvador","Marc","Bryan","Doug","Bernard","Ray","Clinton","Victor","Randy","Rene","Robin","Lowell","Arthur","Robert",
            //                    "Dominick","Rudolph","Gabriel","Phil","Dan","Jean","Neal","Hugh","Morris","Alton","Mack","David","Ricky","Fredrick","Archie","Steve","Donald","Frederick","Tom",
            //                    "Preston","Gregory","Zachary","Julius","Phillip","Keith","Stanley","Christopher","Steven","Nathaniel","Dennis","Jonathan","Woodrow","Ivan","Chad","Lyle","Jonathon",
            //                    "Marlon","Armando","Darrin","Rodney","Ron","Kurt","Lynn","Nathan","Ernesto","Danny","Elias","Terence","Richard","Willis","Tracy","Fernando","Peter","Felix","Arturo",
            //                    "Max","Cornelius","Clint","Van","Francis","Theodore","Marco","Matthew","Jack","Wendell","Jeremy","Leon","Angel","Rufus","Gregg","Bill","Clifford","Bradford","Otis",
            //                    "Curtis","Adam","Randal","Randall","Laurence","Merle","Warren"};

            //Random rnd = new Random();
            //OracleDB db = new OracleDB("Ata");
            //db.openConnection();
            //for (int i = 0; i < names.Length; i++)
            //{
            //    string[] a = names[i].Split(' ');
            //    int ID_part1 = rnd.Next(10000, 99999);
            //    int ID_part2 = rnd.Next(10000, 99999);
            //    int phone_part1 = rnd.Next(50000, 99999);
            //    int phone_part2 = rnd.Next(10000, 99999);
            //    string ID_full = ID_part1.ToString() + ID_part2.ToString();
            //    string phone_full = phone_part1.ToString() + phone_part2.ToString();
            //    long ID = long.Parse(ID_full);
            //    long phone = long.Parse(phone_full);
            //    int day = rnd.Next(1, 31);
            //    int month = rnd.Next(1, 12);
            //    int year = rnd.Next(1940, 2000);
            //    if (month == 2 && day > 28)
            //    {
            //        day = rnd.Next(1, 28);
            //    }
            //    string sql = "INSERT INTO PATİENT(ID,BİRTH,PHONE,NAME,SURNAME,FATHERS_NAME) VALUES('"+ID+"','"+day+"/"+month+"/"+year+"','"+phone+"','"+a[0]+"','"+a[1]+"','"+f_names[i]+"')";
            //    db.updateDataFromDB(sql);
            //}
            //Label2.Text = "Disconnected";
            //db.closeConnection();

            //POLYCLİNİC TABLE FILLED 
            //INSERT INTO POLYCLİNİC(NAME,KONTEJYAN,POLYCLİNİC_TİME) VALUES ('a','b','c');
            //                     kulak          göz         burun        diş        ağız       surat,saç      bel sırt
            //string[] p_names = { "Otology", "Ophthalmology", "Rhinology", "Dentalogy", "Oralogy", "Dermatology", "Orthopedy" };
            //int[] kontejyan = { 10, 20, 30, 40, 50 };
            //int[] p_time = { 8, 9, 10 };
            //Random rnd = new Random();
            //OracleDB db = new OracleDB("Ata");
            //db.openConnection();
            //for(int i = 0; i < p_names.Length; i++)
            //{
            //    int kontej = rnd.Next(5);
            //    int time = rnd.Next(3);
            //    string sql = "INSERT INTO POLYCLİNİC(NAME,KONTEJYAN,POLYCLİNİC_TİME) VALUES('" + p_names[i] + "','" + kontejyan[kontej] + "','" + p_time[time] + "')";
            //    db.updateDataFromDB(sql);
            //}
            //Label2.Text = "Disconnected";
            //db.closeConnection();

            ////PDP FILL PART
            //string[] p_ids = new string[20];
            //string[] polyclinics = new string[20];
            //string[] d_ids = new string[20];
            //int count = 0;
            //Random rnd = new Random();
            //OracleDB db = new OracleDB("Ata");
            //db.openConnection();
            //string sql = "SELECT ID FROM ( SELECT ID FROM PATİENT ORDER BY DBMS_RANDOM.RANDOM) WHERE  rownum < 21";

            //OracleDataReader reader = db.getDataFromDB(sql);
            //while (reader.Read())
            //{
            //    p_ids[count] = reader.GetString(0);
            //    count++;
            //}
            ////SELECT NAME FROM ( SELECT NAME FROM POLYCLİNİC ORDER BY DBMS_RANDOM.RANDOM) WHERE  rownum <2;
            //for (int i = 0; i < 20; i++)
            //{
            //    sql = "SELECT NAME FROM ( SELECT NAME FROM POLYCLİNİC ORDER BY DBMS_RANDOM.RANDOM) WHERE  rownum <2";
            //    reader = db.getDataFromDB(sql);
            //    while (reader.Read())
            //    {
            //        polyclinics[i] = reader.GetString(0);
            //    }
            //}
            ////SELECT  ID FROM ( SELECT ID FROM DOCTOR WHERE DOCTOR.TİTLE='Oculist' ORDER BY DBMS_RANDOM.RANDOM) WHERE  rownum <2;
            //for (int i = 0; i < 20; i++)
            //{
            //    string pol_name = polyclinics[i];
            //    string title = find_job(pol_name);
            //    sql = "SELECT  ID FROM ( SELECT ID FROM DOCTOR WHERE DOCTOR.TİTLE='" + title + "' ORDER BY DBMS_RANDOM.RANDOM) WHERE  rownum <2";
            //    reader = db.getDataFromDB(sql);
            //    while (reader.Read())
            //    {
            //        d_ids[i] = reader.GetString(0);
            //    }
            //}
            ////INSERT INTO PDP (ID,DOCTOR_ID,POLYCLİNİC_NAME,PATİENT_ID) VALUES('1000','110','Otology','9670815161');
            //for (int i = 0; i < 20; i++)
            //{
            //    int ID = i + 1000;
            //    sql = "INSERT INTO PDP(ID,DOCTOR_ID,POLYCLİNİC_NAME,PATİENT_ID) VALUES('" + ID + "','" + d_ids[i] + "','" + polyclinics[i] + "','" + p_ids[i] + "')";
            //    db.updateDataFromDB(sql);
            //}

            //Label2.Text = "Disconnected";
            //db.closeConnection();

            //RESERVATION FILL

            //INSERT INTO RESERVATİON(ID,RESERVATİON_TİME,RESERVATİON_İNFO,ADMİN_ID,PDP_ID)
            //VALUES('10001', '01/01/1960 23:03:20', 'INFO', NULL, '1002');     //CURRENT_TIMESTAMP
            //OracleDB db = new OracleDB("Ata");
            //db.openConnection();
            //string[] pdp_ids = new string[20];
            //string sql = "SELECT ID FROM PDP";
            //OracleDataReader reader = db.getDataFromDB(sql);
            //int count = 0;
            //while (reader.Read())
            //{
            //    pdp_ids[count] = reader.GetString(0);
            //    count++;
            //}
            //for(int i = 0; i < 20; i++)
            //{
            //    sql= "INSERT INTO RESERVATİON(ID,RESERVATİON_TİME,RESERVATİON_İNFO,ADMİN_ID,PDP_ID) VALUES('"+(i+10000)+"',CURRENT_TIMESTAMP,'INFO" + i + "','Ata','" + pdp_ids[i] + "')";
            //    db.updateDataFromDB(sql);
            //}

            //Label2.Text = "Disconnected";
            //db.closeConnection();



        }
        //                  kulak,burun     göz      diş,ağız    surat,saç        bel sırt       saç,ağız
        //string[] jobs = { "Otologist","Oculist","Dentist", "Dermatologist", "Chiropractic", "Endocrinologist"};
        //                     kulak          göz             burun        diş        ağız       surat,saç      bel sırt
        //string[] p_names = { "Otology", "Ophthalmology", "Rhinology", "Dentalogy", "Oralogy", "Dermatology", "Orthopedy" };
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