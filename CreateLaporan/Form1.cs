using CreateLaporan.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateLaporan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UCDashboard uc = new UCDashboard();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl) 
        { 
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UCCreateLaporan uc = new UCCreateLaporan();
            addUserControl(uc);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UCDashboard uc = new UCDashboard();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UCEditDeleteLaporan uc = new UCEditDeleteLaporan();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UCSearchLaporan uc = new UCSearchLaporan();
            addUserControl(uc);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            UCListLaporan uc = new UCListLaporan();
            addUserControl(uc);
        }
    }
}
