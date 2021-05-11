
namespace Time_Table_Management_System
{
    partial class manageSubject
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
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.subject_id = new System.Windows.Forms.TextBox();
            this.subjectView = new System.Windows.Forms.DataGridView();
            this.offered_year = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.no_of_evalu = new System.Windows.Forms.ComboBox();
            this.subject_code = new System.Windows.Forms.TextBox();
            this.subject_name = new System.Windows.Forms.TextBox();
            this.no_of_lab = new System.Windows.Forms.ComboBox();
            this.no_of_tute = new System.Windows.Forms.ComboBox();
            this.no_of_lec = new System.Windows.Forms.ComboBox();
            this.offered_sem = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectView)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1162, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 47);
            this.button3.TabIndex = 27;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.subject_id);
            this.panel2.Controls.Add(this.subjectView);
            this.panel2.Controls.Add(this.offered_year);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.no_of_evalu);
            this.panel2.Controls.Add(this.subject_code);
            this.panel2.Controls.Add(this.subject_name);
            this.panel2.Controls.Add(this.no_of_lab);
            this.panel2.Controls.Add(this.no_of_tute);
            this.panel2.Controls.Add(this.no_of_lec);
            this.panel2.Controls.Add(this.offered_sem);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1395, 855);
            this.panel2.TabIndex = 14;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(345, 39);
            this.label10.TabIndex = 76;
            this.label10.Text = "MANAGE SUBJECT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1395, 49);
            this.panel1.TabIndex = 74;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 73;
            this.label1.Text = "Subject ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // subject_id
            // 
            this.subject_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_id.Location = new System.Drawing.Point(315, 472);
            this.subject_id.Name = "subject_id";
            this.subject_id.Size = new System.Drawing.Size(256, 34);
            this.subject_id.TabIndex = 72;
            // 
            // subjectView
            // 
            this.subjectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectView.Location = new System.Drawing.Point(12, 119);
            this.subjectView.Name = "subjectView";
            this.subjectView.RowHeadersWidth = 51;
            this.subjectView.RowTemplate.Height = 24;
            this.subjectView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectView.Size = new System.Drawing.Size(1127, 337);
            this.subjectView.TabIndex = 71;
            this.subjectView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectView_CellContentClick_1);
            // 
            // offered_year
            // 
            this.offered_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offered_year.Location = new System.Drawing.Point(315, 538);
            this.offered_year.Name = "offered_year";
            this.offered_year.Size = new System.Drawing.Size(256, 34);
            this.offered_year.TabIndex = 70;
            this.offered_year.TextChanged += new System.EventHandler(this.offered_year_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(145)))), ((int)(((byte)(231)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1162, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 47);
            this.button2.TabIndex = 25;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // no_of_evalu
            // 
            this.no_of_evalu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_evalu.FormattingEnabled = true;
            this.no_of_evalu.Items.AddRange(new object[] {
            "1.00",
            "2.00",
            "3.00"});
            this.no_of_evalu.Location = new System.Drawing.Point(977, 749);
            this.no_of_evalu.Name = "no_of_evalu";
            this.no_of_evalu.Size = new System.Drawing.Size(124, 37);
            this.no_of_evalu.TabIndex = 24;
            // 
            // subject_code
            // 
            this.subject_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_code.Location = new System.Drawing.Point(315, 749);
            this.subject_code.Name = "subject_code";
            this.subject_code.Size = new System.Drawing.Size(256, 34);
            this.subject_code.TabIndex = 23;
            // 
            // subject_name
            // 
            this.subject_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_name.Location = new System.Drawing.Point(315, 678);
            this.subject_name.Name = "subject_name";
            this.subject_name.Size = new System.Drawing.Size(256, 34);
            this.subject_name.TabIndex = 22;
            // 
            // no_of_lab
            // 
            this.no_of_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_lab.FormattingEnabled = true;
            this.no_of_lab.Items.AddRange(new object[] {
            "2.00",
            "3.00"});
            this.no_of_lab.Location = new System.Drawing.Point(977, 678);
            this.no_of_lab.Name = "no_of_lab";
            this.no_of_lab.Size = new System.Drawing.Size(124, 37);
            this.no_of_lab.TabIndex = 21;
            // 
            // no_of_tute
            // 
            this.no_of_tute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_tute.FormattingEnabled = true;
            this.no_of_tute.Items.AddRange(new object[] {
            "1.00",
            "2.00"});
            this.no_of_tute.Location = new System.Drawing.Point(977, 605);
            this.no_of_tute.Name = "no_of_tute";
            this.no_of_tute.Size = new System.Drawing.Size(124, 37);
            this.no_of_tute.TabIndex = 20;
            // 
            // no_of_lec
            // 
            this.no_of_lec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_lec.FormattingEnabled = true;
            this.no_of_lec.Items.AddRange(new object[] {
            "1.00",
            "2.00",
            "3.00",
            "4.00"});
            this.no_of_lec.Location = new System.Drawing.Point(977, 535);
            this.no_of_lec.Name = "no_of_lec";
            this.no_of_lec.Size = new System.Drawing.Size(124, 37);
            this.no_of_lec.TabIndex = 19;
            // 
            // offered_sem
            // 
            this.offered_sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offered_sem.FormattingEnabled = true;
            this.offered_sem.Items.AddRange(new object[] {
            "1 st semester",
            "2 nd semester"});
            this.offered_sem.Location = new System.Drawing.Point(315, 605);
            this.offered_sem.Name = "offered_sem";
            this.offered_sem.Size = new System.Drawing.Size(256, 37);
            this.offered_sem.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(186)))), ((int)(((byte)(247)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1162, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 47);
            this.button1.TabIndex = 16;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(619, 749);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(307, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "No. of evaluation hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(620, 678);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "No. of lab hours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(619, 605);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "No. of tut. hours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(619, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "No. of lect. hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 749);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Subject code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 678);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Subject name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 605);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Offered semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Offered year";
            // 
            // manageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 855);
            this.Controls.Add(this.panel2);
            this.Name = "manageSubject";
            this.Text = "manageSubject";
            this.Load += new System.EventHandler(this.manageSubject_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox no_of_evalu;
        private System.Windows.Forms.TextBox subject_code;
        private System.Windows.Forms.TextBox subject_name;
        private System.Windows.Forms.ComboBox no_of_lab;
        private System.Windows.Forms.ComboBox no_of_tute;
        private System.Windows.Forms.ComboBox no_of_lec;
        private System.Windows.Forms.ComboBox offered_sem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox offered_year;
        private System.Windows.Forms.DataGridView subjectView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subject_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
    }
}