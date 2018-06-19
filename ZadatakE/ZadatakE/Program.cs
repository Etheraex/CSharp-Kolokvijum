using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakE
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Paket p = new Paket();
				p.Ucitaj("C:\\Users\\mladj\\Desktop\\ulaz.txt");
				Posiljka asd = new PosiljkaBrzePoste("Dusanova", "Mika", 1, 20, 50); //opasna
				Posiljka asd1 = new PosiljkaBrzePoste("Dusanova", "Mika", 1, 20, 50); //opasna
				p.Dodaj(asd);
				p.Dodaj(asd1);
				p.Snimi("C:\\Users\\mladj\\Desktop\\izlaz.txt"); //snimljeno sa opasnim
				p.ModelujGubljenje();
				p.Snimi("C:\\Users\\mladj\\Desktop\\izlaz1.txt"); //snimljeno ako nije uzgubljen
				p.IzbaciOpasne();
				//Exception zbog prekoracenja limita pri dodavanju nove posiljke
				//Posiljka asd1 = new PosiljkaBrzePoste("Dusanova", "Mika", 2, 100, 50);

				//p.Dodaj(asd1);
				p.Snimi("C:\\Users\\mladj\\Desktop\\izlaz2.txt"); //bez opasnih


			}
			catch(Exception e)
			{
				Console.WriteLine(e);
			}
		}
	}
}
