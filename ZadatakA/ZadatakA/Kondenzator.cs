using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZadatakA
{
	class Kondenzator : Komponenta
	{
		//private
		private float maxNapon;
		private Tip jedinica;
		//property
		public float MaxNapon { get { return maxNapon; } }
		override public Tip Jedinica { get { return jedinica; } }
		override public void Snimi(StreamWriter sw)
		{
			base.Snimi(sw);
			sw.WriteLine((int)Jedinica);
			sw.WriteLine(MaxNapon);
		}
		public override void Ucitaj(StreamReader sr)
		{
			base.Ucitaj(sr);
			jedinica = (Tip)int.Parse(sr.ReadLine());
			maxNapon = Single.Parse(sr.ReadLine());
		}

	}
}
