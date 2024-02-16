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

namespace ProgramShop.DLC
{
    public partial class HomeForm : Form
    {
        int n = 0;
        MainForm f;

        public HomeForm()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];

            next_btn.FlatAppearance.BorderSize = 0; 
            back_btn.FlatAppearance.BorderSize = 0;
        }

        public HomeForm(MainForm _f)
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];

            f = _f;
            next_btn.FlatAppearance.BorderSize = 0;
            back_btn.FlatAppearance.BorderSize = 0;
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            n++;
            if (n >= imageList1.Images.Count)
                n = 0;
            pictureBox1.Image = imageList1.Images[n];
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            n--;
            if (n < 0)
                n = imageList1.Images.Count - 1;
            pictureBox1.Image = imageList1.Images[n];
        }

        private void more_program_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new ProgramsForm(f), sender);

        }

        private void more_game_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new GamesForm(f), sender);
        }

        private void yout_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new YoutubeProgramForm(), sender);
        }

        private void vk_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new VkProgramForm(), sender);
        }

        private void word_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new WordProgramForm(), sender);
        }

        private void visio_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new VisioProgramForm(), sender);
        }

        private void ps_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new PsProgramForm(), sender);
        }

        private void mine_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new MineGameForm(), sender);
        }

        private void forza_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new ForzaGameForm(), sender);
        }

        private void osu_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new OsuGameForm(), sender);
        }

        private void dota_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new DotaGameForm(), sender);
        }

        private void hunt_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new HuntGameForm(), sender);
        }
    }
}
