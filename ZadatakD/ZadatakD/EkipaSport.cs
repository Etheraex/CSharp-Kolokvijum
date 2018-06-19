using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZadatakD
{
	enum Disciplina
	{
		MuskiFudbal,
		ZenskiFudbal,
		MuskaKosarka,
		ZenskaKosarka,
		Sah
	}
	class EkipaSport:IEkipa
	{
		//private
		private int poeniEkipe;
		private Disciplina sport;
		//property
		public int PoeniEkipe { get { return poeniEkipe; } }
		public Disciplina Sport { get { return sport; } }
		//operatori
		static public bool operator>(EkipaSport leva,EkipaSport desna)
		{
			return (leva.PoeniEkipe > desna.PoeniEkipe) ? true : false;
		}
		static public bool operator <(EkipaSport leva,EkipaSport desna)
		{
			return (leva.PoeniEkipe < desna.PoeniEkipe) ? true : false;
		}
		//metode
		public void Snimi(StreamWriter sw)
		{
			sw.WriteLine(PoeniEkipe);
			sw.WriteLine((int)Sport);
		}
		public void Ucitaj(StreamReader sr)
		{
			poeniEkipe = int.Parse(sr.ReadLine());
			sport = (Disciplina)int.Parse(sr.ReadLine());
		}
	}
}
