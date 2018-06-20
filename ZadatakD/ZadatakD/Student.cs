using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakD
{
	class Student
	{
		//private
		private string ime;
		private string prezime;
		private int brojPoena;
		//property
		public string Ime { get { return ime; } }
		public string Prezime { get{ return prezime; } }
		public int BrojPoena { get { return brojPoena; } }
		//metode
		public void Snimi(System.IO.StreamWriter sw)
		{
			sw.WriteLine(Ime);
			sw.WriteLine(Prezime);
			sw.WriteLine(BrojPoena);
		}
		public void Ucitaj(System.IO.StreamReader sr)
		{
			ime = sr.ReadLine();
			prezime = sr.ReadLine();
			brojPoena = int.Parse(sr.ReadLine());
			if (brojPoena < 0) throw new Exception("Negativan broj poena");
		}

		static public bool operator >(Student levi, Student desni)
		{
			return (levi.BrojPoena > desni.BrojPoena) ? true : false;
		}
		static public bool operator <(Student levi, Student desni)
		{
			return (levi.BrojPoena < desni.BrojPoena) ? true : false;
		}
	}
}
