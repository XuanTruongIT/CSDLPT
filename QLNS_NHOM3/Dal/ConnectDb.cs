﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dal
{
    class ConnectDb
    {
        private SqlConnection _conn;

        public void OpenConnect()
        {
            const string strConn = @"Data Source=XUANTRUONG;Initial Catalog=QLNS;Persist Security Info=True;User ID=sa;Password=123";
            _conn = new SqlConnection(strConn);
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }

        public void CloseConnect()
        {
            if (_conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }
        }
    }
}
