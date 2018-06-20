using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakD
{
	class Program
	{
		static void Main(string[] args)
		{
			Fakultet Elektronski = new Fakultet("Elektronski Fakultet");
			Elektronski.Ucitaj("nauka.txt", "sport.txt");
			Elektronski.Sortiraj();
			Elektronski.Snimi("naukaIzlaz.txt", "sportIzlaz.txt");
		}
	}
}
