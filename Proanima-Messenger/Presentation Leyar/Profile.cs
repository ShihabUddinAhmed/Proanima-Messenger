using Microsoft.VisualBasic;
using Proanima_Messenger.Data_Access_Layar;
using Proanima_Messenger.Entities;
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

namespace Proanima_Messenger.Presentation_Leyar
{
    public partial class Profile : Form
    {
        User user;
        Form back;
        string imageLocation = string.Empty;
        public Profile(User user, Form back)
        {
            InitializeComponent();
            this.user = user;
            this.back = back;
            profileLabel.Text = user.Name + "'s " + profileLabel.Text;
            nameTextBox.Text = user.Name;
            userNameTextBox.Text = user.UserName;
            emailTextBox.Text = user.Email;
            contactNumberTextBox.Text = user.ContactNo;
            dOBDateTimePicker.Text = user.DOB;
            bloodGroupComboBox.Text = user.BloodGroup;
            if (user.Gender == "Male")
            {
                maleRadioButton.Checked = true;
                femaleRadioButton.Checked = false;
                othersRadioButton.Checked = false;
            }
            else if (user.Gender == "Female")
            {
                maleRadioButton.Checked = false;
                femaleRadioButton.Checked = true;
                othersRadioButton.Checked = false;
            }
            else
            {
                maleRadioButton.Checked = false;
                femaleRadioButton.Checked = false;
                othersRadioButton.Checked = true;
            }
            if (user.ProfilePicture != null)
            {
                MemoryStream memoryStream = new MemoryStream(user.ProfilePicture);
                profilePictureBox.Image = Image.FromStream(memoryStream);
            }
        }

        private void changePhotoButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                profilePictureBox.Image = Image.FromFile(openFileDialog.FileName);
                imageLocation = openFileDialog.FileName.ToString();
            }
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            back.Show();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != string.Empty && userNameTextBox.Text != string.Empty && emailTextBox.Text != string.Empty && contactNumberTextBox.Text != string.Empty && bloodGroupComboBox.Text != string.Empty && imageLocation != string.Empty)
            {
                this.user.Name = nameTextBox.Text;
                this.user.UserName = userNameTextBox.Text;
                this.user.Email = emailTextBox.Text;
                this.user.ContactNo = contactNumberTextBox.Text;
                this.user.DOB = dOBDateTimePicker.Text;
                this.user.BloodGroup = bloodGroupComboBox.Text;
                if (maleRadioButton.Checked)
                {
                    this.user.Gender = maleRadioButton.Text;
                }
                else if (femaleRadioButton.Checked)
                {
                    this.user.Gender = femaleRadioButton.Text;
                }
                else
                {
                    this.user.Gender = othersRadioButton.Text;
                }
                string sql = "UPDATE Users SET Name='" + this.user.Name + "',UserName='" + this.user.UserName + "',Password='" + this.user.Password + "',ProfilePicture=@image" + ",DoB='" + this.user.DOB + "',Gender='" + this.user.Gender + "',Email='" + this.user.Email + "',PhoneNumber='" + this.user.ContactNo + "',BloodGroup='" + this.user.BloodGroup + "' WHERE UserID=" + this.user.UserID;
                FileStream filestream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader binaryreader = new BinaryReader(filestream);
                byte[] img = binaryreader.ReadBytes((int)filestream.Length);
                user.ProfilePicture = img;
                try
                {
                    DataAccess dataAccess = new DataAccess();
                    SqlCommand sqlCommand = new SqlCommand(sql, dataAccess.Connection);
                    sqlCommand.Parameters.Add(new SqlParameter("@image", img));
                    int result = dataAccess.ExecuteQuery(sqlCommand);
                    if (result > 0)
                    {
                        MessageBox.Show("Profile Updated Successfully...!");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful operation...");
                    }
                    dataAccess.CloseConnection();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    MessageBox.Show("Invalid Update Request!\nPlease Try Again..."+ex.Message);
                }
            }
            else if (nameTextBox.Text != string.Empty && userNameTextBox.Text != string.Empty && emailTextBox.Text != string.Empty && contactNumberTextBox.Text != string.Empty && bloodGroupComboBox.Text != string.Empty && imageLocation == string.Empty)
            {
                this.user.Name = nameTextBox.Text;
                this.user.UserName = userNameTextBox.Text;
                this.user.Email = emailTextBox.Text;
                this.user.ContactNo = contactNumberTextBox.Text;
                this.user.DOB = dOBDateTimePicker.Text;
                this.user.BloodGroup = bloodGroupComboBox.Text;
                if (maleRadioButton.Checked)
                {
                    this.user.Gender = maleRadioButton.Text;
                }
                else if (femaleRadioButton.Checked)
                {
                    this.user.Gender = femaleRadioButton.Text;
                }
                else
                {
                    this.user.Gender = othersRadioButton.Text;
                }
                string sql = "UPDATE Users SET Name='" + this.user.Name + "',UserName='" + this.user.UserName + "',Password='" + this.user.Password + "'," + "DoB='" + this.user.DOB + "',Gender='" + this.user.Gender + "',Email='" + this.user.Email + "',PhoneNumber='" + this.user.ContactNo + "',BloodGroup='" + this.user.BloodGroup + "' WHERE UserID=" + this.user.UserID;
                try
                {
                    DataAccess dataAccess = new DataAccess();
                    int result = dataAccess.ExecuteQuery(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("Profile Updated Successfully...!");
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful operation...");
                    }
                    dataAccess.CloseConnection();
                }
                catch (Exception ex)
                {
                    string msg = ex.Message;
                    MessageBox.Show("Invalid Update Request!\nPlease Try Again...");
                }
                backButton.PerformClick();
            }
            else
            {
                MessageBox.Show("Fields cannot be Empty...!");
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            string myvalue = Interaction.InputBox("Change Password", "Enter Current Password:", "Enter password...");
            if (myvalue == user.Password)
            {
                string newPass = Interaction.InputBox("Change Password", "Enter New Password:", "Enter New password...");
                string confPass = Interaction.InputBox("Change Password", "Confirm Password:", "Enter password...");
                if (newPass == confPass)
                {
                    user.Password = newPass;
                }
                else
                {
                    MessageBox.Show("Password Confirmation Error!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
