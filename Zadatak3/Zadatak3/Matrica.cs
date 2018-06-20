using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
	class Matrica<T> where T: struct, IBroj
	{
		//private
		private int vrsta;
		private int kolona;
		private T[,] matrica;

		//konstruktori
		public Matrica(int v,int k)
		{
			this.vrsta = v;
			this.kolona = k;
			this.matrica = new T[vrsta, kolona];
		}

		public Matrica(Matrica<T> m)
		{
			this.vrsta = m.vrsta;
			this.kolona = m.kolona;
			this.matrica = new T[vrsta, kolona];
			for (int i = 0; i < vrsta; i++)
				for (int j = 0; j < kolona; j++)
					this.matrica[i, j] = m.matrica[i, j];
		}

		//indexer
		public T this[int i,int j]
		{
			get { return matrica[i, j]; }
			set { matrica[i, j] = value; }
		}

		//metode
		public void Prikazi()
		{
			for (int i = 0; i < vrsta; i++)
			{
				for (int j = 0; j < kolona; j++)
					Console.Write(matrica[i, j] + " ");
				Console.WriteLine();
			}
		}

		//operatori
		public static Matrica<T> operator++(Matrica<T> m)
		{
			Matrica<T> rezultat = new Matrica<T>(m);
			for (int i = 0; i < rezultat.vrsta; i++)
				for (int j = 0; j < rezultat.kolona; j++)
					rezultat.matrica[i, j].Inkrementiraj();
			return rezultat;
		}

		public static Matrica<T> operator+(Matrica<T> prva,Matrica<T> druga)
		{
			if (prva.vrsta != druga.vrsta || prva.kolona != druga.kolona)
				throw new Exception("Matrice nisu kompatabilne");
			Matrica<T> rezultat = new Matrica<T>(prva.vrsta, prva.kolona);
			for (int i = 0; i < rezultat.vrsta; i++)
				for (int j = 0; j < rezultat.kolona; j++)
					rezultat.matrica[i, j] = (T)prva.matrica[i, j].Saberi(druga.matrica[i, j]);
			return rezultat;
		}

		public static Matrica<T> operator*(Matrica<T> prva,Matrica<T> druga)
		{
			if(prva.kolona!=druga.vrsta)
				throw new Exception("Matrice nisu kompatabilne");
			Matrica<T> rezultat = new Matrica<T>(prva.vrsta, druga.kolona);
			for (int i = 0; i < rezultat.vrsta; i++)
				for (int j = 0; j < rezultat.kolona; j++)
				{
					rezultat.matrica[i, j] = (T)rezultat.matrica[i, j].Nula;
					for (int k = 0; k < prva.kolona; k++)
						rezultat.matrica[i, j] = (T)rezultat.matrica[i, j].Saberi(prva.matrica[i, k].Pomnozi(druga.matrica[k, j]));
				}
			return rezultat;
		}

		public void Snimi(string putanja)
		{
			using (System.IO.StreamWriter sw=new System.IO.StreamWriter(putanja))
			{
				sw.WriteLine(vrsta);
				sw.WriteLine(kolona);
				for (int i = 0; i < vrsta; i++)
					for (int j = 0; j < kolona; j++)
						sw.WriteLine(matrica[i,j]);
			}
		}
	}
}
