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
    public partial class HomeUC : UserControl
    {
        public HomeUC()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Confirm your exit?", "Null; <resturant>",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Exit == DialogResult.Yes)
                Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
