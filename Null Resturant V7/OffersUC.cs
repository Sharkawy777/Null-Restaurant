using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Null_Resturant_V7
{
    public partial class OffersUC : UserControl
    {
        public OffersUC()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Confirm your exit?", "Null; <resturant>",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit == DialogResult.Yes)
                Application.Exit();
        }

        private void BringFront()
        {
            button1.BringToFront();
            button2.BringToFront();
            button3.BringToFront();
            button4.BringToFront();
            button5.BringToFront();
            button6.BringToFront();

            ExitButton.BringToFront();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            offer61.BringToFront();
            offer31.BringToFront();
            offer11.BringToFront();

            BringFront();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            offer11.BringToFront();
            offer41.BringToFront();
            offer21.BringToFront();

            BringFront();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            offer31.BringToFront();
            offer61.BringToFront();
            offer41.BringToFront();

            BringFront();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            offer41.BringToFront();
            offer11.BringToFront();
            offer51.BringToFront();

            BringFront();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            offer21.BringToFront();
            offer51.BringToFront();
            offer31.BringToFront();

            BringFront();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            offer51.BringToFront();
            offer21.BringToFront();
            offer61.BringToFront();

            BringFront();
        }
    }
}
