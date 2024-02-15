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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            string disk= 
                "\tProgramShop - это компания, которая предлагает широкий выбор " +
                "программного обеспечения для различных целей и задач." +
                "\n\tНа сайте ProgramShop вы можете найти и купить софт для работы," +
                "учебы, развлечений, безопасности, разработки и многого другого." +
                "\nProgramShop сотрудничает с ведущими российскими и зарубежными разработчиками ПО," +
                "такими как Microsoft, Adobe, Autodesk, Kaspersky, ABBYY и другими." +
                "\n\tProgramShop также поддерживает отечественных производителей софта и " +
                "предоставляет им площадку для продвижения и продажи своих продуктов. " +
                "\n\tProgramShop гарантирует качество и безопасность предлагаемого софта, " +
                "а также предоставляет техническую поддержку и консультации по выбору и " +
                "установке ПО. \n\tProgramShop - это удобный и надежный способ приобрести " +
                "программное обеспечение для любых нужд.";
            label1.Text = disk;
        }
    }
}
