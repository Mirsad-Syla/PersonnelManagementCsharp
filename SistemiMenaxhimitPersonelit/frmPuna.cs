using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemiMenaxhimitPersonelit
{
    public partial class frmPuna : Form
    {
        DataTable dataTable = new DataTable();
        RSAEncryption rsaEncryption = new RSAEncryption();
        int pervojaPunesID;
        public frmPuna()
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

        private void frmPuna_Load(object sender, EventArgs e)
        {
            FillGrid();
            DataTable cmdDataTable = new DataTable();
            string connectionString = @"Data Source=Mirsad;Initial Catalog=SistemiMenaxhimitPersonelit;Integrated Security=True";
            string query = "SELECT ID FROM dbo.Personel";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(cmdDataTable);
            connection.Close();
            dataAdapter.Dispose();
            foreach (DataRow row in cmdDataTable.Rows)
            {
                cmbIdPersonit.Items.Add(row["ID"].ToString());
            }


            query = "SELECT ID FROM dbo.Organizata";
            SqlConnection crganizationConnection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, crganizationConnection);
            connection.Open();
            SqlDataAdapter organisationDataAdapter = new SqlDataAdapter(command);
            DataTable cmdOrganizataDataTable = new DataTable();
            organisationDataAdapter.Fill(cmdOrganizataDataTable);
            crganizationConnection.Close();
            organisationDataAdapter.Dispose();
            foreach (DataRow row in cmdOrganizataDataTable.Rows)
            {
                cmdEmriOrganizates.Items.Add(row["ID"].ToString());
            }
        }

        void FillGrid()
        {
            PullData();
            dgvPuna.DataSource = dataTable;
        }

        public void PullData()
        {
            dgvPuna.DataSource = null;
            dgvPuna.Rows.Clear();
            dataTable.Clear();
            string connectionString = @"Data Source=Mirsad;Initial Catalog=SistemiMenaxhimitPersonelit;Integrated Security=True";
            string query = "SELECT * FROM dbo.PervojaPunes";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            connection.Close();
            dataAdapter.Dispose();
            foreach (DataRow row in dataTable.Rows)
            {
                row["Pergjegjesite"] = rsaEncryption.DecryptRSA(row["Pergjegjesite"].ToString());
            }
        }

        private void RegjistroPersonelin()
        {
            if (cmbIdPersonit.Text == "" || cmdEmriOrganizates.Text == "" || txtPergjegjesite.Text == "" || txtVitePervoje.Text == "")
            {
                MessageBox.Show("Ju lutem plotesoni te gjitha fushat me te dhena");
                return;
            }

            var pergjegjesite = rsaEncryption.EncryptRSA(txtPergjegjesite.Text);

            using (var context = new SistemiMenaxhimitPersonelitEntities5())
            {
                var s = new PervojaPune()
                {
                    OrganizataID = Convert.ToInt32(cmdEmriOrganizates.Text),
                    PersoniID = Convert.ToInt32(cmbIdPersonit.Text),
                    VitePervoje = Convert.ToInt32(txtVitePervoje.Text),
                    Pergjegjesite = pergjegjesite
                };

                context.PervojaPunes.Add(s);
                context.SaveChanges();
            };
            MessageBox.Show("Ruajtja e te dhenes u realizua me sukses.");
            FillGrid();
            ClearFields();

        }

        void ClearFields()
        {
            txtIDOrganizates.Text = txtIDpersonit.Text = txtPergjegjesite.Text = txtVitePervoje.Text = cmbIdPersonit.Text = cmdEmriOrganizates.Text = "";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegjistroPersonelin();
        }

        private void btnRegjistro_Click(object sender, EventArgs e)
        {
            RegjistroPersonelin();
        }

        private void dgvPuna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnFshije.Visible = true;
            btnNdrysho.Visible = true;
            btnRegjistro.Enabled = false;
            pictureBox3.Visible = true;
            pictureBox2.Visible = true;
            if (dgvPuna.Focused)
            {
                if (dgvPuna.RowCount > 0)
                {
                    pervojaPunesID = int.Parse(dgvPuna["ID", dgvPuna.CurrentRow.Index].Value.ToString());
                    cmdEmriOrganizates.Text = dgvPuna["OrganizataID", dgvPuna.CurrentRow.Index].Value.ToString();
                    cmbIdPersonit.Text = dgvPuna["PersoniID", dgvPuna.CurrentRow.Index].Value.ToString();
                    txtVitePervoje.Text = dgvPuna["VitePervoje", dgvPuna.CurrentRow.Index].Value.ToString();
                    txtPergjegjesite.Text = dgvPuna["Pergjegjesite", dgvPuna.CurrentRow.Index].Value.ToString();
                }
            }
        }
        private void btnNdrysho_Click(object sender, EventArgs e)
        {
            var pergjegjesite = rsaEncryption.EncryptRSA(txtPergjegjesite.Text);
            using (var context = new SistemiMenaxhimitPersonelitEntities5())
            {
                PervojaPune pervojaPune = context.PervojaPunes.First(x => x.ID == pervojaPunesID);
                //Student student1 = context.Students.Find(studentId);
                pervojaPune.OrganizataID = Convert.ToInt32(cmdEmriOrganizates.Text);
                pervojaPune.PersoniID = Convert.ToInt32(cmbIdPersonit.Text);
                pervojaPune.VitePervoje = Convert.ToInt32(txtVitePervoje.Text);
                pervojaPune.Pergjegjesite = pergjegjesite;
                context.SaveChanges();
            }
            ClearFields();
            MessageBox.Show("Perditsimi i te dhenave u realizua me sukses.");
            btnFshije.Visible = false;
            btnNdrysho.Visible = false;
            btnRegjistro.Enabled = true;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            FillGrid();
        }

        private void btnFshije_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("A jeni i sigurt?", "Informacion", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (var context = new SistemiMenaxhimitPersonelitEntities5())
                {
                    PervojaPune pervojaPune = context.PervojaPunes.Find(pervojaPunesID);
                    context.PervojaPunes.Remove(pervojaPune);
                    context.SaveChanges();
                }

                ClearFields();
                MessageBox.Show("Fshirja u realizua me sukses!");
                btnFshije.Visible = false;
                btnNdrysho.Visible = false;
                pictureBox3.Visible = false;
                btnRegjistro.Enabled = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                FillGrid();
            } else
            {
                ClearFields();
                btnFshije.Visible = false;
                btnNdrysho.Visible = false;
                btnRegjistro.Enabled = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
            }
        }

        private void txtIDpersonit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            // * 8 - key code constant qendron per backspace
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Ju lutem perdorni vetem shifra numerike!", "Verejtje");
            }
        }

        private void txtIDOrganizates_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            // * 8 - key code constant qendron per backspace
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Ju lutem perdorni vetem shifra numerike!", "Verejtje");
            }
        }

        private void txtVitePervoje_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            // * 8 - key code constant qendron per backspace
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Ju lutem perdorni vetem shifra numerike!", "Verejtje");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbIdPersonit_SelectedIndexChanged(object sender, EventArgs e)
        {
            RSAEncryption rsaEncryption = new RSAEncryption();
            string connectionString = @"Data Source=Mirsad;Initial Catalog=SistemiMenaxhimitPersonelit;Integrated Security=True";
            string query = "SELECT * FROM dbo.Personel WHERE ID = " + int.Parse(cmbIdPersonit.Text);

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string personelName = (string)dataReader["Emri"].ToString();
                txtIDpersonit.Text = rsaEncryption.DecryptRSA(personelName);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdEmriOrganizates_SelectedIndexChanged(object sender, EventArgs e)
        {
            RSAEncryption rsaEncryption = new RSAEncryption();
            string connectionString = @"Data Source=Mirsad;Initial Catalog=SistemiMenaxhimitPersonelit;Integrated Security=True";
            string query = "SELECT * FROM dbo.Organizata WHERE ID = " + int.Parse(cmdEmriOrganizates.Text);

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string organisationName = (string)dataReader["Organizata"].ToString();
                txtIDOrganizates.Text = rsaEncryption.DecryptRSA(organisationName);
            }
        }
    }
}
