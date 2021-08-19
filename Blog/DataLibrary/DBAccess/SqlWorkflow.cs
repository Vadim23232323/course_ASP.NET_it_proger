﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DataLibrary.DBAccess
{
    public class SqlWorkflow
    {
        public static string getStringConnection()
        {
            return ConfigurationManager.ConnectionStrings["ITBlogDB"].ConnectionString;
        }

        public static List<T> loadData<T>(string sql)
        {
            using (IDbConnection conn = new SqlConnection(getStringConnection()))
            {
                return conn.Query<T>(sql).ToList();
            }

        }

        public static void saveData<T>(string sql, T data)
        {
            using (IDbConnection conn = new SqlConnection(getStringConnection()))
            {
                conn.Execute(sql, data);
            }
        }
    }
}
