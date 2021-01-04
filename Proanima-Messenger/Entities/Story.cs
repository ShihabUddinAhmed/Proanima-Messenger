using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proanima_Messenger.Entities
{
    public class Story
    {
        private int storyID;
        private byte[] storyImage;
        private string storyDate;
        private string name;

        public Story(int storyID, byte[] storyImage, string storyDate, string name)
        {
            this.StoryID = storyID;
            this.StoryImage = storyImage;
            this.StoryDate = storyDate;
            this.Name = name;
        }

        public int StoryID { get => storyID; set => storyID = value; }
        public byte[] StoryImage { get => storyImage; set => storyImage = value; }
        public string StoryDate { get => storyDate; set => storyDate = value; }
        public string Name { get => name; set => name = value; }
    }
}
