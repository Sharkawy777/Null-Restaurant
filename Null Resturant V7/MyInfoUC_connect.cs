using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Resturant_V7
{
    class MyInfoUC_connect
    {
        private OleDbConnection Connection = new OleDbConnection();
        private string username, password, phonenumber, address;
       
        public MyInfoUC_connect()
        {
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ACU\Levels\Level 2\Semester 2\Practical Applications In CS II\Project\Final\Null Resturant v9.1\Null Resturant V7\Project.accdb;Persist Security Info=False;";
        }

        public int login(string phonenumber, string password)
        {
            this.phonenumber = phonenumber;
            this.password = password;
            Connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            command.CommandText = "select *  From Customers where phonenumber= '" + this.phonenumber + "' and password='" + this.password + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            reader.Close();
            Connection.Dispose();
            Connection.Close();
            return count;

        }
        public DataTable Data_user(string phonenumber, string password)
        {
            this.phonenumber = phonenumber;
            this.password = password;
            Connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            DataTable table = new DataTable();
            if (phonenumber == "admin" && password == "admin")
            {
                string query = "select *  From Customers";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(table);
                Connection.Close();
            }
            else
            {
                string query = "select *  From Customers where phonenumber= '" + phonenumber + "' and password='" + password + "'";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                
                da.Fill(table);
                
                Connection.Close();
            }
            return table;
        }
        public DataTable Data_query(string phonenumber,string password)
        {
            this.phonenumber = phonenumber;
            this.password = password;
            Connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            DataTable table = new DataTable();
            if (phonenumber == "admin" && password == "admin")
            {
                string query = "select *  From CustomersQuery";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(table);
                Connection.Close();
            }
            else
            {
                string query = "select *  From CustomersQuery where phonenumber= '" + phonenumber + "' and password='" + password + "'";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);

                da.Fill(table);

                Connection.Close();
            }
            return table;
        }
        public void delete_data(string phonenumber)
        {
            this.phonenumber = phonenumber;
            Connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            string query = "delete from Customers where  phonenumber='" + phonenumber + "'";
            command.CommandText = query;
            command.ExecuteNonQuery();
            Connection.Close();

        }
        public void Delete_Alldata()
        {
            Connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            string query = "delete from Customers ";
            command.CommandText = query;
            command.ExecuteNonQuery();
            Connection.Close();

        }
        public void edit_data(string phonenumber, string username, string password,string address)
        {
            this.address = address;
            this.password = password;
            this.phonenumber = phonenumber;
            this.username = username;
            Connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = Connection;
            string query = "update Customers set username='" + this.username + "'and password='" + this.password + "'and address='" + this.address + "' where phonenumber=" + phonenumber;
            command.CommandText = query;
            command.ExecuteNonQuery();
            Connection.Close();
        }
    }
}
