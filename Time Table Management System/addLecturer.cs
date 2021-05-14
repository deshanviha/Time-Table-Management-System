using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Model;
using Time_Table_Management_System.Controller;
using Time_Table_Management_System.DBConnection;
using System.Data.SqlClient;

namespace Time_Table_Management_System
{
    public partial class addLecturer : Form
    {


        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public addLecturer()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }

        addLecturerControl addingCon = new addLecturerControl();
        addLecturerModel addinglec_mod = new addLecturerModel();


        private void button1_Click(object sender, EventArgs e)
        {
            if (lec_Name.Text != "") {

                addinglec_mod.lecturerName = lec_Name.Text;
                addinglec_mod.employeeId = lec_Id.Text;
                addinglec_mod.faculty = lec_Faculty.Text;
                addinglec_mod.department = lec_Department.Text;
                addinglec_mod.center = lec_Center.Text;
                addinglec_mod.building = lec_Building.Text;
                addinglec_mod.level = int.Parse(lec_Level.Text);
                addinglec_mod.rank = float.Parse(lec_Rank.Text);

                addingCon.insertLecturerDetails(addinglec_mod);

                reset();

            }
            else
            {
                MessageBox.Show("Please Fill the all the required fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           /* if (ValidateChildren(ValidationConstraints.Enabled))
            {


                MessageBox.Show(lec_Name.Text, "Demo App - Message!");

            }
            else if (ValidateChildren(ValidationConstraints.Enabled)) {

                MessageBox.Show(lec_Name.Text, "Demo App - Message!");

            }*/

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //rank genarate key method
        private void button2_Click(object sender, EventArgs e)
        {

            addLecturerControl rankGenarate = new addLecturerControl();
            
            
            float Rank = rankGenarate.generatteRank(int.Parse(lec_Level.Text),int.Parse(lec_Id.Text));
            lec_Rank.Text = Rank.ToString();


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();

        }

        // feild reset method
        private void reset()
        {
            lec_Name.Clear();
            lec_Id.Clear();
            lec_Faculty.ResetText();
            lec_Department.ResetText();
            lec_Center.ResetText();
            lec_Building.ResetText();
            lec_Level.ResetText(); ;
            lec_Rank.Clear();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

       private void lec_Id_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lec_Id.Text))
            {
                e.Cancel = true;
                lec_Id.Focus();
                errorProvider1.SetError(lec_Id, "Please enter employee id");

            }
            else {


                e.Cancel = false;
                errorProvider1.SetError(lec_Id,"");
            
            }
        }

        private void lec_Name_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(lec_Name.Text))
            {
                e.Cancel = true;
                lec_Id.Focus();
                errorProvider1.SetError(lec_Name, "Please enter name");

            }
            else
            {


                e.Cancel = false;
                errorProvider1.SetError(lec_Name,"");

            }

        }
    }
}
