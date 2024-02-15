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
    public partial class ProgramsForm : Form
    {
        MainForm f;
        WordProgramForm w;
        public ProgramsForm()
        {
            InitializeComponent();
        }
        public ProgramsForm(MainForm _f)
        {
            InitializeComponent();
            f = _f;
        }

        private void word_prog_btn_Click(object sender, EventArgs e)
        {
              f.OpenChildForm(new WordProgramForm(), sender);
            //WordProgramForm w = new WordProgramForm();
            //w.Show();   
        }

        private void visio_prog_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new VisioProgramForm(), sender);
        }

        private void ps_prog_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new PsProgramForm(), sender);
        }

        private void vk_prog_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new VkProgramForm(), sender);
        }

        private void yout_prog_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new YoutubeProgramForm(), sender);
        }

        private void steam_prog_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new SteamProgramForms(), sender);
        }

        private void vs_prog_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new VsProgramForm(), sender);
        }

        private void ij_prog_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new IjProgramForm(), sender);
        }

        private void pp_prog_btn_Click(object sender, EventArgs e)
        {
            f.OpenChildForm(new PowerpointProgramForm(), sender);
        }
    }
}
