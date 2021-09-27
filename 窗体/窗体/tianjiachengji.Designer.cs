namespace 窗体
{
    partial class tianjiachengji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tianjiachengji));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbKemu = new System.Windows.Forms.ComboBox();
            this.txbno = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txbXueHao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_insert = new System.Windows.Forms.Button();
            this.Tb_score = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cmbKemu);
            this.groupBox1.Controls.Add(this.txbno);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.txbXueHao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.B_insert);
            this.groupBox1.Controls.Add(this.Tb_score);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(31, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(927, 305);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入成绩";
            // 
            // cmbKemu
            // 
            this.cmbKemu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKemu.FormattingEnabled = true;
            this.cmbKemu.Items.AddRange(new object[] {
            "计算机",
            "英语",
            "政治",
            "体育"});
            this.cmbKemu.Location = new System.Drawing.Point(299, 148);
            this.cmbKemu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbKemu.Name = "cmbKemu";
            this.cmbKemu.Size = new System.Drawing.Size(223, 23);
            this.cmbKemu.TabIndex = 36;
            // 
            // txbno
            // 
            this.txbno.Location = new System.Drawing.Point(24, 80);
            this.txbno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbno.Name = "txbno";
            this.txbno.Size = new System.Drawing.Size(100, 25);
            this.txbno.TabIndex = 35;
            this.txbno.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(605, 42);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 25);
            this.btnSelect.TabIndex = 34;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click_1);
            // 
            // txbXueHao
            // 
            this.txbXueHao.Location = new System.Drawing.Point(299, 42);
            this.txbXueHao.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbXueHao.Name = "txbXueHao";
            this.txbXueHao.Size = new System.Drawing.Size(223, 25);
            this.txbXueHao.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "学号";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(299, 98);
            this.txbName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(381, 25);
            this.txbName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "姓名";
            // 
            // B_insert
            // 
            this.B_insert.Location = new System.Drawing.Point(760, 251);
            this.B_insert.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.B_insert.Name = "B_insert";
            this.B_insert.Size = new System.Drawing.Size(100, 30);
            this.B_insert.TabIndex = 28;
            this.B_insert.Text = "添 加";
            this.B_insert.UseVisualStyleBackColor = true;
            this.B_insert.Click += new System.EventHandler(this.B_insert_Click);
            // 
            // Tb_score
            // 
            this.Tb_score.Location = new System.Drawing.Point(299, 199);
            this.Tb_score.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Tb_score.Name = "Tb_score";
            this.Tb_score.Size = new System.Drawing.Size(381, 25);
            this.Tb_score.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "成绩";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "科目";
            // 
            // tianjiachengji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1002, 430);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "tianjiachengji";
            this.Text = "添加成绩";
            this.Load += new System.EventHandler(this.tianjiachengji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button B_insert;
        private System.Windows.Forms.TextBox Tb_score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbXueHao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txbno;
        private System.Windows.Forms.ComboBox cmbKemu;
    }
}