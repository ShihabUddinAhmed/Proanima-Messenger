using Proanima_Messenger.Data_Access_Layar;
using Proanima_Messenger.Entities;
using Proanima_Messenger.Presentation_Leyar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proanima_Messenger
{
    public partial class Proanima : Form
    {
        public Proanima()
        {
            InitializeComponent();
        }

        private void Proanima_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp(this);
            signUp.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty)
            {
                string sql = "SELECT * FROM Users WHERE UserName='" + userNameTextBox.Text + "'AND Password='" + passwordTextBox.Text + "'";
                SqlDataReader sqlDataReader;
                try
                {
                    DataAccess dataAccess = new DataAccess();
                    sqlDataReader = dataAccess.GetData(sql);
                    sqlDataReader.Read();
                    int id = (int)sqlDataReader["UserID"];
                    User user = new User(id, sqlDataReader["Name"].ToString(), sqlDataReader["UserName"].ToString(), sqlDataReader["Password"].ToString(), (byte[])sqlDataReader["ProfilePicture"], sqlDataReader["DoB"].ToString(), sqlDataReader["Gender"].ToString(), sqlDataReader["Email"].ToString(), sqlDataReader["PhoneNumber"].ToString(), sqlDataReader["BloodGroup"].ToString());
                    HomePage homePage = new HomePage(user, this);
                    homePage.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    MessageBox.Show("Invalid UserName or Password!\nPlease Try Again...");
                }
            }
            else
            {
                MessageBox.Show("Fields Cannot be Empty!");
            }
            userNameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }
    }
}
