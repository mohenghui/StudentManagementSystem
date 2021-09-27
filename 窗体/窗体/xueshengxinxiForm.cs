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
    public partial class xueshengxinxiForm : Form
    {
        public xueshengxinxiForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string i = treeView1.SelectedNode.Text;

            string sqlstr = "";

            switch (i)
            {
                case "全部": sqlstr = "select * from student,grade where student.gradeno=grade.gradeno"; break;
                case "计算机系": sqlstr = "select * from student,grade,xibu where student.gradeno=grade.gradeno and student.xibuid=xibu.xibuid and xibuname='计算机系'"; break;
                case "机电系": sqlstr = "select * from student,grade,xibu where student.gradeno=grade.gradeno and student.xibuid=xibu.xibuid and xibuname='机电系'"; break;
                case "外国语系": sqlstr = "select * from student,grade,xibu where student.gradeno=grade.gradeno and student.xibuid=xibu.xibuid and xibuname='外国语系'"; break;

                default:
                    break;
            }


            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[0].Nodes[0])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='计算机系' and classname='18ab班' ";

            }
            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[0].Nodes[1])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='计算机系' and classname='18cd班'";
            }
            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[0].Nodes[2])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='计算机系' and classname='18ef班'";
            }
            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[0].Nodes[3])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='计算机系' and classname='18gh班'";
            }
            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[0].Nodes[4])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='计算机系' and classname='18ij班'";
            }

            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[1].Nodes[0])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='机电系' and classname='18ab班' ";
            }
            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[1].Nodes[1])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='机电系' and classname='18cd班'";
            }
            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[1].Nodes[2])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='机电系' and classname='18ef班'";
            }
            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[1].Nodes[3])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='机电系' and classname='18gh班'";
            }
            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[1].Nodes[4])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='机电系' and classname='18ij班'";
            }

            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[2].Nodes[0])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='外国语系' and classname='18ab班' ";
            }
            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[2].Nodes[1])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='外国语系' and classname='18cd班'";
            }
            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[2].Nodes[2])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='外国语系' and classname='18ef班'";
            }
            
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[2].Nodes[3])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='外国语系' and classname='18gh班'";
            }

            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[2].Nodes[4])
            {
                sqlstr = "select * from student,grade,class,xibu where student.gradeno=grade.gradeno and student.classno=class.classno and student.xibuid=xibu.xibuid and xibuname='外国语系' and classname='18ij班'";
            }

            DataTable dt = DBHelper.GetDataTable(sqlstr);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = dt;
            
        }

        private void xueshengxinxiForm_Load(object sender, EventArgs e)
        {
            string sqlstr = "select * from student,grade where student.gradeno=grade.gradeno";
            DataTable dt = DBHelper.GetDataTable(sqlstr);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = dt;
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
