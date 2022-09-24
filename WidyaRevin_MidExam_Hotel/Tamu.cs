using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidyaRevin_MidExam_Hotel
{
    public class Tamu
    {
        public string NoRegister { get; set; }
        public string NamaDepan { get; set; }
        public string NamaBelakang { get; set; }
        public DateTime TanggalLahir { get; set; }
        public string KotaLahir { get; set; }
        public string JenKel { get; set; }
        public string NoKTP { get; set; }
        public DateTime TanggalCheckIn { get; set; }
        public DateTime TanggalCheckOut { get; set; }

        public List<Tamu> listAnggota { get; set; }

        public List<Kamar> listKamar { get; set; }

        public Kamar kamar { get; set; }

        public Tamu ()  { }

        public Tamu (string noReg, string namaDepan, string namaBelakang, DateTime tglLahir, string kotaLahir, string jenkel, string noKTP, DateTime checkIn, DateTime checkOut, Kamar noKamar, List<Tamu> listTamu)
        {
            this.NoRegister = noReg;
            this.NamaDepan = namaDepan;
            this.NamaBelakang = namaBelakang;
            this.TanggalLahir = tglLahir;
            this.KotaLahir = kotaLahir;
            this.JenKel = jenkel;
            this.NoKTP = noKTP;
            this.TanggalCheckIn = checkIn;
            this.TanggalCheckOut = checkOut;
            this.kamar = noKamar;
            this.listAnggota = listTamu;
        }

        public Tamu(string noReg, string namaDepan, string namaBelakang, DateTime tglLahir, string kotaLahir, string jenkel, string noKTP, DateTime checkIn, DateTime checkOut, Kamar noKamar)
        {
            this.NoRegister = noReg;
            this.NamaDepan = namaDepan;
            this.NamaBelakang = namaBelakang;
            this.TanggalLahir = tglLahir;
            this.KotaLahir = kotaLahir;
            this.JenKel = jenkel;
            this.NoKTP = noKTP;
            this.TanggalCheckIn = checkIn;
            this.TanggalCheckOut = checkOut;
            this.kamar = noKamar;
        }

        public Tamu (string noReg, string namaDepan, string namaBelakang) 
        {
            this.NoRegister = noReg;
            this.NamaDepan = namaDepan;
            this.NamaBelakang = namaBelakang;
        }



        public void printInfoTamu()
        {
            Console.WriteLine($"First Name : {this.NamaDepan}");
            Console.WriteLine($"Last Name : {this.NamaBelakang}");
            Console.WriteLine($"Gender : {this.JenKel}");
            Console.WriteLine($"Birth Information : {this.TanggalLahir.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))}, {this.hitungUmur()} tahun");
            Console.WriteLine($"ID Card : {this.NoKTP}");
            Console.WriteLine($"Menginap Selama : {this.hitungLamaInap()} hari");
            Console.WriteLine($"Biaya Penginapan : {formatHarga(hitungHargaKamar())}");
            Console.WriteLine("\nMenginap di : ");
            Console.WriteLine($"Room Number : {this.kamar.NoKamar}");
            Console.WriteLine($"Floor : {this.kamar.LantaiKamar}");
            Console.WriteLine($"Room Type : {this.kamar.TipeKamar}");
            Console.WriteLine("\nAnggota Keluarga : ");
            foreach (Tamu item in this.listAnggota)
            {
                Console.WriteLine($"{item.NamaDepan} {item.NamaBelakang} dengan Nomor Register : {item.NoRegister}");
            }
        }

        public void printInfoGuest()
        {
            Console.WriteLine($"{this.NamaDepan} {this.NamaBelakang} dengan Nomor Registrasi : {this.NoRegister}");
        }

        public int hitungUmur()
        {
            return DateTime.Now.Year - this.TanggalLahir.Year;
        }

        public int hitungLamaInap()
        {
            return this.TanggalCheckOut.Day - this.TanggalCheckIn.Day;
        }

        public decimal hitungHargaKamar()
        {
            return hitungLamaInap() * this.kamar.HargaKamar;
        }

        public string formatHarga(decimal harga)
        {
            return harga.ToString("C2", CultureInfo.CreateSpecificCulture("id-ID"));
        }

        

    }
}
