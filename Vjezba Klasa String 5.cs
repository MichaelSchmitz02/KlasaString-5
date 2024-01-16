using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    { 
        Console.Write("Unesite cijeli broj i decimalni broj odvojeni razmakom: ");
        string unos = Console.ReadLine();
       
        string[] dijelovi = unos.Split(' ');

        if (dijelovi.Length == 2 && int.TryParse(dijelovi[0], out int cijeliBroj) && double.TryParse(dijelovi[1], out double decimalniBroj))
        {
            Console.WriteLine("Uneseni cijeli broj: " + cijeliBroj);
            Console.WriteLine("Uneseni decimalni broj: " + decimalniBroj);
        }
        else
        {
            Console.WriteLine("Pogrešan unos. Molimo unesite ispravne vrijednosti.");
        }
    }
}
