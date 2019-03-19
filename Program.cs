using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_dan_objek
{
    public class Mahasiswa
    {
        //properties
        public string NIM { get; set; }
        public string Nama { get; set; }
        public float IPK { get; set; }

        //method
        public void Registrasi()
        {
            Console.WriteLine("Nama: {0}", Nama);
            Console.WriteLine("NIM: {0}", NIM);
            Console.WriteLine("IPK: {0}", IPK);
            Console.WriteLine("Telah melakukan registrasi");
        
        }

        public void IsiKrs()
        {
            Console.WriteLine("{0} sedang melakukan proses krs\n", Nama);
        }
        static void Main(string[] args)
        {
            //membuat objek dari class Mahasiswa
            Mahasiswa aku = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //mengeset nilai properties objek aku dan kamu
            aku.NIM = "54321";
            aku.Nama = "Yoyo";
            aku.IPK = 3.99f;

            kamu.NIM = "12345";
            kamu.Nama = "Poyo";
            kamu.IPK = 3.98f;

            //memanggil method registrasi dan isi krs
            aku.Registrasi();
            aku.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
