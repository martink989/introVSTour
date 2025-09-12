/*
int käimasolevAasta = 2025;
int olenNiiVana = 17;
int tehteTulemus = käimasolevAasta + olenNiiVana;

//float pikkus = 2.5f;

string sõnum = "Teie vanus on: ";

//bool miskion = false;
//CTRL K C
//Console.WriteLine(sõnum+tehteTulemus);
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("fffffffffff");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
//Console.WriteLine("Sõnum");
*/

//int lahutav1 = 0;
//int lahutav2 = 0;
//Console.WriteLine("Tere, palun sisesta esimene lahutav: ");
//lahutav1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tere, palun sisesta teine lahutav: ");
//lahutav2 = int.Parse(Console.ReadLine());
//int lahutav = lahutav1 - lahutav2;
//Console.WriteLine($"Tehte tulemus: {lahutav}");
//Console.WriteLine("Tehte tulemus: " + lahutav);

//int jagatav1 = 0;
//int jagatav2 = 0;
//Console.WriteLine("Tere, palun sisesta esimene jagatav: ");
//jagatav1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tere, palun sisesta teine jagatav: ");
//jagatav2 = int.Parse(Console.ReadLine());
//int jagatav = jagatav1 / jagatav2;
//Console.WriteLine($"Tehte tulemus: {jagatav}");
//Console.WriteLine("Tehte tulemus: " + jagatav);

//int korrutav1 = 0;
//int korrutav2 = 0;
//Console.WriteLine("Tere, palun sisesta esimene korrutav: ");
//korrutav1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tere, palun sisesta teine korrutav: ");
//korrutav2 = int.Parse(Console.ReadLine());
//int korrutav = korrutav1 * korrutav2;
//Console.WriteLine($"Tehte tulemus: {korrutav}");
//Console.WriteLine("Tehte tulemus: "+korrutav);

int arv1 = 0;
int arv2 = 0;
Console.WriteLine("Tere, palun sisesta esimene arv: ");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("Palun sisesta teine arv: ");
arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / *");
string tehtetüüp = Console.ReadLine();
int tehe = 0;

if (tehtetüüp == "+")
{
    tehe = arv1 + arv2;
}

if (tehtetüüp == "-")
{
    tehe = arv1 - arv2;
}

if (tehtetüüp == "/")
{
    tehe = arv1 / arv2;
}

if (tehtetüüp == "*")
{
    tehe = arv1 * arv2;
}

if (tehtetüüp == "^")
{
    tehe = (int)Math.Pow(arv1, arv2);
}

Console.WriteLine($"Tehte tulemus: {tehe}");



// + liitmine
// - lahutame
// / jagamine
// * korrutamine

