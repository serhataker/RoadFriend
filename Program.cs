using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace RoadFriend
{
    class BestFriend
    {
        static void Main(string[] args)
        {
            do
            {

           
            Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");//option for the choose
            Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");
            Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL");
            string vac;
            int vac1;
            do
            {
                Console.Write("Please Chose Vacation:");
                vac=Console.ReadLine().ToLower();

                switch (vac)
                {
                   
                    case "bodrum":
                        Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)");
                        break;
                    case "marmaris":
                        Console.WriteLine("2 - Marmaris (Paket başlangıç fiyatı 3000 TL)");

                        break;
                    case "çeşme":
                        Console.WriteLine("3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
                        break;

                    default:
                        // state of not
                        Console.WriteLine("Invalid choice. Please enter a valid option location name (bodrum, marmaris, çeşme).");
                        break;
                }

                
            } while (vac != "bodrum" && vac != "marmaris" && vac != "çeşme");
            
            Console.WriteLine($"Thank you for choosing your destination with us!");

            if (vac == "bodrum")
            {
                vac1 = 4000;//Vacation for the one people price
                Console.WriteLine("The love life in the bodrum!");
            }
            else if(vac=="marmaris") {
                vac1 = 3000;//Vacation for the one people price
                    Console.WriteLine("Marmaris is very good land in egea");
            }
            else
            {
                vac1 = 5000;//Vacation for the one people price
                    Console.WriteLine("Çeşme is so expensive!");
            }
            Console.WriteLine("Plese input how many people with you will come vacation:?");// Sum total 
            int countPeople=Convert.ToInt32( Console.ReadLine());
                countPeople = countPeople++;// Because the people we count plus
            Console.WriteLine("1-Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");//option for the choose
                Console.WriteLine("2-Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");

            string trs;// transporter variable
            int trs1; // transporter variable for coounting
                do
            {
                Console.Write("Please Chose transporter vehicle:");//question what do you want to transporter
                trs = Console.ReadLine();

                switch (trs)
                {

                    case "1":
                        Console.WriteLine("Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )");
                        break;
                    case "2":
                        Console.WriteLine("Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");

                        break;
                    default:
                        // state of not
                        Console.WriteLine("Invalid choice. Please enter a valid option transporter (1, 2).");
                        break;
                }


            } while (trs != "1" && trs!="2");
            Console.WriteLine("");
            if (trs == "1")
            {
                trs1 = 1500;
                Console.WriteLine($"Total Sum Price:" + countPeople * (trs1 + vac1));// total count price
            }
            else  
            {
                trs1 = 4000;
                Console.WriteLine($"Total Sum Price:"+countPeople * (trs1 + vac1));//totoal count price
            }


                Console.WriteLine("Do you want to calculate a new vacation? (y/n)");//option for the choose
                string choose = Console.ReadLine().ToLower();

                // if user wants to continue
                if (choose != "y")
                {
                    break;
                }

            } while (true);

            Console.WriteLine("Thank you for choosing to us!");
        }

      
    }
}