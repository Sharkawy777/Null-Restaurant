namespace Null_Resturant_V7
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrderButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutUsButton = new System.Windows.Forms.Button();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.MyInfoButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.DeliveryButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.OffersButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.aboutUsUC1 = new Null_Resturant_V7.AboutUsUC();
            this.homeUC1 = new Null_Resturant_V7.HomeUC();
            this.menuUC1 = new Null_Resturant_V7.MenuUC();
            this.deliveryUC1 = new Null_Resturant_V7.DeliveryUC();
            this.offersUC1 = new Null_Resturant_V7.OffersUC();
            this.customersUC1 = new Null_Resturant_V7.CustomersUC();
            this.myInfoUC1 = new Null_Resturant_V7.MyInfoUC();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(682, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "#Null; <resturant>";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(34)))), ((int)(((byte)(12)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 15);
            this.panel2.TabIndex = 8;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseUp);
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(99)))), ((int)(((byte)(33)))));
            this.OrderButton.FlatAppearance.BorderSize = 0;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.ForeColor = System.Drawing.Color.White;
            this.OrderButton.Location = new System.Drawing.Point(633, 280);
            this.OrderButton.Margin = new System.Windows.Forms.Padding(5);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(144, 47);
            this.OrderButton.TabIndex = 188;
            this.OrderButton.Text = "Order NOW!";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(266, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Enter your phone number";
            this.textBox1.Click += new System.EventHandler(this.TextBox1_Click);
            this.textBox1.Enter += new System.EventHandler(this.TextBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.BackgroundImage = global::Null_Resturant_V7.Properties.Resources._4;
            this.panel1.Controls.Add(this.AboutUsButton);
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.MyInfoButton);
            this.panel1.Controls.Add(this.CustomersButton);
            this.panel1.Controls.Add(this.DeliveryButton);
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Controls.Add(this.OffersButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 510);
            this.panel1.TabIndex = 7;
            // 
            // AboutUsButton
            // 
            this.AboutUsButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutUsButton.FlatAppearance.BorderSize = 0;
            this.AboutUsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutUsButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(198)))), ((int)(((byte)(7)))));
            this.AboutUsButton.Location = new System.Drawing.Point(8, 464);
            this.AboutUsButton.Name = "AboutUsButton";
            this.AboutUsButton.Size = new System.Drawing.Size(37, 34);
            this.AboutUsButton.TabIndex = 7;
            this.AboutUsButton.Text = "?";
            this.AboutUsButton.UseVisualStyleBackColor = false;
            this.AboutUsButton.Click += new System.EventHandler(this.AboutUsButton_Click);
            this.AboutUsButton.MouseEnter += new System.EventHandler(this.AboutUsButton_MouseEnter);
            this.AboutUsButton.MouseLeave += new System.EventHandler(this.AboutUsButton_MouseLeave);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(198)))), ((int)(((byte)(7)))));
            this.sidepanel.Location = new System.Drawing.Point(0, 65);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(5, 55);
            this.sidepanel.TabIndex = 6;
            // 
            // MyInfoButton
            // 
            this.MyInfoButton.BackColor = System.Drawing.Color.Transparent;
            this.MyInfoButton.FlatAppearance.BorderSize = 0;
            this.MyInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyInfoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MyInfoButton.Image = global::Null_Resturant_V7.Properties.Resources.myinfo1;
            this.MyInfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyInfoButton.Location = new System.Drawing.Point(8, 375);
            this.MyInfoButton.Name = "MyInfoButton";
            this.MyInfoButton.Size = new System.Drawing.Size(192, 56);
            this.MyInfoButton.TabIndex = 2;
            this.MyInfoButton.Text = "MyInfo";
            this.MyInfoButton.UseVisualStyleBackColor = false;
            this.MyInfoButton.Click += new System.EventHandler(this.MyInfoButton_Click);
            this.MyInfoButton.MouseEnter += new System.EventHandler(this.MyInfoButton_MouseEnter);
            this.MyInfoButton.MouseLeave += new System.EventHandler(this.MyInfoButton_MouseLeave);
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackColor = System.Drawing.Color.Transparent;
            this.CustomersButton.FlatAppearance.BorderSize = 0;
            this.CustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CustomersButton.Image = global::Null_Resturant_V7.Properties.Resources.customers;
            this.CustomersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomersButton.Location = new System.Drawing.Point(8, 313);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(192, 56);
            this.CustomersButton.TabIndex = 2;
            this.CustomersButton.Text = "Registration";
            this.CustomersButton.UseVisualStyleBackColor = false;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            this.CustomersButton.MouseEnter += new System.EventHandler(this.CustomersButton_MouseEnter);
            this.CustomersButton.MouseLeave += new System.EventHandler(this.CustomersButton_MouseLeave);
            // 
            // DeliveryButton
            // 
            this.DeliveryButton.BackColor = System.Drawing.Color.Transparent;
            this.DeliveryButton.FlatAppearance.BorderSize = 0;
            this.DeliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryButton.ForeColor = System.Drawing.SystemColors.Control;
            this.DeliveryButton.Image = global::Null_Resturant_V7.Properties.Resources.delivery;
            this.DeliveryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeliveryButton.Location = new System.Drawing.Point(8, 251);
            this.DeliveryButton.Name = "DeliveryButton";
            this.DeliveryButton.Size = new System.Drawing.Size(192, 56);
            this.DeliveryButton.TabIndex = 2;
            this.DeliveryButton.Text = "Delivery";
            this.DeliveryButton.UseVisualStyleBackColor = false;
            this.DeliveryButton.Click += new System.EventHandler(this.DeliveryButton_Click);
            this.DeliveryButton.MouseEnter += new System.EventHandler(this.DeliveryButton_MouseEnter);
            this.DeliveryButton.MouseLeave += new System.EventHandler(this.DeliveryButton_MouseLeave);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MenuButton.Image = global::Null_Resturant_V7.Properties.Resources.menu;
            this.MenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuButton.Location = new System.Drawing.Point(8, 189);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(192, 56);
            this.MenuButton.TabIndex = 2;
            this.MenuButton.Text = "Menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            this.MenuButton.MouseEnter += new System.EventHandler(this.MenuButton_MouseEnter);
            this.MenuButton.MouseLeave += new System.EventHandler(this.MenuButton_MouseLeave);
            // 
            // OffersButton
            // 
            this.OffersButton.BackColor = System.Drawing.Color.Transparent;
            this.OffersButton.FlatAppearance.BorderSize = 0;
            this.OffersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OffersButton.ForeColor = System.Drawing.SystemColors.Control;
            this.OffersButton.Image = global::Null_Resturant_V7.Properties.Resources.offers;
            this.OffersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OffersButton.Location = new System.Drawing.Point(8, 127);
            this.OffersButton.Name = "OffersButton";
            this.OffersButton.Size = new System.Drawing.Size(192, 56);
            this.OffersButton.TabIndex = 2;
            this.OffersButton.Text = "Offers";
            this.OffersButton.UseVisualStyleBackColor = false;
            this.OffersButton.Click += new System.EventHandler(this.OffersButton_Click);
            this.OffersButton.MouseEnter += new System.EventHandler(this.OffersButton_MouseEnter);
            this.OffersButton.MouseLeave += new System.EventHandler(this.OffersButton_MouseLeave);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.HomeButton.Image = global::Null_Resturant_V7.Properties.Resources.home;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(8, 65);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(192, 56);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            this.HomeButton.MouseEnter += new System.EventHandler(this.HomeButton_MouseEnter);
            this.HomeButton.MouseLeave += new System.EventHandler(this.HomeButton_MouseLeave);
            // 
            // aboutUsUC1
            // 
            this.aboutUsUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutUsUC1.BackgroundImage")));
            this.aboutUsUC1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsUC1.Location = new System.Drawing.Point(200, 15);
            this.aboutUsUC1.Margin = new System.Windows.Forms.Padding(5);
            this.aboutUsUC1.Name = "aboutUsUC1";
            this.aboutUsUC1.Size = new System.Drawing.Size(600, 510);
            this.aboutUsUC1.TabIndex = 196;
            // 
            // homeUC1
            // 
            this.homeUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeUC1.BackgroundImage")));
            this.homeUC1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeUC1.Location = new System.Drawing.Point(200, 15);
            this.homeUC1.Margin = new System.Windows.Forms.Padding(5);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(600, 510);
            this.homeUC1.TabIndex = 195;
            // 
            // menuUC1
            // 
            this.menuUC1._ph = null;
            this.menuUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuUC1.BackgroundImage")));
            this.menuUC1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUC1.Location = new System.Drawing.Point(199, 15);
            this.menuUC1.Margin = new System.Windows.Forms.Padding(5);
            this.menuUC1.Name = "menuUC1";
            this.menuUC1.Size = new System.Drawing.Size(600, 510);
            this.menuUC1.TabIndex = 194;
            // 
            // deliveryUC1
            // 
            this.deliveryUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deliveryUC1.BackgroundImage")));
            this.deliveryUC1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryUC1.Location = new System.Drawing.Point(199, 15);
            this.deliveryUC1.Margin = new System.Windows.Forms.Padding(5);
            this.deliveryUC1.Name = "deliveryUC1";
            this.deliveryUC1.Size = new System.Drawing.Size(600, 510);
            this.deliveryUC1.TabIndex = 193;
            // 
            // offersUC1
            // 
            this.offersUC1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offersUC1.Location = new System.Drawing.Point(199, 15);
            this.offersUC1.Margin = new System.Windows.Forms.Padding(5);
            this.offersUC1.Name = "offersUC1";
            this.offersUC1.Size = new System.Drawing.Size(600, 510);
            this.offersUC1.TabIndex = 13;
            // 
            // customersUC1
            // 
            this.customersUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customersUC1.BackgroundImage")));
            this.customersUC1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersUC1.Location = new System.Drawing.Point(200, 15);
            this.customersUC1.Margin = new System.Windows.Forms.Padding(5);
            this.customersUC1.Name = "customersUC1";
            this.customersUC1.Size = new System.Drawing.Size(600, 510);
            this.customersUC1.TabIndex = 192;
            // 
            // myInfoUC1
            // 
            this.myInfoUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myInfoUC1.BackgroundImage")));
            this.myInfoUC1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.myInfoUC1.Location = new System.Drawing.Point(200, 15);
            this.myInfoUC1.Margin = new System.Windows.Forms.Padding(5);
            this.myInfoUC1.Name = "myInfoUC1";
            this.myInfoUC1.Size = new System.Drawing.Size(600, 510);
            this.myInfoUC1.TabIndex = 191;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.homeUC1);
            this.Controls.Add(this.menuUC1);
            this.Controls.Add(this.deliveryUC1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.offersUC1);
            this.Controls.Add(this.customersUC1);
            this.Controls.Add(this.myInfoUC1);
            this.Controls.Add(this.aboutUsUC1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Null; <resturant>";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AboutUsButton;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button DeliveryButton;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.Button OffersButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private OffersUC offersUC1;
        private System.Windows.Forms.Button MyInfoButton;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.TextBox textBox1;
        private MyInfoUC myInfoUC1;
        private CustomersUC customersUC1;
        private DeliveryUC deliveryUC1;
        private MenuUC menuUC1;
        private HomeUC homeUC1;
        private AboutUsUC aboutUsUC1;
    }
}

