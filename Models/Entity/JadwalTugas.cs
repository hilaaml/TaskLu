using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JadwalMahasiswa.Models.Entity
{
    public class JadwalTugas
    {
        public int IDTugas { get; set; }
        public string KodeMK { get; set; }
        public string NamaTugas { get; set; }
        public string Deskripsi { get; set; }
        public DateTime Deadline { get; set; }
        public bool status { get; set; }

    }
}

