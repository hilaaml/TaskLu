using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using JadwalMahasiswa.Controller;
using JadwalMahasiswa.Models.Entity;
using JadwalMahasiswa.Models.Repository;

namespace JadwalMahasiswa.View
{
    public partial class EditMKForm : Form
    {
        private MKRepository _mkRepository;
        private JadwalMKRepository _jadwalMKRepository;
        private DosenRepository _dosenRepository;

        public EditMKForm()
        {
            InitializeComponent();
            _dosenRepository = new DosenRepository();
            _mkRepository = new MKRepository();
            _jadwalMKRepository = new JadwalMKRepository();
            LoadData();
            LoadView();
        }
        private void LoadView()
        {
            // Set view to details for each ListView
            lvwJadwalMK.View = System.Windows.Forms.View.Details;
            lvwDosen.View = System.Windows.Forms.View.Details;
            lvwMataKuliah.View = System.Windows.Forms.  View.Details;

            // Add columns to lvwJadwalMK
            lvwJadwalMK.Columns.Add("IJMK", 10); // Adjust width as necessary
            lvwJadwalMK.Columns.Add("IdMK", 30);
            lvwJadwalMK.Columns.Add("MK", 70);
            lvwJadwalMK.Columns.Add("Hari", 50);
            lvwJadwalMK.Columns.Add("Jam Masuk", 20);
            lvwJadwalMK.Columns.Add("Jam Selesai", 20);

            // Add columns to lvwDosen
            lvwDosen.Columns.Add("NIDN", 25); // Adjust width as necessary
            lvwDosen.Columns.Add("Nama Dosen", 200);

            // Add columns to lvwMataKuliah
            lvwMataKuliah.Columns.Add("Id MK", 25); // Adjust width as necessary
            lvwMataKuliah.Columns.Add("Nama MK", 200);
        }
        private void LoadData()
        {
            // Load cmbDosen
            var dosenList = _dosenRepository.GetAllDosen();
            cmbDosen.DataSource = dosenList;
            cmbDosen.DisplayMember = "NamaDosen";
            cmbDosen.ValueMember = "NIDN";

            // Load cmbMK
            var mkList = _mkRepository.GetAllMatakuliah();
            cmbMK.DataSource = mkList;
            cmbMK.DisplayMember = "NamaMK";
            cmbMK.ValueMember = "IdMK";

            // Load lvwJadwalMK
            lvwJadwalMK.Items.Clear();
            foreach (var jadwal in _jadwalMKRepository.GetAllJadwalMK())
            {
                var item = new ListViewItem(jadwal.IJMK.ToString());
                item.SubItems.Add(jadwal.IdMK);
                item.SubItems.Add(jadwal.NamaMK);
                item.SubItems.Add(jadwal.Hari);
                item.SubItems.Add(jadwal.JamMasuk.ToString());
                item.SubItems.Add(jadwal.JamSelesai.ToString());
                lvwJadwalMK.Items.Add(item);
            }

            // Load lvwDosen
            lvwDosen.Items.Clear();
            foreach (var dosen in dosenList)
            {
                var item = new ListViewItem(dosen.NIDN.ToString());
                item.SubItems.Add(dosen.NamaDosen);
                lvwDosen.Items.Add(item);
            }

            // Load lvwMataKuliah
            lvwMataKuliah.Items.Clear();
            foreach (var mk in mkList)
            {
                var item = new ListViewItem(mk.IdMK);
                item.SubItems.Add(mk.NamaMK);
                lvwMataKuliah.Items.Add(item);
            }
        }

        private string GetSesi(TimeSpan jamMasuk, TimeSpan jamSelesai)
        {
            if (jamMasuk >= new TimeSpan(7, 0, 0) && jamSelesai <= new TimeSpan(8, 40, 0)) return "Sesi 1";
            if (jamMasuk >= new TimeSpan(8, 50, 0) && jamSelesai <= new TimeSpan(10, 30, 0)) return "Sesi 2";
            if (jamMasuk >= new TimeSpan(10, 40, 0) && jamSelesai <= new TimeSpan(12, 20, 0)) return "Sesi 3";
            if (jamMasuk >= new TimeSpan(13, 20, 0) && jamSelesai <= new TimeSpan(15, 0, 0)) return "Sesi 4";
            if (jamMasuk >= new TimeSpan(15, 0, 0) && jamSelesai <= new TimeSpan(17, 10, 0)) return "Sesi 5";
            return "Invalid Sesi";
        }

