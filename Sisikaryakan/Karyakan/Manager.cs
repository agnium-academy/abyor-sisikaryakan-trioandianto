using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karyakan
{
    class Manager : Karyawan
    {
        public int tunjanganHariRaya;
        public int tunjanganStudiBanding;
        public int tunjanganKesehatan;
        public int tunjanganInternet;
        public int tunjanganPenginapan;

        public Manager()
        {
        }
        public Manager(string divisi)
        {
            this.divisi = divisi;
        }
        public override string tanggalDiterima(string masuk)
        {
            throw new NotImplementedException();

        }

        public override string pelatihan(string materi)
        {
            throw new NotImplementedException();

        }

        public override string penugasan(string Tugas)
        {
            throw new NotImplementedException();
        }

        public override string tanggalDipecat(string keluar)
        {
            throw new NotImplementedException();
        }
    }
}