using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;

namespace Time_Table_Management_System.Controller
{

   

    class addSessionControl
    {


        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();


        public addSessionControl() {


            con = DBConnection.getDBConnection();

        }


        private static int Execution(SqlCommand command)
        {

            return command.ExecuteNonQuery();

        }


        public void insertSessionDetails(addSessionModel add)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string query = "insert into session values('" + add.lec1 + "','" + add.lec2 + "','" + add.lec1_Tag + "','" + add.group_no + "','" + add.subject_name + "','" + add.noOfStudent + "','" + add.duration + "')";

            SqlCommand com = new SqlCommand(query, con);
            int ret = Execution(com);

            MessageBox.Show("inserted succesfully");
            con.Close();


        }


        public DataTable GetSessionDetails()
        {


            if (con.State.ToString() != "Open")
            {

                con.Open();

            }

            DataTable gotSessionDet = new DataTable();

            string query = "select * from session";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            gotSessionDet.Load(data);
            return gotSessionDet;

        }


        //function for fdelete lecturer details 
        public void deleteRow(int IDNumber)
        {
            try
            {
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM session WHERE sesId = " + IDNumber, con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        public void updateSession(int lec_1, int lec_2, int lec_tag_1, int groupno, int subjectname, int noOfStudent, decimal duration,int sessionId)
        {

            //
            try
            {
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(" UPDATE session SET lec1 = '" + lec_1 + "', lec2 ='" + lec_2 + "' , lec1_Tag ='" + lec_tag_1 + "' , group_no ='" + groupno + "' , subject_name ='" + subjectname + "' ,  noOfStudent = '" + noOfStudent + "' , duration ='" + duration + "' WHERE   sesId ='" + sessionId + "'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }


        }


    }
}
