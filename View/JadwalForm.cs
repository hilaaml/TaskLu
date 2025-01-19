using System;
using System.Data;
using System.Windows.Forms;

using JadwalMahasiswa.Controller;
using JadwalMahasiswa.Models.Context;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace JadwalMahasiswa.View
{
    public partial class JadwalForm : Form
    {
        private TugasController _controller;
        private string _nim;
        private string _nama;
        private string _email;
        private string _role;
        public JadwalForm(string nim, string nama, string email, string role)
        {
            InitializeComponent();
            this.dgvTugas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTugas_CellContentClick);
            _nim = nim;
            _nama = nama;
            _email = email;
            _role = role;
            lblNama.Text = $"{nama}";
            var context = new DbContext();
            _controller = new TugasController(context);

            LoadData();
        }

        private void LoadData()
        {
            dgvMK.DataSource = _controller.ShowMKByDay();
            dgvTugas.DataSource = _controller.ShowTugas();
            if (dgvTugas.Columns.Contains("IDTugas"))
            {
                dgvTugas.Columns["IDTugas"].Visible = false;
            }
            if (dgvTugas.Columns.Contains("KodeMK"))
            {
                dgvTugas.Columns["KodeMK"].Visible = false;
            }
            if (!dgvTugas.Columns.Contains("status"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.Name = "status";
                checkBoxColumn.HeaderText = "Status";
                checkBoxColumn.DataPropertyName = "status";
                dgvTugas.Columns.Insert(0, checkBoxColumn);
            }
            dgvTugas.RowHeadersWidth = 15;
            dgvTugas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMK.RowHeadersWidth = 15;
            dgvMK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTambahTugas_Click(object sender, EventArgs e)
        {
            var tambahTugasForm = new TambahTugasForm();
            tambahTugasForm.ShowDialog();
            LoadData(); // Refresh task data
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTugas.SelectedRows.Count > 0)
            {
                int idTugas = Convert.ToInt32(dgvTugas.SelectedRows[0].Cells["IDTugas"].Value); // Adjust based on your column names

                // Confirm deletion
                var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus tugas ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    _controller.DeleteTugas(idTugas); // Call your controller's delete method
                    LoadData(); // Refresh data after deletion
                    MessageBox.Show("Data tugas berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih tugas yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvTugas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvTugas.Columns["status"].Index && e.RowIndex >= 0)
            {
                // Toggle the current value of status
                bool currentStatus = Convert.ToBoolean(dgvTugas.Rows[e.RowIndex].Cells["status"].Value);
                dgvTugas.Rows[e.RowIndex].Cells["status"].Value = !currentStatus;

                // Get IDTugas to update in database
                int idTugas = Convert.ToInt32(dgvTugas.Rows[e.RowIndex].Cells["IDTugas"].Value);

                // Update status in database
                var controller = new TugasController(new DbContext());
                controller.UpdateStatus(idTugas, !currentStatus);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTugas.SelectedRows.Count > 0)
            {
                var selectedRow = dgvTugas.SelectedRows[0];

                // Retrieve values from DataGridView
                int idTugas = Convert.ToInt32(selectedRow.Cells["IDTugas"].Value); // Get ID for updating
                string namaTugas = selectedRow.Cells["Tugas"].Value.ToString(); // Get task name
                string deskripsi = selectedRow.Cells["Deskripsi"].Value.ToString(); // Get description
                DateTime deadline = Convert.ToDateTime(selectedRow.Cells["Deadline"].Value); // Get deadline
                string kodeMK = selectedRow.Cells["KodeMK"].Value.ToString(); // Get course code

                // Create and show the update form
                UpdateTugasForm updateForm = new UpdateTugasForm(idTugas, namaTugas, deskripsi, deadline, kodeMK);
                updateForm.ShowDialog();

                // Refresh the DataGridView after closing the update form
                LoadData(); // Reload data to reflect changes
            }
            else
            {
                MessageBox.Show("Silakan pilih tugas yang ingin diedit.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteJadwal_Click(object sender, EventArgs e)
        {

        }

        private void dgvTugas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditMK_Click(object sender, EventArgs e)
        {
            var createMkForm = new EditMKForm();
            createMkForm.ShowDialog();
            LoadData();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string searchTerm = txtCariTugas.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                dgvTugas.DataSource = _controller.SearchTugas(searchTerm);
            }
            else
            {
                LoadData();
            }
        }

    }
}
