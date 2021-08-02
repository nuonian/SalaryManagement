using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagement.Common
{
    class Dao
    {
        public SqlConnection sc;
        #region 获得数据库链接对象
        /// <summary>
        /// 获得数据库链接对象
        /// </summary>
        /// <returns></returns>
        public SqlConnection connect()
        {
            string str = @"Data Source=DESKTOP-ABAS92R;Initial Catalog=SalaryManagement;Integrated Security=True";
            sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }
        #endregion
        #region 获得数据库操作对象
        /// <summary>
        /// 获得数据库操作对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        #endregion
        #region 更新操作
        /// <summary>
        /// 更新操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }
        #endregion
        #region 读取操作
        /// <summary>
        /// 读取操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
        #endregion
        #region 关闭数据库
        /// <summary>
        /// 关闭数据库
        /// </summary>
        public void DaoClose()
        {
            sc.Close();
        }
        #endregion
    }
}
