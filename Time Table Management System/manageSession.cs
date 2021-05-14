using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time_Table_Management_System.Controller;

namespace Time_Table_Management_System
{
    public partial class manageSession : Form
    {
        public manageSession()
        {
            InitializeComponent();
        }

        addSessionControl review = new addSessionControl();

        private void manageSession_Load(object sender, EventArgs e)
        {

            subjectView.DataSource = review.GetSessionDetails();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lec_2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void group_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void duration_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void no_of_student_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lec_1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lec1_tag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lec2_tag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void subjectView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            sessionId.Text = subjectView.SelectedRows[0].Cells[0].Value.ToString();
            lec_1.Text = subjectView.SelectedRows[0].Cells[1].Value.ToString();
            lec_2.Text = subjectView.SelectedRows[0].Cells[2].Value.ToString();
            lec1_tag.Text = subjectView.SelectedRows[0].Cells[3].Value.ToString();
            group.Text = subjectView.SelectedRows[0].Cells[4].Value.ToString();
            subject.Text = subjectView.SelectedRows[0].Cells[5].Value.ToString();
            no_of_student.Text = subjectView.SelectedRows[0].Cells[6].Value.ToString();
            duration.Text = subjectView.SelectedRows[0].Cells[7].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            addSessionControl delete = new addSessionControl();
            delete.deleteRow(int.Parse(sessionId.Text));
            reset();
            subjectView.DataSource = review.GetSessionDetails();

        }

        private void reset()
        {
            sessionId.Clear();
            lec_1.ResetText();
            lec_2.ResetText();
            lec1_tag.ResetText();
            group.ResetText();
            subject.ResetText();
            no_of_student.Clear();
            duration.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addSessionControl edit_ses = new addSessionControl();

            edit_ses.updateSession(int.Parse(lec_1.Text), int.Parse(lec_2.Text), int.Parse(lec1_tag.Text), int.Parse(group.Text), int.Parse(subject.Text), int.Parse(no_of_student.Text),decimal.Parse(duration.Text),int.Parse(sessionId.Text));
            subjectView.DataSource = review.GetSessionDetails();
            reset();
        }
    }
}
