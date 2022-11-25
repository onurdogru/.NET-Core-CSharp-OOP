using System;
using System.Globalization;
/// <????????????????????>


namespace ConsoleApp
{
    class Program
    {
        class Araba
        {
            //PROPERTYLER
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Renk { get; set; }
            public bool Otomatik { get; set; }


            //METOTLAR
            public void Start()
            {
                Console.WriteLine("Araba Çalıştırıldı");
            }

            public void Stop()
            {
                Console.WriteLine("Araba stop edildi.");
            }

            public void Yavasla()
            {
                Console.WriteLine("Araba Yavaşlıyor");
            }
            public void Hizlan()
            {
                Console.WriteLine("Araba Hızlanıyor");
            }

            public void Menu() 
            {
                string komut = "";
                do
                {
                    Console.Write("Seçiminiz: 1-Start 2-Hızlan 3-Yavaşla 4-Stop 5-Çıkış Ç");
                    komut= ConsoleApp.ReadLine();

                    switch (komut)
                    {
                        case "1":
                        this.Start();
                        break;
                        case "2":
                        this.Hizlan();
                        break;
                        case "3":
                        this.Yavasla();
                        break;
                        case "4":
                        this.Stop();
                        break;
                       default:
                       Console.WriteLine("yanlış seçim");
                       break;

                    }
                }while (komut!="Ç");


            }
        }
        static void Main (string[] args)
        {
            //NESNELER
            var opel = new Araba();
            opel.Marka ="Opel";
            opel.Modeli = "Astra";
            opel.Renk = "Beyaz";
            opel.Otomatik = true;

            // opel.Start();
            // opel.Stop();
            // opel.Hizlan();
            // opel.Yavasla();????????????????????????????????

        }
    }
}