using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakB
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string put = "C:\\Users\\mladj\\Desktop\\prvenstvo.txt";
				string put1 = "C:\\Users\\mladj\\Desktop\\retard.txt";
				Prvenstvo prvo = new Prvenstvo();
				prvo.Ucitaj(put);
				prvo.Sortiraj();
				//prvo.Izbaci();
				prvo.Snimi(put1);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
