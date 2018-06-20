using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZadatakD
{
	class Fakultet
	{
		//private
		private string naziv;
		private List<EkipaNauka> nizNauka=new List<EkipaNauka>();
		private List<EkipaSport> nizSport=new List<EkipaSport>();
		//property
		
		public int UkupnoPoena
		{
			get
			{
				int pom = 0;
				foreach (EkipaNauka en in nizNauka)
					pom += en.PoeniEkipe;
				foreach (EkipaSport es in nizSport)
					pom += es.PoeniEkipe;
				return pom;
			}
		}

		public string Naziv { get { return naziv; } }
		//metode
		public Fakultet(string naz)
		{
			this.naziv = naz;
		}
		public void Snimi(string putanja1,string putanja2)
		{
			using (StreamWriter sw1=new StreamWriter(putanja1))
			{
				foreach (EkipaNauka en in nizNauka)
					en.Snimi(sw1);
			}
			using (StreamWriter sw2 = new StreamWriter(putanja2))
			{
				foreach (EkipaSport en in nizSport)
					en.Snimi(sw2);

			}
		}

		public void Ucitaj(string putanja1,string putanja2)
		{
			using (StreamReader sr1=new StreamReader(putanja1))
			{
				while (!sr1.EndOfStream)
				{
					EkipaNauka pom = new EkipaNauka();
					pom.Ucitaj(sr1);
					nizNauka.Add(pom);
				}
			}
			using (StreamReader sr2 = new StreamReader(putanja2))
			{
				while (!sr2.EndOfStream)
				{
					EkipaSport pom = new EkipaSport();
					pom.Ucitaj(sr2);
					nizSport.Add(pom);
				}
			}
		}

		public void Sortiraj()
		{
			//sortira niz naucnih ekipa
			for (int i = 0; i < nizNauka.Count-1; i++)
				for (int j = i+1; j < nizNauka.Count; j++)
					if (nizNauka[i] < nizNauka[j])
					{
						EkipaNauka pom = new EkipaNauka();
						pom = nizNauka[i];
						nizNauka[i] = nizNauka[j];
						nizNauka[j] = pom;
					}
			//sortira niz sportskih ekipa
			for (int i = 0; i < nizSport.Count-1; i++)
				for (int j =i+1; j < nizSport.Count; j++)
					if (nizSport[i] < nizSport[j])
					{
						EkipaSport pom = new EkipaSport();
						pom = nizSport[i];
						nizSport[i] = nizSport[j];
						nizSport[j] = pom;
					}
		}
	}
}
