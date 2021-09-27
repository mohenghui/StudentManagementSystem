namespace 窗体
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbname = new System.Windows.Forms.TextBox();
            this.txbpwd = new System.Windows.Forms.TextBox();
            this.btnTianJia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // txbname
            // 
            this.txbname.Location = new System.Drawing.Point(121, 55);
            this.txbname.Margin = new System.Windows.Forms.Padding(4);
            this.txbname.Name = "txbname";
            this.txbname.Size = new System.Drawing.Size(188, 25);
            this.txbname.TabIndex = 2;
            // 
            // txbpwd
            // 
            this.txbpwd.Location = new System.Drawing.Point(121, 131);
            this.txbpwd.Margin = new System.Windows.Forms.Padding(4);
            this.txbpwd.Name = "txbpwd";
            this.txbpwd.Size = new System.Drawing.Size(188, 25);
            this.txbpwd.TabIndex = 3;
            // 
            // btnTianJia
            // 
            this.btnTianJia.Location = new System.Drawing.Point(121, 238);
            this.btnTianJia.Margin = new System.Windows.Forms.Padding(4);
            this.btnTianJia.Name = "btnTianJia";
            this.btnTianJia.Size = new System.Drawing.Size(100, 29);
            this.btnTianJia.TabIndex = 4;
            this.btnTianJia.Text = "添加";
            this.btnTianJia.UseVisualStyleBackColor = true;
            this.btnTianJia.Click += new System.EventHandler(this.btnTianJia_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(389, 393);
            this.Controls.Add(this.btnTianJia);
            this.Controls.Add(this.txbpwd);
            this.Controls.Add(this.txbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeacherForm";
            this.Text = "添加老师账号";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbname;
        private System.Windows.Forms.TextBox txbpwd;
        private System.Windows.Forms.Button btnTianJia;
    }
}