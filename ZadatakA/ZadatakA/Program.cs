using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakA
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Paket<Kondenzator> kond = new Paket<Kondenzator>();
				kond.Ucitaj("C:\\Users\\mladj\\Desktop\\kondenzatori.txt");
				//kond.Snimi("C:\\Users\\mladj\\Desktop\\kondenzatoriRez.txt");
				//Paket<Otpornik> otp = new Paket<Otpornik>();
				//otp.Ucitaj("C:\\Users\\mladj\\Desktop\\otpornici.txt");
				//otp.Snimi("C:\\Users\\mladj\\Desktop\\otporniciRez.txt");
				List<Paket<Kondenzator>> asd = new List<Paket<Kondenzator>>();
				asd = kond.Razvrstaj();
				asd[0].Snimi("C:\\Users\\mladj\\Desktop\\kondenzatori1.txt");
				asd[1].Snimi("C:\\Users\\mladj\\Desktop\\kondenzatori2.txt");
				asd[2].Snimi("C:\\Users\\mladj\\Desktop\\kondenzatori3.txt");
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}
	}
}
