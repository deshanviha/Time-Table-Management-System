using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;

namespace Time_Table_Management_System.Controller
{
    class addLecturerControl
    {
        // db connecdtion
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();



        public addLecturerControl()
        {
            con = DBConnection.getDBConnection();

        }

        
        private  static int Execution(SqlCommand command) {

            return command.ExecuteNonQuery();

        }

        // Add lecturer detils
        public void insertLecturerDetails(addLecturerModel  add) {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string query = "insert into lecturer values('" + add.lecturerName + "','" + add.employeeId + "','" + add.faculty+ "','" + add.department + "','" + add.center + "','" + add.building + "','" + add.level + "','" + add.rank + "')";

            SqlCommand com = new SqlCommand(query, con);
            int ret = Execution(com);

            MessageBox.Show("inserted succesfully");
            con.Close();


        }

        // retrive lecturer details 
        public DataTable GetLecturerDetails() {


            if (con.State.ToString() != "Open") {


                con.Open();
            
            }

            DataTable gotLectureDet = new DataTable();

            string query = "select * from lecturer";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            gotLectureDet.Load(data);
            return gotLectureDet;
        
        }


        //function for fdelete lecturer details 
        public  void deleteRow(int IDNumber)
        {
            try
            {
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM lecturer WHERE lid = " + IDNumber, con))
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


        // generate rank
        public float  generatteRank(int lvl , int empId) {


            string s1 = lvl.ToString();
            string s2 = empId.ToString();

            string s = (s1)+"."+(s2);

            float c = float.Parse(s);


            return c;

        
        }

        //edit details 

        public void updateLec(String lecName,String empID,String fclty,String dpt , String cnt,String build,int lvl,float rnk,int lecID) {

            //
            try
            {
                if (con.State.ToString() != "Open")
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand(" UPDATE lecturer SET lecturerName = '" + lecName + "', employeeId ='" + empID + "' , faculty ='" + fclty + "' , department = '" + dpt + "' , center ='" + cnt + "' , building='" + build + "' ,  level = '" + lvl + "' , rank ='" + rnk + "' WHERE   lid ='" + lecID + "'",con))
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
