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
    /// DbAccess��,���������ݿ����ʱ��Ҫ���õ��� 
    /// </summary> 
    public class DbaseCS
    {
        //ȡ���������ݿ������ַ���
        public static string conStr = Properties.Settings.Default.StdMng2015NConnectionString;

        #region ��������
        /// <summary>
        /// �õ����ݿ����Ӷ���
        /// </summary>
        /// <returns>���ݿ����Ӷ���</returns>
        public static SqlConnection GetConObject()
        {
            return new SqlConnection(conStr);
        }

        /// <summary>
        /// �������ݿ�ִ������
        /// </summary>
        /// <param name="cmd">���ݿ�ִ���������</param>
        /// <param name="con">���ݿ����Ӷ���</param>
        /// <param name="trans">���ݿ��������</param>
        /// <param name="procOrCmdTxt">�洢�������ƻ�Sql�������</param>
        /// <param name="cmdParms">�洢������ʹ�õĲ�������</param>
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
        /// ׼���������.
        /// </summary>
        /// <param name="paramName">��������</param>
        /// <param name="dbType">������������</param>
        /// <param name="size">������С</param>
        /// <param name="value">����ֵ</param>
        /// <returns>�������</returns>
        public static SqlParameter MakeInParam(string paramName, SqlDbType dbType, int size, object inValue)
        {
            return MakeParam(paramName, dbType, size, ParameterDirection.Input, inValue);
        }

        /// <summary>
        /// ׼���������.
        /// </summary>
        /// <param name="paramName">��������</param>
        /// <param name="dbType">������������</param>
        /// <param name="value">����ֵ</param>
        /// <returns>�������</returns>
        public static SqlParameter MakeInParam(string paramName, SqlDbType dbType, object inValue)
        {
            return MakeParam(paramName, dbType, -1, ParameterDirection.Input, inValue);
        }

        /// <summary>
        /// ׼���������.
        /// </summary>
        /// <param name="paramName">��������</param>
        /// <param name="dbType">������������</param>
        /// <param name="size">������С</param>		
        /// <returns>�������</returns>
        public static SqlParameter MakeOutParam(string paramName, SqlDbType dbType, int size)
        {
            return MakeParam(paramName, dbType, size, ParameterDirection.Output, null);
        }


        /// <summary>
        /// ׼���洢���̵Ĳ���.
        /// </summary>
        /// <param name="paramName">��������</param>
        /// <param name="dbType">������������</param>
        /// <param name="size">������С</param>		
        /// <param name="direction">��������</param>
        /// <param name="inValue">����ֵ</param>
        /// <returns>������������</returns>
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
        /// �ر����ݿ�����
        /// </summary>
        /// <param name="myConn">���ݿ����Ӷ���</param>
        public static void Close(SqlConnection myConn)
        {
            if ((myConn != null) && (myConn.State == ConnectionState.Open))
            {
                myConn.Close();
            }
        }
        #endregion

        #region ʹ�ô������ķ�ʽ��ȡ���ݻ�������ݿ⣬����ʹ��
        /// <summary>
        /// ִ�в������ݿ�Ĵ洢�������ƻ�Sql�������,û�в����ʹ�nullֵ
        /// </summary>
        /// <param name="procOrCmdTxt">�洢�������ƻ�Sql�����������</param>
        /// <param name="cmdParms">�洢�������ƻ�Sql���������ʹ�õĲ���</param>
        /// <param name="cmdType">��������</param>
        /// <returns>�洢�������ƻ�Sql�������ִ�к���Ӱ�������</returns>
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
        /// ִ�в������ݿ�Ĵ洢�������ƻ�Sql�������(�������),û�в����ʹ�nullֵ
        /// </summary>
        /// <param name="trans">���ݿ��������������������</param>
        /// <param name="procOrCmdTxt">�洢�������ƻ�Sql�����������</param>
        /// <param name="cmdParms">�洢�������ƻ�Sql���������ʹ�õĲ���</param>
        /// <param name="cmdType">��������</param>
        /// <returns>�洢�������ƻ�Sql�������ִ�к���Ӱ�������</returns>
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
        /// �õ���ѯ����ĵ�һ�е�һ��,û�в����ʹ�nullֵ
        /// </summary>
        /// <param name="procOrCmdTxt">�洢�������ƻ�Sql�������</param>
        /// <param name="cmdParms">��ѯ����</param>
        /// <param name="cmdType">��������</param>
        /// <returns>����һ������</returns>
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
        /// �õ���ѯ����ĵ�һ�е�һ��(�������),û�в����ʹ�nullֵ
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
        /// ִ�ж����ݼ���������DataReader����ʽ����,û�в����ʹ�nullֵ
        /// </summary>
        /// <param name="procOrCmdTxt">�洢�������ƻ�Sql�������</param>
        /// <param name="cmdParms">�洢�������ƻ�Sql���������ʹ�õĲ���</param>
        /// <param name="cmdType">��������</param>
        /// <returns>DataReader����</returns>
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
        /// ִ�ж����ݼ���������DataSet����ʽ����,û�в����ʹ�nullֵ
        /// </summary>
        /// <param name="procOrCmdTxt">�洢�������ƻ�Sql�������</param>
        /// <param name="cmdParms">�洢�������ƻ�Sql���������ʹ�õĲ���</param>
        /// <param name="cmdType">��������</param>
        /// <returns>DataSet����</returns>
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

        #region ֱ��ִ��Sql��䣬������ڲ���ʱʹ�ã���ʽ�����в�Ҫ�ã���

        /// <summary>
        /// ֱ��ִ��sql��䷵�����ݼ�
        /// </summary>
        /// <param name="strSql">sql���</param>
        /// <returns>��ѯ�����ݼ�</returns>
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
        /// ֱ������sql���
        /// </summary>
        /// <param name="trans">����</param>
        /// <param name="strSql">sql���</param>
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
        /// ֱ������sql���
        /// </summary>   
        /// <param name="strSql">sql���</param>
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
        /// �õ���ѯ����ĵ�һ�е�һ��
        /// </summary>
        /// <param name="strSql">��ѯ���</param>
        /// <returns>����һ������</returns>
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
