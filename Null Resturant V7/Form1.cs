using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Null_Resturant_V7
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            HomeButton.ForeColor = Color.FromArgb(253, 198, 7);
        }

        int move, moveX, moveY;
        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }
        private void Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
        }
        private void Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            sidepanel.Height = HomeButton.Height;
            sidepanel.Top = HomeButton.Top;

            homeUC1.BringToFront();

            panel2.BackColor = Color.FromArgb(62, 34, 12);
            sidepanel.BackColor = Color.FromArgb(253, 198, 7);
            AboutUsButton.ForeColor = Color.FromArgb(253, 198, 7);

            HomeButton.ForeColor = Color.FromArgb(253, 198, 7);
            OffersButton.ForeColor = Color.White;
            MenuButton.ForeColor = Color.White;
            DeliveryButton.ForeColor = Color.White;
            CustomersButton.ForeColor = Color.White;
            MyInfoButton.ForeColor = Color.White;
        }

        private void OffersButton_Click(object sender, EventArgs e)
        {
            sidepanel.Height = OffersButton.Height;
            sidepanel.Top = OffersButton.Top;

            offersUC1.BringToFront();

            panel2.BackColor = Color.FromArgb(68, 159, 135);
            sidepanel.BackColor = Color.FromArgb(68, 159, 135);
            AboutUsButton.ForeColor = Color.FromArgb(68, 159, 135);

            OffersButton.ForeColor = Color.FromArgb(68, 159, 135);
            HomeButton.ForeColor = Color.White;
            MenuButton.ForeColor = Color.White;
            DeliveryButton.ForeColor = Color.White;
            CustomersButton.ForeColor = Color.White;
            MyInfoButton.ForeColor = Color.White;

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            sidepanel.Height = MenuButton.Height;
            sidepanel.Top = MenuButton.Top;

            menuUC1.BringToFront();

            panel2.BackColor = Color.FromArgb(44, 43, 59);
            sidepanel.BackColor = Color.FromArgb(44, 43, 59);
            AboutUsButton.ForeColor = Color.FromArgb(44, 43, 59);

            MenuButton.ForeColor = Color.FromArgb(44, 43, 59);
            HomeButton.ForeColor = Color.White;
            OffersButton.ForeColor = Color.White;
            DeliveryButton.ForeColor = Color.White;
            CustomersButton.ForeColor = Color.White;
            MyInfoButton.ForeColor = Color.White;

        }

        private void DeliveryButton_Click(object sender, EventArgs e)
        {
            sidepanel.Height = DeliveryButton.Height;
            sidepanel.Top = DeliveryButton.Top;

            deliveryUC1.BringToFront();
            OrderButton.BringToFront();
            textBox1.BringToFront();

            panel2.BackColor = Color.FromArgb(255, 150, 9);
            sidepanel.BackColor = Color.FromArgb(255, 150, 9);
            AboutUsButton.ForeColor = Color.FromArgb(255, 150, 9);

            DeliveryButton.ForeColor = Color.FromArgb(255, 150, 9);
            HomeButton.ForeColor = Color.White;
            OffersButton.ForeColor = Color.White;
            MenuButton.ForeColor = Color.White;
            CustomersButton.ForeColor = Color.White;
            MyInfoButton.ForeColor = Color.White;

        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            sidepanel.Height = CustomersButton.Height;
            sidepanel.Top = CustomersButton.Top;

            customersUC1.BringToFront();

            panel2.BackColor = Color.FromArgb(241, 167, 8);
            sidepanel.BackColor = Color.FromArgb(241, 167, 8);
            AboutUsButton.ForeColor = Color.FromArgb(241, 167, 8);

            CustomersButton.ForeColor = Color.FromArgb(241, 167, 8);
            HomeButton.ForeColor = Color.White;
            OffersButton.ForeColor = Color.White;
            MenuButton.ForeColor = Color.White;
            DeliveryButton.ForeColor = Color.White;
        }

        private void AboutUsButton_Click(object sender, EventArgs e)
        {
            aboutUsUC1.BringToFront();

            panel2.BackColor = Color.FromArgb(49, 27, 14);
            sidepanel.BackColor = Color.FromArgb(49, 27, 14);
            AboutUsButton.ForeColor = Color.FromArgb(49, 27, 14);

            HomeButton.ForeColor = Color.White;
            OffersButton.ForeColor = Color.White;
            MenuButton.ForeColor = Color.White;
            DeliveryButton.ForeColor = Color.White;
            CustomersButton.ForeColor = Color.White;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            menuUC1._ph = textBox1.Text;

            string OrderText = textBox1.Text;
            if (OrderText == " " || OrderText == "Enter your phone number")
                MessageBox.Show("Enter your number phone.", "Null; <resturant", MessageBoxButtons.OK);
            
            try
            {
                Delivery_connect dc = new Delivery_connect();
                string c=dc.d_c(OrderText);
                int c1 = Convert.ToInt32(c);
                if (c1== 1)
                {
                    MessageBox.Show("Login Succcesfull");
                    sidepanel.Height = MenuButton.Height;
                    sidepanel.Top = MenuButton.Top;

                    menuUC1.BringToFront();
                    panel2.BackColor = Color.FromArgb(94, 84, 92);
                    sidepanel.BackColor = Color.FromArgb(94, 84, 92);
                    AboutUsButton.ForeColor = Color.FromArgb(94, 84, 92);

                    MenuButton.ForeColor = Color.FromArgb(94, 84, 92);
                    HomeButton.ForeColor = Color.White;
                    OffersButton.ForeColor = Color.White;
                    DeliveryButton.ForeColor = Color.White;
                    CustomersButton.ForeColor = Color.White;
                    
                }
                else
                {
                    MessageBox.Show("Please, Rigister!");
                    customersUC1.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sidepanel.Height = CustomersButton.Height;
            sidepanel.Top = CustomersButton.Top;

            customersUC1.BringToFront();

            panel2.BackColor = Color.FromArgb(159, 151, 68);
            sidepanel.BackColor = Color.FromArgb(159, 151, 68);
            AboutUsButton.ForeColor = Color.FromArgb(159, 151, 68);

            CustomersButton.ForeColor = Color.FromArgb(159, 151, 68);
            HomeButton.ForeColor = Color.White;
            OffersButton.ForeColor = Color.White;
            MenuButton.ForeColor = Color.White;
            DeliveryButton.ForeColor = Color.White;
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
       
        private void MyInfoButton_Click(object sender, EventArgs e)
        {
            sidepanel.Height = MyInfoButton.Height;
            sidepanel.Top = MyInfoButton.Top;
            myInfoUC1.BringToFront();

            panel2.BackColor = Color.FromArgb(60, 67, 83);
            sidepanel.BackColor = Color.FromArgb(60, 67, 83);
            MyInfoButton.ForeColor = Color.FromArgb(60, 67, 83);

            AboutUsButton.ForeColor = Color.White;
            MenuButton.ForeColor = Color.White;
            HomeButton.ForeColor = Color.White;
            OffersButton.ForeColor = Color.White;
            DeliveryButton.ForeColor = Color.White;
            CustomersButton.ForeColor = Color.White;

        }


        public class Invisible_Button : UserControl
        {
            protected override void OnMouseMove(MouseEventArgs e)
            {
                base.OnMouseMove(e);
                this.Cursor = Cursors.Hand;
            }
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                e.Graphics.FillRectangle(new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);
            }
        }


        private void MenuButton_MouseMove(object sender, MouseEventArgs e)
        {
            MenuButton.BackColor = Color.FromArgb(27, 23, 22);

        }

        private void DeliveryButton_MouseMove(object sender, MouseEventArgs e)
        {
            DeliveryButton.BackColor = Color.FromArgb(27, 23, 22);
        }

        private void CustomersButton_MouseMove(object sender, MouseEventArgs e)
        {
            CustomersButton.BackColor = Color.FromArgb(27, 23, 22);
        }

        private void MyInfoButton_MouseMove(object sender, MouseEventArgs e)
        {
            MyInfoButton.BackColor = Color.FromArgb(27, 23, 22);
        }

        private void AboutUsButton_MouseMove(object sender, MouseEventArgs e)
        {
            AboutUsButton.BackColor = Color.FromArgb(27, 23, 22);
        }

        private void HomeButton_MouseEnter(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.FromArgb(27, 23, 22);
        }

        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            HomeButton.BackColor = Color.Transparent;
        }

        private void OffersButton_MouseEnter(object sender, EventArgs e)
        {
            OffersButton.BackColor = Color.FromArgb(27, 23, 22);
        }

        private void OffersButton_MouseLeave(object sender, EventArgs e)
        {
            OffersButton.BackColor = Color.Transparent;
        }

        private void MenuButton_MouseEnter(object sender, EventArgs e)
        {
            MenuButton.BackColor = Color.FromArgb(27, 23, 22);
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            MenuButton.BackColor = Color.Transparent;
        }

        private void DeliveryButton_MouseEnter(object sender, EventArgs e)
        {
            DeliveryButton.BackColor = Color.FromArgb(27, 23, 22);
        }

        private void DeliveryButton_MouseLeave(object sender, EventArgs e)
        {
            DeliveryButton.BackColor = Color.Transparent;
        }

        private void CustomersButton_MouseEnter(object sender, EventArgs e)
        {
            CustomersButton.BackColor = Color.FromArgb(27, 23, 22);

        }

        private void CustomersButton_MouseLeave(object sender, EventArgs e)
        {
            CustomersButton.BackColor = Color.Transparent;

        }

        private void MyInfoButton_MouseEnter(object sender, EventArgs e)
        {
            MyInfoButton.BackColor = Color.FromArgb(27, 23, 22);

        }

        private void MyInfoButton_MouseLeave(object sender, EventArgs e)
        {
            MyInfoButton.BackColor = Color.Transparent;

        }

        private void AboutUsButton_MouseEnter(object sender, EventArgs e)
        {
            AboutUsButton.BackColor = Color.FromArgb(27, 23, 22);

        }

        private void AboutUsButton_MouseLeave(object sender, EventArgs e)
        {
            MyInfoButton.BackColor = Color.Transparent;

        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter your phone number")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter your phone number";
                textBox1.ForeColor = Color.DarkGray;
            }
        }
    }
}
