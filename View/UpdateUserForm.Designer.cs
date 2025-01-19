namespace JadwalMahasiswa.View
{
    partial class UpdateUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblTugas = new System.Windows.Forms.Label();
            this.lblMK = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(15, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Role";
            // 
            // txtRole
            // 
            this.txtRole.AutoCompleteCustomSource.AddRange(new string[] {
            "User",
            "Admin"});
            this.txtRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtRole.Location = new System.Drawing.Point(136, 160);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(293, 26);
            this.txtRole.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtEmail.Location = new System.Drawing.Point(136, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 26);
            this.txtEmail.TabIndex = 36;
            // 
            // txtNIM
            // 
            this.txtNIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtNIM.Location = new System.Drawing.Point(136, 14);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(293, 26);
            this.txtNIM.TabIndex = 35;
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDeskripsi.Location = new System.Drawing.Point(15, 126);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(89, 22);
            this.lblDeskripsi.TabIndex = 34;
            this.lblDeskripsi.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtPassword.Location = new System.Drawing.Point(136, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(293, 26);
            this.txtPassword.TabIndex = 33;
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDeadline.Location = new System.Drawing.Point(15, 92);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(52, 22);
            this.lblDeadline.TabIndex = 32;
            this.lblDeadline.Text = "Surel";
            // 
            // lblTugas
            // 
            this.lblTugas.AutoSize = true;
            this.lblTugas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTugas.Location = new System.Drawing.Point(15, 54);
            this.lblTugas.Name = "lblTugas";
            this.lblTugas.Size = new System.Drawing.Size(57, 22);
            this.lblTugas.TabIndex = 31;
            this.lblTugas.Text = "Nama";
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMK.Location = new System.Drawing.Point(15, 15);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(41, 22);
            this.lblMK.TabIndex = 30;
            this.lblMK.Text = "NIM";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCancel.Location = new System.Drawing.Point(311, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 38);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Batal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSimpan.Location = new System.Drawing.Point(166, 192);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(136, 38);
            this.btnSimpan.TabIndex = 28;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtNama.Location = new System.Drawing.Point(136, 51);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(293, 26);
            this.txtNama.TabIndex = 27;
            // 
            // UpdateUserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(444, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblTugas);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtNama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblTugas;
        private System.Windows.Forms.Label lblMK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtNama;
    }
}