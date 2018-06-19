using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakE
{
	class PosiljkaBrzePoste:Posiljka
	{
		//private
		private float masa;
		private float cenaPoKg;
		//property
		public override float Masa { get => masa; }
		//metode
		public PosiljkaBrzePoste() : base()
		{

		}
		public PosiljkaBrzePoste(string adr,string im,int i,float m,float cpkg) : base(adr,im,i)
		{
			this.masa = m;
			this.cenaPoKg = cpkg;
		}

		override public float Cena
		{
			get
			{
				return cenaPoKg * masa;
			}
		}
		override public void Snimi(System.IO.StreamWriter sw)
		{
			base.Snimi(sw);
			sw.WriteLine(masa);
			sw.WriteLine(cenaPoKg);
		}
		public override void Ucitaj(StreamReader sr)
		{
			base.Ucitaj(sr);
			masa = Single.Parse(sr.ReadLine());
			cenaPoKg = Single.Parse(sr.ReadLine());
		}
	}
}
