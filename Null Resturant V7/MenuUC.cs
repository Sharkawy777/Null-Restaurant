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

    public partial class MenuUC : UserControl
    {
        private OleDbConnection Connection = new OleDbConnection();
        public MenuUC()
        {
            InitializeComponent();
            Connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Programming\Null\Null Resturant v9.1\Null Resturant V7\Project.accdb;Persist Security Info=False;";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        const double price_Fish = 29.9;
        const double price_Pizza = 19.9;
        const double price_FreshFries = 9.9;
        const double price_CheeseBurger = 34.9;
        const double price_GrilledChicken = 49.9;
        const double price_FolandTa3mea = 9.99;

        const double price_tea = 3;
        const double price_coffee = 5;
        const double price_nescafe = 7;
        const double price_capchino = 10;
        const double price_soda = 10;
        const double price_orangejuice = 15;

        double Tax, Total, Charge;

        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (Controls) =>
            {
                foreach (Control control in Controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void MenuUC_Load(object sender, EventArgs e)
        {
            EnableTextBoxes();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";

            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Text = "";

            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = "";

            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";

            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
                textBox5.Text = "";
            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = "";
            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox8.Enabled = true;
                textBox8.Text = "";
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox9.Enabled = true;
                textBox9.Text = "";
            }
            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }

        private void CheckBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox10.Enabled = true;
                textBox10.Text = "";
            }
            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }

        private void CheckBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox11.Enabled = true;
                textBox11.Text = "";

            }
            else
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }

        private void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox12.Enabled = true;
                textBox12.Text = "";
            }
            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }
        private string phonenumber;
        public string _ph
        {
            set
            {
                phonenumber = value;
            }
            get
            {
                return phonenumber;
            }
        }
        private void TotalButton_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null)
                MessageBox.Show("Please choose the payment method.");
            else
            {
                try
                {
                    double[] itemcost = new double[13];
                    itemcost[1] = Convert.ToDouble(textBox1.Text) * price_Fish;
                    itemcost[2] = Convert.ToDouble(textBox2.Text) * price_Pizza;
                    itemcost[3] = Convert.ToDouble(textBox3.Text) * price_FreshFries;
                    itemcost[4] = Convert.ToDouble(textBox4.Text) * price_CheeseBurger;
                    itemcost[5] = Convert.ToDouble(textBox5.Text) * price_GrilledChicken;
                    itemcost[6] = Convert.ToDouble(textBox6.Text) * price_FolandTa3mea;

                    itemcost[7] = Convert.ToDouble(textBox7.Text) * price_tea;
                    itemcost[8] = Convert.ToDouble(textBox8.Text) * price_coffee;
                    itemcost[9] = Convert.ToDouble(textBox9.Text) * price_nescafe;
                    itemcost[10] = Convert.ToDouble(textBox10.Text) * price_capchino;
                    itemcost[11] = Convert.ToDouble(textBox11.Text) * price_soda;
                    itemcost[12] = Convert.ToDouble(textBox12.Text) * price_orangejuice;

                    Charge = itemcost[1] + itemcost[2] + itemcost[3] +
                              itemcost[4] + itemcost[5] + itemcost[6] +
                              itemcost[7] + itemcost[8] + itemcost[9] +
                              itemcost[10] + itemcost[11] + itemcost[12];

                    textBox13.Text = Convert.ToString(Charge);

                    Tax = Charge * 0.14;
                    textBox14.Text = Convert.ToString(Tax);

                    Total = Charge + Tax;
                    textBox15.Text = Convert.ToString(Total);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //DataBase

            string order = "";

            if (checkBox1.Checked == true)
            {
                order += textBox1.Text + " " + checkBox1.Text + " ";
            }
            if (checkBox2.Checked == true)
            {
                order += textBox2.Text + " " + checkBox2.Text + " ";
            }
            if (checkBox3.Checked == true)
            {
                order += textBox3.Text + " " + checkBox3.Text + " ";
            }
            if (checkBox4.Checked == true)
            {
                order += textBox4.Text + " " + checkBox4.Text + " ";
            }
            if (checkBox4.Checked == true)
            {
                order += textBox4.Text + " " + checkBox4.Text + " ";
            }
            if (checkBox5.Checked == true)
            {
                order += textBox5.Text + " " + checkBox5.Text + " ";
            }
            if (checkBox6.Checked == true)
            {
                order += textBox6.Text + " " + checkBox6.Text + " ";
            }
            if (checkBox7.Checked == true)
            {
                order += textBox7.Text + " " + checkBox7.Text + " ";
            }
            if (checkBox8.Checked == true)
            {
                order += textBox8.Text + " " + checkBox8.Text + " ";
            }
            if (checkBox9.Checked == true)
            {
                order += textBox9.Text + " " + checkBox9.Text + " ";
            }
            if (checkBox10.Checked == true)
            {
                order += textBox10.Text + " " + checkBox10.Text + " ";
            }
            if (checkBox11.Checked == true)
            {
                order += textBox11.Text + " " + checkBox11.Text + " ";
            }
            if (checkBox12.Checked == true)
            {
                order += textBox12.Text + " " + checkBox12.Text + " ";
            }
            try
            {
                Connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = Connection;
                
                command.CommandText = "insert into Orders ([phonenumber],[Order],[Cost])values('" + _ph + "','" + order + "','" + textBox15.Text + "')";

                command.ExecuteNonQuery();

                Connection.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void ResetButton_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Confirm your exit?", "Null; <resturant>",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit == DialogResult.Yes)
                Application.Exit();
        }

    }
}
