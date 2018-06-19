using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakE
{
	public enum Vrsta
	{
		Lomljiva,
		Opasna,
		Obicna
	}
	abstract class Posiljka
	{
		//private
		private string adresa;
		private string ime;
		private Vrsta vrstaPosiljke;
		//propery
		public string Adresa { get { return adresa; } }
		public string Ime { get { return ime; } }
		public Vrsta VrstaPosiljke { get { return vrstaPosiljke; } }
		abstract public float Cena { get; }
		abstract public float Masa { get; }
		//metode
		public Posiljka()
		{

		}
		public Posiljka(string adr,string im,int i)
		{
			this.adresa = adr;
			this.ime = im;
			this.vrstaPosiljke = (Vrsta)i;
		}
		public virtual void Snimi(System.IO.StreamWriter sw)
		{
			sw.WriteLine(adresa);
			sw.WriteLine(ime);
			sw.WriteLine((int)vrstaPosiljke);
		}
		public virtual void Ucitaj(System.IO.StreamReader sr)
		{
			adresa = sr.ReadLine();
			ime = sr.ReadLine();
			vrstaPosiljke = (Vrsta)int.Parse(sr.ReadLine());
		}
	}
}
