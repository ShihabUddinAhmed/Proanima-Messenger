using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proanima_Messenger.Entities
{
    public class User
    {
        private int userID;
        private string name;
        private string userName;
        private string password;
        private byte[] profilePicture;
        private string dOB;
        private string gender;
        private string email;
        private string contactNo;
        private string bloodGroup;

        public User(int userID, string name, string userName, string password, byte[] profilePicture, string dOB, string gender, string email, string contactNo, string bloodGroup)
        {
            this.UserID = userID;
            this.Name = name;
            this.UserName = userName;
            this.Password = password;
            this.ProfilePicture = profilePicture;
            this.DOB = dOB;
            this.Gender = gender;
            this.Email = email;
            this.ContactNo = contactNo;
            this.BloodGroup = bloodGroup;
        }

        public int UserID { get => userID; set => userID = value; }
        public string Name { get => name; set => name = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public byte[] ProfilePicture { get => profilePicture; set => profilePicture = value; }
        public string DOB { get => dOB; set => dOB = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string ContactNo { get => contactNo; set => contactNo = value; }
        public string BloodGroup { get => bloodGroup; set => bloodGroup = value; }
    }
}
