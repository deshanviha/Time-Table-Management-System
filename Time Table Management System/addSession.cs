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
    public partial class addSession : Form
    {


        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public addSession()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addSession_Load(object sender, EventArgs e)
        {

        }

        private void lec_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lec_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        addSessionModel addSes_mod = new addSessionModel();
        addSessionControl ins_sess = new addSessionControl();

        private void button1_Click(object sender, EventArgs e)
        {

            if (lect_1.Text != "") {

                addSes_mod.lec1 = int.Parse(lect_1.Text);
                addSes_mod.lec2 = int.Parse(lect_2.Text);
                addSes_mod.lec1_Tag = int.Parse(lec1_tag.Text);
                addSes_mod.group_no = int.Parse(group.Text);
                addSes_mod.subject_name = int.Parse(subject.Text);
                addSes_mod.noOfStudent = int.Parse(no_of_student.Text);
                addSes_mod.duration = decimal.Parse(duration.Text);

                ins_sess.insertSessionDetails(addSes_mod);

                reset();

            }


        }

        private void reset()
        {

            lect_1.ResetText();
            lect_2.ResetText();
            lec1_tag.ResetText();
            group.ResetText();
            subject.ResetText();
            no_of_student.Clear();
            duration.Clear();

        }
    }
}
