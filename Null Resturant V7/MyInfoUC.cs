using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Null_Resturant_V7
{
    public partial class MyInfoUC : UserControl
    {
        private OleDbConnection Connection = new OleDbConnection();
        public MyInfoUC()
        {
            InitializeComponent();

            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ACU\Levels\Level 2\Semester 2\Practical Applications In CS II\Project\Final\Null Resturant v9.1\Null Resturant V7\Project.accdb;Persist Security Info=False;";
        }
        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "phonenumber")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "phonenumer";
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "admin" && textBox2.Text == "admin") {
                MessageBox.Show("Login Succcesfull " + "Welcome");
                button2.Visible = true;
                button7.Visible = true;
                button4.Visible = false;
                button3.Visible = false;
                button9.Visible = true;

            }
            else
            {
                try
                {
                    
                    MyInfoUC_connect mi = new MyInfoUC_connect();
                    int count = mi.login(textBox1.Text, textBox2.Text);
                    button9.Visible = true;
                    button4.Visible = true;
                    button3.Visible = true;
                    button2.Visible = false;
                    button7.Visible = false;
                    if (count == 1)
                    {
                        MessageBox.Show("Login Succcesfull " + "Welcome");
                    }
                    else if (count > 1)
                    {
                        MessageBox.Show("Duplicate username");
                    }
                    else
                    {
                        MessageBox.Show("Error.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Connection.Close();
                }
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            try
                {
                MyInfoUC_connect mi = new MyInfoUC_connect();
                dataGridView1.Visible = true;
                dataGridView1.BringToFront();
                dataGridView1.DataSource = mi.Data_user(textBox1.Text,textBox2.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }
        }

       
        private void TextBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                
            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "password";
                textBox2.ForeColor = Color.DarkGray;
            }
        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            try { }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (textBox4.Text != "password")
            {
                textBox4.UseSystemPasswordChar = true;
            }
            else
            {
                textBox4.UseSystemPasswordChar = false;
            }
        }

        private void TextBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "password")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void TextBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "password";
                textBox4.ForeColor = Color.DarkGray;
            }
        }

        private void TextBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "phonenumber")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void TextBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "phonenumber";
                textBox6.ForeColor = Color.DarkGray;
            }
        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "username")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "username";
                textBox3.ForeColor = Color.DarkGray;
            }
        }

        private void TextBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "address";
                textBox5.ForeColor = Color.DarkGray;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                MyInfoUC_connect mi = new MyInfoUC_connect();
                mi.edit_data(this.textBox3.Text,this.textBox6.Text, this.textBox4.Text, this.textBox5.Text);
                
                MessageBox.Show("Edit Complete.", "Null; <resturant>", MessageBoxButtons.OK);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            try { }
            catch (FormatException ex) {
                MessageBox.Show(ex.Message);
                Connection.Close();
            };
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                MyInfoUC_connect mi = new MyInfoUC_connect();
                mi.delete_data(textBox1.Text);
                
                MessageBox.Show("Delete Complete.", "Null; <resturant>", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Confirm your exit?", "Null; <resturant>",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit == DialogResult.Yes)
                Application.Exit();
        }      
        private void TextBox5_Enter_1(object sender, EventArgs e)
        {
            if (textBox5.Text == "address")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            textBox7.Visible = true;
        }

        private void Button3_Click_2(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox1.Visible = false;
            panel1.Visible = false;
            textBox2.Visible = false;
            panel4.Visible = false;
            button1.Visible = false;
            textBox8.UseSystemPasswordChar = true;
            textBox8.Visible = true;
            panel8.Visible = true;
            textBox7.Visible = true;
            panel7.Visible = true;
            textBox9.Visible = true;
            panel9.Visible = true;
            button6.Visible = true;

        }


        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                OleDbCommand cmdUpdate = new OleDbCommand();
                cmdUpdate.Connection = Connection;
                cmdUpdate.CommandText = "update Customers set [username]='" + textBox7.Text + "' where phonenumber='" + textBox1.Text + "' ";
                cmdUpdate.ExecuteNonQuery();
                cmdUpdate.CommandText = "update Customers set [password]='" + textBox8.Text + "'  where phonenumber='" + textBox1.Text + "'";
                cmdUpdate.ExecuteNonQuery();
                cmdUpdate.CommandText = "update Customers set [address]='" + textBox9.Text + "' where phonenumber='" + textBox1.Text + "'";
                cmdUpdate.ExecuteNonQuery();

                Connection.Close();
                MessageBox.Show("Edit Complete.", "Null; <resturant>", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }

        }
        private void Button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin"&& textBox2.Text == "admin") {
                try
                {
                    MyInfoUC_connect mi = new MyInfoUC_connect();
                    mi.Delete_Alldata();
                    MessageBox.Show("Delete Complete.", "Null; <resturant>", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Connection.Close();
                }
            }
            else
            {
                MessageBox.Show("You have permission to do it");
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            textBox8.Visible = false;
            panel8.Visible = false;
            textBox7.Visible = false;
            panel7.Visible = false;
            textBox9.Visible = false;
            panel9.Visible = false;
            button6.Visible = false;
            dataGridView1.Visible = false;
            textBox1.Visible = true;
            panel1.Visible = true;
            textBox2.Visible = true;
            panel4.Visible = true;
            button1.Visible = true;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox8.Visible = false;
            panel8.Visible = false;
            textBox7.Visible = false;
            panel7.Visible = false;
            textBox9.Visible = false;
            panel9.Visible = false;
            button6.Visible = false;
            textBox1.Visible = false;
            panel1.Visible = false;
            textBox2.Visible = false;
            panel4.Visible = false;
            button1.Visible = false;
            dataGridView1.Visible = true;
            try
            {
                MyInfoUC_connect mi = new MyInfoUC_connect();
                dataGridView1.Visible = true;
                dataGridView1.BringToFront();
                dataGridView1.DataSource = mi.Data_query(textBox1.Text, textBox2.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Connection.Close();
            }
        }

        private void MyInfoUC_Load(object sender, EventArgs e)
        {

        }
    }
    }
    


            
    
            
        

