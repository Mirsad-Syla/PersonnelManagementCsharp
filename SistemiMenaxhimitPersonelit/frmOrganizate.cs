using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemiMenaxhimitPersonelit
{
    public partial class frmOrganizate : Form
    {
        DataTable dataTable = new DataTable();
        RSAEncryption rsaEncryption = new RSAEncryption();
        int organizataID;

        public frmOrganizate()
        {
            InitializeComponent();
        }

        private void MinimizePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        //private void btnRegjistro_Click(object sender, EventArgs e)
        //{
        //    if (txtOrganizata.Text == "" || txtPershkrimi.Text == "")
        //    {
        //        MessageBox.Show("Ju lutem plotesoni te gjitha fushat me te dhena");
        //        return;
        //    }
        //    var organizata = rsaEncryption.EncryptRSA(txtOrganizata.Text);
        //    var pershkrimi = rsaEncryption.EncryptRSA(txtPershkrimi.Text);

        //    using (var context = new SistemiMenaxhimitPersonelitEntities5())
        //    {
        //        var s = new Organizata()
        //        {
        //            Organizata1 = organizata,
        //            Pershkrimi = pershkrimi,
        //        };
        //        context.Organizatas.Add(s);
        //        context.SaveChanges();
        //    };
        //    MessageBox.Show("Ruajtja e te dhenes u realizua me sukses.");
        //    FillGrid();
        //    ClearFields();
        //}

        void FillGrid() 
        {
            PullData();
            dgvOrganizata.DataSource = dataTable;
        }

        public void PullData()
        {
            dgvOrganizata.DataSource = null;
            dgvOrganizata.Rows.Clear();
            dataTable.Clear();
            string connectionString = @"Data Source=Mirsad;Initial Catalog=SistemiMenaxhimitPersonelit;Integrated Security=True";
            string query = "SELECT * FROM dbo.Organizata";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            connection.Close();
            dataAdapter.Dispose();
            foreach (DataRow row in dataTable.Rows)
            {
                row["Organizata"] = rsaEncryption.DecryptRSA(row["Organizata"].ToString());
                row["Pershkrimi"] = rsaEncryption.DecryptRSA(row["Pershkrimi"].ToString());
            }
        }

        private void frmOrganizate_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        void ClearFields()
        {
            txtOrganizata.Text = txtPershkrimi.Text = "";
        }

        private void dgvOrganizata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrganizata.Focused)
            {
                if (dgvOrganizata.RowCount > 0)
                {
                    organizataID = int.Parse(dgvOrganizata["ID", dgvOrganizata.CurrentRow.Index].Value.ToString());
                    txtOrganizata.Text = dgvOrganizata["Organizata", dgvOrganizata.CurrentRow.Index].Value.ToString();
                    txtPershkrimi.Text = dgvOrganizata["Pershkrimi", dgvOrganizata.CurrentRow.Index].Value.ToString();
                }
            }
            btnFshije.Visible = true;
            btnNdrysho.Visible = true;
            btnRegjistro.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox3.Visible = true;
        }
        //private void btnNdrysho_Click(object sender, EventArgs e)
        //{
        //    var organizata = rsaEncryption.EncryptRSA(txtOrganizata.Text);
        //    var pershkrimi = rsaEncryption.EncryptRSA(txtPershkrimi.Text);
        //    using (var context = new SistemiMenaxhimitPersonelitEntities5())
        //    {
        //        Organizata organizata1 = context.Organizatas.First(x => x.ID == organizataID);
        //        organizata1.Organizata1 = organizata;
        //        organizata1.Pershkrimi = pershkrimi;
        //        context.SaveChanges();
        //    }
        //    ClearFields();
        //    MessageBox.Show("Perditsimi i te dhenave u realizua me sukses.");
        //    btnFshije.Visible = false;
        //    btnNdrysho.Visible = false;
        //    btnRegjistro.Enabled = true;
        //    pictureBox1.Visible = false;
        //    pictureBox3.Visible = false;
        //    FillGrid();
        //}

        //private void btnFshije_Click(object sender, EventArgs e)
        //{
        //    DialogResult result;

        //    result = MessageBox.Show("A jeni i sigurt?", "Informacion", MessageBoxButtons.YesNo);

        //    if (result == DialogResult.Yes)
        //    {
        //        using (var context = new SistemiMenaxhimitPersonelitEntities5())
        //        {
        //            Organizata organizata1 = context.Organizatas.Find(organizataID);
        //            context.Organizatas.Remove(organizata1);
        //            context.SaveChanges();
        //        }
        //        ClearFields();
        //        MessageBox.Show("Fshirja u realizua me sukses!");
        //        btnFshije.Visible = false;
        //        btnNdrysho.Visible = false;
        //        btnRegjistro.Enabled = true;
        //        pictureBox1.Visible = false;
        //        pictureBox3.Visible = false;
        //        FillGrid();
        //    } else
        //    {
        //        btnFshije.Visible = false;
        //        btnNdrysho.Visible = false;
        //        btnRegjistro.Enabled = true;
        //        pictureBox1.Visible = false;
        //        pictureBox3.Visible = false;
        //    }
        //}

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            (dgvOrganizata.DataSource as DataTable).DefaultView.RowFilter = string.Format("Organizata LIKE '%{0}%'", txtKerko.Text);
        }

        private void btnRegjistro_Click_1(object sender, EventArgs e)
        {
            if (txtOrganizata.Text == "" || txtPershkrimi.Text == "")
            {
                MessageBox.Show("Ju lutem plotesoni te gjitha fushat me te dhena");
                return;
            }
            var organizata = rsaEncryption.EncryptRSA(txtOrganizata.Text);
            var pershkrimi = rsaEncryption.EncryptRSA(txtPershkrimi.Text);

            using (var context = new SistemiMenaxhimitPersonelitEntities5())
            {
                var s = new Organizata()
                {
                    Organizata1 = organizata,
                    Pershkrimi = pershkrimi,
                };
                context.Organizatas.Add(s);
                context.SaveChanges();
            };
            MessageBox.Show("Ruajtja e te dhenes u realizua me sukses.");
            FillGrid();
            ClearFields();
        }

        private void btnFshije_Click_1(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("A jeni i sigurt?", "Informacion", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (var context = new SistemiMenaxhimitPersonelitEntities5())
                {
                    Organizata organizata1 = context.Organizatas.Find(organizataID);
                    context.Organizatas.Remove(organizata1);
                    context.SaveChanges();
                }
                ClearFields();
                MessageBox.Show("Fshirja u realizua me sukses!");
                btnFshije.Visible = false;
                btnNdrysho.Visible = false;
                btnRegjistro.Enabled = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                FillGrid();
            }
            else
            {
                btnFshije.Visible = false;
                btnNdrysho.Visible = false;
                btnRegjistro.Enabled = true;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
            }
        }

        private void btnNdrysho_Click_1(object sender, EventArgs e)
        {
            var organizata = rsaEncryption.EncryptRSA(txtOrganizata.Text);
            var pershkrimi = rsaEncryption.EncryptRSA(txtPershkrimi.Text);
            using (var context = new SistemiMenaxhimitPersonelitEntities5())
            {
                Organizata organizata1 = context.Organizatas.First(x => x.ID == organizataID);
                organizata1.Organizata1 = organizata;
                organizata1.Pershkrimi = pershkrimi;
                context.SaveChanges();
            }
            ClearFields();
            MessageBox.Show("Perditsimi i te dhenave u realizua me sukses.");
            btnFshije.Visible = false;
            btnNdrysho.Visible = false;
            btnRegjistro.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            FillGrid();
        }
    }
}
