using Homework.Enums;
using Homework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework.Views
{
    public partial class FormSettings : Form
    {
        Settings settings;
        public FormSettings()
        {
            settings = Settings.Get();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settings.Language = cmbLanguage.Text;
            settings.Vendor  = (VendorTypes)cmbVendor.SelectedIndex;
            settings.Save();
            this.Close();
        }

        
    }
}
