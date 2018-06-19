using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ZadatakB
{
	class EkipaSaRezultatima:IRezultat
	{
		private string naziv;
		private List<Utakmica> domacinNiz;
		private List<Utakmica> gostNiz;
		private int domaceUk;
		private int straneUk;

		public int BrojBodova
		{
			get
			{
				int pom = 0;
				foreach(Utakmica ut in domacinNiz)
				{
					switch (ut.Ishod)
					{
						case asd.Nereseno:
							pom += 1;
							break;
						case asd.Pobeda_Domacina:
							pom += 3;
							break;
						case asd.Pobeda_Gosta:
							break;
					}
				}
				foreach (Utakmica ut in gostNiz)
				{
					switch (ut.Ishod)
					{
						case asd.Nereseno:
							pom += 1;
							break;
						case asd.Pobeda_Domacina:
							break;
						case asd.Pobeda_Gosta:
							pom += 3;
							break;
					}
				}
				return pom;
			}
		}
		public int BrojIskljucenja {
			get
			{
				int pom = 0;
				foreach (Utakmica ut in domacinNiz)
					pom += ut.IskDomacih;
				foreach(Utakmica ut in gostNiz)
					pom += ut.IskGosta;
				return pom;
			}
		}
		public void Snimi(StreamWriter sw)
		{
			sw.WriteLine(naziv);
			sw.WriteLine(domaceUk);
			sw.WriteLine(straneUk);
			foreach (Utakmica ut in domacinNiz)
				ut.Snimi(sw);
			foreach (Utakmica ut in gostNiz)
				ut.Snimi(sw);
		}
		public void Ucitaj(StreamReader sr)
		{
			naziv = sr.ReadLine();
			domaceUk = int.Parse(sr.ReadLine());
			straneUk = int.Parse(sr.ReadLine());
			domacinNiz = new List<Utakmica>(domaceUk);
			for(int i = 0; i < domaceUk; i++)
			{
				Utakmica pom=new Utakmica();
				pom.Ucitaj(sr);
				domacinNiz.Add(pom);
			}
			gostNiz = new List<Utakmica>(straneUk);
			for (int i = 0; i < straneUk; i++)
			{
				Utakmica pom = new Utakmica();
				pom.Ucitaj(sr);
				gostNiz.Add(pom);
			}
		}
	}
}
