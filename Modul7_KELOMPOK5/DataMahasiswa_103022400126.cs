using System;
using System.Collections.Generic;
using System.Text;

namespace Modul7_KELOMPOK5
{
    public class DataMahasiswa_103022400126
    {
        public string Nama { get; set; }
        public string NIM { get; set; }

        public DataMahasiswa_103022400126(string nama, string nim)
        {
            this.Nama = nama;
            this.NIM = nim;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"NIM : {NIM}");
        }
    }
}
