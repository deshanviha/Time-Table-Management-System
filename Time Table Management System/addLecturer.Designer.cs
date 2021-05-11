
namespace Time_Table_Management_System
{
    partial class addLecturer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lec_Level = new System.Windows.Forms.ComboBox();
            this.lec_Building = new System.Windows.Forms.ComboBox();
            this.lec_Center = new System.Windows.Forms.ComboBox();
            this.lec_Department = new System.Windows.Forms.ComboBox();
            this.lec_Faculty = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lec_Rank = new System.Windows.Forms.TextBox();
            this.lec_Id = new System.Windows.Forms.TextBox();
            this.lec_Name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(886, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 58);
            this.button3.TabIndex = 23;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(197)))), ((int)(((byte)(32)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(886, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 58);
            this.button2.TabIndex = 22;
            this.button2.Text = "Generate Rank";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lec_Level
            // 
            this.lec_Level.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lec_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec_Level.FormattingEnabled = true;
            this.lec_Level.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.lec_Level.Location = new System.Drawing.Point(307, 611);
            this.lec_Level.Name = "lec_Level";
            this.lec_Level.Size = new System.Drawing.Size(354, 39);
            this.lec_Level.TabIndex = 21;
            this.lec_Level.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // lec_Building
            // 
            this.lec_Building.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lec_Building.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec_Building.FormattingEnabled = true;
            this.lec_Building.Items.AddRange(new object[] {
            "Main(IT)",
            "Engineering",
            "Business"});
            this.lec_Building.Location = new System.Drawing.Point(307, 539);
            this.lec_Building.Name = "lec_Building";
            this.lec_Building.Size = new System.Drawing.Size(354, 39);
            this.lec_Building.TabIndex = 20;
            this.lec_Building.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // lec_Center
            // 
            this.lec_Center.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lec_Center.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec_Center.FormattingEnabled = true;
            this.lec_Center.Items.AddRange(new object[] {
            "Malabe",
            "Matara",
            "Jaffna",
            "Kurunegala"});
            this.lec_Center.Location = new System.Drawing.Point(307, 476);
            this.lec_Center.Name = "lec_Center";
            this.lec_Center.Size = new System.Drawing.Size(354, 39);
            this.lec_Center.TabIndex = 19;
            this.lec_Center.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lec_Department
            // 
            this.lec_Department.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lec_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec_Department.FormattingEnabled = true;
            this.lec_Department.Items.AddRange(new object[] {
            "IT",
            "SE",
            "IM",
            "ISE",
            "CS",
            "CSNE "});
            this.lec_Department.Location = new System.Drawing.Point(307, 407);
            this.lec_Department.Name = "lec_Department";
            this.lec_Department.Size = new System.Drawing.Size(354, 39);
            this.lec_Department.TabIndex = 18;
            this.lec_Department.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // lec_Faculty
            // 
            this.lec_Faculty.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lec_Faculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec_Faculty.FormattingEnabled = true;
            this.lec_Faculty.Items.AddRange(new object[] {
            "Compuiting",
            "Engineering",
            "Business"});
            this.lec_Faculty.Location = new System.Drawing.Point(307, 331);
            this.lec_Faculty.Name = "lec_Faculty";
            this.lec_Faculty.Size = new System.Drawing.Size(354, 39);
            this.lec_Faculty.TabIndex = 17;
            this.lec_Faculty.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(85)))), ((int)(((byte)(145)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(886, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 58);
            this.button1.TabIndex = 16;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lec_Rank
            // 
            this.lec_Rank.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lec_Rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec_Rank.Location = new System.Drawing.Point(307, 690);
            this.lec_Rank.Name = "lec_Rank";
            this.lec_Rank.Size = new System.Drawing.Size(354, 38);
            this.lec_Rank.TabIndex = 15;
            this.lec_Rank.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // lec_Id
            // 
            this.lec_Id.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lec_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec_Id.Location = new System.Drawing.Point(307, 263);
            this.lec_Id.Name = "lec_Id";
            this.lec_Id.Size = new System.Drawing.Size(354, 38);
            this.lec_Id.TabIndex = 9;
            this.lec_Id.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.lec_Id.Validating += new System.ComponentModel.CancelEventHandler(this.lec_Id_Validating);
            // 
            // lec_Name
            // 
            this.lec_Name.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lec_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lec_Name.Location = new System.Drawing.Point(307, 189);
            this.lec_Name.Name = "lec_Name";
            this.lec_Name.Size = new System.Drawing.Size(354, 38);
            this.lec_Name.TabIndex = 8;
            this.lec_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.lec_Name.Validating += new System.ComponentModel.CancelEventHandler(this.lec_Name_Validating);
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 690);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "Rank";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 616);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "Level";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Building";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 481);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Center";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Department";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Faculty";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Employee ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lecturer name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.lec_Level);
            this.panel5.Controls.Add(this.lec_Building);
            this.panel5.Controls.Add(this.lec_Center);
            this.panel5.Controls.Add(this.lec_Department);
            this.panel5.Controls.Add(this.lec_Faculty);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.lec_Rank);
            this.panel5.Controls.Add(this.lec_Id);
            this.panel5.Controls.Add(this.lec_Name);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1395, 855);
            this.panel5.TabIndex = 14;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1395, 49);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "ADD LECTURER";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // addLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 855);
            this.Controls.Add(this.panel5);
            this.Name = "addLecturer";
            this.Text = "Form1";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox lec_Level;
        private System.Windows.Forms.ComboBox lec_Building;
        private System.Windows.Forms.ComboBox lec_Center;
        private System.Windows.Forms.ComboBox lec_Department;
        private System.Windows.Forms.ComboBox lec_Faculty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lec_Rank;
        private System.Windows.Forms.TextBox lec_Id;
        private System.Windows.Forms.TextBox lec_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}