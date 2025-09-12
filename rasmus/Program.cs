/*
int KäimasolevAasta = 2025;
int OlenNiiVana = 17;
int TehteTulemus = KäimasolevAasta + OlenNiiVana;

//float pikkus = 2.5f;

string sõnum = "teie vanus on: ";

//bool miskion = false;

//Console.WriteLine(sõnum+TehteTulemus);
//Console.WriteLine("sõnum");
//Console.WriteLine("sõnum");
//Console.WriteLine("llllll");
//Console.WriteLine("sõnum");
*/

int arv1 = 0;
int arv2 = 0;
int lahutatav1 = 0;
int lahutatav2 = 0;
int jagatav1 = 0;
int jagatav2 = 0;
int korrutatav1 = 0;
int korrutatav2 = 0;

Console.WriteLine("tere, palun sisesta esimene arv: ");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("tere, palun sisesta teine arv: ");
arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("missugust tehet soovid teha? kirjuta kas: + - / * ^");
string tehtetüüp = Console.ReadLine();
int tehe = 0;

if (tehtetüüp == "+" /*tingimus siia*/) 
{
    tehe = arv1 + arv2;
}
if (tehtetüüp == "-" /*tingimus siia*/) 
{
    tehe = arv1 - arv2;
}
if (tehtetüüp == "/" /*tingimus siia*/) 
{
    tehe = arv1 / arv2;
}
if (tehtetüüp == "*" /*tingimus siia*/) 
{
    tehe = arv1 * arv2;
}
if (tehtetüüp == "^" /*tingimus siia*/)
{
    tehe = (int)Math.Pow(arv1,arv2);
}
Console.WriteLine($"{tehtetüüp}tehte tulemus: {tehe}");

//Console.WriteLine("tere, palun sisesta esimene lahutatav: ");
//lahutatav1 = int.Parse(Console.ReadLine());
//Console.WriteLine("tere, palun sisesta teine lahutatav: ");
//lahutatav2 = int.Parse(Console.ReadLine());
//int lahutamine = lahutatav1 - lahutatav2;
//Console.WriteLine($"tehte tulemus:{lahutamine}");

//Console.WriteLine("tere, palun sisesta esimene jagatav: ");
//jagatav1 = int.Parse(Console.ReadLine());
//Console.WriteLine("tere, palun sisesta teine jagatav: ");
//jagatav2 = int.Parse(Console.ReadLine());
//int jagamine = jagatav1 / jagatav2;
//Console.WriteLine($"tehte tulemus:{jagamine}");

//Console.WriteLine("tere, palun sisesta esimene korrutatav: ");
//korrutatav1 = int.Parse(Console.ReadLine());
//Console.WriteLine("tere, palun sisesta teine korrutatav: ");
//korrutatav2 = int.Parse(Console.ReadLine());
//int korrutamine = korrutatav1 * korrutatav2;
//Console.WriteLine($"tehte tulemus:{korrutamine}");