using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ZadatakB
{
	class Prvenstvo
	{
		private List<EkipaSaRezultatima> nizEkipa = new List<EkipaSaRezultatima>();
		public void Snimi(string putanja)
		{
			using (StreamWriter sw=new StreamWriter(putanja))
			{
				for (int i = 0; i < nizEkipa.Count; i++)
					nizEkipa[i].Snimi(sw);
			}
		}

		public void Ucitaj(string putanja)
		{
			using (StreamReader sr=new StreamReader(putanja))
			{
				while (!sr.EndOfStream)
				{
					var pom = new EkipaSaRezultatima();
					pom.Ucitaj(sr);
					nizEkipa.Add(pom);
				}
					
			}
		}
		public void Sortiraj()
		{
			for(int i=0;i<nizEkipa.Count-1;i++)
				for(int j=i+1;j<nizEkipa.Count;j++)
					if (nizEkipa[i].BrojBodova < nizEkipa[j].BrojBodova)
					{
						var pom = new EkipaSaRezultatima();
						pom = nizEkipa[i];
						nizEkipa[i] = nizEkipa[j];
						nizEkipa[j] = pom;
					}
		}
		public void Izbaci()
		{
			for (int i = 0; i < nizEkipa.Count; i++)
				if (nizEkipa[i].BrojIskljucenja > 2)
					nizEkipa.RemoveAt(i);
		}
	}
}
