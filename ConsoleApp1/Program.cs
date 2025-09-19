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

//int arv1 = 0;
//int arv2 = 0;
//Console.WriteLine("Tere, palun sisesta esimene arv: ");
//arv1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Palun sisesta teine arv: ");
//arv2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / *");
//string tehtetüüp = Console.ReadLine();
//int tehe = 0;

//if (tehtetüüp == "+")
//{
//    tehe = arv1 + arv2;
//}

//if (tehtetüüp == "-")
//{
//    tehe = arv1 - arv2;
//}

//if (tehtetüüp == "/")
//{
//    tehe = arv1 / arv2;
//}

//if (tehtetüüp == "*")
//{
//    tehe = arv1 * arv2;
//}

//if (tehtetüüp == "^")
//{
//    tehe = (int)Math.Pow(arv1, arv2);
//}

//Console.WriteLine($"Tehte tulemus: {tehe}");
//string lemmikpuuvili = "";
//string valik = "";
//string lemmikjuurvili;
//string lemmikköögivili;
//Console.WriteLine("Kas sulle meeldivad puuviljad, köögiviljad või juurviljad ?");
//valik = Console.ReadLine().ToString();


//if (valik == "puuviljad")
//{
//    Console.WriteLine("Milline puuvili on sinu lemmik?");
//    lemmikpuuvili = Console.ReadLine();

//    if (lemmikpuuvili == "maasikas")
//    {
//        Console.WriteLine("Maasikas ei ole puuvili");
//    }
//    else if (lemmikpuuvili == "pirn")
//    {
//        Console.WriteLine("Kas hapu pirn või magus pirn, mõlemad on head.");
//    }
//    else if (lemmikpuuvili == "kartul")
//    {
//        Console.WriteLine("See ei kasva isegi mitte puu otsas");
//    }
//    else
//    {
//        Console.WriteLine("Ei tunne seda puuvilja");
//    }
//}
//else if (valik == "juurviljad")
//{
//    Console.WriteLine("Milline juurvili on sinu lemmik?");
//    lemmikjuurvili = Console.ReadLine();

//    if (lemmikjuurvili == "õun")
//    {
//        Console.WriteLine("õun ei kasva juurtega");
//    }
//    else if (lemmikjuurvili == "sibul")
//    {
//        Console.WriteLine("Vinge");
//    }
//    else if (lemmikjuurvili == "banaan")
//    {
//        Console.WriteLine("Banaan kasvab puu otsas");
//    }
//    else
//    {
//        Console.WriteLine("Ei tunne seda juurvilja");
//    }
//}
//else if (valik == "köögiviljad")
//{
//    Console.WriteLine("Milline köögivili on sinu lemmik?");
//    lemmikköögivili = Console.ReadLine();

//    if (lemmikköögivili == "pelmeen")
//    {
//        Console.WriteLine("Ei ole köögivili");
//    }
//    else if (lemmikköögivili == "kartul")
//    {
//        Console.WriteLine("Kas magus kartul või tavaline kartul ?");

//    }
//    else if (lemmikköögivili == "maasikas")
//    {
//        Console.WriteLine("maasikas ei ole köögivili");
//    }
//    else
//    {
//        Console.WriteLine("Ei tunne seda köögivilja");
//    }
//}

//else
//{
//    Console.WriteLine("Seda valikut ei ole");
//}

int a_kulg = 0;
int b_kulg = 0;
int c_kulg = 0;
int läbimõõt = 0;
string valik = "";
Console.WriteLine("Tere Kas teie tuba on kolmnurga, ristküliku või ringi kujuline?");
valik = Console.ReadLine().ToString();

if (valik == "kolmnurk") 
{
    Console.WriteLine("Palun sisesta oma toa esimene külg");
    a_kulg = int.Parse(Console.ReadLine());

    Console.WriteLine("Sisesta oma toa teine külg");
    b_kulg = int.Parse(Console.ReadLine());

    Console.WriteLine("Sisesta oma toa kolmas külg");
    c_kulg = int.Parse(Console.ReadLine());

    int kujund = (a_kulg + b_kulg + c_kulg) / 2;
    Console.WriteLine($"Toa pindala on: {kujund}");
}



else if (valik == "ristkülik")
{
    Console.WriteLine("Palun sisesta toa esimene külg");
    a_kulg = int.Parse(Console.ReadLine());

    Console.WriteLine("Sisesta oma toa teine külg");
    b_kulg = int.Parse(Console.ReadLine());

    int kujund2 = a_kulg * b_kulg;
    Console.WriteLine($"Toa pindala on: {kujund2}");
}

else if (valik == "ring")
{
    Console.WriteLine("Palun sisesta oma toa läbimõõt");
    läbimõõt = int.Parse(Console.ReadLine());

    int kujund3 = Math.PI *  Math.Pow(läbimõõt/2);
    Console.WriteLine($"Toa pindala on: {kujund3}");
}
else
{
    Console.WriteLine("Ei tunne seda kujundit");
}

// + liitmine
// - lahutame
// / jagamine
// * korrutamine

