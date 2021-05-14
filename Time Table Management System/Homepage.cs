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

namespace Time_Table_Management_System
{
    public partial class Homepage : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UCQ3NA3T\SQLEXPRESS;Initial Catalog=TLM;Integrated Security=True");
        public Homepage()
        {
            InitializeComponent();
            customizeDialog();
        }

        private void customizeDialog()
        {
            panellocation.Visible = false;
            sub_panel.Visible = false;
            sub_panel1.Visible = false;

        }



        private void hideSubMenu()
        {
            if (panellocation.Visible = true)
                panellocation.Visible = false;


            if (sub_panel.Visible = true)
                sub_panel.Visible = false;
            if (sub_panel1.Visible = true)
                sub_panel1.Visible = true;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                // hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildForm.Controls.Add(childForm);
            panelchildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            openChildForm(new addLecturer());
            showSubMenu(panellocation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new addLecturer());
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new AddRooms());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            addLecturer addLec = new addLecturer();
            addLec.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            this.Hide();
            manageLecturer mngLec = new manageLecturer();
            mngLec.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            addSubject addSub = new addSubject();
            addSub.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            manageSubject mngSub = new manageSubject();
            mngSub.Show();
        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            openChildForm(new addLecturer());
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
     


        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        private void lecturerSub_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click_2(object sender, EventArgs e)
        {
            openChildForm(new manageLecturer());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new addSubject());
            showSubMenu(sub_panel);
        }

        private void addSub_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new addSubject());
        }

        private void subMng_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new manageSubject());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new manageLecturer());
        }

        private void panelchildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void sub_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click_2(object sender, EventArgs e)
        {
            openChildForm(new addSession());
            showSubMenu(sub_panel1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void panellocation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click_3(object sender, EventArgs e)
        {
            openChildForm(new manageSession());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            openChildForm(new addSession());
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
