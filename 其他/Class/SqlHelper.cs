using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Reflection;

namespace Tools
{
    public sealed class SqlHelper
    {
        #region 连接字符串

        /// <summary>
        /// 连接字符串
        /// </summary>
        private string ConStr;

        #endregion

        #region 构造

        public SqlHelper(string DBServer, string DBUser, string DBPassword, string DBName)
        {
            this.ConStr = string.Format("server={0};uid={1};pwd={2};database={3};", DBServer, DBUser, DBPassword, DBName);
        }

        public SqlHelper(string connectionString)
        {
            this.ConStr = connectionString;
        }

        #endregion

        #region 测试连接

        /// <summary>
        /// 测试连接
        /// </summary>
        /// <returns></returns>
        public bool ConnectionTest()
        {
            return ConnectionTest(ConStr);
        }

        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="DBServer">数据库服务器</param>
        /// <param name="DBUser">数据库用户</param>
        /// <param name="DBPassword">数据库密码</param>
        /// <param name="DBName">数据库名</param>
        /// <returns></returns>
        public bool ConnectionTest(string DBServer, string DBUser, string DBPassword, string DBName)
        {
            string connectionString = string.Format("server={0};uid={1};pwd={2};database={3};", DBServer, DBUser, DBPassword, DBName);
            return ConnectionTest(connectionString);
        }

        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="ConStr">连接字符串</param>
        /// <returns></returns>
        public bool ConnectionTest(string connectionString)
        {
            SqlConnection sqlcon = new SqlConnection(connectionString);
            try
            {
                sqlcon.Open();
                sqlcon.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region 获取受影响行数

        /// <summary>
        /// 执行命令语句
        /// </summary>
        /// <param name="comdText">命令语句</param>
        /// <param name="comdParam">命令参数</param>
        /// <returns>受影响行数</returns>
        public int ExecComd(string comdText, params SqlParameter[] sqlParam)
        {
            return ExecNonQuery(comdText, CommandType.Text, sqlParam);
        }

        public int ExecComd(string comdText, dynamic sqlParam)
        {
            return ExecNonQuery(comdText, CommandType.Text, ToSqlParameters(sqlParam));
        }

        public int ExecComd<T>(string comdText, T sqlParam)
        {
            return ExecNonQuery(comdText, CommandType.Text, ToSqlParameters<T>(sqlParam));
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="procParam">存储过程参数</param>
        /// <returns>受影响行数</returns>
        public int ExecProc(string procName, params SqlParameter[] sqlParam)
        {
            return ExecNonQuery(procName, CommandType.StoredProcedure, sqlParam);
        }

        public int ExecProc(string procName, dynamic sqlParam)
        {
            return ExecNonQuery(procName, CommandType.StoredProcedure, ToSqlParameters(sqlParam));
        }

        public int ExecProc<T>(string procName, T sqlParam)
        {
            return ExecNonQuery(procName, CommandType.StoredProcedure, ToSqlParameters<T>(sqlParam));
        }

        /// <summary>
        /// 获取受影响行数
        /// </summary>
        /// <param name="sqlText">sql文本</param>
        /// <param name="sqlType">执行类型</param>
        /// <param name="sqlParam">参数对象</param>
        /// <returns>受影响行数</returns>
        private int ExecNonQuery(string sqlText, CommandType sqlType, params SqlParameter[] sqlParam)
        {
            using (SqlConnection sqlcon = new SqlConnection(ConStr))
            {
                try
                {
                    sqlcon.Open();
                    SqlCommand sqlcom = CreateCommand(sqlText, sqlcon, sqlType, sqlParam);
                    return sqlcom.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    sqlcon.Close();
                }
            }
        }

        #endregion

        #region 获取查询结果集第一行第一列对象

        /// <summary>
        /// 执行命令语句
        /// </summary>
        /// <param name="comdText">命令语句</param>
        /// <param name="comdParam">命令参数</param>
        /// <returns>受影响行数</returns>
        public object ExecComdToObject(string comdText, params SqlParameter[] sqlParam)
        {
            return ExecScalar(comdText, CommandType.Text, sqlParam);
        }

        public object ExecComdToObject(string comdText, dynamic sqlParam)
        {
            return ExecScalar(comdText, CommandType.Text, ToSqlParameters(sqlParam));
        }

        public object ExecComdToObject<T>(string comdText, T sqlParam)
        {
            return ExecScalar(comdText, CommandType.Text, ToSqlParameters<T>(sqlParam));
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="procParam">存储过程参数</param>
        /// <returns>受影响行数</returns>
        public object ExecProcToObject(string procName, params SqlParameter[] sqlParam)
        {
            return ExecScalar(procName, CommandType.StoredProcedure, sqlParam);
        }

        public object ExecProcToObject(string procName, dynamic sqlParam)
        {
            return ExecScalar(procName, CommandType.StoredProcedure, ToSqlParameters(sqlParam));
        }

        public object ExecProcToObject<T>(string procName, T sqlParam)
        {
            return ExecScalar(procName, CommandType.StoredProcedure, ToSqlParameters<T>(sqlParam));
        }

        /// <summary>
        /// 获取查询结果集第一行第一列对象
        /// </summary>
        /// <param name="sqlText">sql文本</param>
        /// <param name="sqlType">执行类型</param>
        /// <param name="sqlParam">参数对象</param>
        /// <returns>结果集第一行第一列对象</returns>
        private object ExecScalar(string sqlText, CommandType sqlType, params SqlParameter[] sqlParam)
        {
            using (SqlConnection sqlcon = new SqlConnection(ConStr))
            {
                try
                {
                    sqlcon.Open();
                    SqlCommand sqlcom = CreateCommand(sqlText, sqlcon, sqlType, sqlParam);
                    return sqlcom.ExecuteScalar();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    sqlcon.Close();
                }
            }
        }

        #endregion

        #region 获取DataSet

        /// <summary>
        /// 执行命令语句
        /// </summary>
        /// <param name="comdText">命令文本</param>
        /// <param name="comdParam">参数对象</param>
        /// <returns>DataSet</returns>
        public DataSet ExecComdToDataSet(string comdText, params SqlParameter[] sqlParam)
        {
            return GetDataSet(comdText, CommandType.Text, sqlParam);
        }

        public DataSet ExecComdToDataSet(string comdText, dynamic sqlParam)
        {
            return GetDataSet(comdText, CommandType.Text, ToSqlParameters(sqlParam));
        }

        public DataSet ExecComdToDataSet<T>(string comdText, T sqlParam)
        {
            return GetDataSet(comdText, CommandType.Text, ToSqlParameters(sqlParam));
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="prams">参数对象</param>
        /// <returns>DataSet</returns>
        public DataSet ExecProcToDataSet(string procName, params SqlParameter[] sqlParam)
        {
            return GetDataSet(procName, CommandType.StoredProcedure, sqlParam);
        }

        public DataSet ExecProcToDataSet(string procName, dynamic sqlParam)
        {
            return GetDataSet(procName, CommandType.StoredProcedure, ToSqlParameters(sqlParam));
        }

        public DataSet ExecProcToDataSet<T>(string procName, T sqlParam)
        {
            return GetDataSet(procName, CommandType.StoredProcedure, ToSqlParameters(sqlParam));
        }

        /// <summary>
        /// 获取DataSet
        /// </summary>
        /// <param name="sqlText">sql文本</param>
        /// <param name="sqlType">执行类型</param>
        /// <param name="prams">参数对象</param>
        /// <returns>DataSet对象</returns>
        private DataSet GetDataSet(string sqlText, CommandType sqlType, params SqlParameter[] sqlParam)
        {
            using (SqlConnection sqlcon = new SqlConnection(ConStr))
            {
                try
                {
                    SqlDataAdapter sqlda = CreateDataAdapter(sqlText, sqlcon, sqlType, sqlParam);
                    DataSet ds = new DataSet();
                    sqlda.Fill(ds);
                    return ds;
                }
                catch
                {
                    throw;
                }
                finally
                {
                    sqlcon.Close();
                }
            }
        }

        #endregion

        #region 获取SqlDataReader

        /// <summary>
        /// 执行语句
        /// </summary>
        /// <param name="comdText">命令文本</param>
        /// <param name="comdParam">命令参数</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader ExecComdToSqlDataReader(string comdText, params SqlParameter[] sqlParam)
        {
            return GetSqlDataReader(comdText, CommandType.Text, sqlParam);
        }

        public SqlDataReader ExecComdToSqlDataReader(string comdText, dynamic sqlParam)
        {
            return GetSqlDataReader(comdText, CommandType.Text, ToSqlParameters(sqlParam));
        }

        public SqlDataReader ExecComdToSqlDataReader<T>(string comdText, T sqlParam)
        {
            return GetSqlDataReader(comdText, CommandType.Text, ToSqlParameters(sqlParam));
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="procParam">存储过程参数</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader ExecProcToSqlDataReader(string procName, params SqlParameter[] sqlParam)
        {
            return GetSqlDataReader(procName, CommandType.StoredProcedure, sqlParam);
        }

        public SqlDataReader ExecProcToSqlDataReader(string procName, dynamic sqlParam)
        {
            return GetSqlDataReader(procName, CommandType.StoredProcedure, ToSqlParameters(sqlParam));
        }

        public SqlDataReader ExecProcToSqlDataReader<T>(string procName, T sqlParam)
        {
            return GetSqlDataReader(procName, CommandType.StoredProcedure, ToSqlParameters(sqlParam));
        }

        /// <summary>
        /// 获取SqlDataReader对象
        /// </summary>
        /// <param name="sqlText">sql文本</param>
        /// <param name="sqlType">执行类型</param>
        /// <param name="sqlParam">参数对象</param>
        /// <returns>SqlDataReader对象</returns>
        private SqlDataReader GetSqlDataReader(string sqlText, CommandType sqlType, params SqlParameter[] sqlParam)
        {
            SqlConnection sqlcon = new SqlConnection(ConStr);
            try
            {
                sqlcon.Open();
                SqlCommand sqlcom = CreateCommand(sqlText, sqlcon, sqlType, sqlParam);
                return sqlcom.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                sqlcon.Close();
                throw;
            }
        }

        #endregion

        #region 获取List

        /// <summary>
        /// 执行语句
        /// </summary>
        /// <param name="comdText">命令文本</param>
        /// <param name="comdParam">命令参数</param>
        /// <returns>List</returns>
        public List<T> ExecComdToList<T>(string comdText, params SqlParameter[] sqlParam) where T : new()
        {
            List<T> list = new List<T>();
            SqlDataReader sdr = ExecComdToSqlDataReader(comdText, sqlParam);
            while (sdr.Read()) list.Add(CreateModel<T>(sdr));
            sdr.Close();
            return list;
        }

        public List<T> ExecComdToList<T>(string comdText, dynamic sqlParam) where T : new()
        {
            return ExecComdToList<T>(comdText, ToSqlParameters(sqlParam));
        }

        public List<T> ExecComdToList<T>(string comdText, T sqlParam) where T : new()
        {
            return ExecComdToList<T>(comdText, ToSqlParameters(sqlParam));
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="procParam">存储过程参数</param>
        /// <returns>List</returns>
        public List<T> ExecProcToList<T>(string procName, params SqlParameter[] sqlParam) where T : new()
        {
            List<T> list = new List<T>();
            SqlDataReader sdr = ExecProcToSqlDataReader(procName, sqlParam);
            while (sdr.Read()) list.Add(CreateModel<T>(sdr));
            sdr.Close();
            return list;
        }

        public List<T> ExecProcToList<T>(string procName, dynamic sqlParam) where T : new()
        {
            return ExecProcToList<T>(procName, ToSqlParameters(sqlParam));
        }

        public List<T> ExecProcToList<T>(string procName, T sqlParam) where T : new()
        {
            return ExecProcToList<T>(procName, ToSqlParameters(sqlParam));
        }

        /// <summary>
        /// 创建Model实例
        /// </summary>
        private T CreateModel<T>(SqlDataReader sdr) where T : new()
        {
            T obj = new T();
            for (int i = 0; i < sdr.FieldCount; i++)
            {
                PropertyInfo info = obj.GetType().GetProperty(sdr.GetName(i));
                if (info != null)
                {
                    object value = sdr.GetValue(i);
                    if (value == DBNull.Value)
                        value = null;
                    else
                        value = ChangeType(value, info.PropertyType);
                    info.SetValue(obj, value, null);
                }
            }
            return obj;
        }

        /// <summary>
        /// 通用类型转换
        /// </summary>
        private static object ChangeType(object value, Type type)
        {
            if (value == null && type.IsGenericType) return Activator.CreateInstance(type);
            if (value == null) return null;
            if (type == value.GetType()) return value;
            if (type.IsEnum)
            {
                if (value is string)
                    return Enum.Parse(type, value as string);
                else
                    return Enum.ToObject(type, value);
            }
            if (!type.IsInterface && type.IsGenericType)
            {
                Type innerType = type.GetGenericArguments()[0];
                object innerValue = ChangeType(value, innerType);
                return Activator.CreateInstance(type, new object[] { innerValue });
            }
            if (value is string && type == typeof(Guid)) return new Guid(value as string);
            if (value is string && type == typeof(Version)) return new Version(value as string);
            if (!(value is IConvertible)) return value;
            return Convert.ChangeType(value, type);
        }
        #endregion

        #region 执行事务

        /// <summary>
        /// 事务基本对象
        /// </summary>
        SqlConnection sqlTranCon;
        SqlCommand sqlTranCom;
        SqlTransaction sqlTran;
        int affectRowsCount;
        public int AffectRowsCount { get { return affectRowsCount; } }

        /// <summary>
        /// 事务开始
        /// </summary>
        public void ExecTranBegin()
        {
            sqlTranCon = new SqlConnection(ConStr);
            sqlTranCon.Open();
            sqlTran = sqlTranCon.BeginTransaction();
            sqlTranCom = CreateCommand(sqlTranCon);
            sqlTranCom.Transaction = sqlTran;
            affectRowsCount = 0;
        }

        /// <summary>
        /// 事务提交
        /// </summary>
        public int ExecTranCommit()
        {
            if (sqlTranCon.State == ConnectionState.Open)
            {
                sqlTran.Commit();
                sqlTranCon.Close();
                return affectRowsCount;
            }
            return 0;
        }

        /// <summary>
        /// 事务回滚
        /// </summary>
        public int ExecTranRollback()
        {
            if (sqlTranCon.State == ConnectionState.Open)
            {
                sqlTran.Rollback();
                sqlTranCon.Close();
                return affectRowsCount;
            }
            return 0;
        }

        /// <summary>
        /// 事务执行命令语句
        /// </summary>
        /// <param name="comdText">命令语句</param>
        /// <param name="comdParam">命令参数</param>
        /// <returns>受影响行数</returns>
        public int ExecTranComd(string comdText, params SqlParameter[] sqlParam)
        {
            return ExecTran(comdText, CommandType.Text, sqlParam);
        }

        public int ExecTranComd(string comdText, dynamic sqlParam)
        {
            return ExecTran(comdText, CommandType.Text, ToSqlParameters(sqlParam));
        }

        public int ExecTranComd<T>(string procName, T sqlParam)
        {
            return ExecTran(procName, CommandType.Text, ToSqlParameters<T>(sqlParam));
        }

        /// <summary>
        /// 事务执行存储过程
        /// </summary>
        /// <param name="procName">存储过程名</param>
        /// <param name="procParam">存储过程参数</param>
        /// <returns>受影响行数</returns>
        public int ExecTranProc(string procName, params SqlParameter[] sqlParam)
        {
            return ExecTran(procName, CommandType.StoredProcedure, sqlParam);
        }

        public int ExecTranProc(string procName, dynamic sqlParam)
        {
            return ExecTran(procName, CommandType.StoredProcedure, ToSqlParameters(sqlParam));
        }

        public int ExecTranProc<T>(string procName, T sqlParam)
        {
            return ExecTran(procName, CommandType.StoredProcedure, ToSqlParameters<T>(sqlParam));
        }

        /// <summary>
        /// 事务执行
        /// </summary>
        /// <param name="sqlText">sql文本</param>
        /// <param name="sqlType">执行类型</param>
        /// <param name="sqlParam">参数对象</param>
        /// <returns>受影响行数</returns>
        private int ExecTran(string sql, CommandType cmdType, params SqlParameter[] sqlParam)
        {
            try
            {
                sqlTranCom.CommandText = sql;
                sqlTranCom.CommandType = cmdType;
                sqlTranCom.Parameters.AddRange(sqlParam);
                int n = sqlTranCom.ExecuteNonQuery();
                affectRowsCount += n;
                sqlTranCom.Parameters.Clear();
                return n;
            }
            catch
            {
                sqlTran.Rollback();
                sqlTranCon.Close();
                throw;
            }
        }

        #endregion

        #region 创建SqlCommand对象

        /// <summary>
        /// 创建SqlCommand对象
        /// </summary>
        /// <param name="sqlcon">连接对象</param>
        /// <returns>返回SqlCommand对象</returns>
        private SqlCommand CreateCommand(SqlConnection sqlcon)
        {
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = sqlcon;
            return sqlcom;
        }

        /// <summary>
        /// 创建SqlCommand对象
        /// </summary>
        /// <param name="sqlcon">连接对象</param>
        /// <param name="cmdType">命令类型</param>
        /// <returns>返回SqlCommand对象</returns>
        private SqlCommand CreateCommand(SqlConnection sqlcon, CommandType cmdType)
        {
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = sqlcon;
            sqlcom.CommandType = cmdType;
            return sqlcom;
        }

        /// <summary>
        /// 创建SqlCommand对象
        /// </summary>
        /// <param name="commandText">命令文本</param>
        /// <param name="sqlcon">连接对象</param>
        /// <param name="prams">参数对象</param>
        /// <returns>返回SqlCommand对象</returns>
        private SqlCommand CreateCommand(string procCmd, SqlConnection sqlcon, CommandType cmdType, params SqlParameter[] prams)
        {
            SqlCommand sqlcom = new SqlCommand(procCmd, sqlcon);
            sqlcom.CommandType = cmdType;
            if (prams != null) sqlcom.Parameters.AddRange(prams);
            return sqlcom;
        }

        #endregion

        #region 创建SqlDataAdapter对象

        /// <summary>
        /// 创建SqlDataAdapter对象
        /// </summary>
        /// <param name="procName">命令文本</param>
        /// <param name="prams">参数对象</param>
        /// <returns>返回SqlDataAdapter对象</returns>
        private SqlDataAdapter CreateDataAdapter(string procCmd, SqlConnection sqlcon, CommandType cmdType, params SqlParameter[] sqlParam)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(procCmd, sqlcon);
            sqlda.SelectCommand.CommandType = cmdType;
            if (sqlParam != null) sqlda.SelectCommand.Parameters.AddRange(sqlParam);
            return sqlda;
        }

        #endregion

        #region sql参数

        /// <summary>
        /// 输入参数
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="DbType">参数类型</param>
        /// <param name="size">参数大小</param>
        /// <param name="value">参数值</param>
        /// <returns>SqlParameter对象</returns>
        public SqlParameter MakeInParam(string paramName, SqlDbType DbType, int size, object value = null)
        {
            return MakeParam(paramName, DbType, size, ParameterDirection.Input, value);
        }

        /// <summary>
        /// 输出参数
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="DbType">参数类型</param>
        /// <param name="size">参数大小</param>
        /// <param name="value">参数值</param>
        /// <returns>SqlParameter对象</returns>
        public SqlParameter MakeOutParam(string paramName, SqlDbType DbType, int size, object value = null)
        {
            return MakeParam(paramName, DbType, size, ParameterDirection.Output, value);
        }

        /// <summary>
        /// 输入输出参数
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="DbType">参数类型</param>
        /// <param name="size">参数大小</param>
        /// <param name="value">参数值</param>
        /// <returns>SqlParameter对象</returns>
        public SqlParameter MakeInOutParam(string paramName, SqlDbType DbType, int size, object value = null)
        {
            return MakeParam(paramName, DbType, size, ParameterDirection.InputOutput, value);
        }

        /// <summary>
        /// 返回值参数
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="DbType">参数类型</param>
        /// <param name="size">参数大小</param>
        /// <param name="value">参数值</param>
        /// <returns>SqlParameter对象</returns>
        public SqlParameter MakeRetValParam(string paramName, SqlDbType DbType, int size, object value = null)
        {
            return MakeParam(paramName, DbType, size, ParameterDirection.ReturnValue, value);
        }

        /// <summary>
        /// 初始化参数值
        /// </summary>
        /// <param name="paramName">参数名称</param>
        /// <param name="DbType">参数类型</param>
        /// <param name="size">参数大小</param>
        /// <param name="Direction">参数方向</param>
        /// <param name="value">参数值</param>
        /// <returns>SqlParameter对象</returns>
        private SqlParameter MakeParam(string paramName, SqlDbType DbType, int size, ParameterDirection Direction, object value = null)
        {
            SqlParameter param = size > 0 ?
                new SqlParameter(paramName, DbType, size) :
                new SqlParameter(paramName, DbType);
            param.Direction = Direction;
            param.Value = value == null ? DBNull.Value : value;
            return param;
        }

        /// <summary>
        /// 转换到DB类型
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public object ToDBValue(object value)
        {
            return value == null || value.ToString() == "" ? DBNull.Value : value;
        }

        /// <summary>
        /// 从DB类型转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public object FromDBValue(object value)
        {
            return value == DBNull.Value ? null : value;
        }

        /// <summary>
        /// 转换到sql参数类型
        /// </summary>
        /// <param name="dynObj"></param>
        /// <returns></returns>
        public SqlParameter[] ToSqlParameters<T>(T sqlParam)
        {
            PropertyInfo[] pInfo = sqlParam.GetType().GetProperties();
            SqlParameter[] sqlparams = new SqlParameter[pInfo.Length];
            for (int i = 0; i < sqlparams.Length; i++)
            {
                if (pInfo[i].PropertyType == typeof(SqlParameter))
                {
                    sqlparams[i] = (SqlParameter)pInfo[i].GetValue(sqlParam, null);
                }
                else
                {
                    SqlParameter sp = new SqlParameter();
                    sp.ParameterName = "@" + pInfo[i].Name;
                    sp.Value = pInfo[i].GetValue(sqlParam, null);
                    sp.Value = sp.Value == null ? DBNull.Value : sp.Value;
                    sqlparams[i] = sp;
                }
            }
            return sqlparams;
        }

        public SqlParameter[] ToSqlParameters(dynamic sqlParam)
        {
            return ToSqlParameters<dynamic>(sqlParam);
        }

        #endregion

    }
}
