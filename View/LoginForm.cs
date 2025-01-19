using System;
using System.Windows.Forms;
using JadwalMahasiswa.Models.Context;
using JadwalMahasiswa.Controller;

namespace JadwalMahasiswa.View
{
    public partial class LoginForm : Form
    {
        private LoginController _loginController;

        public LoginForm()
        {
            InitializeComponent();
            var context = new DbContext();
            _loginController = new LoginController(context);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string nim, nama, role;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email dan Sandi harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_loginController.Login(email, password, out nim, out nama, out role))
            {
                if (role == "admin")
                {
                    AdministratorForm adminForm = new AdministratorForm(nim, nama, email, role);
                    adminForm.Show();
                }
                else if (role == "user")
                {
                    JadwalForm jadwalForm = new JadwalForm(nim, nama, email, role);
                    jadwalForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Email atau Password tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetUserRole(string nim)
        {
            return "user";
        }
    }
}
