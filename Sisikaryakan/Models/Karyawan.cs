using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sisikaryakan.Models
{
    public class Karyawan
    {
        public int Id { get; set; }

        [Required]
        public string Nama { get; set; }

        [Required]
        public string Jabatan { get; set; }

        [Required]
        public string divisi { get; set; }
    }
}