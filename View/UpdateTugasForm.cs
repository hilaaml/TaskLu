using System;
using System.Data;
using System.Windows.Forms;
using JadwalMahasiswa.Models.Repository;
using JadwalMahasiswa.Models.Context;
using JadwalMahasiswa.Controller;

namespace JadwalMahasiswa.View
{
    public partial class UpdateTugasForm : Form
    {
        private int _idTugas;

        public UpdateTugasForm(int idTugas, string namaTugas, string deskripsi, DateTime deadline, string kodeMK)
        {
            InitializeComponent();
            _idTugas = idTugas;
            txtNamaTugas.Text = namaTugas;
            txtDeskripsi.Text = deskripsi;
            dtpDeadline.Value = deadline;

            LoadMatakuliah();
            cmbNamaMK.SelectedValue = kodeMK;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string kodeMK = cmbNamaMK.SelectedValue.ToString();
                string namaTugas = txtNamaTugas.Text;
                string deskripsi = txtDeskripsi.Text;
                DateTime deadline = dtpDeadline.Value;

                TugasController controller = new TugasController(new DbContext());
                controller.UpdateTugas(_idTugas, kodeMK, namaTugas, deskripsi, deadline);

                MessageBox.Show("Tugas berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close the form after saving
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtNamaTugas.Text))
            {
                MessageBox.Show("Nama Tugas harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDeskripsi.Text))
            {
                MessageBox.Show("Deskripsi harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbNamaMK.SelectedItem == null)
            {
                MessageBox.Show("Pilih Mata Kuliah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // All validations passed
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTugasForm_Load(object sender, EventArgs e)
        {
            LoadMatakuliah();
        }

        private void LoadMatakuliah()
        {
            using (var context = new DbContext())
            {
                var repository = new TugasRepository(context);
                DataTable matakuliahTable = repository.GetAllMatakuliah();

                if (matakuliahTable != null && matakuliahTable.Rows.Count > 0)
                {
                    cmbNamaMK.DataSource = matakuliahTable;
                    cmbNamaMK.DisplayMember = "NamaMK";
                    cmbNamaMK.ValueMember = "IdMK";
                }
                else
                {
                    MessageBox.Show("Tidak ada mata kuliah yang tersedia.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

        }

        private void UpdateTugasForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
