using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakE
{
	class Paket:IPaket
	{
		//private
		private float cena;
		private string adresaDostave;
		private float limit;
		private double izgubljen=1;
		private List<Posiljka> niz;
		//property
		public float UkMasa
		{
			get
			{
				float pom=0;
				foreach (Posiljka p in niz)
					pom += p.Masa;
				return pom;
			}
		}
		public float UkCena { get => cena; }
		public string AdresaDostave { get => adresaDostave; }
		public float Limit { get => limit; }
		//metode
		public void Snimi(string putanja)
		{
			if (izgubljen > 0.2)
			{
				using (System.IO.StreamWriter sw = new System.IO.StreamWriter(putanja))
				{
					sw.WriteLine(cena);
					sw.WriteLine(adresaDostave);
					sw.WriteLine(limit);
					foreach (Posiljka p in niz)
						p.Snimi(sw);
				}
			}
			else Console.WriteLine("Paket Izgubljen");
		}

		public void Ucitaj(string putanja)
		{
			using (System.IO.StreamReader sr = new System.IO.StreamReader(putanja))
			{
				cena = Single.Parse(sr.ReadLine());
				adresaDostave = sr.ReadLine();
				limit = Single.Parse(sr.ReadLine());
				float pom = 0;
				niz = new List<Posiljka>();
				while(pom<=limit && !sr.EndOfStream)
				{
					PosiljkaBrzePoste asd = new PosiljkaBrzePoste();
					asd.Ucitaj(sr);
					niz.Add(asd);
					pom += asd.Masa;
				}
				if (pom > limit)
					throw new Exception("Prekoracen limit pri citanju iz fajla");
			}
		}
		public void Dodaj(Posiljka p)
		{
			if (p.Masa + this.UkMasa > this.limit)
				throw new Exception("Prekoracen limit pri ubacivanju nove posiljke");
			else niz.Add(p);
		}

		public void IzbaciOpasne()
		{
			for (int i = 0; i < niz.Count;)
			{
				if (niz[i].VrstaPosiljke == Vrsta.Opasna)
					niz.RemoveAt(i);
				else i++;
			}
		}

		public void ModelujGubljenje()
		{
			Random rand = new Random();
			izgubljen = rand.NextDouble();
		}
	}
}
