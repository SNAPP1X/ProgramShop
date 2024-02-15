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
    public partial class LogoForm : Form
    {
        Timer timer = new Timer();
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            pictureBox1.Left = ClientSize.Width / 2 - pictureBox1.Width / 2;
            pictureBox1.Top = ClientSize.Height / 2 - pictureBox1.Height / 2;
        }
        public LogoForm()
        {
            InitializeComponent();
            timer.Interval = 5000;
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            AuthForm auth = new AuthForm();
            auth.Show();
            timer.Stop();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
