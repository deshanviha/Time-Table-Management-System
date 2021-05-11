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
using Time_Table_Management_System.Model;

namespace Time_Table_Management_System
{
    public partial class addSubject : Form
    {

        DBcon DBConnection = new DBcon();
        SqlConnection con = new SqlConnection();

        public addSubject()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
        }


        addSubjectControl addSub = new addSubjectControl();
        addSubjectModel addSub_mod = new addSubjectModel();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjectSave_btn_Click(object sender, EventArgs e)
        {
            if (offered_year.Text != "") {

                addSub_mod.off_year = offered_year.Text;
                addSub_mod.off_sem = Offered_sem.Text;
                addSub_mod.sub_name = Subject_name.Text;
                addSub_mod.sub_code = subject_code.Text;
                addSub_mod.no_lec_hours = float.Parse(lec_hours.Text);
                addSub_mod.no_tut_hours = float.Parse(tute_hours.Text);
                addSub_mod.no_lab_hours = float.Parse(lab_hours.Text);
                addSub_mod.no_evalu_hours = float.Parse(evaluation_hours.Text);


                addSub.insertSubjectDetails(addSub_mod);
  
            }

            reset();

           /* if (ValidateChildren(ValidationConstraints.Enabled))
            {


                MessageBox.Show(offered_year.Text, "Demo App - Message!");

            }
            else if (ValidateChildren(ValidationConstraints.Enabled))
            {

                MessageBox.Show(Offered_sem.Text, "Demo App - Message!");

            } */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage hm = new Homepage();
                hm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void offered_year_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(offered_year.Text))
            {
                e.Cancel = true;
                offered_year.Focus();
                errorProvider2.SetError(offered_year, "Please enter offered year");

            }
            else
            {


                e.Cancel = false;
                errorProvider2.SetError(offered_year, "");

            }
        }

        private void Offered_sem_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Offered_sem.Text))
            {
                e.Cancel = true;
                Offered_sem.Focus();
                errorProvider2.SetError(Offered_sem, "Please enter offered semester");

            }
            else
            {


                e.Cancel = false;
                errorProvider2.SetError(Offered_sem, "");

            }
        }

        private void subjectClear_btn_Click(object sender, EventArgs e)
        {

            reset();

        }

        //text filed clear method
        public void reset()
        {

            offered_year.Clear();
            subject_code.Clear();
            Subject_name.Clear();
            Offered_sem.ResetText();
            lec_hours.ResetText();
            tute_hours.ResetText();
            lab_hours.ResetText();
            tute_hours.ResetText();
            evaluation_hours.ResetText();

        }
    }
}
