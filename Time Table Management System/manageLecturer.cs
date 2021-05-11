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
using Time_Table_Management_System.Controller;
using Time_Table_Management_System.DBConnection;

namespace Time_Table_Management_System
{
    public partial class manageLecturer : Form
    {
        //database connection
        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public manageLecturer()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }
        

        addLecturerControl controlLec = new addLecturerControl();

        // retrive details to the data gridview 
        private void manageLecturer_Load(object sender, EventArgs e)
        {

            lecturerView.DataSource = controlLec.GetLecturerDetails();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // retrive lecturer record for the relavant field
        private void lecturerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            m_lec_name.Text = lecturerView.SelectedRows[0].Cells[1].Value.ToString();
            m_lec_Id.Text = lecturerView.SelectedRows[0].Cells[2].Value.ToString();
            m_lec_Faculty.Text = lecturerView.SelectedRows[0].Cells[3].Value.ToString();
            m_lec_dept.Text = lecturerView.SelectedRows[0].Cells[4].Value.ToString();
            m_lec_Center.Text = lecturerView.SelectedRows[0].Cells[5].Value.ToString();
            m_lec_Building.Text = lecturerView.SelectedRows[0].Cells[6].Value.ToString();
            m_lec_Level.Text = lecturerView.SelectedRows[0].Cells[7].Value.ToString();
            m_lec_Rank.Text = lecturerView.SelectedRows[0].Cells[8].Value.ToString();
            m_lec_Lid.Text = lecturerView.SelectedRows[0].Cells[0].Value.ToString();


        }

        // function for delete lecturer record details
        private void button2_Click(object sender, EventArgs e)
        {
            addLecturerControl delete = new addLecturerControl();

            try
            {
                delete.deleteRow(int.Parse(m_lec_Lid.Text));
                lecturerView.DataSource = controlLec.GetLecturerDetails();

            }
            catch (ArithmeticException) {

                MessageBox.Show("invalid data type");

            }
            reset();
        }

        private void m_lec_Lid_TextChanged(object sender, EventArgs e)
        {

        }

        // back navigation
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hm = new Homepage();
                hm.Show();
        }

        // calling update function to update lecturer records
        private void button1_Click(object sender, EventArgs e)
        {
            addLecturerControl updateLec = new addLecturerControl();

            updateLec.updateLec(m_lec_name.Text,m_lec_Id.Text,m_lec_Faculty.Text,m_lec_dept.Text,m_lec_Center.Text,m_lec_Building.Text,int.Parse(m_lec_Level.Text),float.Parse(m_lec_Rank.Text),int.Parse(m_lec_Lid.Text));

            lecturerView.DataSource = controlLec.GetLecturerDetails();

            
        }


        // reset record from the field
        public void reset() {

            m_lec_Lid.Clear();
            m_lec_name.Clear();
            m_lec_Id.Clear();
            m_lec_Faculty.ResetText();
            m_lec_dept.ResetText();
            m_lec_Center.ResetText();
            m_lec_Building.ResetText();
            m_lec_Level.ResetText();
            m_lec_Rank.Clear();
           
            


        }


        // reset buttton click function calling
        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
