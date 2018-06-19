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
			int[] najveci=new int[3];
			najveci[0] = niz[0].BrojPoena;
			najveci[1] = niz[1].BrojPoena;
			najveci[2] = niz[2].BrojPoena;
			for(int i = 3; i < niz.Count; i++)
			{
				if (niz[i].BrojPoena > najveci[0])
					najveci[0] = niz[i].BrojPoena;
				else if (niz[i].BrojPoena > najveci[1])
					najveci[1] = niz[i].BrojPoena;
				else if (niz[i].BrojPoena > najveci[2])
					najveci[2] = niz[i].BrojPoena;
			}

			return (najveci[0]+najveci[1]+najveci[2]);
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
