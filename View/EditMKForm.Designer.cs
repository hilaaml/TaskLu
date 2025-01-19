namespace JadwalMahasiswa.View
{
    partial class EditMKForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMKForm));
            this.lblHari = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.lblKMK = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSimpanMK = new System.Windows.Forms.Button();
            this.txtNamaMK = new System.Windows.Forms.TextBox();
            this.txtIdMK = new System.Windows.Forms.TextBox();
            this.cmbHari = new System.Windows.Forms.ComboBox();
            this.lblSesi = new System.Windows.Forms.Label();
            this.cmbMK = new System.Windows.Forms.ComboBox();
            this.lblMK2 = new System.Windows.Forms.Label();
            this.btnSimpanJadwalMK = new System.Windows.Forms.Button();
            this.lvwJadwalMK = new System.Windows.Forms.ListView();
            this.gbEditMK = new System.Windows.Forms.GroupBox();
            this.cmbDosen = new System.Windows.Forms.ComboBox();
            this.lbDosen = new System.Windows.Forms.Label();
            this.gbEditJadwalMK = new System.Windows.Forms.GroupBox();
            this.txtIJMK = new System.Windows.Forms.TextBox();
            this.IJMK = new System.Windows.Forms.Label();
            this.cmbSesi = new System.Windows.Forms.ComboBox();
            this.gbJadwalMK = new System.Windows.Forms.GroupBox();
            this.gbEditDosen = new System.Windows.Forms.GroupBox();
            this.txtNamaDosen = new System.Windows.Forms.TextBox();
            this.txtNIDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimpanDosen = new System.Windows.Forms.Button();
            this.NIDN = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.gbDosen = new System.Windows.Forms.GroupBox();
            this.lvwDosen = new System.Windows.Forms.ListView();
            this.gbMK = new System.Windows.Forms.GroupBox();
            this.lvwMataKuliah = new System.Windows.Forms.ListView();
            this.gbEditMK.SuspendLayout();
            this.gbEditJadwalMK.SuspendLayout();
            this.gbJadwalMK.SuspendLayout();
            this.gbEditDosen.SuspendLayout();
            this.gbDosen.SuspendLayout();
            this.gbMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHari
            // 
            this.lblHari.AutoSize = true;
            this.lblHari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblHari.Location = new System.Drawing.Point(8, 75);
            this.lblHari.Name = "lblHari";
            this.lblHari.Size = new System.Drawing.Size(43, 22);
            this.lblHari.TabIndex = 22;
            this.lblHari.Text = "Hari";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMK.Location = new System.Drawing.Point(8, 69);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(104, 22);
            this.lblMK.TabIndex = 19;
            this.lblMK.Text = "Mata Kuliah";
            // 
            // lblKMK
            // 
            this.lblKMK.AutoSize = true;
            this.lblKMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblKMK.Location = new System.Drawing.Point(8, 31);
            this.lblKMK.Name = "lblKMK";
            this.lblKMK.Size = new System.Drawing.Size(109, 22);
            this.lblKMK.TabIndex = 18;
            this.lblKMK.Text = "Kode Matkul";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCancel.Location = new System.Drawing.Point(346, 629);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 31);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Selesai";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSimpanMK
            // 
            this.btnSimpanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSimpanMK.Location = new System.Drawing.Point(245, 154);
            this.btnSimpanMK.Name = "btnSimpanMK";
            this.btnSimpanMK.Size = new System.Drawing.Size(178, 31);
            this.btnSimpanMK.TabIndex = 15;
            this.btnSimpanMK.Text = "Simpan Mata Kuliah";
            this.btnSimpanMK.UseVisualStyleBackColor = true;
            this.btnSimpanMK.Click += new System.EventHandler(this.btnSimpanMK_Click);
            // 
            // txtNamaMK
            // 
            this.txtNamaMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtNamaMK.Location = new System.Drawing.Point(129, 66);
            this.txtNamaMK.Name = "txtNamaMK";
            this.txtNamaMK.Size = new System.Drawing.Size(294, 26);
            this.txtNamaMK.TabIndex = 13;
            // 
            // txtIdMK
            // 
            this.txtIdMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtIdMK.Location = new System.Drawing.Point(129, 29);
            this.txtIdMK.Name = "txtIdMK";
            this.txtIdMK.Size = new System.Drawing.Size(294, 26);
            this.txtIdMK.TabIndex = 23;
            // 
            // cmbHari
            // 
            this.cmbHari.AutoCompleteCustomSource.AddRange(new string[] {
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat",
            "Sabtu"});
            this.cmbHari.FormattingEnabled = true;
            this.cmbHari.Items.AddRange(new object[] {
            "Senin",
            "Selasa",
            "Rabu",
            "Kamis",
            "Jumat",
            "Sabtu",
            "Minggu"});
            this.cmbHari.Location = new System.Drawing.Point(129, 75);
            this.cmbHari.Name = "cmbHari";
            this.cmbHari.Size = new System.Drawing.Size(294, 28);
            this.cmbHari.TabIndex = 24;
            // 
            // lblSesi
            // 
            this.lblSesi.AutoSize = true;
            this.lblSesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSesi.Location = new System.Drawing.Point(8, 115);
            this.lblSesi.Name = "lblSesi";
            this.lblSesi.Size = new System.Drawing.Size(45, 22);
            this.lblSesi.TabIndex = 25;
            this.lblSesi.Text = "Sesi";
            // 
            // cmbMK
            // 
            this.cmbMK.FormattingEnabled = true;
            this.cmbMK.Location = new System.Drawing.Point(129, 34);
            this.cmbMK.Name = "cmbMK";
            this.cmbMK.Size = new System.Drawing.Size(294, 28);
            this.cmbMK.TabIndex = 28;
            // 
            // lblMK2
            // 
            this.lblMK2.AutoSize = true;
            this.lblMK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMK2.Location = new System.Drawing.Point(8, 35);
            this.lblMK2.Name = "lblMK2";
            this.lblMK2.Size = new System.Drawing.Size(104, 22);
            this.lblMK2.TabIndex = 27;
            this.lblMK2.Text = "Mata Kuliah";
            // 
            // btnSimpanJadwalMK
            // 
            this.btnSimpanJadwalMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSimpanJadwalMK.Location = new System.Drawing.Point(202, 184);
            this.btnSimpanJadwalMK.Name = "btnSimpanJadwalMK";
            this.btnSimpanJadwalMK.Size = new System.Drawing.Size(220, 31);
            this.btnSimpanJadwalMK.TabIndex = 29;
            this.btnSimpanJadwalMK.Text = "Simpan Jadwal Matkul";
            this.btnSimpanJadwalMK.UseVisualStyleBackColor = true;
            this.btnSimpanJadwalMK.Click += new System.EventHandler(this.btnSimpanJadwalMK_Click);
            // 
            // lvwJadwalMK
            // 
            this.lvwJadwalMK.HideSelection = false;
            this.lvwJadwalMK.Location = new System.Drawing.Point(9, 32);
            this.lvwJadwalMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwJadwalMK.Name = "lvwJadwalMK";
            this.lvwJadwalMK.Size = new System.Drawing.Size(341, 559);
            this.lvwJadwalMK.TabIndex = 30;
            this.lvwJadwalMK.UseCompatibleStateImageBehavior = false;
            // 
            // gbEditMK
            // 
            this.gbEditMK.Controls.Add(this.cmbDosen);
            this.gbEditMK.Controls.Add(this.lbDosen);
            this.gbEditMK.Controls.Add(this.btnSimpanMK);
            this.gbEditMK.Controls.Add(this.txtNamaMK);
            this.gbEditMK.Controls.Add(this.lblKMK);
            this.gbEditMK.Controls.Add(this.lblMK);
            this.gbEditMK.Controls.Add(this.txtIdMK);
            this.gbEditMK.Location = new System.Drawing.Point(16, 17);
            this.gbEditMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEditMK.Name = "gbEditMK";
            this.gbEditMK.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEditMK.Size = new System.Drawing.Size(441, 204);
            this.gbEditMK.TabIndex = 31;
            this.gbEditMK.TabStop = false;
            this.gbEditMK.Text = "Mata Kuliah";
            // 
            // cmbDosen
            // 
            this.cmbDosen.FormattingEnabled = true;
            this.cmbDosen.Location = new System.Drawing.Point(127, 111);
            this.cmbDosen.Name = "cmbDosen";
            this.cmbDosen.Size = new System.Drawing.Size(294, 28);
            this.cmbDosen.TabIndex = 29;
            // 
            // lbDosen
            // 
            this.lbDosen.AutoSize = true;
            this.lbDosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbDosen.Location = new System.Drawing.Point(8, 112);
            this.lbDosen.Name = "lbDosen";
            this.lbDosen.Size = new System.Drawing.Size(62, 22);
            this.lbDosen.TabIndex = 25;
            this.lbDosen.Text = "Dosen";
            // 
            // gbEditJadwalMK
            // 
            this.gbEditJadwalMK.Controls.Add(this.txtIJMK);
            this.gbEditJadwalMK.Controls.Add(this.IJMK);
            this.gbEditJadwalMK.Controls.Add(this.cmbSesi);
            this.gbEditJadwalMK.Controls.Add(this.lblSesi);
            this.gbEditJadwalMK.Controls.Add(this.lblHari);
            this.gbEditJadwalMK.Controls.Add(this.cmbHari);
            this.gbEditJadwalMK.Controls.Add(this.btnSimpanJadwalMK);
            this.gbEditJadwalMK.Controls.Add(this.cmbMK);
            this.gbEditJadwalMK.Controls.Add(this.lblMK2);
            this.gbEditJadwalMK.Location = new System.Drawing.Point(13, 231);
            this.gbEditJadwalMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEditJadwalMK.Name = "gbEditJadwalMK";
            this.gbEditJadwalMK.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEditJadwalMK.Size = new System.Drawing.Size(441, 223);
            this.gbEditJadwalMK.TabIndex = 32;
            this.gbEditJadwalMK.TabStop = false;
            this.gbEditJadwalMK.Text = "Jadwal Mata Kuliah";
            // 
            // txtIJMK
            // 
            this.txtIJMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtIJMK.Location = new System.Drawing.Point(128, 152);
            this.txtIJMK.Name = "txtIJMK";
            this.txtIJMK.Size = new System.Drawing.Size(294, 26);
            this.txtIJMK.TabIndex = 32;
            // 
            // IJMK
            // 
            this.IJMK.AutoSize = true;
            this.IJMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.IJMK.Location = new System.Drawing.Point(8, 151);
            this.IJMK.Name = "IJMK";
            this.IJMK.Size = new System.Drawing.Size(49, 22);
            this.IJMK.TabIndex = 31;
            this.IJMK.Text = "IJMK";
            // 
            // cmbSesi
            // 
            this.cmbSesi.AutoCompleteCustomSource.AddRange(new string[] {
            "Sesi 1",
            "Sesi 2",
            "Sesi 3",
            "Sesi 4",
            "Sesi 5"});
            this.cmbSesi.FormattingEnabled = true;
            this.cmbSesi.Items.AddRange(new object[] {
            "07:00 - 08:40",
            "08:50 - 10:30",
            "10:40 - 12:20",
            "13:20 - 15:00",
            "15:00 - 17:10"});
            this.cmbSesi.Location = new System.Drawing.Point(128, 114);
            this.cmbSesi.Name = "cmbSesi";
            this.cmbSesi.Size = new System.Drawing.Size(294, 28);
            this.cmbSesi.TabIndex = 30;
            // 
            // gbJadwalMK
            // 
            this.gbJadwalMK.Controls.Add(this.lvwJadwalMK);
            this.gbJadwalMK.Location = new System.Drawing.Point(466, 18);
            this.gbJadwalMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbJadwalMK.Name = "gbJadwalMK";
            this.gbJadwalMK.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbJadwalMK.Size = new System.Drawing.Size(367, 601);
            this.gbJadwalMK.TabIndex = 33;
            this.gbJadwalMK.TabStop = false;
            this.gbJadwalMK.Text = "Jadwal Mata Kuliah";
            // 
            // gbEditDosen
            // 
            this.gbEditDosen.Controls.Add(this.txtNamaDosen);
            this.gbEditDosen.Controls.Add(this.txtNIDN);
            this.gbEditDosen.Controls.Add(this.label2);
            this.gbEditDosen.Controls.Add(this.btnSimpanDosen);
            this.gbEditDosen.Controls.Add(this.NIDN);
            this.gbEditDosen.Location = new System.Drawing.Point(13, 464);
            this.gbEditDosen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEditDosen.Name = "gbEditDosen";
            this.gbEditDosen.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbEditDosen.Size = new System.Drawing.Size(441, 155);
            this.gbEditDosen.TabIndex = 33;
            this.gbEditDosen.TabStop = false;
            this.gbEditDosen.Text = "Dosen";
            // 
            // txtNamaDosen
            // 
            this.txtNamaDosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtNamaDosen.Location = new System.Drawing.Point(129, 74);
            this.txtNamaDosen.Name = "txtNamaDosen";
            this.txtNamaDosen.Size = new System.Drawing.Size(294, 26);
            this.txtNamaDosen.TabIndex = 31;
            // 
            // txtNIDN
            // 
            this.txtNIDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtNIDN.Location = new System.Drawing.Point(129, 34);
            this.txtNIDN.Name = "txtNIDN";
            this.txtNIDN.Size = new System.Drawing.Size(294, 26);
            this.txtNIDN.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nama Dosen";
            // 
            // btnSimpanDosen
            // 
            this.btnSimpanDosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSimpanDosen.Location = new System.Drawing.Point(207, 109);
            this.btnSimpanDosen.Name = "btnSimpanDosen";
            this.btnSimpanDosen.Size = new System.Drawing.Size(220, 31);
            this.btnSimpanDosen.TabIndex = 29;
            this.btnSimpanDosen.Text = "Simpan Dosen";
            this.btnSimpanDosen.UseVisualStyleBackColor = true;
            this.btnSimpanDosen.Click += new System.EventHandler(this.btnSimpanDosen_Click);
            // 
            // NIDN
            // 
            this.NIDN.AutoSize = true;
            this.NIDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NIDN.Location = new System.Drawing.Point(8, 35);
            this.NIDN.Name = "NIDN";
            this.NIDN.Size = new System.Drawing.Size(53, 22);
            this.NIDN.TabIndex = 27;
            this.NIDN.Text = "NIDN";
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnHapus.Location = new System.Drawing.Point(968, 627);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(93, 31);
            this.btnHapus.TabIndex = 34;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // gbDosen
            // 
            this.gbDosen.Controls.Add(this.lvwDosen);
            this.gbDosen.Location = new System.Drawing.Point(841, 18);
            this.gbDosen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDosen.Name = "gbDosen";
            this.gbDosen.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDosen.Size = new System.Drawing.Size(236, 258);
            this.gbDosen.TabIndex = 34;
            this.gbDosen.TabStop = false;
            this.gbDosen.Text = "Dosen";
            // 
            // lvwDosen
            // 
            this.lvwDosen.HideSelection = false;
            this.lvwDosen.Location = new System.Drawing.Point(9, 32);
            this.lvwDosen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwDosen.Name = "lvwDosen";
            this.lvwDosen.Size = new System.Drawing.Size(211, 217);
            this.lvwDosen.TabIndex = 30;
            this.lvwDosen.UseCompatibleStateImageBehavior = false;
            // 
            // gbMK
            // 
            this.gbMK.Controls.Add(this.lvwMataKuliah);
            this.gbMK.Location = new System.Drawing.Point(841, 286);
            this.gbMK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMK.Name = "gbMK";
            this.gbMK.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbMK.Size = new System.Drawing.Size(236, 333);
            this.gbMK.TabIndex = 35;
            this.gbMK.TabStop = false;
            this.gbMK.Text = "MataKuliah";
            // 
            // lvwMataKuliah
            // 
            this.lvwMataKuliah.HideSelection = false;
            this.lvwMataKuliah.Location = new System.Drawing.Point(9, 32);
            this.lvwMataKuliah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwMataKuliah.Name = "lvwMataKuliah";
            this.lvwMataKuliah.Size = new System.Drawing.Size(211, 291);
            this.lvwMataKuliah.TabIndex = 30;
            this.lvwMataKuliah.UseCompatibleStateImageBehavior = false;
            // 
            // EditMKForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 674);
            this.Controls.Add(this.gbMK);
            this.Controls.Add(this.gbDosen);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.gbEditDosen);
            this.Controls.Add(this.gbJadwalMK);
            this.Controls.Add(this.gbEditJadwalMK);
            this.Controls.Add(this.gbEditMK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMKForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskLu - Edit Jadwal Mata Kuliah";
            this.gbEditMK.ResumeLayout(false);
            this.gbEditMK.PerformLayout();
            this.gbEditJadwalMK.ResumeLayout(false);
            this.gbEditJadwalMK.PerformLayout();
            this.gbJadwalMK.ResumeLayout(false);
            this.gbEditDosen.ResumeLayout(false);
            this.gbEditDosen.PerformLayout();
            this.gbDosen.ResumeLayout(false);
            this.gbMK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHari;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.Label lblKMK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSimpanMK;
        private System.Windows.Forms.TextBox txtNamaMK;
        private System.Windows.Forms.TextBox txtIdMK;
        private System.Windows.Forms.ComboBox cmbHari;
        private System.Windows.Forms.Label lblSesi;
        private System.Windows.Forms.ComboBox cmbMK;
        private System.Windows.Forms.Label lblMK2;
        private System.Windows.Forms.Button btnSimpanJadwalMK;
        private System.Windows.Forms.ListView lvwJadwalMK;
        private System.Windows.Forms.GroupBox gbEditMK;
        private System.Windows.Forms.GroupBox gbEditJadwalMK;
        private System.Windows.Forms.GroupBox gbJadwalMK;
        private System.Windows.Forms.GroupBox gbEditDosen;
        private System.Windows.Forms.Button btnSimpanDosen;
        private System.Windows.Forms.Label NIDN;
        private System.Windows.Forms.ComboBox cmbDosen;
        private System.Windows.Forms.Label lbDosen;
        private System.Windows.Forms.TextBox txtNamaDosen;
        private System.Windows.Forms.TextBox txtNIDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSesi;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.GroupBox gbDosen;
        private System.Windows.Forms.ListView lvwDosen;
        private System.Windows.Forms.GroupBox gbMK;
        private System.Windows.Forms.ListView lvwMataKuliah;
        private System.Windows.Forms.Label IJMK;
        private System.Windows.Forms.TextBox txtIJMK;
    }
}