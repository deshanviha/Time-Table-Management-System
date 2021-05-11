using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.DBConnection;
using Time_Table_Management_System.Model;
using Time_Table_Management_System.Controller;


namespace Time_Table_Management_System
{
    public partial class addlocation : Form
    {

        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public addlocation()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }

        locationControl LocationControl = new locationControl();
        locationModel locationModel = new locationModel();

        private void addbtn_Click(object sender, EventArgs e)
        {

            if (addBuildingname.Text != "" )
            {
               // locationModel.locationPID = locationID.Text;
                locationModel.buildingname = addBuildingname.Text;
                LocationControl.insertLocationDetails(locationModel);

                bunifuDataGridView1.DataSource = LocationControl.getlocationvalues();     
            }
            else
            {
                MessageBox.Show("Please Fill the all the required fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            addBuildingID.Clear();
            addBuildingname.Clear();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addBuildingID.Text = bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            addBuildingname.Text = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void addlocation_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = LocationControl.getlocationvalues();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}
