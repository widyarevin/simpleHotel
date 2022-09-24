using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidyaRevin_MidExam_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] noKamar = { "301", "302", "303", "401", "402", "403"};

            Kamar kamar1 = new Kamar("301", 3, "Renguler single bed", 800000m);
            Kamar kamar2 = new Kamar("302", 3, "Reguler double bed", 1000000m);
            Kamar kamar3 = new Kamar("303", 3, "Reguler twin bed", 1200000m);
            Kamar kamar4 = new Kamar("401", 4, "VIP single bed", 1000000m);
            Kamar kamar5 = new Kamar("402", 4, "VIP double bed", 1200000m);
            Kamar kamar6 = new Kamar("403", 4, "VIP twin bed", 1400000m);

            SortedList<string, Kamar> listKamarHotel = new SortedList<string, Kamar>();
            listKamarHotel.Add(noKamar[0], kamar1);
            listKamarHotel.Add(noKamar[1], kamar2);
            listKamarHotel.Add(noKamar[2], kamar3);
            listKamarHotel.Add(noKamar[3], kamar4);
            listKamarHotel.Add(noKamar[4], kamar5);
            listKamarHotel.Add(noKamar[5], kamar6);


            string[] noRegis = { "A021", "A022", "A023", "A024", "A025", "A026" };

            SortedList<string, Tamu> listTamuHotel = new SortedList<string, Tamu>();
            listTamuHotel.Add(noRegis[0], new Tamu("A021", "Danny", "Tan", new DateTime(1990, 11, 23), "Beijing", "Laki-laki", "312008923111990002", new DateTime(2018, 04, 12), new DateTime(2018, 04, 14), kamar1, new List<Tamu>() {new Tamu("A022","Dessy", "Wang")} ));
            listTamuHotel.Add(noRegis[1], new Tamu("A022", "Dessy", "Wang", new DateTime(1990, 11, 11), "Beijing", "Perempuan", "312008911111990002", new DateTime(2018, 04, 12), new DateTime(2018, 04, 14), kamar1, new List<Tamu>() { new Tamu("A021", "Danny", "Tan")} ));
            listTamuHotel.Add(noRegis[2], new Tamu("A023", "Sunarti", "Wijaya", new DateTime(1985, 04, 18), "Bandung", "Perempuan", "312008923111990002", new DateTime(2018, 05, 15), new DateTime(2018, 05, 17), kamar2, new List<Tamu>() { new Tamu("A024", "Ardi", "Sanjaya"), new Tamu("A025", "Muliawan", "Sanjaya") }));
            listTamuHotel.Add(noRegis[3], new Tamu("A024", "Ardi", "Sanjaya", new DateTime(1985, 08, 01), "Jakarta", "Laki-laki", "312008901081990002", new DateTime(2018, 05, 15), new DateTime(2018, 05, 17), kamar2, new List<Tamu>() { new Tamu("A023", "Sunarti", "Wijaya"), new Tamu("A025", "Muliawan", "Sanjaya") } ));
            listTamuHotel.Add(noRegis[4], new Tamu("A025", "Muliawan", "Sanjaya", new DateTime(2000, 10, 10), "Jakarta", "Laki-laki", "3120089010102000002", new DateTime(2018, 04, 12), new DateTime(2018, 04, 14), kamar2, new List<Tamu>() { new Tamu("A024", "Ardi", "Sanjaya"), new Tamu("A023", "Sunarti", "Wijaya")} ));
            listTamuHotel.Add(noRegis[5], new Tamu("A026", "Tirta", "Raharja", new DateTime(1988, 10, 14), "Jakarta", "Laki-laki", "3120089014101988002", new DateTime(2018, 05, 18), new DateTime(2018, 05, 18), kamar4));


            SortedList<string, Tamu> listAllGuest = new SortedList<string, Tamu>();
            listAllGuest.Add(noRegis[0], new Tamu("A021", "Dany", "Tan"));
            listAllGuest.Add(noRegis[1], new Tamu("A022", "Dessy", "Wang"));
            listAllGuest.Add(noRegis[2], new Tamu("A023", "Sunarti", "Wijaya"));
            listAllGuest.Add(noRegis[3], new Tamu("A024", "Ardi", "Sanjaya"));
            listAllGuest.Add(noRegis[4], new Tamu("A025", "Muliawan", "Sanjaya"));
            listAllGuest.Add(noRegis[5], new Tamu("A026", "Tirta", "Raharja"));

            SortedList<string, List<string>> history = new SortedList<string, List<string>>();
            history.Add(noKamar[0], new List<string>()
            {
                {$"{listTamuHotel[noRegis[0]].TanggalCheckIn.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))} - {listTamuHotel[noRegis[0]].TanggalCheckOut.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))} ({listTamuHotel[noRegis[0]].NamaDepan} {listTamuHotel[noRegis[0]].NamaBelakang}, {listTamuHotel[noRegis[0]].NoRegister})" },
                {$"{listTamuHotel[noRegis[1]].TanggalCheckIn.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))} - {listTamuHotel[noRegis[1]].TanggalCheckOut.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))} ({listTamuHotel[noRegis[1]].NamaDepan} {listTamuHotel[noRegis[1]].NamaBelakang}, {listTamuHotel[noRegis[1]].NoRegister})" }
            });

            history.Add(noKamar[1], new List<string>()
            {
                {$"{listTamuHotel[noRegis[2]].TanggalCheckIn.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))} - {listTamuHotel[noRegis[2]].TanggalCheckOut.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))} ({listTamuHotel[noRegis[2]].NamaDepan} {listTamuHotel[noRegis[2]].NamaBelakang}, {listTamuHotel[noRegis[2]].NoRegister})" },
                {$"{listTamuHotel[noRegis[3]].TanggalCheckIn.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))} - {listTamuHotel[noRegis[3]].TanggalCheckOut.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))} ({listTamuHotel[noRegis[3]].NamaDepan} {listTamuHotel[noRegis[3]].NamaBelakang}, {listTamuHotel[noRegis[3]].NoRegister})" },
                {$"{listTamuHotel[noRegis[4]].TanggalCheckIn.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))} - {listTamuHotel[noRegis[4]].TanggalCheckOut.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))} ({listTamuHotel[noRegis[4]].NamaDepan} {listTamuHotel[noRegis[4]].NamaBelakang}, {listTamuHotel[noRegis[4]].NoRegister})" }
            });

            history.Add(noKamar[2], new List<string>());

            history.Add(noKamar[3], new List<string>()
            {
                {$"{listTamuHotel[noRegis[5]].TanggalCheckIn.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))} - {listTamuHotel[noRegis[5]].TanggalCheckOut.ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"))} ({listTamuHotel[noRegis[5]].NamaDepan} {listTamuHotel[noRegis[5]].NamaBelakang}, {listTamuHotel[noRegis[5]].NoRegister})" }
            });

            history.Add(noKamar[4], new List<string>());
            history.Add(noKamar[5], new List<string>());

            string inputMenu;
            string pilihMenu;

            bool pilihanMenu = true;
            Console.WriteLine("Hotel Silver Coast");
            do
            {
                Console.WriteLine("\nPilih nomor menu untuk masuk ke menunya : ");
                Console.WriteLine("1. All Guest Data");
                Console.WriteLine("2. All Room Data");
                Console.WriteLine("3. About This Hotel");
                Console.WriteLine("4. Exit Application");
                inputMenu = Console.ReadLine();

                switch (inputMenu)
                {
                    case "1":
                        bool menu1 = true;
                        do
                        {
                            foreach (Tamu item in listAllGuest.Values)
                            {
                                item.printInfoGuest();
                            }
                            Console.WriteLine("\nPilih nomor menu untuk masuk ke menunya:");
                            Console.WriteLine("1. Guest Information");
                            Console.WriteLine("2. Back To Main Menu");
                            Console.WriteLine("3. Exit Apllication");
                            pilihMenu = Console.ReadLine();

                            switch (pilihMenu)
                            {
                                case "1":
                                    Console.Write("Masukan nomor Register yang anda ingin lihat informasinya:");
                                    string inputNoReg = Console.ReadLine();
                                    if (noRegis.Contains(inputNoReg))
                                    {
                                        listTamuHotel[inputNoReg].printInfoTamu();

                                        Console.WriteLine("\nPilih nomor menu untuk masuk ke menunya:");
                                        Console.WriteLine("1. Back To All Guest Data");
                                        Console.WriteLine("2. Back To Main Menu");
                                        Console.WriteLine("3. Exit Application");
                                        pilihMenu = Console.ReadLine();

                                        switch (pilihMenu)
                                        {
                                            case "1":
                                                menu1 = true;
                                                break;
                                            case "2":
                                                pilihanMenu = true;
                                                menu1 = false;
                                                break;
                                            case "3":
                                                menu1 = false;
                                                pilihanMenu = false;

                                                break;
                                            default:
                                                Console.WriteLine("Pilih 1-3 : ");
                                                break;
                                        }
                                        break;

                                    }
                                    Console.WriteLine("\nNomor register salah. Masukkan lagi nomor registrasi kembali\n");

                                    break;

                                case "2":

                                    menu1 = false;
                                    pilihanMenu = true;

                                    break;

                                case "3":

                                    menu1 = false;
                                    pilihanMenu = false;

                                    break;

                                default:
                                    Console.WriteLine("Pilihan tidak tersedia. Silahkan input 1-3\n");
                                    break;
                            }
                        } while (menu1);
    
                        break;

                    case "2":
                        bool menu2 = true;
                        do
                        {
                            Console.WriteLine($"Lantai 3 : 301, 302, 303");
                            Console.WriteLine($"Lantai 4 : 401, 402, 403");

                            Console.WriteLine("Pilih nomor menu untuk masuk ke menunya :");
                            Console.WriteLine("1. Room Information");
                            Console.WriteLine("2. Back To Main Menu");
                            Console.WriteLine("3. Exit Apllication");
                            pilihMenu = Console.ReadLine();

                            switch (pilihMenu)
                            {
                                case "1":
                                    bool inputKamar = true;
                                    do
                                    {
                                        Console.Write("Masukan nomor Room yang anda ingin lihat informasinya : ");
                                        string inputNoKamar = Console.ReadLine();
                                        if (noKamar.Contains(inputNoKamar))
                                        {
                                            listKamarHotel[inputNoKamar].printInfoKamar();

                                            Console.WriteLine("\nReservation History : ");

                                            foreach(string item in history[inputNoKamar])
                                            {
                                                Console.WriteLine(item);
                                            }

                                            Console.WriteLine("\nPilih nomor menu untuk masuk ke menunya:");
                                            Console.WriteLine("1. Back To All Room Data");
                                            Console.WriteLine("2. Back To Main Menu");
                                            Console.WriteLine("3. Exit Application");
                                            pilihMenu = Console.ReadLine();

                                            switch (pilihMenu)
                                            {
                                                case "1":
                                                    inputKamar = false;
                                                    menu2 = true;
                                                    break;
                                                case "2":
                                                    inputKamar = false;
                                                    menu2 = false;
                                                    break;
                                                case "3":
                                                    inputKamar = false;
                                                    menu2 = false;
                                                    pilihanMenu = false;

                                                    break;
                                                default:
                                                    Console.WriteLine("\nPilih 1-3 : ");
                                                    break;
                                            }
                                            break;
                                        }
                                        Console.WriteLine("Nomor ruangan tidak ada. Silahkan input ulang.");
                                    } while (inputKamar);
                        
                                break;

                            case "2":
                                    menu2 = false;
                                pilihanMenu = true;

                                break;

                            case "3":

                                    menu2 = false;
                                pilihanMenu = false;

                                break;

                             default:
                                    Console.WriteLine("\nPilihan tidak ada. Input 1-3\n");
                                 break;
                        }
                        } while (menu2);
                        break;

                    case "3":
                        Console.WriteLine("Hotel ini bernama Silver Coast Hotel. Sudah didirikan sejak  12 May 1990 di Australia, Queensland, di kota Gold Coast.\n");
                        break;

                    case "4":
                        pilihanMenu = false;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak tersedia. Silahkan input 1-4\n");
                        break;
                }
            } while (pilihanMenu);


        }


    }
}
