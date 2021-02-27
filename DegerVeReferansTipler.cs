using System;

namespace DeğerVeReferansTipleri
{
	class Program
	{
		static void Main(string[] args)
		{
			int sayi1 = 10;
			int sayi2 = 30;
			sayi1 = sayi2;  //sayi1?
			sayi2 = 65;
			Console.WriteLine(sayi1);
			int[] sayilar1 = new int[] { 10, 20, 30 };                //sayiler1=             [10,20,30] sayilar1 de artık sayilar2 dizisinde yer alır ve 
			
			int[] sayilar2 = new int[] { 100, 200, 300 };             //sayiler2=           [100,200,300]                 sayılar1 ilk sayısı 9999 olur.
			sayilar1 = sayilar2;
			sayilar2[0] = 999;
			//sayiler1[0]=?
			Console.WriteLine(sayilar1[0]);
		}
	}
}
