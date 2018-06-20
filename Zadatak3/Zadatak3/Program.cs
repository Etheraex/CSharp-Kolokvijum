using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
	class Program
	{
		static void Main(string[] args)
		{
			Matrica<RacionalniBroj> racMatrica = new Matrica<RacionalniBroj>(2, 3);
			Console.WriteLine("Default racionalna matrica");
			racMatrica.Prikazi();
			for (int i = 0; i < 2; i++)
				for (int j = 0; j < 3; j++)
					racMatrica[i, j] = new RacionalniBroj(i+1,j+1);
			Console.WriteLine("Racionalna sa zadatim vrednostima");
			racMatrica.Prikazi();
			Console.WriteLine("Postinkrement i prikaz u istoj liniji");
			(racMatrica++).Prikazi();
			Console.WriteLine("Postinkrement ponovni prikaz");
			racMatrica.Prikazi();
			racMatrica = racMatrica + racMatrica;
			Console.WriteLine("Sabiranje");
			racMatrica.Prikazi();
			racMatrica.Snimi("C: \\Users\\mladj\\Desktop\\matricaRac.txt");
			Console.WriteLine("================================================");


			Matrica<Kompleksni> kompMatrica = new Matrica<Kompleksni>(2, 3);
			Console.WriteLine("Default kompleksna matrica");
			kompMatrica.Prikazi();
			for (int i = 0; i < 2; i++)
				for (int j = 0; j < 3; j++)
					kompMatrica[i, j] = new Kompleksni(i + j+1, j + 1);
			Console.WriteLine("Kompleksan sa zadatim vrednostima");
			kompMatrica.Prikazi();
			Console.WriteLine("Postinkrement i prikaz u istoj liniji");
			(kompMatrica++).Prikazi();
			Console.WriteLine("Postinkrement ponovni prikaz");
			kompMatrica.Prikazi();
			kompMatrica = kompMatrica + kompMatrica;
			Console.WriteLine("Sabiranje");
			kompMatrica.Prikazi();

			Matrica<Kompleksni> komp = new Matrica<Kompleksni>(3, 2);
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 2; j++)
					komp[i, j] = new Kompleksni(i + j+1, j + 3);
			
			Matrica<Kompleksni> rezultat = new Matrica<Kompleksni>(2,2);
			rezultat = komp * kompMatrica;
			Console.WriteLine("Mnozenje");
			rezultat.Prikazi();
			kompMatrica.Snimi("C: \\Users\\mladj\\Desktop\\matricaKomp.txt");
		}
	}
}
