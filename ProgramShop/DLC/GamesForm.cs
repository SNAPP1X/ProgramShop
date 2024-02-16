using ProgramShop.Games;
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
    public partial class GamesForm : Form
    {
        MainForm f;
        public GamesForm()
        {
            InitializeComponent();
        }
        public GamesForm(MainForm _f)
        {
            InitializeComponent();
            f = _f;
        }

        private void dota_game_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new DotaGameForm(), sender);
        }

        private void mine_game_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new MineGameForm(), sender);
        }

        private void forza_game_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new ForzaGameForm(), sender);
        }

        private void osu_game_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new OsuGameForm(), sender);
        }

        private void hunt_game_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new HuntGameForm(), sender);
        }

        private void cs_game_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new CsGameForm(), sender);
        }

        private void val_game_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new ValGameForm(), sender);
        }

        private void sky_game_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new SkyGameForm(), sender);
        }

        private void gta_game_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new GtaGameForm(), sender);
        }
    }
}
