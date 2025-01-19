namespace JadwalMahasiswa.View
{
    partial class UpdateTugasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTugasForm));
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.txtDeskripsi = new System.Windows.Forms.TextBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblTugas = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.cmbNamaMK = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.txtNamaTugas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDeskripsi.Location = new System.Drawing.Point(13, 129);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(84, 22);
            this.lblDeskripsi.TabIndex = 22;
            this.lblDeskripsi.Text = "Deskripsi";
            // 
            // txtDeskripsi
            // 
            this.txtDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtDeskripsi.Location = new System.Drawing.Point(130, 129);
            this.txtDeskripsi.Name = "txtDeskripsi";
            this.txtDeskripsi.Size = new System.Drawing.Size(292, 26);
            this.txtDeskripsi.TabIndex = 21;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDeadline.Location = new System.Drawing.Point(13, 93);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(81, 22);
            this.lblDeadline.TabIndex = 20;
            this.lblDeadline.Text = "Deadline";
            // 
            // lblTugas
            // 
            this.lblTugas.AutoSize = true;
            this.lblTugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTugas.Location = new System.Drawing.Point(13, 57);
            this.lblTugas.Name = "lblTugas";
            this.lblTugas.Size = new System.Drawing.Size(61, 22);
            this.lblTugas.TabIndex = 19;
            this.lblTugas.Text = "Tugas";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMK.Location = new System.Drawing.Point(12, 18);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(104, 22);
            this.lblMK.TabIndex = 18;
            this.lblMK.Text = "Mata Kuliah";
            // 
            // cmbNamaMK
            // 
            this.cmbNamaMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbNamaMK.FormattingEnabled = true;
            this.cmbNamaMK.Location = new System.Drawing.Point(130, 18);
            this.cmbNamaMK.Name = "cmbNamaMK";
            this.cmbNamaMK.Size = new System.Drawing.Size(292, 28);
            this.cmbNamaMK.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCancel.Location = new System.Drawing.Point(346, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 38);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Batal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSimpan.Location = new System.Drawing.Point(211, 169);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(129, 38);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan Jadwal";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeadline.Location = new System.Drawing.Point(129, 93);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDeadline.Size = new System.Drawing.Size(292, 26);
            this.dtpDeadline.TabIndex = 14;
            // 
            // txtNamaTugas
            // 
            this.txtNamaTugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtNamaTugas.Location = new System.Drawing.Point(130, 57);
            this.txtNamaTugas.Name = "txtNamaTugas";
            this.txtNamaTugas.Size = new System.Drawing.Size(291, 26);
            this.txtNamaTugas.TabIndex = 13;
            // 
            // UpdateTugasForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(438, 222);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.txtDeskripsi);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblTugas);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.cmbNamaMK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.txtNamaTugas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateTugasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Jadwal";
            this.Load += new System.EventHandler(this.UpdateTugasForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtDeskripsi;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblTugas;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.ComboBox cmbNamaMK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.TextBox txtNamaTugas;
    }
}