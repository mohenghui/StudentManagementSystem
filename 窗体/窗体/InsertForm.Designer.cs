namespace 窗体
{
    partial class InsertForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbXiBu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.B_insert = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Tb_xuehao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Tb_email = new System.Windows.Forms.TextBox();
            this.Dtp_date = new System.Windows.Forms.DateTimePicker();
            this.Tb_adress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tb_phone = new System.Windows.Forms.TextBox();
            this.Tb_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(104, 368);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 27);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.cmbXiBu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbClass);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbGrade);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbsex);
            this.groupBox2.Controls.Add(this.B_insert);
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Controls.Add(this.Tb_xuehao);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Tb_email);
            this.groupBox2.Controls.Add(this.Dtp_date);
            this.groupBox2.Controls.Add(this.Tb_adress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Tb_phone);
            this.groupBox2.Controls.Add(this.Tb_name);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(17, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(520, 432);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户基本信息";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // cmbXiBu
            // 
            this.cmbXiBu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXiBu.FormattingEnabled = true;
            this.cmbXiBu.Items.AddRange(new object[] {
            "计算机系",
            "机电系",
            "外国语系"});
            this.cmbXiBu.Location = new System.Drawing.Point(101, 367);
            this.cmbXiBu.Name = "cmbXiBu";
            this.cmbXiBu.Size = new System.Drawing.Size(206, 23);
            this.cmbXiBu.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "系部";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "18ab班",
            "18cd班",
            "18ef班",
            "18gh班",
            "18ij班"});
            this.cmbClass.Location = new System.Drawing.Point(101, 332);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(206, 23);
            this.cmbClass.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "班级";
            // 
            // cmbGrade
            // 
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Items.AddRange(new object[] {
            "大一",
            "大二",
            "大三",
            "大四"});
            this.cmbGrade.Location = new System.Drawing.Point(101, 294);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(206, 23);
            this.cmbGrade.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "年级";
            // 
            // cmbsex
            // 
            this.cmbsex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbsex.Location = new System.Drawing.Point(100, 61);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(207, 23);
            this.cmbsex.TabIndex = 30;
            // 
            // B_insert
            // 
            this.B_insert.Location = new System.Drawing.Point(401, 400);
            this.B_insert.Margin = new System.Windows.Forms.Padding(4);
            this.B_insert.Name = "B_insert";
            this.B_insert.Size = new System.Drawing.Size(75, 24);
            this.B_insert.TabIndex = 29;
            this.B_insert.Text = "添 加";
            this.B_insert.UseVisualStyleBackColor = true;
            this.B_insert.Click += new System.EventHandler(this.B_insert_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(436, 527);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(160, 136);
            this.treeView1.TabIndex = 23;
            // 
            // Tb_xuehao
            // 
            this.Tb_xuehao.Location = new System.Drawing.Point(101, 255);
            this.Tb_xuehao.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_xuehao.Name = "Tb_xuehao";
            this.Tb_xuehao.Size = new System.Drawing.Size(273, 25);
            this.Tb_xuehao.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "学号";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 635);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Tb_email
            // 
            this.Tb_email.Location = new System.Drawing.Point(100, 216);
            this.Tb_email.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_email.Name = "Tb_email";
            this.Tb_email.Size = new System.Drawing.Size(274, 25);
            this.Tb_email.TabIndex = 16;
            // 
            // Dtp_date
            // 
            this.Dtp_date.Location = new System.Drawing.Point(101, 177);
            this.Dtp_date.Margin = new System.Windows.Forms.Padding(4);
            this.Dtp_date.Name = "Dtp_date";
            this.Dtp_date.Size = new System.Drawing.Size(206, 25);
            this.Dtp_date.TabIndex = 15;
            this.Dtp_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Tb_adress
            // 
            this.Tb_adress.Location = new System.Drawing.Point(100, 138);
            this.Tb_adress.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_adress.Name = "Tb_adress";
            this.Tb_adress.Size = new System.Drawing.Size(274, 25);
            this.Tb_adress.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 222);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 183);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "出生日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "电话";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 144);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "地址";
            // 
            // Tb_phone
            // 
            this.Tb_phone.Location = new System.Drawing.Point(100, 99);
            this.Tb_phone.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_phone.MaxLength = 12;
            this.Tb_phone.Name = "Tb_phone";
            this.Tb_phone.Size = new System.Drawing.Size(207, 25);
            this.Tb_phone.TabIndex = 5;
            this.Tb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_phone_KeyPress);
            // 
            // Tb_name
            // 
            this.Tb_name.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tb_name.Location = new System.Drawing.Point(100, 22);
            this.Tb_name.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_name.Name = "Tb_name";
            this.Tb_name.Size = new System.Drawing.Size(207, 25);
            this.Tb_name.TabIndex = 3;
            this.Tb_name.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "性别";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "姓名";
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(556, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                          添加学生信息";
            this.Load += new System.EventHandler(this.编辑学生信息_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tb_phone;
        private System.Windows.Forms.TextBox Tb_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tb_email;
        private System.Windows.Forms.DateTimePicker Dtp_date;
        private System.Windows.Forms.TextBox Tb_adress;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox Tb_xuehao;
        private System.Windows.Forms.Button B_insert;
        private System.Windows.Forms.ComboBox cmbsex;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbXiBu;
        private System.Windows.Forms.Label label4;
    }
}