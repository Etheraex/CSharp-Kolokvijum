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
			Fakultet Elektronski = new Fakultet();
			Elektronski.Ucitaj("C:\\Users\\mladj\\Desktop\\nauka.txt", "C:\\Users\\mladj\\Desktop\\sport.txt");
			Elektronski.Sortiraj();
			Elektronski.Snimi("C:\\Users\\mladj\\Desktop\\naukaIzlaz.txt", "C:\\Users\\mladj\\Desktop\\sportIzlaz.txt");
		}
	}
}
