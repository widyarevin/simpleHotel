using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidyaRevin_MidExam_Hotel
{
    public class Kamar
    {
        public string NoKamar { get; set; }
        public int LantaiKamar { get; set; }
        public string TipeKamar { get; set; }
        public decimal HargaKamar { get; set; }

        public List<Tamu> listTamu = new List<Tamu>();

        public List<Tamu> GetTamu()
        {
            return this.listTamu;
        }

        public void AddTamu(Tamu daftarTamu)
        {
            this.listTamu.Add(daftarTamu);
        }

        public Kamar () { }
        public Kamar (string noKamar, int lantaiKamar, string tipeKamar, decimal hargaKamar)
        {
            this.NoKamar = noKamar;
            this.LantaiKamar = lantaiKamar;
            this.TipeKamar = tipeKamar;
            this.HargaKamar = hargaKamar;
        }

        //public Kamar( int lantaiKamar)
        //{
        //    this.LantaiKamar = lantaiKamar;
        //}

        public Kamar(string noKamar)
        {
            this.NoKamar = noKamar;
        }

        public void printInfoKamar()
        {
            Console.WriteLine($"Room Number : {this.NoKamar}");
            Console.WriteLine($"Floor : {this.LantaiKamar}");
            Console.WriteLine($"Room Type : {this.TipeKamar}");
            Console.WriteLine($"Price : {formatHarga(this.HargaKamar)}");
            //foreach (Tamu item in listTamu)
            //{
            //    Console.WriteLine("Reservation History");
            //    Console.WriteLine($"{item.TanggalCheckIn} - {item.TanggalCheckOut} ({item.NamaDepan} {item.NamaBelakang}, {item.NoRegister})");
            //}
        }

        

        //public string formatCash()
        //{
        //    string rupiah = HargaKamar.ToString("C2", CultureInfo.CreateSpecificCulture("id-IDR"));
        //    return (rupiah);
        //}

        public string formatHarga(decimal harga)
        {
            return harga.ToString("C2", CultureInfo.CreateSpecificCulture("id-ID"));
        }
    }
}
