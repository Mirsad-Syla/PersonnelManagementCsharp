using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemiMenaxhimitPersonelit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPersoneli_Click(object sender, EventArgs e)
        {
            frmPersoneli frm = new frmPersoneli();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnOrganizata_Click(object sender, EventArgs e)
        {
            frmOrganizate frm = new frmOrganizate();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnPuna_Click(object sender, EventArgs e)
        {
            frmPuna frm = new frmPuna();
            this.Hide();
            frm.ShowDialog();
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
