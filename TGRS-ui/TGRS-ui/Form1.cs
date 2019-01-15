using System;
using System.Windows.Forms;
using TGRS_CSharp_API;

namespace TGRS_ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SQL_Handler handler = new SQL_Handler();
            handler.SQLConnect("default", 0, "default", "default", "users");
            
            if ((handler.SQLQuery("SELECT password FROM users WHERE mail=" + passwordTB + ";")[0]) == passwordTB.Text)
            {
                Main m = new Main();
                m.Activate();
                this.Close();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.CreateUser(usernameTB.Text, passwordTB.Text);
        }
    }
}
