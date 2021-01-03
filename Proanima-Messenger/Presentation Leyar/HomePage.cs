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
    public partial class HomePage : Form
    {
        string imageLocation = string.Empty;
        User user;
        Form back;
        public HomePage(User user, Form back)
        {
            InitializeComponent();
            this.user = user;
            this.back = back;
            nameLabel.Text = "Welcome " + user.Name;
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(user, this);
            profile.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            back.Show();
        }

        private void createStoryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select a Photo as your Story: ");
            openFileDialog.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                storyPictureBox.Image = Image.FromFile(openFileDialog.FileName);
                imageLocation = openFileDialog.FileName.ToString();
            }
            DialogResult dialogResult = MessageBox.Show("This picture will be set as your story. Are you sure to proceed?", "Confirmation: ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string sql = "INSERT INTO Stories(StoryImage,StoryDate,UserID) VALUES(@image,'" + DateTime.Now + "'," + user.UserID + ")";
                    FileStream filestream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryreader = new BinaryReader(filestream);
                    byte[] img = binaryreader.ReadBytes((int)filestream.Length);
                    DataAccess dataaccess = new DataAccess();
                    SqlCommand sqlCommand = new SqlCommand(sql, dataaccess.Connection);
                    sqlCommand.Parameters.Add(new SqlParameter("@image", img));
                    int resultD = dataaccess.ExecuteQuery(sqlCommand);
                    if (resultD > 0)
                    {
                        MessageBox.Show("Story Posted Successfully...!");
                    }
                    else
                    {
                        MessageBox.Show("Sorry! \n\nStroy Post Unsuccessful...");
                    }
                    dataaccess.CloseConnection();
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Error uploading! Try again!");
                }
            }
        }
    }
}
