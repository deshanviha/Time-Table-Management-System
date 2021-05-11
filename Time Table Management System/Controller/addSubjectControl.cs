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
    class addSubjectControl
    {

        // database connection
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();


        public addSubjectControl() {

            con = DBConnection.getDBConnection();

        }
        private static int Execution(SqlCommand command) {

            return command.ExecuteNonQuery();
        
        }

        // add subject details

        public void insertSubjectDetails(addSubjectModel add) {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "insert into subject values('" + add.off_year + "','" + add.off_sem + "','" + add.sub_name + "','" + add.sub_code + "','" + add.no_lec_hours + "','" + add.no_tut_hours + "','" + add.no_lab_hours + "','" + add.no_evalu_hours + "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = Execution(com);

            MessageBox.Show("insert subject detils succesfuly");
            con.Close();

        }

        // retrive subject details
        public DataTable GetSubjectDetails(){


            if (con.State.ToString() != "Open")
            {


                con.Open();

            }

            DataTable gotsubjectDet = new DataTable();

            string query = "select * from subject";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();

            gotsubjectDet.Load(data);
            return gotsubjectDet;

        }

        // Delete subject details

        public void deleteSubjectRow(int subject_id)
        {
            try
            {
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM subject WHERE sub_id = " + subject_id, con))
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

        // function for update detils 
        public void updateSubject(String off_Year,String off_Sem,String sub_Name,String sub_Code, float no_Oflechr, float no_Oftutehr, float noOflabhr , float no_Ofevalutionhr, int sub_Id) {


            try
            {
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(" UPDATE subject SET off_year ='" + off_Year + "' , off_sem ='" + off_Sem + "' , sub_name = '" + sub_Name + "' , sub_code ='" + sub_Code + "' , no_lec_hours='" + no_Oflechr + "' ,  no_tut_hours = '" + no_Oftutehr + "' , no_lab_hours ='" + noOflabhr + "',no_evalu_hours='"+ no_Ofevalutionhr + "' WHERE   sub_id ='" + sub_Id + "'", con))
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
