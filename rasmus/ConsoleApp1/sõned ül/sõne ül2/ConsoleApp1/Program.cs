using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kirjuta programm, kus on 2 kasutajat (kasutajanime ja parooliga(:
            //küsi kasutajalt tema kasutajanime, otsi kasutajate järjendist vastav kasutaja, ja kui kasutajat ei leita, ütle et kasutaja ei eksisteeri
            //kui kasutaja eksisteerib, vaata kasutaja parooli, küsi kasutajalt tema parooli ja võrdle neid
            //kui paroolid ühtivad, ütle tere tulemast
            //kui aga ei ühti, küsi kasutajalt parooli uuesti.

            List<List<string>> kasutajad = new List<List<string>>();
            kasutajad.Add(new List<string> { "kasutajanimi", "parool" });
            kasutajad.Add(new List<string> { "kasutajanimi2", "parool2" });

            string kasutajanimi = "";
            Console.WriteLine("palus sisesta oma kasutajanimi");
            kasutajanimi = Console.ReadLine();
            bool doesuserexist = false;
            string õigeparool = "";
            foreach (var user in kasutajad)
            {
                if (user[0] == kasutajanimi)
                {
                    doesuserexist = true;
                }
                if (doesuserexist == true)
                {
                    string sisestus = "";
                    Console.WriteLine("tere", kasutajanimi, "sisesta oma parool");
                    while (sisestus != õigeparool)
                    {
                        Console.WriteLine("palus sisestage oma parool!");
                        sisestus = Console.ReadLine();
                    }
                    Console.WriteLine($"Tere tulemast {kasutajanimi}");
                }
                else
                {
                    Console.WriteLine("kasutaja ei eksisteeri");
                }
            }
        }
    }
}
