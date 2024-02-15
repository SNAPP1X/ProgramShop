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
    public partial class RegistrForm : Form
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            panel1.Left = ClientSize.Width / 2 - panel1.Width / 2;
            panel1.Top = ClientSize.Height / 2 - panel1.Height / 2;
        }
        public RegistrForm()
        {
            InitializeComponent();
        }

        private void sign_in_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AuthForm auth = new AuthForm();
            auth.Visible = true;
        }

        private void sign_in_lb_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AuthForm auth = new AuthForm();
            auth.Visible = true;
        }

        private void sign_in_lb_MouseEnter(object sender, EventArgs e)
        {
            sign_in_lb.ForeColor = Color.Red;
        }

        private void sign_in_lb_MouseLeave(object sender, EventArgs e)
        {
            sign_in_lb.ForeColor= Color.RoyalBlue;
        }

        private void close_registr_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AuthForm auth = new AuthForm();
            auth.Visible = true;

        }
    }
}
