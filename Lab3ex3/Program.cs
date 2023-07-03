//Ex 3
// o functie care va determina daca un numar este sau nu patrat perfect. Apelati-o si afisati-i rezultatu
//
//





Console.WriteLine("Introduce un numar");
int numar = int.Parse(Console.ReadLine());

bool rezultat = IsPatratPerfect(numar);

if (rezultat)
    Console.WriteLine("Numărul este un pătrat perfect.");
else
    Console.WriteLine("Numărul nu este un pătrat perfect.");


static bool IsPatratPerfect(int numar)
{
    int radacina = (int)Math.Sqrt(numar);
    return radacina * radacina == numar;
}