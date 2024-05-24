using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramShop
{
    public partial class AuthForm : Form
    {
        DB db = new DB();
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            panel1.Left = ClientSize.Width / 2 - panel1.Width / 2;
            panel1.Top = ClientSize.Height / 2 - panel1.Height / 2;
        }

        public AuthForm()
        {
            InitializeComponent();
        }

        private void registr_lb_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegistrForm registr = new RegistrForm();
            registr.Show();
        }

        private void registr_lb_MouseEnter(object sender, EventArgs e)
        {
            registr_lb.ForeColor = Color.Red;
        }

        private void registr_lb_MouseLeave(object sender, EventArgs e)
        {
            registr_lb.ForeColor = Color.RoyalBlue;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from clients where login = @login and password = @password", db.getConnection());
            cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = login.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password.Text;
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                MainForm main = new MainForm();
                main.Show();
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные и повтори попытку");
            }
        }

        private void AuthForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
