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
    public partial class scorePaiMing : Form
    {
        public scorePaiMing()
        {
            InitializeComponent();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            string course = cmbCourse.Text;

            SqlConnection conn = new SqlConnection(DBHelper.conStr);
            DataSet ds = new DataSet();
            SqlDataAdapter dap;
            string sqlstr = string.Format("select * from score where course='{0}' order by score desc", course);
            dap = new SqlDataAdapter(sqlstr, conn);
            dap.Fill(ds, "score");
            SqlCommandBuilder builder = new SqlCommandBuilder(dap);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables["score"];
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
