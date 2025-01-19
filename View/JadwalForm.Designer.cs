namespace JadwalMahasiswa.View
{
    partial class JadwalForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JadwalForm));
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTambahTugas = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteJadwal = new System.Windows.Forms.Button();
            this.lblNama = new System.Windows.Forms.Label();
            this.dgvTugas = new System.Windows.Forms.DataGridView();
            this.dgvMK = new System.Windows.Forms.DataGridView();
            this.btnEditMK = new System.Windows.Forms.Button();
            this.txtCariTugas = new System.Windows.Forms.TextBox();
            this.btnCari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTugas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMK)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(36, 269);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(118, 39);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnTambahTugas
            // 
            this.btnTambahTugas.Location = new System.Drawing.Point(467, 323);
            this.btnTambahTugas.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambahTugas.Name = "btnTambahTugas";
            this.btnTambahTugas.Size = new System.Drawing.Size(134, 32);
            this.btnTambahTugas.TabIndex = 1;
            this.btnTambahTugas.Text = "Tambah";
            this.btnTambahTugas.UseVisualStyleBackColor = true;
            this.btnTambahTugas.Click += new System.EventHandler(this.btnTambahTugas_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(607, 323);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 32);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteJadwal
            // 
            this.btnDeleteJadwal.Location = new System.Drawing.Point(728, 323);
            this.btnDeleteJadwal.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteJadwal.Name = "btnDeleteJadwal";
            this.btnDeleteJadwal.Size = new System.Drawing.Size(135, 32);
            this.btnDeleteJadwal.TabIndex = 6;
            this.btnDeleteJadwal.Text = "Hapus";
            this.btnDeleteJadwal.UseVisualStyleBackColor = true;
            this.btnDeleteJadwal.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblNama.Location = new System.Drawing.Point(48, 240);
            this.lblNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(66, 20);
            this.lblNama.TabIndex = 7;
            this.lblNama.Text = "lblNama";
            // 
            // dgvTugas
            // 
            this.dgvTugas.AllowUserToAddRows = false;
            this.dgvTugas.AllowUserToDeleteRows = false;
            this.dgvTugas.AllowUserToOrderColumns = true;
            this.dgvTugas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTugas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTugas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTugas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTugas.Location = new System.Drawing.Point(41, 364);
            this.dgvTugas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTugas.Name = "dgvTugas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTugas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTugas.RowHeadersWidth = 62;
            this.dgvTugas.RowTemplate.Height = 28;
            this.dgvTugas.Size = new System.Drawing.Size(830, 250);
            this.dgvTugas.TabIndex = 10;
            this.dgvTugas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTugas_CellContentClick_1);
            // 
            // dgvMK
            // 
            this.dgvMK.AllowUserToAddRows = false;
            this.dgvMK.AllowUserToDeleteRows = false;
            this.dgvMK.AllowUserToOrderColumns = true;
            this.dgvMK.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMK.Location = new System.Drawing.Point(263, 85);
            this.dgvMK.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMK.Name = "dgvMK";
            this.dgvMK.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMK.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMK.RowHeadersWidth = 62;
            this.dgvMK.RowTemplate.Height = 28;
            this.dgvMK.Size = new System.Drawing.Size(607, 174);
            this.dgvMK.TabIndex = 9;
            // 
            // btnEditMK
            // 
            this.btnEditMK.BackColor = System.Drawing.Color.LightPink;
            this.btnEditMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMK.Location = new System.Drawing.Point(607, 49);
            this.btnEditMK.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditMK.Name = "btnEditMK";
            this.btnEditMK.Size = new System.Drawing.Size(255, 32);
            this.btnEditMK.TabIndex = 17;
            this.btnEditMK.Text = "Edit";
            this.btnEditMK.UseVisualStyleBackColor = false;
            this.btnEditMK.Click += new System.EventHandler(this.btnEditMK_Click);
            // 
            // txtCariTugas
            // 
            this.txtCariTugas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCariTugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCariTugas.Location = new System.Drawing.Point(215, 280);
            this.txtCariTugas.Name = "txtCariTugas";
            this.txtCariTugas.Size = new System.Drawing.Size(573, 23);
            this.txtCariTugas.TabIndex = 19;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.LightPink;
            this.btnCari.Location = new System.Drawing.Point(793, 276);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(69, 25);
            this.btnCari.TabIndex = 20;
            this.btnCari.Text = "Cari Tugas";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // JadwalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::JadwalMahasiswa.Properties.Resources.dashboard__mhs_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(918, 644);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCariTugas);
            this.Controls.Add(this.btnEditMK);
            this.Controls.Add(this.dgvTugas);
            this.Controls.Add(this.dgvMK);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.btnDeleteJadwal);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambahTugas);
            this.Controls.Add(this.btnLogout);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JadwalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskLu - Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTugas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnTambahTugas;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteJadwal;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.DataGridView dgvTugas;
        private System.Windows.Forms.DataGridView dgvMK;
        private System.Windows.Forms.Button btnEditMK;
        private System.Windows.Forms.TextBox txtCariTugas;
        private System.Windows.Forms.Button btnCari;
    }
}