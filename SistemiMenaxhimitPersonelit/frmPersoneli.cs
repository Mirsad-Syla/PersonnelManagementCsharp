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
    public partial class frmPersoneli : Form
    {
        int personeliID;
        DataTable dataTable = new DataTable();
        RSAEncryption rsaEncryption = new RSAEncryption();
        public frmPersoneli()
        {
            InitializeComponent();
        }

        private void MinimizePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmPersoneli_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        void FillGrid()
        {
            PullData();
            dgvPersoneli.DataSource = dataTable;
        }

        public void PullData()
        {
            dgvPersoneli.DataSource = null;
            dgvPersoneli.Rows.Clear();
            dataTable.Clear();
            string connectionString = @"Data Source=Mirsad;Initial Catalog=SistemiMenaxhimitPersonelit;Integrated Security=True";
            string query = "SELECT * FROM dbo.Personel";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);
            connection.Close();
            dataAdapter.Dispose();
            foreach (DataRow row in dataTable.Rows)
            {
                row["Emri"] = rsaEncryption.DecryptRSA(row["Emri"].ToString());
                row["Mbiemri"] = rsaEncryption.DecryptRSA(row["Mbiemri"].ToString());
                row["Adresa"] = rsaEncryption.DecryptRSA(row["Adresa"].ToString());
            }
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }
        private void btnRegjistro_Click_1(object sender, EventArgs e)
        {
            RegjistroPersonelin();
        }

        private void RegjistroPersonelin()
        {
            if (txtEmri.Text == "" || txtMbiemri.Text == "" || txtAdresa.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Ju lutem plotesoni te gjitha fushat me te dhena");
                return;
            }

            if((DateTime.Today.Year - dtpDitelindja.Value.Year) < 18)
            {
                MessageBox.Show("Data e dhene nuk eshte valide!");
                return;
            }

            var emri = rsaEncryption.EncryptRSA(txtEmri.Text);
            var mbiemri = rsaEncryption.EncryptRSA(txtMbiemri.Text);
            var adresa = rsaEncryption.EncryptRSA(txtAdresa.Text);

            using (var context = new SistemiMenaxhimitPersonelitEntities5())
            {
                var s = new Personel()
                {
                    Emri = emri,
                    Mbiemri = mbiemri,
                    Adresa = adresa,
                    Email = txtEmail.Text,
                    Gjinia = (rtbM.Checked ? "M" : "F"),
                    Ditelindja = dtpDitelindja.Value.ToString("dd-MM-yyyy")
                };

                context.Personels.Add(s);
                context.SaveChanges();
            };
            MessageBox.Show("Ruajtja e te dhenes u realizua me sukses.");
            FillGrid();
            ClearFields();
        }

        void ClearFields()
        {
            txtEmri.Text = txtMbiemri.Text = txtAdresa.Text = txtEmail.Text = "";
            dtpDitelindja.Value = DateTime.Now;
            rtbM.Checked = true;

        }

        private void dgvPersoneli_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersoneli.Focused)
            {
                if (dgvPersoneli.RowCount > 0)
                {
                    personeliID = int.Parse(dgvPersoneli["ID", dgvPersoneli.CurrentRow.Index].Value.ToString());
                    txtEmri.Text = dgvPersoneli["Emri", dgvPersoneli.CurrentRow.Index].Value.ToString();
                    txtMbiemri.Text = dgvPersoneli["Mbiemri", dgvPersoneli.CurrentRow.Index].Value.ToString();
                    txtAdresa.Text = dgvPersoneli["Adresa", dgvPersoneli.CurrentRow.Index].Value.ToString();
                    rtbM.Checked = dgvPersoneli["Gjinia", dgvPersoneli.CurrentRow.Index].Value.ToString() == "M" ? true : false;
                    txtEmail.Text = dgvPersoneli["Email", dgvPersoneli.CurrentRow.Index].Value.ToString();
                    string dataLindjesString = dgvPersoneli["Ditelindja", dgvPersoneli.CurrentRow.Index].Value.ToString();
                    DateTime dataLindjes = DateTime.Parse(dataLindjesString);
                    dtpDitelindja.Value = dataLindjes;
                    //dtpRegisteredDate.Value = DateTime.Parse(dgvStudents["RegisteredDate", dgvStudents.CurrentRow.Index].Value.ToString());
                }
            }
            btnFshije.Visible = true;
            btnNdryshoPersonelin.Visible = true;
            btnRegjistro.Enabled = false;
            pictureBox1.Visible = true;
            pictureBox3.Visible = true;
        }

        private void btnNdrysho_Click(object sender, EventArgs e)
        {
            var emri = rsaEncryption.EncryptRSA(txtEmri.Text);
            var mbiemri = rsaEncryption.EncryptRSA(txtMbiemri.Text);
            var adresa = rsaEncryption.EncryptRSA(txtAdresa.Text);
            using (var context = new SistemiMenaxhimitPersonelitEntities5())
            {
                Personel personel = context.Personels.First(x => x.ID == personeliID);
                //Student student1 = context.Students.Find(studentId);
                personel.Emri = emri;
                personel.Mbiemri = mbiemri;
                personel.Gjinia = (rtbM.Checked ? "M" : "F");
                personel.Adresa = adresa;
                personel.Email = txtEmail.Text;
                personel.Ditelindja = dtpDitelindja.Value.ToString("dd/MM/yyyy");
                context.SaveChanges();
            }
            ClearFields();
            MessageBox.Show("Perditsimi i te dhenave u realizua me sukses.");
            btnFshije.Visible = false;
            btnNdryshoPersonelin.Visible = false;
            pictureBox1.Visible = false;
            btnRegjistro.Enabled = true;
            pictureBox3.Visible = false;
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
                    Personel student = context.Personels.Find(personeliID);
                    context.Personels.Remove(student);
                    context.SaveChanges();
                }

                ClearFields();
                MessageBox.Show("Fshirja u realizua me sukses!");
                btnFshije.Visible = false;
                btnNdryshoPersonelin.Visible = false;
                btnRegjistro.Enabled = true;
                pictureBox3.Visible = false;
                pictureBox1.Visible = false;
                FillGrid();
            } else
            {
                ClearFields();
                btnFshije.Visible = false;
                btnNdryshoPersonelin.Visible = false;
                btnRegjistro.Enabled = true;
                btnNdryshoPersonelin.Visible = false;
                pictureBox3.Visible = false;
                pictureBox1.Visible = false;
            }
        }

        private void txtKerko_TextChanged(object sender, EventArgs e)
        {
            (dgvPersoneli.DataSource as DataTable).DefaultView.RowFilter = string.Format("Emri LIKE '%{0}%'", txtKerko.Text);
            (dgvPersoneli.DataSource as DataTable).DefaultView.RowFilter = string.Format("Mbiemri LIKE '%{0}%'", txtKerko.Text);
        }

        private void txtKerko_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.Enter)
            //{
            //    if(string.IsNullOrEmpty(txtKerko.Text))
                    
            //}
        }

        private void btnNdryshoPersonelin_Click(object sender, EventArgs e)
        {
            var emri = rsaEncryption.EncryptRSA(txtEmri.Text);
            var mbiemri = rsaEncryption.EncryptRSA(txtMbiemri.Text);
            var adresa = rsaEncryption.EncryptRSA(txtAdresa.Text);
            using (var context = new SistemiMenaxhimitPersonelitEntities5())
            {
                Personel personel = context.Personels.First(x => x.ID == personeliID);
                //Student student1 = context.Students.Find(studentId);
                personel.Emri = emri;
                personel.Mbiemri = mbiemri;
                personel.Gjinia = (rtbM.Checked ? "M" : "F");
                personel.Adresa = adresa;
                personel.Email = txtEmail.Text;
                personel.Ditelindja = dtpDitelindja.Value.ToString("dd/MM/yyyy");
                context.SaveChanges();
            }
            ClearFields();
            MessageBox.Show("Perditsimi i te dhenave u realizua me sukses.");
            btnFshije.Visible = false;
            btnNdryshoPersonelin.Visible = false;
            btnRegjistro.Enabled = true;
            pictureBox3.Visible = false;
            pictureBox1.Visible = false;
            FillGrid();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
