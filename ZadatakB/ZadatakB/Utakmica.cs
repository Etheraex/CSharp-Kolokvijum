using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakB
{
	public enum asd
	{
		Pobeda_Domacina,
		Nereseno,
		Pobeda_Gosta
	}
	class Utakmica
	{
		private string domaca;
		private string gostujuca;
		private asd ishod;
		private int iskDomacih;
		private int iskGosta;

		public string Domaca { get { return domaca; } }
		public string Gostujuca { get { return gostujuca; } }
		public asd Ishod { get { return ishod; } }
		public int IskDomacih { get { return iskDomacih; } }
		public int IskGosta { get { return iskGosta; } }
		public Utakmica()
		{
		}
		public virtual void Snimi(System.IO.StreamWriter sw)
		{
			sw.WriteLine(this.domaca);
			sw.WriteLine(this.gostujuca);
			sw.WriteLine(this.ishod);
			sw.WriteLine(this.iskDomacih);
			sw.WriteLine(this.iskGosta);
		}
		public virtual void Ucitaj(System.IO.StreamReader sr)
		{
			this.domaca = sr.ReadLine();
			this.gostujuca = sr.ReadLine();
			this.ishod = (asd)int.Parse(sr.ReadLine());
			this.iskDomacih = int.Parse(sr.ReadLine());
			this.iskGosta = int.Parse(sr.ReadLine());
		}
	}
}
