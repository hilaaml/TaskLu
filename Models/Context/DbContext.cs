using System;
using System.Data;
using System.Data.SQLite;

namespace JadwalMahasiswa.Models.Context
{
    public class DbContext : IDisposable
    {
        private SQLiteConnection _conn;

        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null;
            try
            {
                string dbPath = @"C:\Users\Sahi\source\repos\hilaaml\JadwalMahasiswa\Resources\JadwalMahasiswaDb.db";
                string connectionString = $"Data Source={dbPath}; Version=3;";
                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection Error: {ex.Message}");
            }
            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                if (_conn.State != ConnectionState.Closed) _conn.Close();
                _conn.Dispose();
            }
        }
    }
}
