using System;
using System.Data;

using System.Data.SQLite;
using JadwalMahasiswa.Models.Entity;
using JadwalMahasiswa.Models.Context;
using JadwalMahasiswa.Models.Repository;

namespace JadwalMahasiswa.Controller
{
    public class TugasController
    {
        private TugasRepository _repository;

        public TugasController(DbContext context)
        {
            _repository = new TugasRepository(context);
        }

        public DataTable GetAllMatakuliah()
        {
            return _repository.GetAllMatakuliah();
        }
        public DataTable ShowMKByDay()
        {
            return _repository.ShowMKByDay();
        }
        public DataTable ShowTugas()
        {
            return _repository.ShowTugas();
        }
        public DataTable GetAllTugas()
        {
            return _repository.GetAllTugas();
        }
        public void CreateTugas(string kodeMK, string namaTugas, string deskripsi, DateTime deadline)
        {
            _repository.CreateTugas(kodeMK, namaTugas, deskripsi, deadline);
        }

        public void UpdateTugas(int idTugas, string kodeMK, string namaTugas, string deskripsi, DateTime deadline)
        {
            _repository.UpdateTugas(idTugas, kodeMK, namaTugas, deskripsi, deadline);
        }

        public void DeleteTugas(int id)
        {
            _repository.DeleteTugas(id);
        }
        public void UpdateStatus(int idTugas, bool status)
        {
            _repository.UpdateStatus(idTugas, status); 
        }
        public DataTable SearchTugas(string searchTerm)
        {
            return _repository.SearchTugas(searchTerm);
        }

    }
}
