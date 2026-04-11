using System;
using System.IO;
using System.Text.Json;

namespace TP7
{
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

    public class Program
    {
        public static void Main(string[] args)
        {
            DataMahasiswa_103022400058 data = new DataMahasiswa_103022400058();
            data.ReadJSON();
        }
    }
}