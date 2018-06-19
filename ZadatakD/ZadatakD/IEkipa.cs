using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ZadatakD
{
	interface IEkipa
	{
		int PoeniEkipe { get; }
		void Snimi(StreamWriter sw);
		void Ucitaj(StreamReader sr);
	}
}
