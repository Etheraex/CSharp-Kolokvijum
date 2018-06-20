using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
	struct RacionalniBroj:IBroj
	{
		private int brojilac;
		private int imenilac;

		public RacionalniBroj(int x, int y)
		{
			this.brojilac = x;
			this.imenilac = y;
		}

		public IBroj Nula { get { return new RacionalniBroj(0, 1); } }

		public IBroj Inkrementiraj()
		{
			brojilac += imenilac;
			return this;
		}

		public IBroj Saberi(IBroj broj)
		{
			if (broj is RacionalniBroj)
			{
				RacionalniBroj drugi = (RacionalniBroj)broj;
				return new RacionalniBroj(this.brojilac * drugi.imenilac + this.imenilac * drugi.brojilac, this.imenilac * drugi.imenilac);
			}
			else
				throw new Exception("Prosledjeni nije racionalni broj");
		}
		
		public IBroj Pomnozi(IBroj broj)
		{
			if (broj is RacionalniBroj)
			{
				RacionalniBroj drugi = (RacionalniBroj)broj;
				return new RacionalniBroj(this.brojilac*drugi.brojilac,this.imenilac*drugi.imenilac);
			}
			else
				throw new Exception("Prosledjeni operand nije racionalni broj");
		}

		public override string ToString()
		{
			return brojilac + "/" + imenilac;
		}
	}
}
