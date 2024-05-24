using ProgramShop.DLC;
using ProgramShop.Games;
using ProgramShop.Programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProgramShop
{
    public partial class MainForm : Form
    {

        ProfileForm profileForm = new ProfileForm();
        HomeForm homeForm;
        ProgramsForm programsForm;
        GamesForm gamesForm;
        LibraryForm libraryForm = new LibraryForm();
        AboutForm aboutForm = new AboutForm();
        ShoppingCart cart = new ShoppingCart();
        CartForm cartForm;
        Point LastPoint;
        private Form activeForm;
        private Button currentButton;

        public MainForm()
        {
            InitializeComponent();
            home_btn.FlatAppearance.BorderSize = 0;
            programs_btn.FlatAppearance.BorderSize = 0;
            games_btn.FlatAppearance.BorderSize = 0;
            library_btn.FlatAppearance.BorderSize = 0;
            about_btn.FlatAppearance.BorderSize = 0;

            cartForm = new CartForm(cart);

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
            homeForm = new HomeForm(this);
            programsForm = new ProgramsForm(this);
            gamesForm = new GamesForm(this);

            OpenChildForm(homeForm, sender);
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
        public void OpenChildForm(Form childForm, object btnSender)
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
        public void ActivateButton(object btnSender)
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
            OpenChildForm(homeForm, sender);
            home_btn.FlatAppearance.BorderSize = 0;
            home_btn.BackColor = Color.FromArgb(253, 241, 222);
            programs_btn.BackColor = Color.FromArgb(255, 224, 192);
            games_btn.BackColor = Color.FromArgb(255, 224, 192);
            library_btn.BackColor = Color.FromArgb(255, 224, 192);
            about_btn.BackColor = Color.FromArgb(255, 224, 192);
        }

        public void programs_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(programsForm, sender);
            programs_btn.FlatAppearance.BorderSize = 0;
            home_btn.BackColor = Color.FromArgb(255, 224, 192);
            programs_btn.BackColor = Color.FromArgb(253, 241, 222);
            games_btn.BackColor = Color.FromArgb(255, 224, 192);
            library_btn.BackColor = Color.FromArgb(255, 224, 192);
            about_btn.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void games_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(gamesForm, sender);
            games_btn.FlatAppearance.BorderSize = 0;
            home_btn.BackColor = Color.FromArgb(255, 224, 192);
            programs_btn.BackColor = Color.FromArgb(255, 224, 192);
            games_btn.BackColor = Color.FromArgb(253, 241, 222);
            library_btn.BackColor = Color.FromArgb(255, 224, 192);
            about_btn.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void library_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(libraryForm, sender);
            library_btn.FlatAppearance.BorderSize = 0;
            home_btn.BackColor = Color.FromArgb(255, 224, 192);
            programs_btn.BackColor = Color.FromArgb(255, 224, 192);
            games_btn.BackColor = Color.FromArgb(255, 224, 192);
            library_btn.BackColor = Color.FromArgb(253, 241, 222);
            about_btn.BackColor = Color.FromArgb(255, 224, 192);
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(aboutForm, sender);
            about_btn.FlatAppearance.BorderSize = 0;
            home_btn.BackColor = Color.FromArgb(255, 224, 192);
            programs_btn.BackColor = Color.FromArgb(255, 224, 192);
            games_btn.BackColor = Color.FromArgb(255, 224, 192);
            library_btn.BackColor = Color.FromArgb(255, 224, 192);
            about_btn.BackColor = Color.FromArgb(253, 241, 222);
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(profileForm, sender);
        }

        private void cart_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(cartForm, sender);
        }
    }
}