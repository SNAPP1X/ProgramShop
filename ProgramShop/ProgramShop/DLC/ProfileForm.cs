using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramShop
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void avatar_MouseEnter(object sender, EventArgs e)
        {
            this.avatar.BackgroundImage = global::ProgramShop.Properties.Resources.icons8_пользователь_100__1_;
        }

        private void avatar_MouseLeave(object sender, EventArgs e)
        {
            this.avatar.BackgroundImage = global::ProgramShop.Properties.Resources.icons8_пользователь_100;
        }

        private void avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All files(*.*)|*.*";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    avatar.Image = new Bitmap(ofd.FileName);
                }
                catch 
                {
                    MessageBox.Show("Cannot use the selected file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
