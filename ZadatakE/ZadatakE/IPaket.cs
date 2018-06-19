using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakE
{
	interface IPaket
	{
		string AdresaDostave { get; }
		float UkCena { get; }
		float Limit { get; }
	}
}
