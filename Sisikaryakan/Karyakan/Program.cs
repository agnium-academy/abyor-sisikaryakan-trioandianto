using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karyakan
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager tegar = new Manager("Manager Drilling");
            Manager haidar = new Manager("Manager Drilling");
            Manager sani = new Manager("Manager Refinery");
            Manager adi = new Manager("Manager General Affairs");

            Supervisor iqbal = new Supervisor("Supervisor Drilling Riau");
            Supervisor ucu = new Supervisor("Supervisor Drilling Luwuk");
            Supervisor deni = new Supervisor("Supervisor Refinery Balikpapan");

            Staff dwi = new Staff("Staff Drilling Riau 1");
            Staff trio = new Staff("Straff Drilling Riau 2");
            Staff nuragus = new Staff("Staff Drilling Luwuk");
            Staff sofi = new Staff("Staff Refinery Balikpapan");
            Staff seta = new Staff("Staff General Affairs");

            tegar.nama = "Tegar";
            tegar.tunjanganHariRaya = 3000000;
            tegar.tunjanganStudiBanding = 1500000;
            tegar.tunjanganKesehatan = 5000000;
            tegar.tunjanganPenginapan = 2000000;
            tegar.tunjanganInternet = 100000;
            tegar.basicSalary = 12000000;
            tegar.tunjanganTransportasi = 1000000;

            haidar.nama = "Haidar";
            haidar.tunjanganHariRaya = 2000000;
            haidar.tunjanganStudiBanding = 1000000;
            haidar.tunjanganKesehatan = 5000000;
            haidar.tunjanganPenginapan = 2000000;
            haidar.tunjanganInternet = 100000;
            haidar.basicSalary = 12000000;
            haidar.tunjanganTransportasi = 1000000;

            sani.nama = "Sani";
            sani.tunjanganHariRaya = 2000000;
            sani.tunjanganStudiBanding = 1000000;
            sani.tunjanganKesehatan = 5000000;
            sani.tunjanganPenginapan = 2000000;
            sani.tunjanganInternet = 100000;
            sani.basicSalary = 10000000;
            sani.tunjanganTransportasi = 800000;

            adi.nama = "Adi";
            adi.tunjanganHariRaya = 2000000;
            adi.tunjanganStudiBanding = 1000000;
            adi.tunjanganKesehatan = 5000000;
            adi.tunjanganPenginapan = 2000000;
            adi.tunjanganInternet = 100000;
            adi.basicSalary = 10000000;
            adi.tunjanganTransportasi = 800000;

            iqbal.nama = "Iqbal";
            iqbal.basicSalary = 7500000;
            iqbal.tunjanganInternet = 750000;
            iqbal.tunjanganTransportasi = 500000;

            ucu.nama = "Ucu";
            ucu.basicSalary = 7500000;
            ucu.tunjanganInternet = 750000;
            ucu.tunjanganTransportasi = 500000;

            deni.nama = "Deni";
            deni.basicSalary = 7500000;
            deni.tunjanganInternet = 750000;
            deni.tunjanganTransportasi = 500000;

            dwi.nama = "Dwi Octa";
            dwi.basicSalary = 5000000;
            dwi.tunjanganTransportasi = 300000;

            trio.nama = "Trio Aw";
            trio.basicSalary = 5000000;
            trio.tunjanganTransportasi = 300000;

            nuragus.nama = "Nur Agus";
            nuragus.basicSalary = 5000000;
            nuragus.tunjanganTransportasi = 300000;

            sofi.nama = "Sofy Fitri";
            sofi.basicSalary = 5000000;
            sofi.tunjanganTransportasi = 300000;

            seta.nama = "Dwi Seta";
            seta.basicSalary = 5000000;
            seta.tunjanganTransportasi = 300000;
        }
    }
}
