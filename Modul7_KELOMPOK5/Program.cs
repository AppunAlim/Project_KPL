using System;
using System.IO;
using System.Text.Json;

namespace TP7
{
    public class DataMahasiswa_103022400064
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class DetailMahasiswa
        {
            public Nama nama { get; set; }
            public string nim { get; set; }
            public string fakultas { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "TP7_1_103022400064.json";

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File {filePath} tidak ditemukan!");
                    return;
                }

                string jsonString = File.ReadAllText(filePath);
                DetailMahasiswa mhs = JsonSerializer.Deserialize<DetailMahasiswa>(jsonString);

                Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error di DataMahasiswa: " + ex.Message);
            }
        }
    }


    public class DataMahasiswa_103022400058
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class DetailMahasiswa
        {
            public Nama nama { get; set; }
            public string nim { get; set; }
            public string fakultas { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "TP7_1_103022400058.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);

                DetailMahasiswa mhs = JsonSerializer.Deserialize<DetailMahasiswa>(jsonString);

                Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error : " + ex.Message);
            }
        }
    }

    public class KuliahMahasiswa_103022400064
    {
        public class MataKuliah
        {
            public string kode_matakuliah { get; set; }
            public string nama_matakuliah { get; set; }
        }

        public class DataKuliah
        {
            public List<MataKuliah> mata_kuliah { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "TP7_2_103022400064.json";

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File {filePath} tidak ditemukan!");
                    return;
                }

                string jsonString = File.ReadAllText(filePath);
                DataKuliah data = JsonSerializer.Deserialize<DataKuliah>(jsonString);

                Console.WriteLine("\nDaftar mata kuliah yang diambil:");
                int counter = 1;

                foreach (var mk in data.mata_kuliah)
                {
                    Console.WriteLine($"MK {counter} {mk.kode_matakuliah} - {mk.nama_matakuliah}");
                    counter++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error di KuliahMahasiswa: " + ex.Message);
            }
        }
    }


    public class KuliahMahasiswa_103022400058
    {
        public class MataKuliah
        {
            public string kode_matakuliah { get; set; }
            public string nama_matakuliah { get; set; }
        }

        public class DataKuliah
        {
            public List<MataKuliah> mata_kuliah { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "tp7_2_103022400058.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);

                DataKuliah data = JsonSerializer.Deserialize<DataKuliah>(jsonString);

                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int counter = 1;

                foreach (var mk in data.mata_kuliah)
                {
                    Console.WriteLine($"MK {counter} {mk.kode_matakuliah} - {mk.nama_matakuliah}");
                    counter++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error : " + ex.Message);
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                DataMahasiswa_103022400058 data = new DataMahasiswa_103022400058();
                KuliahMahasiswa_103022400058 kuliah = new KuliahMahasiswa_103022400058();
                data.ReadJSON();
                kuliah.ReadJSON();

                DataMahasiswa_103022400064 dataIbnu = new DataMahasiswa_103022400064();
                KuliahMahasiswa_103022400064 kuliahIbnu = new KuliahMahasiswa_103022400064();
                dataIbnu.ReadJSON();
                kuliahIbnu.ReadJSON();

                Console.WriteLine("\n--- Data Rifky ---");
                DataMahasiswa_103022400126 dataRifky = new DataMahasiswa_103022400126();
                KuliahMahasiswa_103022400126 kuliahRifky = new KuliahMahasiswa_103022400126();
                dataRifky.ReadJSON();
                kuliahRifky.ReadJSON();
            }
        }
    }
    public class DataMahasiswa_103022400126
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class DetailMahasiswa
        {
            public Nama nama { get; set; }
            public string nim { get; set; }
            public string fakultas { get; set; }
        }

        public void ReadJSON()
        {
            // Nama file JSON sesuai NIM kamu
            string filePath = "TP7_1_103022400126.json";

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File {filePath} tidak ditemukan!");
                    return;
                }

                string jsonString = File.ReadAllText(filePath);
                DetailMahasiswa mhs = JsonSerializer.Deserialize<DetailMahasiswa>(jsonString);

                Console.WriteLine($"Nama {mhs.nama.depan} {mhs.nama.belakang} dengan nim {mhs.nim} dari fakultas {mhs.fakultas}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error di DataMahasiswa Rifky: " + ex.Message);
            }
        }
    }

    public class KuliahMahasiswa_103022400126
    {
        public class MataKuliah
        {
            public string kode_matakuliah { get; set; }
            public string nama_matakuliah { get; set; }
        }

        public class DataKuliah
        {
            public List<MataKuliah> mata_kuliah { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "TP7_2_103022400126.json";

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File {filePath} tidak ditemukan!");
                    return;
                }

                string jsonString = File.ReadAllText(filePath);
                DataKuliah data = JsonSerializer.Deserialize<DataKuliah>(jsonString);

                Console.WriteLine("\nDaftar mata kuliah yang diambil (Rifky):");
                int counter = 1;
                foreach (var mk in data.mata_kuliah)
                {
                    Console.WriteLine($"MK {counter} {mk.kode_matakuliah} - {mk.nama_matakuliah}");
                    counter++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error di KuliahMahasiswa Rifky: " + ex.Message);
            }
        }
    }
}