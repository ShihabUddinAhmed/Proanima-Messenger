
namespace Proanima_Messenger.Presentation_Leyar
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storyPictureBox = new System.Windows.Forms.PictureBox();
            this.createStoryButton = new System.Windows.Forms.Button();
            this.storyLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.requestButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.acceptButton = new System.Windows.Forms.Button();
            this.acceptTextBox = new System.Windows.Forms.TextBox();
            this.requestsLabel = new System.Windows.Forms.Label();
            this.requestDataGridView = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.messageButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.connectionsLabel = new System.Windows.Forms.Label();
            this.connectionsDataGridView = new System.Windows.Forms.DataGridView();
            this.storyTimer = new System.Windows.Forms.Timer(this.components);
            this.refreshButton = new System.Windows.Forms.Button();
            this.messageCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.messageTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 72);
            this.panel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLabel.Location = new System.Drawing.Point(15, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(164, 38);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "NameLebel";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1122, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // storyPictureBox
            // 
            this.storyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("storyPictureBox.Image")));
            this.storyPictureBox.Location = new System.Drawing.Point(22, 147);
            this.storyPictureBox.Name = "storyPictureBox";
            this.storyPictureBox.Size = new System.Drawing.Size(432, 652);
            this.storyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.storyPictureBox.TabIndex = 2;
            this.storyPictureBox.TabStop = false;
            // 
            // createStoryButton
            // 
            this.createStoryButton.BackColor = System.Drawing.Color.Indigo;
            this.createStoryButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createStoryButton.ForeColor = System.Drawing.Color.White;
            this.createStoryButton.Location = new System.Drawing.Point(460, 147);
            this.createStoryButton.Name = "createStoryButton";
            this.createStoryButton.Size = new System.Drawing.Size(199, 49);
            this.createStoryButton.TabIndex = 33;
            this.createStoryButton.Text = "Create Story";
            this.createStoryButton.UseVisualStyleBackColor = false;
            this.createStoryButton.Click += new System.EventHandler(this.createStoryButton_Click);
            // 
            // storyLabel
            // 
            this.storyLabel.AutoSize = true;
            this.storyLabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel.ForeColor = System.Drawing.Color.Indigo;
            this.storyLabel.Location = new System.Drawing.Point(15, 106);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(173, 38);
            this.storyLabel.TabIndex = 34;
            this.storyLabel.Text = "Story Name";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.searchLabel);
            this.panel2.Controls.Add(this.searchDataGridView);
            this.panel2.Location = new System.Drawing.Point(665, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 250);
            this.panel2.TabIndex = 35;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(22, 71);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(423, 34);
            this.searchTextBox.TabIndex = 36;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchLabel.Location = new System.Drawing.Point(15, 17);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(223, 38);
            this.searchLabel.TabIndex = 12;
            this.searchLabel.Text = "Search Friends :";
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.BackgroundColor = System.Drawing.Color.Indigo;
            this.searchDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(3, 111);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.RowHeadersWidth = 51;
            this.searchDataGridView.RowTemplate.Height = 24;
            this.searchDataGridView.Size = new System.Drawing.Size(442, 123);
            this.searchDataGridView.TabIndex = 0;
            this.searchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchDataGridView_CellContentClick);
            // 
            // requestTextBox
            // 
            this.requestTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestTextBox.Location = new System.Drawing.Point(665, 355);
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.Size = new System.Drawing.Size(291, 34);
            this.requestTextBox.TabIndex = 37;
            // 
            // requestButton
            // 
            this.requestButton.BackColor = System.Drawing.Color.Indigo;
            this.requestButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestButton.ForeColor = System.Drawing.Color.White;
            this.requestButton.Location = new System.Drawing.Point(962, 355);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(151, 34);
            this.requestButton.TabIndex = 38;
            this.requestButton.Text = "Send Request";
            this.requestButton.UseVisualStyleBackColor = false;
            this.requestButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.acceptButton);
            this.panel3.Controls.Add(this.acceptTextBox);
            this.panel3.Controls.Add(this.requestsLabel);
            this.panel3.Controls.Add(this.requestDataGridView);
            this.panel3.Location = new System.Drawing.Point(665, 395);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 199);
            this.panel3.TabIndex = 39;
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = System.Drawing.SystemColors.Control;
            this.acceptButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptButton.ForeColor = System.Drawing.Color.Indigo;
            this.acceptButton.Location = new System.Drawing.Point(330, 71);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(112, 34);
            this.acceptButton.TabIndex = 40;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // acceptTextBox
            // 
            this.acceptTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptTextBox.Location = new System.Drawing.Point(19, 71);
            this.acceptTextBox.Name = "acceptTextBox";
            this.acceptTextBox.Size = new System.Drawing.Size(305, 34);
            this.acceptTextBox.TabIndex = 36;
            // 
            // requestsLabel
            // 
            this.requestsLabel.AutoSize = true;
            this.requestsLabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.requestsLabel.Location = new System.Drawing.Point(15, 17);
            this.requestsLabel.Name = "requestsLabel";
            this.requestsLabel.Size = new System.Drawing.Size(149, 38);
            this.requestsLabel.TabIndex = 12;
            this.requestsLabel.Text = "Requests :";
            // 
            // requestDataGridView
            // 
            this.requestDataGridView.BackgroundColor = System.Drawing.Color.Indigo;
            this.requestDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestDataGridView.Location = new System.Drawing.Point(0, 111);
            this.requestDataGridView.Name = "requestDataGridView";
            this.requestDataGridView.RowHeadersWidth = 51;
            this.requestDataGridView.RowTemplate.Height = 24;
            this.requestDataGridView.Size = new System.Drawing.Size(445, 88);
            this.requestDataGridView.TabIndex = 0;
            this.requestDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestDataGridView_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Controls.Add(this.messageButton);
            this.panel4.Controls.Add(this.messageTextBox);
            this.panel4.Controls.Add(this.connectionsLabel);
            this.panel4.Controls.Add(this.connectionsDataGridView);
            this.panel4.Location = new System.Drawing.Point(665, 600);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 199);
            this.panel4.TabIndex = 40;
            // 
            // messageButton
            // 
            this.messageButton.BackColor = System.Drawing.SystemColors.Control;
            this.messageButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageButton.ForeColor = System.Drawing.Color.Indigo;
            this.messageButton.Location = new System.Drawing.Point(330, 71);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(112, 34);
            this.messageButton.TabIndex = 40;
            this.messageButton.Text = "Message";
            this.messageButton.UseVisualStyleBackColor = false;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.Location = new System.Drawing.Point(19, 71);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(305, 34);
            this.messageTextBox.TabIndex = 36;
            // 
            // connectionsLabel
            // 
            this.connectionsLabel.AutoSize = true;
            this.connectionsLabel.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.connectionsLabel.Location = new System.Drawing.Point(15, 17);
            this.connectionsLabel.Name = "connectionsLabel";
            this.connectionsLabel.Size = new System.Drawing.Size(194, 38);
            this.connectionsLabel.TabIndex = 12;
            this.connectionsLabel.Text = "Connections :";
            // 
            // connectionsDataGridView
            // 
            this.connectionsDataGridView.BackgroundColor = System.Drawing.Color.Indigo;
            this.connectionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.connectionsDataGridView.Location = new System.Drawing.Point(3, 111);
            this.connectionsDataGridView.Name = "connectionsDataGridView";
            this.connectionsDataGridView.RowHeadersWidth = 51;
            this.connectionsDataGridView.RowTemplate.Height = 24;
            this.connectionsDataGridView.Size = new System.Drawing.Size(442, 85);
            this.connectionsDataGridView.TabIndex = 0;
            this.connectionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.connectionsDataGridView_CellContentClick);
            // 
            // storyTimer
            // 
            this.storyTimer.Interval = 10000;
            this.storyTimer.Tick += new System.EventHandler(this.storyTimer_Tick);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Indigo;
            this.refreshButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.ForeColor = System.Drawing.Color.White;
            this.refreshButton.Location = new System.Drawing.Point(460, 202);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(199, 49);
            this.refreshButton.TabIndex = 41;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // messageCheckTimer
            // 
            this.messageCheckTimer.Tick += new System.EventHandler(this.messageCheckTimer_Tick);
            // 
            // messageTimer
            // 
            this.messageTimer.Tick += new System.EventHandler(this.messageTimer_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1122, 811);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.requestButton);
            this.Controls.Add(this.requestTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.createStoryButton);
            this.Controls.Add(this.storyPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storyPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.PictureBox storyPictureBox;
        private System.Windows.Forms.Button createStoryButton;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox acceptTextBox;
        private System.Windows.Forms.Label requestsLabel;
        private System.Windows.Forms.DataGridView requestDataGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label connectionsLabel;
        private System.Windows.Forms.DataGridView connectionsDataGridView;
        private System.Windows.Forms.Timer storyTimer;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Timer messageCheckTimer;
        private System.Windows.Forms.Timer messageTimer;
    }
}