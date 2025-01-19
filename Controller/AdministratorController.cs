using System.Collections.Generic;
using System.Windows.Forms;
using JadwalMahasiswa.Models.Entity;
using JadwalMahasiswa.Models.Repository;

namespace JadwalMahasiswa.Controller
{
    public class AdministratorController
    {
        private readonly UserRepository _userRepository;

        public AdministratorController()
        {
            _userRepository = new UserRepository();
        }
        public List<Mahasiswa> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
        public void LoadUsers(DataGridView dgvUser)
        {
            dgvUser.DataSource = _userRepository.GetAllUsers();
        }
        public Mahasiswa GetUserByNIM(string nim)
        {
            return _userRepository.GetUserByNIM(nim);
        }
        public void DeleteUser(string nim)
        {
            _userRepository.DeleteUser(nim);
        }

        public void UpdateUser(Mahasiswa user)
        {
            _userRepository.UpdateUser(user);
        }
        public void AddUser(Mahasiswa user)
        {
            _userRepository.AddUser(user);
        }

    }
}
