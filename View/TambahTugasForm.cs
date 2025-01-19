using JadwalMahasiswa.Controller;
using JadwalMahasiswa.Models.Context;
using JadwalMahasiswa.Models.Repository;
using System;
using System.Data;
using System.Windows.Forms;

namespace JadwalMahasiswa.View
{
    public partial class TambahTugasForm : Form
    {
        private TugasRepository _tugasRepo;

        public TambahTugasForm()
        {
            InitializeComponent();
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
                controller.CreateTugas(kodeMK, namaTugas, deskripsi, deadline);

                MessageBox.Show("Tugas berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TambahTugasForm_Load(object sender, EventArgs e)
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {

        }
    }
}
