using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZadatakA
{
	enum Tip
	{
		Om,
		Farad
	}
	abstract class Komponenta
	{
		//privatni
		private float izmerenaVrednost;
		private int serijskiBroj;
		//property
		public float IzmerenaVrednost { get => izmerenaVrednost; }
		abstract public Tip Jedinica { get; }
		public int SerijskiBroj { get { return serijskiBroj; } }
		//metode

		public virtual void Snimi(StreamWriter sw)
		{
			sw.WriteLine(IzmerenaVrednost);
			sw.WriteLine(SerijskiBroj);
		}

		public virtual void Ucitaj(StreamReader sr)
		{
			izmerenaVrednost = Single.Parse(sr.ReadLine());
			serijskiBroj = int.Parse(sr.ReadLine());
		}

		public float Tolerancija(float nominalnaVrednost)
		{
			return Math.Abs(nominalnaVrednost - izmerenaVrednost) / nominalnaVrednost;
		}
	}
}
