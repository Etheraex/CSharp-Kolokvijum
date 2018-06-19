using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ZadatakB
{
	interface IRezultat
	{
		int BrojBodova { get; }
		int BrojIskljucenja { get; }
		void Snimi(StreamWriter sw);
		void Ucitaj(StreamReader sr);
	}
}
