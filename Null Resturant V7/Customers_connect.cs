using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Resturant_V7
{
    class Customers_connect
    {
        
        private string phonenumber,username, password, address;
        private OleDbConnection Connection = new OleDbConnection();
        public Customers_connect()
        {
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ACU\Levels\Level 2\Semester 2\Practical Applications In CS II\Project\Final\Null Resturant v9.1\Null Resturant V7\Project.accdb;Persist Security Info=False;";
        }
        public void Cuc(string phonenumber, string username, string password, string address)
        {
                this.phonenumber = phonenumber;
                this.username = username;
                this.password = password;
                this.address = address;
                Connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = Connection;
                command.CommandText = "insert into Customers values ('" + phonenumber  + "','" + username + "','" + password + "','" + address + "')";
                command.ExecuteNonQuery();
                Connection.Close();

        }
    }
}
