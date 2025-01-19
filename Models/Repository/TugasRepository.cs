using System;
using System.Collections.Generic;
using System.Data;

using System.Data.SQLite;
using JadwalMahasiswa.Models.Entity;
using JadwalMahasiswa.Models.Context;
using JadwalMahasiswa.Models.Repository;

namespace JadwalMahasiswa.Models.Repository
{
    public class TugasRepository
    {
        private SQLiteConnection _conn;

        public TugasRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public DataTable GetAllMatakuliah()
        {
            string query = "SELECT IdMK, NamaMK FROM Matakuliah"; // Simple query to get course ID and name

            using (var cmd = new SQLiteCommand(query, _conn))
            {
                var adapter = new SQLiteDataAdapter(cmd);
                var matakuliahTable = new DataTable();
                adapter.Fill(matakuliahTable);

                // Check if the table contains the expected columns
                if (!matakuliahTable.Columns.Contains("IdMK") || !matakuliahTable.Columns.Contains("NamaMK"))
                {
                    throw new Exception("Expected columns not found in Matakuliah table.");
                }

                return matakuliahTable;
            }
        }

        public DataTable ShowMKByDay()
        {
            string queryJadwalMK = @"
            WITH JadwalDenganNomorBaris AS (
                SELECT 
                    jm.Hari,
                    jm.JamMasuk,
                    jm.JamSelesai,
                    mk.NamaMK,
                    ROW_NUMBER() OVER (PARTITION BY jm.Hari ORDER BY jm.JamMasuk) AS RowNum
                FROM JadwalMK jm
                JOIN Matakuliah mk ON jm.IdMK = mk.IdMK
            )
            SELECT 
                JamMasuk || ' - ' || JamSelesai AS Jam,  -- Combine JamMasuk and JamSelesai for display
                MAX(CASE WHEN Hari = 'Senin' THEN NamaMK ELSE '-' END) AS Senin,
                MAX(CASE WHEN Hari = 'Selasa' THEN NamaMK ELSE '-' END) AS Selasa,
                MAX(CASE WHEN Hari = 'Rabu' THEN NamaMK ELSE '-' END) AS Rabu,
                MAX(CASE WHEN Hari = 'Kamis' THEN NamaMK ELSE '-' END) AS Kamis,
                MAX(CASE WHEN Hari = 'Jumat' THEN NamaMK ELSE '-' END) AS Jumat,
                MAX(CASE WHEN Hari = 'Sabtu' THEN NamaMK ELSE '-' END) AS Sabtu
            FROM JadwalDenganNomorBaris
            GROUP BY JamMasuk, JamSelesai  -- Group by time slots to aggregate subjects per time slot
            ORDER BY JamMasuk;  -- Order by start time";

            using (var cmd = new SQLiteCommand(queryJadwalMK, _conn))
            {
                var adapter = new SQLiteDataAdapter(cmd);
                var tableJadwalMK = new DataTable();
                adapter.Fill(tableJadwalMK);
                return tableJadwalMK;
            }
        }
        public DataTable GetAllTugas()
        {
            string queryGetAllTugas = @"SELECT * FROM Tugas";

            using (var cmd = new SQLiteCommand(queryGetAllTugas, _conn))
            {
                var adapter = new SQLiteDataAdapter(cmd);
                var tableGetAllTugas = new DataTable();
                adapter.Fill(tableGetAllTugas);
                return tableGetAllTugas;
            }
        }

        public DataTable ShowTugas()
        {
            string queryShowTugas = @"
        SELECT 
            JT.IDTugas,  -- Include IDTugas for internal use
            JT.status, 
            JT.NamaTugas AS Tugas, 
            MK.NamaMK AS Matakuliah, 
            JT.Deskripsi, 
            JT.Deadline,
            JT.KodeMK  -- Ensure KodeMK is included in the select statement
        FROM 
            JadwalTugas JT
        JOIN 
            Matakuliah MK ON JT.KodeMK = MK.IdMK;";

            using (var cmd = new SQLiteCommand(queryShowTugas, _conn))
            {
                var adapter = new SQLiteDataAdapter(cmd);
                var tableShowTugas = new DataTable();
                adapter.Fill(tableShowTugas);
                return tableShowTugas;
            }
        }
        public void UpdateStatus(int idTugas, bool status)
        {
            string query = @"UPDATE JadwalTugas SET status = @status WHERE IDTugas = @IDTugas";

            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@IDTugas", idTugas);
                cmd.Parameters.AddWithValue("@status", status);

                cmd.ExecuteNonQuery();
            }
        }

        public void CreateTugas(string kodeMK, string namaTugas, string deskripsi, DateTime deadline)
        {
            string query = "INSERT INTO JadwalTugas (KodeMK, NamaTugas, Deskripsi, Deadline) VALUES (@KodeMK, @NamaTugas, @Deskripsi, @Deadline)";
            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@KodeMK", kodeMK);
                cmd.Parameters.AddWithValue("@NamaTugas", namaTugas);
                cmd.Parameters.AddWithValue("@Deskripsi", deskripsi);
                cmd.Parameters.AddWithValue("@Deadline", deadline);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTugas(int idTugas, string kodeMK, string namaTugas, string deskripsi, DateTime deadline)
        {
            string query = @"UPDATE JadwalTugas 
                     SET KodeMK = @KodeMK, 
                         NamaTugas = @NamaTugas, 
                         Deskripsi = @Deskripsi,
                         Deadline = @Deadline 
                     WHERE IDTugas = @IDTugas";

            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@IDTugas", idTugas);
                cmd.Parameters.AddWithValue("@KodeMK", kodeMK);
                cmd.Parameters.AddWithValue("@NamaTugas", namaTugas);
                cmd.Parameters.AddWithValue("@Deskripsi", deskripsi);
                cmd.Parameters.AddWithValue("@Deadline", deadline);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable SearchTugas(string searchTerm)
        {
            DataTable resultTable = new DataTable();

            using (var command = new SQLiteCommand("SELECT * FROM JadwalTugas WHERE NamaTugas LIKE @search OR Deskripsi LIKE @search", _conn))
            {
                command.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                using (var adapter = new SQLiteDataAdapter(command))
                {
                    adapter.Fill(resultTable);
                }
            }

            return resultTable;
        }


        public void DeleteTugas(int id)
        {
            string query = "DELETE FROM JadwalTugas WHERE IDTugas = @IDTugas";
            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@IDTugas", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
