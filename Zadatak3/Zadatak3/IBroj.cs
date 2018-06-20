using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
	interface IBroj
	{
		IBroj Inkrementiraj();
		IBroj Saberi(IBroj broj);
		IBroj Pomnozi(IBroj broj);
		IBroj Nula { get; }
	}
}
