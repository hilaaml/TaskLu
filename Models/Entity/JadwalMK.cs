using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JadwalMahasiswa.Models.Entity
{
    public class JadwalMK
    {
        public int IJMK { get; set; }
        public string IdMK { get; set; }
        public string Hari { get; set; }
        public TimeSpan JamMasuk { get; set; }
        public TimeSpan JamSelesai { get; set; }
        public string NamaMK { get; set; }

    }
}

