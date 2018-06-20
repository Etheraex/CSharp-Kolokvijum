using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
	struct Kompleksni:IBroj
	{
		private float real;
		private float imag;

		public Kompleksni(float x,float y)
		{
			real = x;
			imag = y;
		}

		public IBroj Nula => new Kompleksni(0,0);

		public IBroj Inkrementiraj()
		{
			this.real += 1;
			this.imag += 1;
			return this;
		}

		public IBroj Pomnozi(IBroj broj)
		{
			if (broj is Kompleksni)
			{
				Kompleksni drugi = (Kompleksni)broj;
				return new Kompleksni(this.real*drugi.real-this.imag*drugi.imag,this.imag*drugi.real+this.real*drugi.imag);
			}
			else
				throw new Exception("Drugi nije Kompleksni");
		}

		public IBroj Saberi(IBroj broj)
		{
			if (broj is Kompleksni)
			{
				Kompleksni drugi = (Kompleksni)broj;
				return new Kompleksni(this.real + drugi.imag, this.imag + drugi.imag);
			}
			else
				throw new Exception("Drugi nije Kompleksni");
		}

		public override string ToString()
		{
			return real + "+i" + imag;
		}
	}
}
