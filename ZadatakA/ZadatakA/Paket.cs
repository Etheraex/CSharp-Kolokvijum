using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZadatakA
{
	class Paket<T> where T : Komponenta, new()
	{
		//private
		private List<T> niz=new List<T>();
		private int kolicina;
		private float nominalnaVrednost;
		//property
		public float NominalnaVrednost { get => nominalnaVrednost; }
		//metode
		public Paket()
		{
		}
		public Paket(int k,float nV)
		{
			kolicina = k;
			nominalnaVrednost = nV;
		}

		public void Dodaj(T k)
		{
			if (niz.Count == kolicina) throw new Exception("Paket je pun");
			else niz.Add(k);
		}

		public void Snimi(string putanja)
		{
			using (StreamWriter sw=new StreamWriter(putanja))
			{
				sw.WriteLine(kolicina);
				sw.WriteLine(nominalnaVrednost);
				foreach (Komponenta k in niz)
					k.Snimi(sw);
			}
		}

		public void Ucitaj(string putanja)
		{
			using (StreamReader sr=new StreamReader(putanja))
			{
				kolicina = int.Parse(sr.ReadLine());
				nominalnaVrednost = Single.Parse(sr.ReadLine());
				while (!sr.EndOfStream)
				{
					T pom = new T();
					pom.Ucitaj(sr);
					niz.Add(pom);
				}
			}
		}

		public List<Paket<T> > Razvrstaj()
		{
			Paket<T> najmanje = new Paket<T>(kolicina,NominalnaVrednost);
			Paket<T> srednji = new Paket<T>(kolicina, NominalnaVrednost);
			Paket<T> najvise = new Paket<T>(kolicina, NominalnaVrednost);

			foreach(T komp in niz)
			{
				float pom = komp.Tolerancija(nominalnaVrednost);
				if (pom < 0.1)
					najmanje.Dodaj(komp);
				else if (pom > 0.1 && pom < 1)
					srednji.Dodaj(komp);
				else if (pom > 1 && pom < 10)
					najvise.Dodaj(komp);
				else
					throw new Exception("Prevelika tolerancija");
			}

			List<Paket<T>> toRet = new List<Paket<T>>();
			toRet.Add(najmanje);
			toRet.Add(srednji);
			toRet.Add(najvise);
			return toRet;
		}
	}
}
