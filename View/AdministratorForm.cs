using System.Linq;
using System;
using System.Data;
using System.Windows.Forms;

using JadwalMahasiswa.Controller;
using JadwalMahasiswa.Models.Context;
using JadwalMahasiswa.Models.Entity;
using JadwalMahasiswa.Models.Repository;
using JadwalMahasiswa.View;

namespace JadwalMahasiswa.View
{
    public partial class AdministratorForm : Form
    {
        private AdministratorController _controller;

        public AdministratorForm(string nim, string nama, string email, string role)
        {
            InitializeComponent();
            _controller = new AdministratorController();
            LoadUsers();
        }
        private void LoadUsers()
        {
            dgvUser.DataSource = _controller.GetAllUsers();
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedNIM = dgvUser.Rows[e.RowIndex].Cells["NIM"].Value.ToString();
            UpdateUserForm updateForm = new UpdateUserForm(selectedNIM);
            updateForm.ShowDialog();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string searchTerm = txtCari.Text.Trim();
            var filteredUsers = _controller.GetAllUsers()
                .Where(u => u.Nama.Contains(searchTerm) || u.Email.Contains(searchTerm))
                .ToList();
            dgvUser.DataSource = filteredUsers;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            CreateUserForm createForm = new CreateUserForm();
            createForm.ShowDialog();
            LoadUsers();
        }


        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                var selectedUser = (Mahasiswa)dgvUser.SelectedRows[0].DataBoundItem; // Ensure this cast is valid
                UpdateUserForm updateForm = new UpdateUserForm(selectedUser.NIM);
                updateForm.ShowDialog();
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Silakan pilih dahulu.");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedRows.Count > 0)
            {
                var selectedUser = (Mahasiswa)dgvUser.SelectedRows[0].DataBoundItem;
                string nim = selectedUser.NIM;

                var confirmResult = MessageBox.Show("Apa yakin ingin menghapus?", "Hapus konfirmasi", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _controller.DeleteUser(nim);
                    LoadUsers(); // Refresh user data after deletion
                    MessageBox.Show("Berhasil dihapus.");
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih dahulu.");
            }
        }


        private void btnKeluar_Click(object sender, EventArgs e)
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
    }
}
