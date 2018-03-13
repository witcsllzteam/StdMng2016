using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Transactions;

namespace StdMng2016.Utility
{
    public enum CmdType
    {
        CmdTxt,
        StoreProcedure
    };

    /// <summary> 
    /// DbAccess类,即进行数据库访问时需要调用的类 
    /// </summary> 
    public class DbaseCS
    {
        //取出中心数据库连接字符串
        public static string conStr = Properties.Settings.Default.StdMng2015NConnectionString;

        #region 公共方法
        /// <summary>
        /// 得到数据库连接对象
        /// </summary>
        /// <returns>数据库连接对象</returns>
        public static SqlConnection GetConObject()
        {
            return new SqlConnection(conStr);
        }

        /// <summary>
        /// 创建数据库执行命令
        /// </summary>
        /// <param name="cmd">数据库执行命令对象</param>
        /// <param name="con">数据库连接对象</param>
        /// <param name="trans">数据库事务对象</param>
        /// <param name="procOrCmdTxt">存储过程名称或Sql命令语句</param>
        /// <param name="cmdParms">存储过程所使用的参数数组</param>
        public static void CreateCommand(SqlCommand cmd, SqlConnection con, SqlTransaction trans, string procOrCmdTxt, SqlParameter[] cmdParms, CmdType cmdType)
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            cmd.Connection = con;
            cmd.CommandText = procOrCmdTxt;

            if (cmdType == CmdType.StoreProcedure)
                cmd.CommandType = CommandType.StoredProcedure;

            if (trans != null)
            {
                cmd.Transaction = trans;
            }

            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        /// <summary>
        /// 准备输入参数.
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="dbType">参数数据类型</param>
        /// <param name="size">参数大小</param>
        /// <param name="value">参数值</param>
        /// <returns>输入参数</returns>
        public static SqlParameter MakeInParam(string paramName, SqlDbType dbType, int size, object inValue)
        {
            return MakeParam(paramName, dbType, size, ParameterDirection.Input, inValue);
        }

        /// <summary>
        /// 准备输入参数.
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="dbType">参数数据类型</param>
        /// <param name="value">参数值</param>
        /// <returns>输入参数</returns>
        public static SqlParameter MakeInParam(string paramName, SqlDbType dbType, object inValue)
        {
            return MakeParam(paramName, dbType, -1, ParameterDirection.Input, inValue);
        }

        /// <summary>
        /// 准备输出参数.
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="dbType">参数数据类型</param>
        /// <param name="size">参数大小</param>		
        /// <returns>输出参数</returns>
        public static SqlParameter MakeOutParam(string paramName, SqlDbType dbType, int size)
        {
            return MakeParam(paramName, dbType, size, ParameterDirection.Output, null);
        }


