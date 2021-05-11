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
    public partial class manageSubject : Form
    {

        // connection calling

        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();


        public manageSubject()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();

        }

        addSubjectControl controlSub = new addSubjectControl();

        // retrive all the subject record for datagrid 

        private void manageSubject_Load_1(object sender, EventArgs e)
        {
            subjectView.DataSource = controlSub.GetSubjectDetails();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void offered_year_TextChanged(object sender, EventArgs e)
        {

        }

        // retrive database subject record to the relavant field

        private void subjectView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            subject_id.Text = subjectView.SelectedRows[0].Cells[0].Value.ToString();
            offered_year.Text = subjectView.SelectedRows[0].Cells[1].Value.ToString();
            offered_sem.Text = subjectView.SelectedRows[0].Cells[2].Value.ToString();
            subject_name.Text = subjectView.SelectedRows[0].Cells[3].Value.ToString();
            subject_code.Text = subjectView.SelectedRows[0].Cells[4].Value.ToString();
            no_of_lec.Text = subjectView.SelectedRows[0].Cells[5].Value.ToString();
            no_of_tute.Text = subjectView.SelectedRows[0].Cells[6].Value.ToString();
            no_of_lab.Text = subjectView.SelectedRows[0].Cells[7].Value.ToString();
            no_of_evalu.Text = subjectView.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // delete record method calling
        private void button2_Click(object sender, EventArgs e)
        {

            addSubjectControl delete = new addSubjectControl();
            delete.deleteSubjectRow(int.Parse(subject_id.Text));
            reset();
            subjectView.DataSource = controlSub.GetSubjectDetails();

        }

        // method for reset the inserted field of the form

        public void reset() {

            subject_id.Clear();
            offered_year.Clear();
            subject_code.Clear();
            subject_name.Clear();
            offered_sem.ResetText();
            no_of_lec.ResetText();
            no_of_tute.ResetText();
            no_of_lab.ResetText();
            no_of_tute.ResetText();
            no_of_evalu.ResetText();

        }


        // reset button
        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }


        // back navigation
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hm = new Homepage();
            hm.Show();
        }

        // onclick method calling for update details

        private void button1_Click(object sender, EventArgs e)
        {
            addSubjectControl edit_sub_dtl = new addSubjectControl();


            edit_sub_dtl.updateSubject(offered_year.Text,offered_sem.Text,subject_name.Text,subject_code.Text,float.Parse(no_of_lec.Text),float.Parse(no_of_tute.Text),float.Parse(no_of_lab.Text),float.Parse(no_of_evalu.Text),int.Parse(subject_id.Text));
            subjectView.DataSource = controlSub.GetSubjectDetails();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
