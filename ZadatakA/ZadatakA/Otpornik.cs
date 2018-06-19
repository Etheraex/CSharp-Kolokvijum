using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZadatakA
{
	class Otpornik:Komponenta
	{
		//private
		private float maxSnaga;
		private Tip jedinica;
		//property
		public float MaxSnaga { get { return maxSnaga; } }
		override public Tip Jedinica { get { return jedinica; } }
		override public void Snimi(StreamWriter sw)
		{
			base.Snimi(sw);
			sw.WriteLine((int)Jedinica);
			sw.WriteLine(MaxSnaga);
		}
		public override void Ucitaj(StreamReader sr)
		{
			base.Ucitaj(sr);
			jedinica = (Tip)int.Parse(sr.ReadLine());
			maxSnaga = Single.Parse(sr.ReadLine());
		}

	}
}
