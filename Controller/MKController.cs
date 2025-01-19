using JadwalMahasiswa.Models.Entity;
using System.Collections.Generic;
using JadwalMahasiswa.Models.Repository;
using System;

namespace JadwalMahasiswa.Controller
{
    public class DosenController
    {
        private readonly DosenRepository _dosenRepository;

        public DosenController()
        {
            _dosenRepository = new DosenRepository();
        }

        public List<Dosen> GetAllDosen()
        {
            return _dosenRepository.GetAllDosen();
        }

        public void SaveDosen(Dosen dosen)
        {
            if (_dosenRepository.Exists(dosen.NIDN))
            {
                _dosenRepository.UpdateDosen(dosen);
            }
            else
            {
                _dosenRepository.AddDosen(dosen);
            }
        }
        public void DeleteDosen(int nidn)
        {
            var dosenRepo = new DosenRepository();
            dosenRepo.DeleteDosen(nidn);
        }
    }

    public class MKController
    {
        private readonly MKRepository _mkRepository;

        public MKController()
        {
            _mkRepository = new MKRepository();
        }

        public List<MK> GetAllMatakuliah()
        {
            return _mkRepository.GetAllMatakuliah();
        }

        public void SaveMatakuliah(MK mk)
        {
            if (_mkRepository.Exists(mk.IdMK))
            {
                _mkRepository.UpdateMK(mk);
            }
            else
            {
                _mkRepository.AddMK(mk);
            }
        }
        public void DeleteMatakuliah(string idMk)
        {
            var mkRepo = new MKRepository();
            mkRepo.DeleteMatakuliah(idMk);
        }
    }

    public class JadwalMKController
    {
        private readonly JadwalMKRepository _jadwalMKRepository;

        public JadwalMKController()
        {
            _jadwalMKRepository = new JadwalMKRepository();
        }

        public List<JadwalMK> GetAllJadwalMK()
        {
            return _jadwalMKRepository.GetAllJadwalMK();
        }

        public void SaveJadwalMK(JadwalMK jadwal)
        {
            if (_jadwalMKRepository.Exists(jadwal.IJMK))
            {
                _jadwalMKRepository.UpdateJadwal(jadwal);
            }
            else
            {
                _jadwalMKRepository.AddJadwal(jadwal);
            }
        }
        public void DeleteJadwal(int ijmk)
        {
            var jadwalRepo = new JadwalMKRepository();
            jadwalRepo.DeleteJadwal(ijmk);
        }
    }
}
