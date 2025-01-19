using System.Linq;
using System;
using System.Windows.Forms;

using JadwalMahasiswa.Models.Entity;
using JadwalMahasiswa.Models.Repository;
using JadwalMahasiswa.Controller;

namespace JadwalMahasiswa.View
{
    public partial class UpdateUserForm : Form
    {
        private UserRepository _userRepository;
        private string _nim;

        public UpdateUserForm(string nim)
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            _nim = nim;
            LoadUserData(nim);
        }
        private void LoadUserData(string nim)
        {
            var user = _userRepository.GetUserByNIM(nim); // Method to fetch user data
            if (user != null)
            {
                txtNIM.Text = user.NIM;
                txtNama.Text = user.Nama;
                txtEmail.Text = user.Email;
                txtPassword.Text = user.Password;
                txtRole.Text = user.Role;
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            var updatedUser = new Mahasiswa
            {
                NIM = txtNIM.Text,
                Nama = txtNama.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Role = txtRole.Text
            };

            _userRepository.UpdateUser(updatedUser); // Method to update user in database
            MessageBox.Show("User updated successfully!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

