using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace 窗体
{
    class DBHelper
    {
        //数据库连接字符串
        public static string conStr = "server=.;database=student1;Integrated Security=true";

        //数据库连接对象
        private static SqlConnection conn = null;

        //初始化数据库连接
        private static void InitConnection()
        {
            //如果连接对象不存在，则创建连接
            if (conn == null)
                conn = new SqlConnection(conStr);
            //如果连接对象关闭，则打开连接
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            //如果连接中断，则重启连接
            if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }

        //查询，获取DataReader
        public static SqlDataReader GetDataReader(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        //查询，获取DataTable
        public static DataTable GetDataTable(string sqlstr)
        {
            InitConnection();
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sqlstr, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }

        //增删改
        public static bool ExecuteNonQuery(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        //执行集合函数
        public static object ExecuteScalar(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            object result = cmd.ExecuteScalar();
            conn.Close();
            return result;

        }
    }     
}
