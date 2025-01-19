using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JadwalMahasiswa.Models.Entity
{
    public class LogUpdate
    {
        public int IDLog { get; set; }
        public string NIM { get; set; }
        public string DeskripsiLog { get; set; }
        public DateTime Waktu { get; set; }
    }
}
