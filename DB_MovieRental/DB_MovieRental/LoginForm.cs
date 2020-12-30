using DatabaseHandler; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseHandler; 
namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int user = Convert.ToInt32(Email_login_textbox.Text);
            int password = Convert.ToInt32(Password_Login_textbox);
            DataTable table = DataBaseHandler.Select("Email", "where AID='" + user + "' and password='" + password + "'");
            if (table.Rows.Count == 0)
            {
                DataTable table2 = DataBaseHandler.Select("Email", "where UID='" + user + "' and password='" + password + "'");
                if (table2.Rows.Count == 0)
                {
                    MessageBox.Show("Wrong mail or password", "warning");
                }
                else
                {
                    AdminInterface form = new AdminInterface();
                    form.Show();
                    this.Hide();
                }


            }
            else
            {
                UserInterface form = new UserInterface();
                form.Show();
                this.Hide();
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
