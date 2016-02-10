using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karyakan
{
    abstract class Karyawan
    {
        public string nama;
        public string divisi;
        public int basicSalary;
        public int tunjanganTransportasi;

        abstract public string tanggalDiterima(string masuk);
        abstract public string pelatihan(string materi);
        abstract public string penugasan(string Tugas);
        abstract public string tanggalDipecat(string keluar);
    }

}



