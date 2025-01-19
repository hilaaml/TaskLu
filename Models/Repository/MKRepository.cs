using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JadwalMahasiswa.Models.Entity;
using JadwalMahasiswa.Controller;
using JadwalMahasiswa.Models.Context;
using JadwalMahasiswa.Models.Repository;
using JadwalMahasiswa.View;

namespace JadwalMahasiswa.Models.Repository
{
 
    public class MKRepository
    {
        private readonly SQLiteConnection _conn;

        public MKRepository()
        {
            _conn = new DbContext().Conn;
        }

        public List<MK> GetAllMatakuliah()
        {
            var list = new List<MK>();
            var query = "SELECT * FROM Matakuliah";
            using (var cmd = new SQLiteCommand(query, _conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new MK
                    {
                        IdMK = reader.GetString(0),
                        NamaMK = reader.GetString(1),
                        NIDN = reader.GetInt32(2)
                    });
                }
            }
            return list;
        }

        public bool Exists(string idMK)
        {
            var query = "SELECT COUNT(*) FROM Matakuliah WHERE IdMK = @idMK";
            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@idMK", idMK);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public void AddMK(MK mk)
        {
            var query = "INSERT INTO Matakuliah (IdMK, NamaMK, NIDN) VALUES (@idMK, @namaMK, @nidn)";
            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@idMK", mk.IdMK);
                cmd.Parameters.AddWithValue("@namaMK", mk.NamaMK);
                cmd.Parameters.AddWithValue("@nidn", mk.NIDN);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMK(MK mk)
        {
            var query = "UPDATE Matakuliah SET NamaMK = @namaMK, NIDN = @nidn WHERE IdMK = @idMK";
            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@idMK", mk.IdMK);
                cmd.Parameters.AddWithValue("@namaMK", mk.NamaMK);
                cmd.Parameters.AddWithValue("@nidn", mk.NIDN);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteMatakuliah(string idMk)
        {
            using (var cmd = _conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Matakuliah WHERE IdMK = @idMk";
                cmd.Parameters.AddWithValue("@idMk", idMk);
                cmd.ExecuteNonQuery();
            }
        }

    }

    public class JadwalMKRepository
    {
        private readonly SQLiteConnection _conn;

        public JadwalMKRepository()
        {
            _conn = new DbContext().Conn;
        }

        public List<JadwalMK> GetAllJadwalMK()
        {
            var list = new List<JadwalMK>();
            // Query untuk menggabungkan tabel JadwalMK dan MataKuliah
            var query = @"
        SELECT jm.IJMK, jm.IdMK, jm.Hari, jm.JamMasuk, jm.JamSelesai, mk.NamaMK
        FROM JadwalMK jm
        JOIN MataKuliah mk ON jm.IdMK = mk.IdMK";

            using (var cmd = new SQLiteCommand(query, _conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new JadwalMK
                    {
                        IJMK = reader.GetInt32(0),
                        IdMK = reader.GetString(1),
                        Hari = reader.GetString(2),
                        JamMasuk = TimeSpan.Parse(reader.GetString(3)),
                        JamSelesai = TimeSpan.Parse(reader.GetString(4)),
                        NamaMK = reader.GetString(5)  // Menambahkan NamaMK ke dalam objek
                    });
                }
            }
            return list;
        }


        public bool Exists(int ijmk)
        {
            var query = "SELECT COUNT(*) FROM JadwalMK WHERE IJMK = @ijmk";
            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@ijmk", ijmk);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public void AddJadwal(JadwalMK jadwal)
        {
            var query = "INSERT INTO JadwalMK (IJMK, IdMK, Hari, JamMasuk, JamSelesai) VALUES (@ijmk, @idMK, @hari, @jamMasuk, @jamSelesai)";
            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@ijmk", jadwal.IJMK);
                cmd.Parameters.AddWithValue("@idMK", jadwal.IdMK);
                cmd.Parameters.AddWithValue("@hari", jadwal.Hari);
                cmd.Parameters.AddWithValue("@jamMasuk", jadwal.JamMasuk.ToString());
                cmd.Parameters.AddWithValue("@jamSelesai", jadwal.JamSelesai.ToString());
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateJadwal(JadwalMK jadwal)
        {
            var query = "UPDATE JadwalMK SET IdMK = @idMK, Hari = @hari, JamMasuk = @jamMasuk, JamSelesai = @jamSelesai WHERE IJMK = @ijmk";
            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@ijmk", jadwal.IJMK);
                cmd.Parameters.AddWithValue("@idMK", jadwal.IdMK);
                cmd.Parameters.AddWithValue("@hari", jadwal.Hari);
                cmd.Parameters.AddWithValue("@jamMasuk", jadwal.JamMasuk.ToString());
                cmd.Parameters.AddWithValue("@jamSelesai", jadwal.JamSelesai.ToString());
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteJadwal(int ijmk)
        {
            using (var cmd = _conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM JadwalMK WHERE IJMK = @ijmk";
                cmd.Parameters.AddWithValue("@ijmk", ijmk);
                cmd.ExecuteNonQuery();
            }
        }

    }

    public class DosenRepository
    {
        private readonly SQLiteConnection _conn;

        public DosenRepository()
        {
            _conn = new DbContext().Conn;
        }

        public List<Dosen> GetAllDosen()
        {
            var list = new List<Dosen>();
            var query = "SELECT * FROM Dosen";
            using (var cmd = new SQLiteCommand(query, _conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Dosen
                    {
                        NIDN = reader.GetInt32(0),
                        NamaDosen = reader.GetString(1)
                    });
                }
            }
            return list;
        }

        public bool Exists(int nidn)
        {
            var query = "SELECT COUNT(*) FROM Dosen WHERE NIDN = @nidn";
            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@nidn", nidn);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        public void AddDosen(Dosen dosen)
        {
            var query = "INSERT INTO Dosen (NIDN, NamaDosen) VALUES (@nidn, @namaDosen)";
            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@nidn", dosen.NIDN);
                cmd.Parameters.AddWithValue("@namaDosen", dosen.NamaDosen);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDosen(Dosen dosen)
        {
            var query = "UPDATE Dosen SET NamaDosen = @namaDosen WHERE NIDN = @nidn";
            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@nidn", dosen.NIDN);
                cmd.Parameters.AddWithValue("@namaDosen", dosen.NamaDosen);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteDosen(int nidn)
        {
            using (var cmd = _conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Dosen WHERE NIDN = @nidn";
                cmd.Parameters.AddWithValue("@nidn", nidn);
                cmd.ExecuteNonQuery();
            }
        }

    }

}
