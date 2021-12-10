using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Resturant_V7
{
    class Delivery_connect
    {
        private OleDbConnection Connection = new OleDbConnection();
        private string phonenumber;
        public Delivery_connect()
        {
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ACU\Levels\Level 2\Semester 2\Practical Applications In CS II\Project\Final\Null Resturant v9.1\Null Resturant V7\Project.accdb;Persist Security Info=False;";
        }
        public string d_c(string phonenumber)
        {
            this.phonenumber = phonenumber;
            Connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            command.CommandText = "select *  From Customers where phonenumber= '" + phonenumber + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
           
            reader.Close();
            Connection.Dispose();
            Connection.Close();
            return count.ToString();

        }

    }
}
