namespace SistemiMenaxhimitPersonelit
{
    partial class frmPuna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuna));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPuna = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmdEmriOrganizates = new System.Windows.Forms.ComboBox();
            this.cmbIdPersonit = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIDOrganizates = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPergjegjesite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVitePervoje = new System.Windows.Forms.TextBox();
            this.txtIDpersonit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.MinimizePic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNdrysho = new ePOSOne.btnProduct.Button_WOC();
            this.btnFshije = new ePOSOne.btnProduct.Button_WOC();
            this.btnRegjistro = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuna)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.HeaderPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 587);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.dgvPuna, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 552F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(745, 552);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // dgvPuna
            // 
            this.dgvPuna.AllowUserToAddRows = false;
            this.dgvPuna.AllowUserToDeleteRows = false;
            this.dgvPuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPuna.Location = new System.Drawing.Point(188, 2);
            this.dgvPuna.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPuna.Name = "dgvPuna";
            this.dgvPuna.ReadOnly = true;
            this.dgvPuna.RowHeadersWidth = 51;
            this.dgvPuna.RowTemplate.Height = 24;
            this.dgvPuna.Size = new System.Drawing.Size(555, 548);
            this.dgvPuna.TabIndex = 26;
            this.dgvPuna.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPuna_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.cmdEmriOrganizates);
            this.panel3.Controls.Add(this.cmbIdPersonit);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnNdrysho);
            this.panel3.Controls.Add(this.btnFshije);
            this.panel3.Controls.Add(this.btnRegjistro);
            this.panel3.Controls.Add(this.txtIDOrganizates);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtPergjegjesite);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtVitePervoje);
            this.panel3.Controls.Add(this.txtIDpersonit);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 548);
            this.panel3.TabIndex = 25;
            // 
            // cmdEmriOrganizates
            // 
            this.cmdEmriOrganizates.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEmriOrganizates.FormattingEnabled = true;
            this.cmdEmriOrganizates.Location = new System.Drawing.Point(13, 159);
            this.cmdEmriOrganizates.Name = "cmdEmriOrganizates";
            this.cmdEmriOrganizates.Size = new System.Drawing.Size(156, 26);
            this.cmdEmriOrganizates.TabIndex = 119;
            this.cmdEmriOrganizates.SelectedIndexChanged += new System.EventHandler(this.cmdEmriOrganizates_SelectedIndexChanged);
            // 
            // cmbIdPersonit
            // 
            this.cmbIdPersonit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdPersonit.FormattingEnabled = true;
            this.cmbIdPersonit.Location = new System.Drawing.Point(11, 37);
            this.cmbIdPersonit.Name = "cmbIdPersonit";
            this.cmbIdPersonit.Size = new System.Drawing.Size(159, 26);
            this.cmbIdPersonit.TabIndex = 118;
            this.cmbIdPersonit.SelectedIndexChanged += new System.EventHandler(this.cmbIdPersonit_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.pictureBox3.Image = global::SistemiMenaxhimitPersonelit.Properties.Resources.available_updates_xxl;
            this.pictureBox3.Location = new System.Drawing.Point(25, 480);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 117;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.pictureBox2.Image = global::SistemiMenaxhimitPersonelit.Properties.Resources.x_mark_xxl;
            this.pictureBox2.Location = new System.Drawing.Point(27, 434);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 116;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.pictureBox1.Image = global::SistemiMenaxhimitPersonelit.Properties.Resources.check_mark_3_xxl;
            this.pictureBox1.Location = new System.Drawing.Point(26, 380);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // txtIDOrganizates
            // 
            this.txtIDOrganizates.Enabled = false;
            this.txtIDOrganizates.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOrganizates.Location = new System.Drawing.Point(12, 219);
            this.txtIDOrganizates.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDOrganizates.Name = "txtIDOrganizates";
            this.txtIDOrganizates.Size = new System.Drawing.Size(158, 24);
            this.txtIDOrganizates.TabIndex = 1;
            this.txtIDOrganizates.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDOrganizates_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID e organizates";
            // 
            // txtPergjegjesite
            // 
            this.txtPergjegjesite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPergjegjesite.Location = new System.Drawing.Point(12, 320);
            this.txtPergjegjesite.Margin = new System.Windows.Forms.Padding(2);
            this.txtPergjegjesite.Name = "txtPergjegjesite";
            this.txtPergjegjesite.Size = new System.Drawing.Size(159, 24);
            this.txtPergjegjesite.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 300);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pergjegjesite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Emri personelit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Emri Organizates";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "ID e personit";
            // 
            // txtVitePervoje
            // 
            this.txtVitePervoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVitePervoje.Location = new System.Drawing.Point(12, 265);
            this.txtVitePervoje.Margin = new System.Windows.Forms.Padding(2);
            this.txtVitePervoje.Name = "txtVitePervoje";
            this.txtVitePervoje.Size = new System.Drawing.Size(159, 24);
            this.txtVitePervoje.TabIndex = 2;
            this.txtVitePervoje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVitePervoje_KeyPress);
            // 
            // txtIDpersonit
            // 
            this.txtIDpersonit.Enabled = false;
            this.txtIDpersonit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDpersonit.Location = new System.Drawing.Point(11, 99);
            this.txtIDpersonit.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDpersonit.Name = "txtIDpersonit";
            this.txtIDpersonit.Size = new System.Drawing.Size(159, 24);
            this.txtIDpersonit.TabIndex = 0;
            this.txtIDpersonit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDpersonit_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Vite pervoje";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.HeaderPanel.Controls.Add(this.ClosePic);
            this.HeaderPanel.Controls.Add(this.pictureBox4);
            this.HeaderPanel.Controls.Add(this.MinimizePic);
            this.HeaderPanel.Controls.Add(this.label3);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(745, 35);
            this.HeaderPanel.TabIndex = 23;
            // 
            // ClosePic
            // 
            this.ClosePic.Image = global::SistemiMenaxhimitPersonelit.Properties.Resources.close_window_xxl;
            this.ClosePic.Location = new System.Drawing.Point(710, 3);
            this.ClosePic.Margin = new System.Windows.Forms.Padding(2);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.Size = new System.Drawing.Size(26, 26);
            this.ClosePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePic.TabIndex = 27;
            this.ClosePic.TabStop = false;
            this.ClosePic.Click += new System.EventHandler(this.ClosePic_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::SistemiMenaxhimitPersonelit.Properties.Resources.WhatsApp_Image_2020_05_16_at_23_22_00;
            this.pictureBox4.Location = new System.Drawing.Point(8, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 28);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.MinimizePic_Click);
            // 
            // MinimizePic
            // 
            this.MinimizePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizePic.Image = global::SistemiMenaxhimitPersonelit.Properties.Resources.minimize_window_xxl;
            this.MinimizePic.Location = new System.Drawing.Point(676, 3);
            this.MinimizePic.Name = "MinimizePic";
            this.MinimizePic.Size = new System.Drawing.Size(31, 26);
            this.MinimizePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizePic.TabIndex = 26;
            this.MinimizePic.TabStop = false;
            this.MinimizePic.Click += new System.EventHandler(this.MinimizePic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(161, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 14;
            // 
            // btnNdrysho
            // 
            this.btnNdrysho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNdrysho.BackColor = System.Drawing.Color.Transparent;
            this.btnNdrysho.BorderColor = System.Drawing.Color.Transparent;
            this.btnNdrysho.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnNdrysho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNdrysho.FlatAppearance.BorderSize = 0;
            this.btnNdrysho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNdrysho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNdrysho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNdrysho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNdrysho.Location = new System.Drawing.Point(3, 470);
            this.btnNdrysho.Name = "btnNdrysho";
            this.btnNdrysho.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNdrysho.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnNdrysho.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNdrysho.Size = new System.Drawing.Size(167, 46);
            this.btnNdrysho.TabIndex = 107;
            this.btnNdrysho.TabStop = false;
            this.btnNdrysho.Text = "Ndrysho";
            this.btnNdrysho.TextColor = System.Drawing.Color.White;
            this.btnNdrysho.UseVisualStyleBackColor = false;
            this.btnNdrysho.Visible = false;
            this.btnNdrysho.Click += new System.EventHandler(this.btnNdrysho_Click);
            // 
            // btnFshije
            // 
            this.btnFshije.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFshije.BackColor = System.Drawing.Color.Transparent;
            this.btnFshije.BorderColor = System.Drawing.Color.Transparent;
            this.btnFshije.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnFshije.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFshije.FlatAppearance.BorderSize = 0;
            this.btnFshije.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFshije.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFshije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFshije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFshije.Location = new System.Drawing.Point(4, 422);
            this.btnFshije.Name = "btnFshije";
            this.btnFshije.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFshije.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnFshije.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFshije.Size = new System.Drawing.Size(167, 46);
            this.btnFshije.TabIndex = 107;
            this.btnFshije.TabStop = false;
            this.btnFshije.Text = "Fshije";
            this.btnFshije.TextColor = System.Drawing.Color.White;
            this.btnFshije.UseVisualStyleBackColor = false;
            this.btnFshije.Visible = false;
            this.btnFshije.Click += new System.EventHandler(this.btnFshije_Click);
            // 
            // btnRegjistro
            // 
            this.btnRegjistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegjistro.BackColor = System.Drawing.Color.Transparent;
            this.btnRegjistro.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegjistro.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnRegjistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegjistro.FlatAppearance.BorderSize = 0;
            this.btnRegjistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegjistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegjistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegjistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegjistro.Image = ((System.Drawing.Image)(resources.GetObject("btnRegjistro.Image")));
            this.btnRegjistro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegjistro.Location = new System.Drawing.Point(6, 370);
            this.btnRegjistro.Name = "btnRegjistro";
            this.btnRegjistro.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegjistro.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.btnRegjistro.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegjistro.Size = new System.Drawing.Size(165, 46);
            this.btnRegjistro.TabIndex = 106;
            this.btnRegjistro.TabStop = false;
            this.btnRegjistro.Text = "Regjistro";
            this.btnRegjistro.TextColor = System.Drawing.Color.White;
            this.btnRegjistro.UseVisualStyleBackColor = false;
            this.btnRegjistro.Click += new System.EventHandler(this.btnRegjistro_Click);
            // 
            // frmPuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 587);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPuna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPersoneliOrganizate";
            this.Load += new System.EventHandler(this.frmPuna_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuna)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private ePOSOne.btnProduct.Button_WOC btnFshije;
        private ePOSOne.btnProduct.Button_WOC btnRegjistro;
        private System.Windows.Forms.TextBox txtIDOrganizates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPergjegjesite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVitePervoje;
        private System.Windows.Forms.TextBox txtIDpersonit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvPuna;
        private System.Windows.Forms.PictureBox MinimizePic;
        private System.Windows.Forms.PictureBox ClosePic;
        private ePOSOne.btnProduct.Button_WOC btnNdrysho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cmbIdPersonit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdEmriOrganizates;
        private System.Windows.Forms.Label label2;
    }
}