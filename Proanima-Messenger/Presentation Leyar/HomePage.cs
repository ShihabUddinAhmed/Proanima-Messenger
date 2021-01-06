using Proanima_Messenger.Communication_Layer;
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
        List<Story> storiesLoaded;
        int counter = 0;
        ChattingWindow chattingWindow;
        public HomePage(User user, Form back)
        {
            InitializeComponent();
            this.user = user;
            this.back = back;
            nameLabel.Text = "Welcome " + user.Name;
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DeleteChat();
            logOutToolStripMenuItem.PerformClick();
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

        private void HomePage_Load(object sender, EventArgs e)
        {
            messageCheckTimer.Start();
            messageTimer.Start();
            this.LoadRequests();
            this.LoadConnections();
            storiesLoaded = this.StoryLoad();
            this.ShowStory(counter);
            storyTimer.Start();
        }

        public List<Story> StoryLoad()
        {
            List<Story> stories = new List<Story>();
            List<PublicProfile> users = LoadConnections();
            try
            {
                for (int i = 0; i < users.Count; i++)
                {
                    PublicProfile publicProfile = users.ElementAt<PublicProfile>(i);
                    string sql = "SELECT UserID FROM Users WHERE UserName='" + publicProfile.UserName + "'";
                    DataAccess dataAccess = new DataAccess();
                    SqlDataReader sqlDataReader = dataAccess.GetData(sql);
                    sqlDataReader.Read();
                    string sqlStory = "SELECT * FROM Stories WHERE UserID=" + (int)sqlDataReader["UserID"];
                    dataAccess.CloseConnection();
                    DataAccess dataAccess1 = new DataAccess();
                    SqlDataReader sqlDataReader1 = dataAccess1.GetData(sqlStory);
                    while (sqlDataReader1.Read())
                    {
                        string date = sqlDataReader1["StoryDate"].ToString();
                        DateTime dateTime = Convert.ToDateTime(date);
                        TimeSpan timeSpan = DateTime.Now.Subtract(dateTime);
                        if (timeSpan.Days < 1)
                        {
                            Story story = new Story((int)sqlDataReader1["StoryID"], (byte[])sqlDataReader1["StoryImage"], date, publicProfile.Name);
                            stories.Add(story);
                        }
                        
                    }
                    dataAccess1.CloseConnection();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Connection Error!");
            }
            return stories;
        }

        public void LoadRequests()
        {
            List<PublicProfile> users = new List<PublicProfile>();
            try
            {
                string sql = "SELECT UserID FROM Connections WHERE Status = 'PENDING' AND ConnectionID = " + user.UserID;
                DataAccess dataAccess = new DataAccess();
                SqlDataReader sqlDataReader = dataAccess.GetData(sql);
                while (sqlDataReader.Read())
                {
                    string sqlUser = "SELECT Name,UserName,ProfilePicture,Gender FROM Users WHERE UserID=" + (int)sqlDataReader["UserID"];
                    DataAccess dataAccess1 = new DataAccess();
                    SqlDataReader sqlDataReader1 = dataAccess1.GetData(sqlUser);
                    sqlDataReader1.Read();
                    PublicProfile user = new PublicProfile(sqlDataReader1["Name"].ToString(), sqlDataReader1["UserName"].ToString(), (byte[])sqlDataReader1["ProfilePicture"], sqlDataReader1["Gender"].ToString());
                    users.Add(user);
                    dataAccess1.CloseConnection();
                }
                dataAccess.CloseConnection();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Source Not Found!");
            }
            requestDataGridView.DataSource = users;
        }

        public List<PublicProfile> LoadConnections()
        {
            List<PublicProfile> users = new List<PublicProfile>();
            try
            {
                string sql = "SELECT UserID,ConnectionID FROM Connections WHERE Status = 'ACTIVE' AND (ConnectionID = " + user.UserID + " OR UserID = " + user.UserID + ")";
                DataAccess dataAccess = new DataAccess();
                SqlDataReader sqlDataReader = dataAccess.GetData(sql);
                while (sqlDataReader.Read())
                {
                    int tempID = (int)sqlDataReader["UserID"];
                    int tempID2 = (int)sqlDataReader["ConnectionID"];
                    if (tempID!=user.UserID)
                    {
                        string sqlUser = "SELECT Name,UserName,ProfilePicture,Gender FROM Users WHERE UserID=" + tempID;
                        DataAccess dataAccess1 = new DataAccess();
                        SqlDataReader sqlDataReader1 = dataAccess1.GetData(sqlUser);
                        sqlDataReader1.Read();
                        PublicProfile user = new PublicProfile(sqlDataReader1["Name"].ToString(), sqlDataReader1["UserName"].ToString(), (byte[])sqlDataReader1["ProfilePicture"], sqlDataReader1["Gender"].ToString());
                        users.Add(user);
                        dataAccess1.CloseConnection();
                    }
                    else if(tempID2!=user.UserID)
                    {
                        string sqlUser = "SELECT Name,UserName,ProfilePicture,Gender FROM Users WHERE UserID=" + tempID2;
                        DataAccess dataAccess1 = new DataAccess();
                        SqlDataReader sqlDataReader1 = dataAccess1.GetData(sqlUser);
                        sqlDataReader1.Read();
                        PublicProfile user = new PublicProfile(sqlDataReader1["Name"].ToString(), sqlDataReader1["UserName"].ToString(), (byte[])sqlDataReader1["ProfilePicture"], sqlDataReader1["Gender"].ToString());
                        users.Add(user);
                        dataAccess1.CloseConnection();
                    }
                }
                dataAccess.CloseConnection();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Source Not Found!");
            }
            connectionsDataGridView.DataSource = users;
            return users;
        }

        public List<PublicProfile> GetUserForSearch(string userName)
        {
            List<PublicProfile> users = new List<PublicProfile>();
            try
            {
                string sql = "SELECT Name,UserName,ProfilePicture,Gender FROM Users WHERE Name LIKE '" + userName + "%' AND UserID <>" + user.UserID;
                DataAccess dataAccess = new DataAccess();
                SqlDataReader sqlDataReader = dataAccess.GetData(sql);
                while (sqlDataReader.Read())
                {
                    PublicProfile user = new PublicProfile(sqlDataReader["Name"].ToString(), sqlDataReader["UserName"].ToString(), (byte[])sqlDataReader["ProfilePicture"], sqlDataReader["Gender"].ToString());
                    users.Add(user);
                }
                dataAccess.CloseConnection();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Source Not Found!");
            }
            return users;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if(searchTextBox.Text!="")
            {
                searchDataGridView.DataSource = GetUserForSearch(searchTextBox.Text);
            }
            else
            {
                searchDataGridView.DataSource = null;
            }
        }

        private void searchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string userName = (string)searchDataGridView.Rows[e.RowIndex].Cells[1].Value;
            requestTextBox.Text = userName;
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            if(requestTextBox.Text!=string.Empty)
            {
                try
                {
                    string sql = "SELECT UserID FROM Users WHERE UserName ='" + requestTextBox.Text + "'";
                    DataAccess dataAccess = new DataAccess();
                    SqlDataReader reader = dataAccess.GetData(sql);
                    reader.Read();
                    int uID = (int)reader["UserID"];
                    dataAccess.CloseConnection();
                    string sqlCheck = "SELECT ConnectionID FROM Connections WHERE UserID=" + user.UserID;
                    DataAccess dataAccess2 = new DataAccess();
                    SqlDataReader readerCheck = dataAccess2.GetData(sqlCheck);
                    bool flagReq = false;
                    while(readerCheck.Read())
                    {
                        if (uID == (int)readerCheck["ConnectionID"])
                        {
                            flagReq = true;
                        }
                    }
                    dataAccess2.CloseConnection();
                    if (flagReq == false)
                    {
                        string sqlAcc = "SELECT UserID FROM Connections WHERE ConnectionID=" + user.UserID;
                        DataAccess dataAccess3 = new DataAccess();
                        SqlDataReader readerAcc = dataAccess3.GetData(sqlAcc);
                        bool flagAcc = false;
                        while (readerAcc.Read())
                        {
                            if (uID == (int)readerAcc["UserID"])
                            {
                                flagAcc = true;
                            }
                        }
                        dataAccess3.CloseConnection();
                        if (flagAcc == false)
                        {
                            string sqlConnection = "INSERT INTO Connections(UserID,ConnectionID,Status) VALUES(" + user.UserID + "," + uID + ",'PENDING')";
                            DataAccess dataAccess1 = new DataAccess();
                            int result = dataAccess1.ExecuteQuery(sqlConnection);
                            if (result > 0)
                            {
                                MessageBox.Show("Request sent!");
                            }
                            else
                            {
                                MessageBox.Show("Request Cannot Sent!\n\nPlease Try Again!");
                            }
                            dataAccess1.CloseConnection();
                        }
                        else
                        {
                            string sqlConnection = "UPDATE Connections SET Status = 'ACTIVE' WHERE UserID=" + uID + " AND ConnectionID=" + user.UserID;
                            DataAccess dataAccess4 = new DataAccess();
                            int result = dataAccess4.ExecuteQuery(sqlConnection);
                            if (result > 0)
                            {
                                MessageBox.Show("Request Accepted!");
                            }
                            else
                            {
                                MessageBox.Show("Request Cannot Sent!\n\nPlease Try Again!");
                            }
                            dataAccess4.CloseConnection();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Requested Already!");
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show("Data Source Error!");
                }
            }
            else
            {
                MessageBox.Show("Select A User First...");
            }
        }

        private void requestDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string userName = (string)requestDataGridView.Rows[e.RowIndex].Cells[1].Value;
            acceptTextBox.Text = userName;
        }

        private void connectionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string userName = (string)connectionsDataGridView.Rows[e.RowIndex].Cells[1].Value;
            messageTextBox.Text = userName;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (acceptTextBox.Text != string.Empty)
            {
                try
                {
                    string sqlID = "SELECT UserID FROM Users WHERE UserName='" + acceptTextBox.Text + "'";
                    DataAccess dataAccess1 = new DataAccess();
                    SqlDataReader sqlDataReader = dataAccess1.GetData(sqlID);
                    sqlDataReader.Read();
                    int uID = (int)sqlDataReader["UserID"];
                    dataAccess1.CloseConnection();
                    string sqlConnection = "UPDATE Connections SET Status = 'ACTIVE' WHERE UserID=" + uID + " AND ConnectionID=" + user.UserID;
                    DataAccess dataAccess = new DataAccess();
                    int result = dataAccess.ExecuteQuery(sqlConnection);
                    if (result > 0)
                    {
                        MessageBox.Show("Request Accepted!");
                    }
                    else
                    {
                        MessageBox.Show("Request Cannot Sent!\n\nPlease Try Again!");
                    }
                    dataAccess.CloseConnection();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Connection Error!");
                }
            }
            else
            {
                MessageBox.Show("Select A Request First...");
            }
        }

        public void ShowStory(int index)
        {
            if (index >= 0 && index < storiesLoaded.Count)
            {
                byte[] loadedStory = storiesLoaded.ElementAt<Story>(index).StoryImage;
                string name = storiesLoaded.ElementAt<Story>(index).Name;
                if (loadedStory != null)
                {
                    MemoryStream memoryStream = new MemoryStream(loadedStory);
                    storyPictureBox.Image = Image.FromStream(memoryStream);
                    storyLabel.Text = name + "'s Story";
                }
            }
        }
        
        private void storyTimer_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter>=0 && counter<storiesLoaded.Count)
            {
                this.ShowStory(counter);
            }
            else
            {
                counter = 0;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            HomePage_Load(sender, e);
        }

        public void DeleteChat()
        {
            try
            {
                string sql = "DELETE FROM MessageAlert WHERE Requestor='" + user.UserName + "'";
                DataAccess dataAccess = new DataAccess();
                dataAccess.ExecuteQuery(sql);
                dataAccess.CloseConnection();
            }
            catch(Exception exc)
            {
                MessageBox.Show("Database Connection Error!");
            }
        }

        private void messageCheckTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM MessageAlert WHERE Status = 'PENDING' AND Acceptor='" + user.UserName + "'";
                DataAccess dataAccess = new DataAccess();
                SqlDataReader sqlDataReader = dataAccess.GetData(sql);
                if (sqlDataReader.Read())
                {
                    int messageID = (int)sqlDataReader["MessageID"];
                    string rName = sqlDataReader["RequestorName"].ToString();
                    string userN = sqlDataReader["Requestor"].ToString();
                    dataAccess.CloseConnection();
                    string sqlA = "UPDATE MessageAlert SET Status='REQUESTED' WHERE MessageID=" + messageID;
                    DataAccess dataAccess1 = new DataAccess();
                    dataAccess1.ExecuteQuery(sqlA);
                    dataAccess1.CloseConnection();
                    DialogResult dialogResult = MessageBox.Show(rName + " wants to chat with you...\n\nDo you want to Chat now?", "Chat Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogResult==DialogResult.Yes)
                    {
                        chattingWindow = new ChattingWindow(user, this);
                        string sqlPic = "SELECT ProfilePicture FROM Users WHERE UserName='" + userN + "'";
                        DataAccess dataAccessP = new DataAccess();
                        SqlDataReader sqlDataReaderP = dataAccessP.GetData(sqlPic);
                        sqlDataReaderP.Read();
                        byte[] picture = (byte[])sqlDataReaderP["ProfilePicture"];
                        dataAccessP.CloseConnection();
                        string sqlC = "UPDATE MessageAlert SET Status='ACTIVE', AcceptorName='"+user.Name+"', AcceptorIP='"+chattingWindow.GetLocalIP()+"' WHERE MessageID=" + messageID;
                        DataAccess dataAccess2 = new DataAccess();
                        dataAccess2.ExecuteQuery(sqlC);
                        dataAccess2.CloseConnection();
                        string sqlGet = "SELECT * FROM MessageAlert WHERE MessageID=" + messageID;
                        DataAccess dataAccessG = new DataAccess();
                        SqlDataReader sqlDataReaderG = dataAccessG.GetData(sqlGet);
                        if (sqlDataReaderG.Read())
                        {
                            if (chattingWindow != null)
                            {
                                chattingWindow.ReceiverName(sqlDataReaderG["RequestorName"].ToString());
                                chattingWindow.LocalUser = sqlDataReaderG["AcceptorIP"].ToString();
                                chattingWindow.RemoteUser = sqlDataReaderG["RequestorIP"].ToString();
                                chattingWindow.LocalPort = (int)sqlDataReaderG["APort"];
                                chattingWindow.RemotePort = (int)sqlDataReaderG["RPort"];
                                chattingWindow.SetProfilePicture(picture);
                                dataAccessG.CloseConnection();
                                StopAllTimer();
                                chattingWindow.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        string sqlC = "UPDATE MessageAlert SET Status='REJECTED' WHERE MessageID=" + messageID;
                        DataAccess dataAccess3 = new DataAccess();
                        dataAccess3.ExecuteQuery(sqlC);
                        dataAccess3.CloseConnection();
                        this.Hide();
                    }
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Database Connection Error!"+exc.Message);
            }
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (messageTextBox.Text != string.Empty)
                {
                    chattingWindow = new ChattingWindow(user, this);
                    string ip = chattingWindow.GetLocalIP();
                    string sql = "INSERT INTO MessageAlert(RequestorName,Requestor,Acceptor,RequestorIP) VALUES('" + user.Name + "','" + user.UserName + "','" + messageTextBox.Text + "','" + ip + "')";
                    DataAccess dataAccess = new DataAccess();
                    int result = dataAccess.ExecuteQuery(sql);
                    if (result > 0)
                    {
                        MessageBox.Show("Message Request Sent!");
                    }
                    else
                    {
                        MessageBox.Show("Sorry, Request Couldn't Sent!");
                    }
                    dataAccess.CloseConnection();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Database Connection Error!");
            }
        }

        private void messageTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM MessageAlert WHERE Status = 'ACTIVE' AND Requestor='" + user.UserName + "'";
                DataAccess dataAccess = new DataAccess();
                SqlDataReader sqlDataReader = dataAccess.GetData(sql);
                if (sqlDataReader.Read())
                {
                    string acceptorUser = sqlDataReader["Acceptor"].ToString();
                    string aName = sqlDataReader["AcceptorName"].ToString();
                    string rIP = sqlDataReader["RequestorIP"].ToString();
                    string aIP = sqlDataReader["AcceptorIP"].ToString();
                    int rPort = (int)sqlDataReader["RPort"];
                    int aPort = (int)sqlDataReader["APort"];
                    dataAccess.CloseConnection();
                    string sqlPic = "SELECT ProfilePicture FROM Users WHERE UserName='" + acceptorUser + "'";
                    DataAccess dataAccessP = new DataAccess();
                    SqlDataReader sqlDataReaderP = dataAccessP.GetData(sqlPic);
                    sqlDataReaderP.Read();
                    byte[] picture = (byte[])sqlDataReaderP["ProfilePicture"];
                    dataAccessP.CloseConnection();
                    if (chattingWindow!=null)
                    {
                        chattingWindow.ReceiverName(aName);
                        chattingWindow.LocalUser = rIP;
                        chattingWindow.RemoteUser = aIP;
                        chattingWindow.LocalPort = rPort;
                        chattingWindow.RemotePort = aPort;
                        chattingWindow.SetProfilePicture(picture);
                        StopAllTimer();
                        chattingWindow.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Database Connection Error!");
            }
        }

        public void StartAllTimer()
        {
            messageCheckTimer.Start();
            messageTimer.Start();
            storyTimer.Start();
        }

        public void StopAllTimer()
        {
            messageCheckTimer.Stop();
            messageTimer.Stop();
            storyTimer.Stop();
        }
    }
}
