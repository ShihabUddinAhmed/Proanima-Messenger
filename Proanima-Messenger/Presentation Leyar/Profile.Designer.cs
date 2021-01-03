
using System;

namespace Proanima_Messenger.Presentation_Leyar
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.changePhotoButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.bloodGroupLabel = new System.Windows.Forms.Label();
            this.dOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dOBLabel = new System.Windows.Forms.Label();
            this.othersRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.genderLabel = new System.Windows.Forms.Label();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.contactNumberLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profileLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.changePasswordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // changePhotoButton
            // 
            this.changePhotoButton.BackColor = System.Drawing.Color.Indigo;
            this.changePhotoButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePhotoButton.ForeColor = System.Drawing.Color.White;
            this.changePhotoButton.Location = new System.Drawing.Point(236, 196);
            this.changePhotoButton.Name = "changePhotoButton";
            this.changePhotoButton.Size = new System.Drawing.Size(178, 57);
            this.changePhotoButton.TabIndex = 30;
            this.changePhotoButton.Text = "Change Photo";
            this.changePhotoButton.UseVisualStyleBackColor = false;
            this.changePhotoButton.Click += new System.EventHandler(this.changePhotoButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profilePictureBox.Image")));
            this.profilePictureBox.Location = new System.Drawing.Point(12, 100);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(218, 216);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 29;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.bloodGroupComboBox);
            this.panel1.Controls.Add(this.bloodGroupLabel);
            this.panel1.Controls.Add(this.dOBDateTimePicker);
            this.panel1.Controls.Add(this.dOBLabel);
            this.panel1.Controls.Add(this.othersRadioButton);
            this.panel1.Controls.Add(this.femaleRadioButton);
            this.panel1.Controls.Add(this.maleRadioButton);
            this.panel1.Controls.Add(this.genderLabel);
            this.panel1.Controls.Add(this.contactNumberTextBox);
            this.panel1.Controls.Add(this.contactNumberLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Controls.Add(this.userNameTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 379);
            this.panel1.TabIndex = 28;
            // 
            // bloodGroupComboBox
            // 
            this.bloodGroupComboBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodGroupComboBox.FormattingEnabled = true;
            this.bloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bloodGroupComboBox.Location = new System.Drawing.Point(270, 313);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(799, 36);
            this.bloodGroupComboBox.TabIndex = 24;
            // 
            // bloodGroupLabel
            // 
            this.bloodGroupLabel.AutoSize = true;
            this.bloodGroupLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodGroupLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bloodGroupLabel.Location = new System.Drawing.Point(21, 316);
            this.bloodGroupLabel.Name = "bloodGroupLabel";
            this.bloodGroupLabel.Size = new System.Drawing.Size(226, 28);
            this.bloodGroupLabel.TabIndex = 23;
            this.bloodGroupLabel.Text = "Blood Group               :";
            // 
            // dOBDateTimePicker
            // 
            this.dOBDateTimePicker.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOBDateTimePicker.Location = new System.Drawing.Point(271, 263);
            this.dOBDateTimePicker.MaxDate = new System.DateTime(2020, 12, 18, 0, 0, 0, 0);
            this.dOBDateTimePicker.Name = "dOBDateTimePicker";
            this.dOBDateTimePicker.Size = new System.Drawing.Size(798, 34);
            this.dOBDateTimePicker.TabIndex = 22;
            this.dOBDateTimePicker.Value = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            // 
            // dOBLabel
            // 
            this.dOBLabel.AutoSize = true;
            this.dOBLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dOBLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dOBLabel.Location = new System.Drawing.Point(23, 268);
            this.dOBLabel.Name = "dOBLabel";
            this.dOBLabel.Size = new System.Drawing.Size(223, 28);
            this.dOBLabel.TabIndex = 21;
            this.dOBLabel.Text = "Date Of Birth             :";
            // 
            // othersRadioButton
            // 
            this.othersRadioButton.AutoSize = true;
            this.othersRadioButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othersRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.othersRadioButton.Location = new System.Drawing.Point(643, 215);
            this.othersRadioButton.Name = "othersRadioButton";
            this.othersRadioButton.Size = new System.Drawing.Size(96, 32);
            this.othersRadioButton.TabIndex = 20;
            this.othersRadioButton.TabStop = true;
            this.othersRadioButton.Text = "Others";
            this.othersRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.femaleRadioButton.Location = new System.Drawing.Point(452, 215);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(100, 32);
            this.femaleRadioButton.TabIndex = 19;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadioButton.ForeColor = System.Drawing.SystemColors.Control;
            this.maleRadioButton.Location = new System.Drawing.Point(271, 215);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(80, 32);
            this.maleRadioButton.TabIndex = 18;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.genderLabel.Location = new System.Drawing.Point(23, 217);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(223, 28);
            this.genderLabel.TabIndex = 17;
            this.genderLabel.Text = "Gender                       :";
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberTextBox.Location = new System.Drawing.Point(270, 162);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.Size = new System.Drawing.Size(799, 34);
            this.contactNumberTextBox.TabIndex = 16;
            // 
            // contactNumberLabel
            // 
            this.contactNumberLabel.AutoSize = true;
            this.contactNumberLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.contactNumberLabel.Location = new System.Drawing.Point(23, 165);
            this.contactNumberLabel.Name = "contactNumberLabel";
            this.contactNumberLabel.Size = new System.Drawing.Size(221, 28);
            this.contactNumberLabel.TabIndex = 15;
            this.contactNumberLabel.Text = "Contact Number        :";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(271, 112);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(798, 34);
            this.emailTextBox.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emailLabel.Location = new System.Drawing.Point(23, 115);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(222, 28);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "E-Mail                        :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLabel.Location = new System.Drawing.Point(23, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(223, 28);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name                         :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(270, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(799, 34);
            this.nameTextBox.TabIndex = 9;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.userNameLabel.Location = new System.Drawing.Point(21, 67);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(223, 28);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "User Name                 :";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(270, 64);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(799, 34);
            this.userNameTextBox.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Indigo;
            this.backButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(717, 733);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(161, 49);
            this.backButton.TabIndex = 32;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.BackColor = System.Drawing.Color.Indigo;
            this.saveChangesButton.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.ForeColor = System.Drawing.Color.White;
            this.saveChangesButton.Location = new System.Drawing.Point(884, 733);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(226, 49);
            this.saveChangesButton.TabIndex = 31;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = false;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.profileLabel);
            this.panel2.Location = new System.Drawing.Point(-6, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 82);
            this.panel2.TabIndex = 33;
            // 
            // profileLabel
            // 
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.profileLabel.Location = new System.Drawing.Point(37, 15);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(145, 54);
            this.profileLabel.TabIndex = 26;
            this.profileLabel.Text = "Profile";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.BackColor = System.Drawing.Color.Indigo;
            this.changePasswordButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.ForeColor = System.Drawing.Color.White;
            this.changePasswordButton.Location = new System.Drawing.Point(236, 259);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(178, 57);
            this.changePasswordButton.TabIndex = 34;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = false;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 811);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.changePhotoButton);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profile_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changePhotoButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox bloodGroupComboBox;
        private System.Windows.Forms.Label bloodGroupLabel;
        private System.Windows.Forms.DateTimePicker dOBDateTimePicker;
        private System.Windows.Forms.Label dOBLabel;
        private System.Windows.Forms.RadioButton othersRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.Label contactNumberLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button changePasswordButton;
    }
}