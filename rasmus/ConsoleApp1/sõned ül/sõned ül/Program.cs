using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Sources;

namespace sõned_ül
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kirjuta programm mis
            //küsib kasutajalt tsüklis, millised mängud talle meeldivad
            //küsimiste tulemus hoia järjendis
            List<string> mängud = new List<string>();
            Console.WriteLine("tere kasutaja, millised mängud sulle meeldivad");
            string mäng = "";
            while (mäng != "ei ole")
            {
                Console.WriteLine("palun sisestage järgmine mäng, kui ei ole kirjuta \"ei ole\"");
                mäng = Console.ReadLine();
                if (mäng != "ei ole")
                {
                    mängud.Add(mäng);
                }

            }
            foreach (var item in mängud)
            {
                Console.WriteLine(item);
            }

            //kui järjend sisaldab (.contains()) "mario cart", siis küsi vana ta on, sarkastiliselt.
            if (mängud.Contains("mario cart"))
            {
                Console.WriteLine("Kui vana sa oled?? mingi 6 v?");
            }
           //kui järjend sisaldab "gta 6" siis küsi kust ta ajamasina sai, et rockstar lõpuks asjadega valmis sai
           if (mängud.Contains("gta 6"))
            {
                Console.WriteLine("kust ajamasina said? Kuidas rockstar arendusega juurde sai?");
            }
            //kui järjend sisaldab"pong" siis ütle "80ndad tahavad vanureid tagasi, toimub boomerite recall"
            if (mängud.Contains("pong")) ;
            {
                Console.WriteLine("80ndad tahavad vanureid tagasi, toimub boomerite recall");
            }
           //kui järjend on tühi siis programm läheb edasi ->

            //küsi kasutajalt kas talle ei meeldi mängud, lase tal vastata sõnaga jah või ei, kontrolli kasutaja sisestust .ToUpper() või .ToLower()iga
            //kui talle ei meeldi, siis ütle "kahju"
            if (!mängud.Any())
            {
                Console.WriteLine("kas sulle ei meeldi mängud? ValueTaskSourceStatus kas jah või ei");
                string jahvõiei = Console.ReadLine().ToLower();
                if (jahvõiei.Contains("jah"))
                {
                    Console.WriteLine("aga miks sa siis ei sisestand?");
                }
                else if (jahvõiei.Contains("ei"))
                    {
                    Console.WriteLine("kahju");
                    }
                else
                {
                    Console.WriteLine("ei saa aru");
                }
            }

            //kui ta vastab jah siis ütle "aga miks siis ei sisestanud?"
            // kui vastus on midagi muud siois ütle "ei saa aru"

        }
    }
}