        private void lvwJadwalMK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwJadwalMK.SelectedItems.Count > 0)
            {
                var selected = lvwJadwalMK.SelectedItems[0];
                txtIJMK.Text = selected.Text;
                cmbMK.SelectedValue = selected.SubItems[1].Text;
                cmbHari.Text = selected.SubItems[2].Text;
                var jamMasuk = TimeSpan.Parse(selected.SubItems[3].Text);
                var jamSelesai = TimeSpan.Parse(selected.SubItems[4].Text);
                cmbSesi.Text = GetSesi(jamMasuk, jamSelesai);
            }
        }

        private void lvwDosen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwDosen.SelectedItems.Count > 0)
            {
                var selected = lvwDosen.SelectedItems[0];
                txtNIDN.Text = selected.Text;
                txtNamaDosen.Text = selected.SubItems[1].Text;
            }
        }

        private void lvwMataKuliah_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMataKuliah.SelectedItems.Count > 0)
            {
                var selected = lvwMataKuliah.SelectedItems[0];
                txtIdMK.Text = selected.Text;
                txtNamaMK.Text = selected.SubItems[1].Text;
                cmbDosen.SelectedValue = selected.SubItems[2].Text;
            }
        }

        private void btnSimpanMK_Click(object sender, EventArgs e)
        {
            var mk = new MK
            {
                IdMK = txtIdMK.Text,
                NamaMK = txtNamaMK.Text,
                NIDN = (int)cmbDosen.SelectedValue
            };

            if (_mkRepository.Exists(mk.IdMK))
                _mkRepository.UpdateMK(mk);
            else
                _mkRepository.AddMK(mk);

            LoadData();
        }

        private void btnSimpanJadwalMK_Click(object sender, EventArgs e)
        {
            var jadwal = new JadwalMK
            {
                IJMK = int.Parse(txtIJMK.Text),
                IdMK = cmbMK.SelectedValue.ToString(),
                Hari = cmbHari.Text,
                JamMasuk = TimeSpan.Parse(cmbSesi.Text.Split('-')[0]),
                JamSelesai = TimeSpan.Parse(cmbSesi.Text.Split('-')[1])
            };

            if (_jadwalMKRepository.Exists(jadwal.IJMK))
                _jadwalMKRepository.UpdateJadwal(jadwal);
            else
                _jadwalMKRepository.AddJadwal(jadwal);

            LoadData();
        }

        private void btnSimpanDosen_Click(object sender, EventArgs e)
        {
            var dosen = new Dosen
            {
                NIDN = int.Parse(txtNIDN.Text),
                NamaDosen = txtNamaDosen.Text
            };

            if (_dosenRepository.Exists(dosen.NIDN))
                _dosenRepository.UpdateDosen(dosen);
            else
                _dosenRepository.AddDosen(dosen);

            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwJadwalMK_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwJadwalMK.SelectedItems.Count > 0) // Check if an item is selected in lvwJadwalMK
            {
                int ijmk = Convert.ToInt32(lvwJadwalMK.SelectedItems[0].SubItems[0].Text); // Assuming IJMK is in the first column
                var controller = new JadwalMKController();
                controller.DeleteJadwal(ijmk);
                LoadData(); // Refresh the ListView after deletion
                MessageBox.Show("Jadwal berhasil dihapus.");
            }
            else if (lvwDosen.SelectedItems.Count > 0) // Check if an item is selected in lvwDosen
            {
                int nidn = Convert.ToInt32(lvwDosen.SelectedItems[0].SubItems[0].Text); // Assuming NIDN is in the first column
                var controller = new DosenController();
                controller.DeleteDosen(nidn);
                LoadData(); // Refresh the ListView after deletion
                MessageBox.Show("Dosen berhasil dihapus.");
            }
            else if (lvwMataKuliah.SelectedItems.Count > 0) // Check if an item is selected in lvwMataKuliah
            {
                string idMk = lvwMataKuliah.SelectedItems[0].SubItems[0].Text; // Assuming IdMK is in the first column
                var controller = new MKController();
                controller.DeleteMatakuliah(idMk);
                LoadData(); // Refresh the ListView after deletion
                MessageBox.Show("Mata Kuliah berhasil dihapus.");
            }
            else
            {
                MessageBox.Show("Silakan pilih item yang ingin dihapus.");
            }
        }


    }
}
