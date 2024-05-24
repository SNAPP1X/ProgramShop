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
            Product product = new Product
            {
                name = "Microsoft Word",
                description = "Word processing software",
                price = 99.99m,
                photo = Properties.Resources.WordIcon
            };

            f.OpenChildForm(new ProductsForm(product), sender);
        }

        private void visio_prog_btn_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                name = "Microsoft Word",
                description = "Word processing software",
                price = 99.99m,
                photo = Properties.Resources.VisioIcon
            };

            f.OpenChildForm(new ProductsForm(product), sender);
        }

        private void ps_prog_btn_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                name = "Microsoft Word",
                description = "Word processing software",
                price = 99.99m,
                photo = Properties.Resources.WordIcon
            };

            f.OpenChildForm(new PsProgramForm(), sender);
        }

        private void vk_prog_btn_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                name = "Microsoft Word",
                description = "Word processing software",
                price = 99.99m,
                photo = Properties.Resources.WordIcon
            };

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
