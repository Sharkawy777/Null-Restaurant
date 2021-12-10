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
    public partial class CustomersUC : UserControl
    {
        private OleDbConnection Connection = new OleDbConnection();
        public CustomersUC()
        {
            InitializeComponent();
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ACU\Levels\Level 2\Semester 2\Practical Applications In CS II\Project\Final\Null Resturant v9.1\Null Resturant V7\Project.accdb;Persist Security Info=False;";

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string pass = textBox4.Text;
            string confirmpass = textBox5.Text;

            if (pass != confirmpass)
                MessageBox.Show("Passwords don`t match.");

            else if (checkBox1.Checked == false)
                MessageBox.Show("You must agree our Privacy policy.");

            else if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" ||
                textBox1.Text == "username" || textBox3.Text == "password" || textBox4.Text == "Confirm Password" || textBox5.Text == "phone number" || textBox6.Text == "address")
            {
                MessageBox.Show("Please complete your information");
            }

            else if (button1.BackColor != Color.FromArgb(241, 167, 8) && button2.BackColor != Color.FromArgb(241, 167, 8))
            {
                MessageBox.Show("Please complete your information");
            }

            else
            {
                try
                {
                    Customers_connect cus = new Customers_connect();
                    cus.Cuc(textBox6.Text, textBox1.Text, textBox4.Text, comboBox1.SelectedItem + " " + textBox3.Text);
                    MessageBox.Show("Registration Completed.\nyou can order now.\nGo to Delivery!.", "Null; <resturant>", MessageBoxButtons.OK);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }     
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.Focus();
        }

        private void TextBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox3.Focus();
        }

        private void TextBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = string.Empty;
            textBox4.Focus();
        }

        private void TextBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = string.Empty;
            textBox5.Focus();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            try { }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = string.Empty;
            textBox6.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(241, 167, 8);
            button1.ForeColor = Color.White;
            button2.BackColor = Color.White;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.FromArgb(241, 167, 8);
            button2.ForeColor = Color.White;
        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please Enter a phone number.");
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

        private void TextBox1_TextChanged(object sender, EventArgs e) { }
        private void TextBox2_Click(object sender, EventArgs e) { }
        private void TextBox3_TextChanged(object sender, EventArgs e) { }
        private void TextBox4_TextChanged(object sender, EventArgs e) {
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

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "Confirm Password")
            {
                textBox5.UseSystemPasswordChar = true;
            }
            else
            {
                textBox5.UseSystemPasswordChar = false;
            }
        }

        private void TextBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Confirm Password")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void TextBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Confirm Password";
                textBox5.ForeColor = Color.DarkGray;
            }
        }

        private void TextBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "phone number")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void TextBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "phone number";
                textBox6.ForeColor = Color.DarkGray;
            }
        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "address")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "address";
                textBox3.ForeColor = Color.DarkGray;
            }
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "username")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "username";
                textBox1.ForeColor = Color.DarkGray;
            }
        }

        private void CustomersUC_Load(object sender, EventArgs e)
        {

        }
    }
}
