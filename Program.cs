using System.Globalization;
string g = "";
bool alfa = true;
while (alfa)
{
    Console.WriteLine("zadej slovo");
    string a = Console.ReadLine();
    g += a;
    g += " ";
    if (string.IsNullOrWhiteSpace(a))
    {
        alfa = false;
        Console.WriteLine(g);
    }
   
}
/*
string b = Console.ReadLine();
for (int i = 1; i < 6; i++)
{
    Console.WriteLine(b);
}
bool beta = true;
while (beta)
{
    int d = 1;
    string c = Console.ReadLine();
    for (int i = 1; i == d; i++)
    {
        Console.WriteLine(c);
    }
    d++;
}
*/
