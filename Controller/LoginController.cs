using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using JadwalMahasiswa.Models.Entity;
using System;
using System;
using JadwalMahasiswa.Models.Repository;
using JadwalMahasiswa.Models.Context;
using JadwalMahasiswa.View;

namespace JadwalMahasiswa.Controller
{
    public class LoginController
    {
        private LoginRepository _repository;

        public LoginController(DbContext context)
        {
            _repository = new LoginRepository(context);
        }

        public bool Login(string email, string password, out string nim, out string nama, out string role)
        {
            nim = string.Empty;
            nama = string.Empty;
            role = string.Empty;

            bool isValid = _repository.ValidateUser(email, password, out nim, out nama, out role);
            return isValid;
        }
    }
}
