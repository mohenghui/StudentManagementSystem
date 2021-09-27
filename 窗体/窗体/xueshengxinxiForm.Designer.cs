namespace 窗体
{
    partial class xueshengxinxiForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("18ab班");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("18cd班");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("18ef班");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("18gh班");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("18ij班");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("计算机系", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("18ab班");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("18cd班");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("18ef班");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("18gh班");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("18ij班");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("机电系", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("18ab班");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("18cd班");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("18ef班");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("18gh班");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("18ij班");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("外国语系", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("全部", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12,
            treeNode18});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(16, 2);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点2";
            treeNode1.Text = "18ab班";
            treeNode2.Name = "节点3";
            treeNode2.Text = "18cd班";
            treeNode3.Name = "节点4";
            treeNode3.Text = "18ef班";
            treeNode4.Name = "节点5";
            treeNode4.Text = "18gh班";
            treeNode5.Name = "节点6";
            treeNode5.Text = "18ij班";
            treeNode6.Name = "节点1";
            treeNode6.Text = "计算机系";
            treeNode7.Name = "节点9";
            treeNode7.Text = "18ab班";
            treeNode8.Name = "节点10";
            treeNode8.Text = "18cd班";
            treeNode9.Name = "节点11";
            treeNode9.Text = "18ef班";
            treeNode10.Name = "节点12";
            treeNode10.Text = "18gh班";
            treeNode11.Name = "节点13";
            treeNode11.Text = "18ij班";
            treeNode12.Name = "节点7";
            treeNode12.Text = "机电系";
            treeNode13.Name = "节点14";
            treeNode13.Text = "18ab班";
            treeNode14.Name = "节点15";
            treeNode14.Text = "18cd班";
            treeNode15.Name = "节点16";
            treeNode15.Text = "18ef班";
            treeNode16.Name = "节点17";
            treeNode16.Text = "18gh班";
            treeNode17.Name = "节点18";
            treeNode17.Text = "18ij班";
            treeNode18.Name = "节点8";
            treeNode18.Text = "外国语系";
            treeNode19.Name = "节点0";
            treeNode19.Text = "全部";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode19});
            this.treeView1.Size = new System.Drawing.Size(167, 530);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(197, 9);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(753, 525);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "xuehao";
            this.Column1.HeaderText = "学号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "stuname";
            this.Column2.HeaderText = "姓名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sex";
            this.Column3.HeaderText = "性别";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GradeName";
            this.Column4.HeaderText = "年级";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Tel";
            this.Column5.HeaderText = "电话";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // xueshengxinxiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(967, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "xueshengxinxiForm";
            this.Text = "总学生信息列表";
            this.Load += new System.EventHandler(this.xueshengxinxiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}