        /// <summary>
        /// 准备存储过程的参数.
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="dbType">参数数据类型</param>
        /// <param name="size">参数大小</param>		
        /// <param name="direction">参数方向</param>
        /// <param name="inValue">参数值</param>
        /// <returns>输入或输出参数</returns>
        public static SqlParameter MakeParam(string paramName, SqlDbType dbType, int size, ParameterDirection direction, object inValue)
        {
            SqlParameter param;

            if (size > 0)
                param = new SqlParameter(paramName, dbType, size);
            else
                param = new SqlParameter(paramName, dbType);

            param.Direction = direction;

            if (!(direction == ParameterDirection.Output && inValue == null))
                param.Value = inValue;

            return param;
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        /// <param name="myConn">数据库连接对象</param>
        public static void Close(SqlConnection myConn)
        {
            if ((myConn != null) && (myConn.State == ConnectionState.Open))
            {
                myConn.Close();
            }
        }
        #endregion

        #region 使用传参数的方式读取数据或操作数据库，建议使用
        /// <summary>
        /// 执行操作数据库的存储过程名称或Sql命令语句,没有参数就传null值
        /// </summary>
        /// <param name="procOrCmdTxt">存储过程名称或Sql命令语句名称</param>
        /// <param name="cmdParms">存储过程名称或Sql命令语句所使用的参数</param>
        /// <param name="cmdType">命令类型</param>
        /// <returns>存储过程名称或Sql命令语句执行后所影响的行数</returns>
        public static int ExecuteNonQuery(string procOrCmdTxt, SqlParameter[] cmdParms, CmdType cmdType)
        {
            SqlCommand cmd = new SqlCommand();

            using (SqlConnection con = GetConObject())
            {
                CreateCommand(cmd, con, null, procOrCmdTxt, cmdParms, cmdType);
                int val;

                //using (TransactionScope ts = new TransactionScope())
                //{
                val = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();
                    //ts.Complete();
                //}

                return val;
            }
        }

        /// <summary>
        /// 执行操作数据库的存储过程名称或Sql命令语句(事务控制),没有参数就传null值
        /// </summary>
        /// <param name="trans">数据库连接所关联的事务对象</param>
        /// <param name="procOrCmdTxt">存储过程名称或Sql命令语句名称</param>
        /// <param name="cmdParms">存储过程名称或Sql命令语句所使用的参数</param>
        /// <param name="cmdType">命令类型</param>
        /// <returns>存储过程名称或Sql命令语句执行后所影响的行数</returns>
        public static int ExecuteNonQuery(SqlTransaction trans, string procOrCmdTxt, SqlParameter[] cmdParms, CmdType cmdType)
        {
            SqlCommand cmd = new SqlCommand();
            CreateCommand(cmd, trans.Connection, trans, procOrCmdTxt, cmdParms, cmdType);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Dispose();
            return val;
        }


        /// <summary>
        /// 得到查询结果的第一行第一列,没有参数就传null值
        /// </summary>
        /// <param name="procOrCmdTxt">存储过程名称或Sql命令语句</param>
        /// <param name="cmdParms">查询参数</param>
        /// <param name="cmdType">命令类型</param>
        /// <returns>返回一个对象</returns>
        public static object ExecuteScalar(string procOrCmdTxt, SqlParameter[] cmdParms, CmdType cmdType)
        {
            SqlCommand cmd = new SqlCommand();

            using (SqlConnection con = GetConObject())
            {
                CreateCommand(cmd, con, null, procOrCmdTxt, cmdParms, cmdType);
                object obj = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
                cmd.Dispose();
                return obj;
            }
        }

        /// <summary>
        /// 得到查询结果的第一行第一列(事务控制),没有参数就传null值
        /// </summary>
        /// <param name="trans"></param>
        /// <param name="procOrCmdTxt"></param>
        /// <param name="cmdParms"></param>
        /// <param name="cmdType"></param>
        /// <returns></returns>
        public static object ExecuteScalar(SqlTransaction trans,string procOrCmdTxt, SqlParameter[] cmdParms, CmdType cmdType)
        {
            SqlCommand cmd = new SqlCommand();
    
            CreateCommand(cmd, trans.Connection, trans, procOrCmdTxt, cmdParms, cmdType);
            object obj = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            cmd.Dispose();
            return obj;
         
        }

        /// <summary>
        /// 执行读数据集操作，以DataReader的形式返回,没有参数就传null值
        /// </summary>
        /// <param name="procOrCmdTxt">存储过程名称或Sql命令语句</param>
        /// <param name="cmdParms">存储过程名称或Sql命令语句所使用的参数</param>
        /// <param name="cmdType">命令类型</param>
        /// <returns>DataReader对象</returns>
        public static SqlDataReader ExecuteReader(string procOrCmdTxt, SqlParameter[] cmdParms, CmdType cmdType)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = GetConObject();
            CreateCommand(cmd, con, null, procOrCmdTxt, cmdParms, cmdType);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            cmd.Parameters.Clear();
            return dr;

        }

        /// <summary>
        /// 执行读数据集操作，以DataSet的形式返回,没有参数就传null值
        /// </summary>
        /// <param name="procOrCmdTxt">存储过程名称或Sql命令语句</param>
        /// <param name="cmdParms">存储过程名称或Sql命令语句所使用的参数</param>
        /// <param name="cmdType">命令类型</param>
        /// <returns>DataSet对象</returns>
        public static DataSet ExecuteDataSet(string procOrCmdTxt, SqlParameter[] cmdParms, CmdType cmdType)
        {
            SqlCommand cmd = new SqlCommand(); ;
            DataSet ds = new DataSet();

            using (SqlConnection con = GetConObject())
            {
                CreateCommand(cmd, con, null, procOrCmdTxt, cmdParms, cmdType);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                cmd.Parameters.Clear();
                return ds;
            }
        }

        #endregion

        #region 直接执行Sql语句，建议仅在测试时使用，正式代码中不要用！！

        /// <summary>
        /// 直接执行sql语句返回数据集
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <returns>查询的数据集</returns>
        public static DataSet ExecuteDataSetSql(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = GetConObject();
            DataSet ds = new DataSet();
            SqlDataAdapter da = null;

            try
            {
                da = new SqlDataAdapter(strSql, con);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (da != null)
                    da.Dispose();

                cmd.Dispose();
                Close(con);
            }
        }

        /// <summary>
        /// 直接运行sql语句
        /// </summary>
        /// <param name="trans">事务</param>
        /// <param name="strSql">sql语句</param>
        public static void ExecuteSql(SqlTransaction trans, string strSql)
        {
            SqlCommand cmd = new SqlCommand();

            try
            {
                cmd.Connection = trans.Connection;
                cmd.Transaction = trans;
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
            }
        }

        /// <summary>
        /// 直接运行sql语句
        /// </summary>   
        /// <param name="strSql">sql语句</param>
        public static void ExecuteSql(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = GetConObject();

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                cmd.Connection = con;
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                Close(con);
            }
        }

        /// <summary>
        /// 得到查询结果的第一行第一列
        /// </summary>
        /// <param name="strSql">查询语句</param>
        /// <returns>返回一个对象</returns>
        public static Object GetValue(string strSql)
        {
            Object obj;
            SqlConnection myConn = null;

            try
            {
                myConn = new SqlConnection(conStr);
                SqlCommand mycommand = new SqlCommand(strSql, myConn);
                myConn.Open();
                obj = mycommand.ExecuteScalar();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                Close(myConn);
            }
            return obj;

        }
        #endregion
    }
}
