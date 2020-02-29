using Homework.Models;
using System;
using System.Windows.Forms;

namespace Homework.Views
{
    public partial class FormMain : Form
    {
        private Settings settings;
        public FormMain()
        {
            settings = Settings.Get();
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblusername.Text = settings.Language;
        }
    }
}
