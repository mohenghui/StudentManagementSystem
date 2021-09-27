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
    public partial class KeMuForm : Form
    {
        public KeMuForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string class1 = cmbgrade.Text;

            //SqlConnection conn = new SqlConnection(DBHelper.conStr);
            //DataSet ds = new DataSet();
            //SqlDataAdapter dap;
            string sqlstr = string.Format("select CouName,ClassName,GradeName from course,class,grade where Course.ClassNo=Class.ClassNO and Grade.GradeNo=Course.GradeNo and ClassName='{0}'", class1);
            this.dgvgrade.AutoGenerateColumns = false;
            dgvgrade.DataSource = DBHelper.GetDataTable(sqlstr);     

            //dap = new SqlDataAdapter(sqlstr, conn);
            //dap.Fill(ds, "grade");
            //SqlCommandBuilder builder = new SqlCommandBuilder(dap);

            //this.dgvgrade.DataSource = ds.Tables["grade"];
        }

        private void Dgvgrade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cmbgrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
