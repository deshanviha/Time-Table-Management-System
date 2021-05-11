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
    class locationControl
    {
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public locationControl()
        {
            con = DBConnection.getDBConnection();
        }

        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }

        //Insert queries

        public void insertLocationDetails(locationModel buildingMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string query = "INSERT INTO locationTB(locationName)  VALUES ('" + buildingMod.buildingname + "')";

            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

        //datagridview

        public DataTable getlocationvalues() {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtbuilding = new DataTable();

            string query = "select * from locationTB";

            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtbuilding.Load(dr1);
            return dtbuilding;
        }

        //delete quarry

        public void DeleteLocationDet(locationModel buildingMod)
        {
           
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM locationTB  WHERE  locationID='" + buildingMod.buildingID + "'";
            SqlCommand com = new SqlCommand(query, con);

            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted" + ret, "Information");
            }

            con.Close();

        }







    }
}
