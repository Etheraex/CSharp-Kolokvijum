using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZadatakD
{
	enum Nauka
	{
		Matematika,
		Informatika,
		OOP
	}
	class EkipaNauka:IEkipa
	{
		//private
		private List<Student> niz=new List<Student>();
		private int poeniEkipe;
		private Nauka predmet;
		//property
		public int PoeniEkipe { get => poeniEkipe; }
		public Nauka Predmet { get { return predmet; } }
		//operatori
		static public bool operator>(EkipaNauka leva,EkipaNauka desna)
		{
			return (leva.PoeniEkipe > desna.PoeniEkipe) ? true : false;
		}
		static public bool operator <(EkipaNauka leva, EkipaNauka desna)
		{
			return (leva.PoeniEkipe < desna.PoeniEkipe) ? true : false;
		}
		//metode
		private int IzracunajPoene()
		{
			int index1 = 0;
			int index2 = 0;
			int index3 = 0;
			for (int i = 0; i < niz.Count; i++)
				if (niz[i] > niz[index1])
					index1 = i;
			for (int i = 0; i < niz.Count; i++)
				if (niz[i] > niz[index2] && i!=index1)
					index2 = i;
			for (int i = 0; i < niz.Count; i++)
				if (niz[i] > niz[index3] && i != index1 && i != index2)
					index3 = i;

			return niz[index1].BrojPoena+niz[index2].BrojPoena+niz[index3].BrojPoena;
		}
		public void Snimi(StreamWriter sw)
		{
			sw.WriteLine((int)Predmet);
			foreach (Student s in niz)
				s.Snimi(sw);
		}
		public void Ucitaj(StreamReader sr)
		{
			predmet = (Nauka)int.Parse(sr.ReadLine());
			for(int i=0;i<5;i++)
			{
				Student pom = new Student();
				pom.Ucitaj(sr);
				niz.Add(pom);
			}
			poeniEkipe = IzracunajPoene();
		}
	}
}
