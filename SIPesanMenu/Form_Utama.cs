using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIPesanMenu
{
    public partial class Form_Utama : Form
    {
        public Form_Utama()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelNav.Controls.Clear();
            panelNav.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            UC_Karyawan uc = new UC_Karyawan();
            addUserControl(uc);
        }
    }
}
