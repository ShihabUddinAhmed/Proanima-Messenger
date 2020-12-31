using Proanima_Messenger.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proanima_Messenger.Presentation_Leyar
{
    public partial class HomePage : Form
    {
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
    }
}
