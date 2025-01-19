using System.Collections.Generic;
using System.Data.SQLite;
using JadwalMahasiswa.Models.Context;
using JadwalMahasiswa.Models.Entity;

namespace JadwalMahasiswa.Models.Repository
{
    public class UserRepository
    {
        private readonly DbContext _context;

        public UserRepository()
        {
            _context = new DbContext();
        }

        public Mahasiswa GetUserByNIM(string nim)
        {
            Mahasiswa user = null;
            using (var command = new SQLiteCommand("SELECT * FROM Mahasiswa WHERE NIM = @nim", _context.Conn))
            {
                command.Parameters.AddWithValue("@nim", nim);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new Mahasiswa
                        {
                            NIM = reader["NIM"].ToString(),
                            Nama = reader["Nama"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                    }
                }
            }
            return user;
        }


        public List<Mahasiswa> GetAllUsers()
        {
            var users = new List<Mahasiswa>();
            using (var command = new SQLiteCommand("SELECT * FROM Mahasiswa", _context.Conn))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    users.Add(new Mahasiswa
                    {
                        NIM = reader["NIM"].ToString(),
                        Nama = reader["Nama"].ToString(),
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["role"].ToString()
                    });
                }
            }
            return users;
        }
        public void AddUser(Mahasiswa user)
        {
            using (var command = new SQLiteCommand("INSERT INTO Mahasiswa (NIM, Nama, Email, Password, Role) VALUES (@NIM, @Nama, @Email, @Password, @Role)", _context.Conn))
            {
                command.Parameters.AddWithValue("@NIM", user.NIM);
                command.Parameters.AddWithValue("@Nama", user.Nama);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Role", user.Role);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateUser(Mahasiswa updatedUser)
        {
            using (var command = new SQLiteCommand("UPDATE Mahasiswa SET Nama = @nama, Email = @email, Password = @password, Role = @role WHERE NIM = @nim", _context.Conn))
            {
                command.Parameters.AddWithValue("@nim", updatedUser.NIM);
                command.Parameters.AddWithValue("@nama", updatedUser.Nama);
                command.Parameters.AddWithValue("@email", updatedUser.Email);
                command.Parameters.AddWithValue("@password", updatedUser.Password);
                command.Parameters.AddWithValue("@role", updatedUser.Role);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteUser(string nim)
        {
            using (var command = new SQLiteCommand("DELETE FROM Mahasiswa WHERE NIM = @NIM", _context.Conn))
            {
                command.Parameters.AddWithValue("@NIM", nim);
                command.ExecuteNonQuery();
            }
        }

    }
}
