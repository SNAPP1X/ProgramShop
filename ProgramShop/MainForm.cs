using ProgramShop.DLC;
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
    public partial class MainForm : Form
    {
        private Form activeForm;
        private Button currentButton;
        Point LastPoint;
        public MainForm()
        {
            InitializeComponent();
            home_btn.FlatAppearance.BorderSize = 0;
            programs_btn.FlatAppearance.BorderSize = 0;
            games_btn.FlatAppearance.BorderSize = 0;
            library_btn.FlatAppearance.BorderSize = 0;
            about_btn.FlatAppearance.BorderSize = 0;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exit_lb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            flowPanelMenu.Hide();
            OpenChildForm(new HomeForm(), sender);
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            home_btn.BackColor = Color.FromArgb(255, 224, 192);
            programs_btn.BackColor = Color.FromArgb(255, 224, 192);
            games_btn.BackColor = Color.FromArgb(255, 224, 192);
            library_btn.BackColor = Color.FromArgb(255, 224, 192);
            about_btn.BackColor = Color.FromArgb(255, 224, 192);
            if (flowPanelMenu.Visible)
            {
                flowPanelMenu.Hide();
            }
            else
                flowPanelMenu.Visible = true;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.main_panel.Controls.Add(childForm);
            this.main_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null && btnSender is Button)
            {
                if (currentButton != (Button)btnSender)
                {
                    currentButton = (Button)btnSender;
                }
            }
        }
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void home_btn_Click(object sender, EventArgs e)
        {   
            OpenChildForm(new HomeForm(), sender);
            home_btn.FlatAppearance.BorderSize = 0;
            home_btn.BackColor = Color.FromArgb(253, 241, 222);
            programs_btn.BackColor = Color.FromArgb(255, 224, 192);
            games_btn.BackColor = Color.FromArgb(255, 224, 192);
            library_btn.BackColor = Color.FromArgb(255, 224, 192);
            about_btn.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void programs_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProgramsForm(), sender);
            programs_btn.FlatAppearance.BorderSize = 0;
            home_btn.BackColor = Color.FromArgb(255, 224, 192);
            programs_btn.BackColor = Color.FromArgb(253, 241, 222);
            games_btn.BackColor = Color.FromArgb(255, 224, 192);
            library_btn.BackColor = Color.FromArgb(255, 224, 192);
            about_btn.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void games_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GamesForm(), sender);
            games_btn.FlatAppearance.BorderSize = 0;
            home_btn.BackColor = Color.FromArgb(255, 224, 192);
            programs_btn.BackColor = Color.FromArgb(255, 224, 192);
            games_btn.BackColor = Color.FromArgb(253, 241, 222);
            library_btn.BackColor = Color.FromArgb(255, 224, 192);
            about_btn.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void library_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LibraryForm(), sender);
            library_btn.FlatAppearance.BorderSize = 0;
            home_btn.BackColor = Color.FromArgb(255, 224, 192);
            programs_btn.BackColor = Color.FromArgb(255, 224, 192);
            games_btn.BackColor = Color.FromArgb(255, 224, 192);
            library_btn.BackColor = Color.FromArgb(253, 241, 222);
            about_btn.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AboutForm(), sender);
            about_btn.FlatAppearance.BorderSize = 0;
            home_btn.BackColor = Color.FromArgb(255, 224, 192);
            programs_btn.BackColor = Color.FromArgb(255, 224, 192);
            games_btn.BackColor = Color.FromArgb(255, 224, 192);
            library_btn.BackColor = Color.FromArgb(255, 224, 192);
            about_btn.BackColor = Color.FromArgb(253, 241, 222);
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileForm(), sender);
        }
    }
}