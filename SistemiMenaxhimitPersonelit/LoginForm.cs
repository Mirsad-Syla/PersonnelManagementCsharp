using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemiMenaxhimitPersonelit
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = txtUsername.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=Mirsad;Initial Catalog=SistemiMenaxhimitPersonelit;Integrated Security=True"); // making connection   
            string query = "SELECT * FROM Login WHERE Username='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "'";
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                MainForm frm = new MainForm();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Perdoruesi/Fjalekalimi eshte gabim", "Verejtje",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Invalid username or password");
                txtPassword.Text = txtUsername.Text = "";
            }
                
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MinimizePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ClosePic_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //8 - backspace
            if (!char.IsLetter(e.KeyChar) && (ch != 8))
            {
                e.Handled = true;
                MessageBox.Show("Nuk lejohet perdorimi i numrave dhe simboleve.", "Verejtje");
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtPassword.Text = txtUsername.Text = "";
        }
    }
}
