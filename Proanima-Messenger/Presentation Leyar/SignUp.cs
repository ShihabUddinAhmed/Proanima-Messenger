using Proanima_Messenger.Data_Access_Layar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proanima_Messenger
{
    public partial class SignUp : Form
    {
        string imageLocation = string.Empty;
        Form back;
        public SignUp(Form back)
        {
            InitializeComponent();
            this.back = back;
            nameTextBox.Focus();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            back.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";
                if (nameTextBox.Text != "" && userNameTextBox.Text != "" && passwordTextBox.Text != "" && confirmPasswordTextBox.Text != "" &&
                   emailTextBox.Text != "" && contactNumberTextBox.Text!= "" && (maleRadioButton.Checked || femaleRadioButton.Checked ||
                   othersRadioButton.Checked) && bloodGroupComboBox.Text != "" && agreementCheckBox.Checked && imageLocation != string.Empty)
                {
                    if (passwordTextBox.Text == confirmPasswordTextBox.Text)
                    {
                        string email = emailTextBox.Text;
                        string word = ".com";
                        string wordE = ".edu";
                        string wordN = ".net";
                        if (email.Contains(word) || email.Contains(wordE) || email.Contains(wordN))
                        {
                            if (maleRadioButton.Checked)
                            {
                                sql = "INSERT INTO Users(Name,UserName,Password,ProfilePicture,DoB,Gender,Email,PhoneNumber,BloodGroup) VALUES('" + nameTextBox.Text + "','" + userNameTextBox.Text + "','" + passwordTextBox.Text + "',@image,'" + dOBDateTimePicker.Text + "','" + maleRadioButton.Text + "','" + emailTextBox.Text + "','" + contactNumberTextBox.Text + "','" + bloodGroupComboBox.Text + "')";
                            }
                            else if (femaleRadioButton.Checked)
                            {
                                sql = "INSERT INTO Users(Name,UserName,Password,ProfilePicture,DoB,Gender,Email,PhoneNumber,BloodGroup) VALUES('" + nameTextBox.Text + "','" + userNameTextBox.Text + "','" + passwordTextBox.Text + "',@image,'" + dOBDateTimePicker.Text + "','" + femaleRadioButton.Text + "','" + emailTextBox.Text + "','" + contactNumberTextBox.Text + "','" + bloodGroupComboBox.Text + "')";
                            }
                            else
                            {
                                sql = "INSERT INTO Users(Name,UserName,Password,ProfilePicture,DoB,Gender,Email,PhoneNumber,BloodGroup) VALUES('" + nameTextBox.Text + "','" + userNameTextBox.Text + "','" + passwordTextBox.Text + "',@image,'" + dOBDateTimePicker.Text + "','" + othersRadioButton.Text + "','" + emailTextBox.Text + "','" + contactNumberTextBox.Text + "','" + bloodGroupComboBox.Text + "')";
                            }
                            FileStream filestream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                            BinaryReader binaryreader = new BinaryReader(filestream);
                            byte[] img = binaryreader.ReadBytes((int)filestream.Length);
                            DataAccess dataaccess = new DataAccess();
                            SqlCommand sqlCommand = new SqlCommand(sql, dataaccess.Connection);
                            sqlCommand.Parameters.Add(new SqlParameter("@image", img));
                            int result = dataaccess.ExecuteQuery(sqlCommand);
                            if (result > 0)
                            {
                                MessageBox.Show("Registered Successfully...!");
                                nameTextBox.Text = userNameTextBox.Text = emailTextBox.Text = passwordTextBox.Text = confirmPasswordTextBox.Text = contactNumberTextBox.Text = bloodGroupComboBox.Text = string.Empty;
                                maleRadioButton.Checked = femaleRadioButton.Checked = othersRadioButton.Checked = false;
                                agreementCheckBox.Checked = false;
                                backButton.PerformClick();
                            }
                            else
                            {
                                MessageBox.Show("Unsuccessful operation...");
                            }
                            dataaccess.CloseConnection();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Password Again!");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill up the form and check the agreement!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                profilePictureBox.Image = Image.FromFile(openFileDialog.FileName);
                imageLocation = openFileDialog.FileName.ToString();
            }
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                userNameTextBox.Focus();
            }
        }

        private void userNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordTextBox.Focus();
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmPasswordTextBox.Focus();
            }
        }

        private void confirmPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                emailTextBox.Focus();
            }
        }

        private void emailTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                contactNumberTextBox.Focus();
            }
        }
    }
}
