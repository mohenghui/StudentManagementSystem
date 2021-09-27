using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 窗体
{
    public partial class NianJiSelectForm : Form
    {
        public NianJiSelectForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NianJiSelectForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nianji = cmbnianji.Text;
            
            SqlConnection conn = new SqlConnection(DBHelper.conStr);
            DataSet ds = new DataSet();
            SqlDataAdapter dap;
            string sqlstr = string.Format("select xuehao,stuname,sex,birthday from student,grade where student.gradeno=grade.gradeno and gradename='{0}'", nianji);
            dap = new SqlDataAdapter(sqlstr, conn);
            dap.Fill(ds, "student");
            SqlCommandBuilder builder = new SqlCommandBuilder(dap);
            this.dgbStudent.AutoGenerateColumns = false;
            this.dgbStudent.DataSource = ds.Tables["student"];
        }
    }
}
