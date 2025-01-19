using JadwalMahasiswa.Models.Entity;
using JadwalMahasiswa.Models.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JadwalMahasiswa.View
{
    public partial class CreateUserForm : Form
    {
        private readonly UserRepository _userRepository;
        public CreateUserForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            var newUser = new Mahasiswa
            {
                NIM = txtNIM.Text,
                Nama = txtNama.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                Role = "user"
            };

            _userRepository.AddUser(newUser);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
