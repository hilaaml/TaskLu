using System;
using System.Data.SQLite;
using JadwalMahasiswa.Models.Entity;
using JadwalMahasiswa.Models.Context;

namespace JadwalMahasiswa.Models.Repository
{
    public class LoginRepository
    {
        private SQLiteConnection _conn;

        public LoginRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public bool ValidateUser(string email, string password, out string nim, out string nama, out string role)
        {
            nim = string.Empty;
            nama = string.Empty;
            role = string.Empty;

            using (var cmd = new SQLiteCommand("SELECT NIM, Nama, Role FROM Mahasiswa WHERE Email = @Email AND Password = @Password", _conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        nim = reader["NIM"].ToString();
                        nama = reader["Nama"].ToString();
                        role = reader["Role"].ToString();
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
