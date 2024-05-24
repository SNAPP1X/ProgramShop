using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProgramShop
{
    public partial class RegistrForm : Form
    {
        DB db = new DB();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            panel1.Left = ClientSize.Width / 2 - panel1.Width / 2;
            panel1.Top = ClientSize.Height / 2 - panel1.Height / 2;
        }
        public RegistrForm()
        {
            InitializeComponent();
            db.openConnection();
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
            sign_in_lb.ForeColor = Color.RoyalBlue;
        }

        private void close_registr_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AuthForm auth = new AuthForm();
            auth.Visible = true;

        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (password.Text == "")
            {
                MessageBox.Show("Укажите пароль");
                return;
            }
            if (email.Text == "")
            {
                MessageBox.Show("Укажите почту");
                return;
            }
            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Некорректный формат почты");
                return;
            }

            if (isUserExists())
            {
                return;
            }

            cmd = new SqlCommand("insert into clients values (@login, @password, @mail, 'Не задано', 0)", db.getConnection());
            cmd.Parameters.Add("@login", SqlDbType.NVarChar).Value = login.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password.Text;
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = email.Text;

            db.openConnection(); 
            if (cmd.ExecuteNonQuery() == 1)
                MessageBox.Show("Пользователь " + login.Text + " зарегистрирован");
            else
                MessageBox.Show("Ошибка");
            db.closeConnection();
        }

        bool isUserExists()
        {
            SqlCommand command = new SqlCommand("select * from clients where login = @login", db.getConnection());
            command.Parameters.Add("@login", SqlDbType.NVarChar).Value = login.Text;
            adapter.SelectCommand = command;

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Аккаунт уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
