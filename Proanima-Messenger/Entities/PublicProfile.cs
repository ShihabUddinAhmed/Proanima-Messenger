using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proanima_Messenger.Entities
{
    public class PublicProfile
    {
        private string name;
        private string userName;
        private byte[] profilePicture;
        private string gender;

        public PublicProfile(string name, string userName, byte[] profilePicture, string gender)
        {
            this.Name = name;
            this.UserName = userName;
            this.ProfilePicture = profilePicture;
            this.Gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public string UserName { get => userName; set => userName = value; }
        public byte[] ProfilePicture { get => profilePicture; set => profilePicture = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
