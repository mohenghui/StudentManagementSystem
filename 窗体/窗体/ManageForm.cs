using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体
{
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            NianJiSelectForm form5 = new NianJiSelectForm();
            form5.Show();
            form5.MdiParent = this;
        }

        private void 科目管理CToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            InsertForm form3 = new InsertForm();
            form3.Show();
            form3.MdiParent = this;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            XingmSelectForm form4 = new XingmSelectForm();
            form4.Show();
            form4.MdiParent = this;
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            xueshengxinxiForm xuesheng = new xueshengxinxiForm();
            xuesheng.Show();
            xuesheng.MdiParent = this;
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            KeMuForm form7 = new KeMuForm();
            form7.Show();
            form7.MdiParent = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            TeacherForm teacher = new TeacherForm();
            teacher.Show();
            teacher.MdiParent = this;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            scorePaiMing scorepm = new scorePaiMing();
            scorepm.Show();
            scorepm.MdiParent = this;
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            tianjiachengji tianjia = new tianjiachengji();
            tianjia.Show();
            tianjia.MdiParent = this;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
           
            DialogResult dt= MessageBox.Show("确定是否退出？","系统提示",MessageBoxButtons.OKCancel);
            if (dt == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            { 
            
            }
        }

        private void ManageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripButton10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
