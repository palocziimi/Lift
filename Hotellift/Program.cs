using System;

namespace Hotellift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. feladat
            List<Lift> list = Lift.Beolvas("lift.txt");

            //3.
            Console.WriteLine($"3. feladat: Összes lifthasználat: {list.Count}");

            //4.
            Console.WriteLine($"4. feladat: Időszak: {list.Min(x => x.Datum).ToShortDateString()} - {list.Max(x => x.Datum).ToShortDateString()}");

            //5.
            Console.WriteLine($"5. feladat: {list.Max(x => x.Veg)}");

            //6.
            Console.Write("Kártya- és célszám szóközzel elválasztva:");
            string kartya = Console.ReadLine();
            int[] adatok = new int[2];
            try
            {
                for (int i = 0; i < 2; i++)
                {
                    adatok[i] = Convert.ToInt32(kartya.Split(' ')[i]);
                }

            }
            catch (Exception)
            {
                adatok[0] = adatok[1] = 5;
            }
            Console.WriteLine($"6. feladat: \n" +
                $"\t Kártya száma: {adatok[0]}" +
                $"\n\t Célszint száma: {adatok[1]}");

            //7.
            Console.WriteLine(list.Any(x => x.Kartyaszam == adatok[0] && x.Veg == adatok[1]) ? 
                $"7. feladat: A(z) {adatok[0]}. kártyával utaztak a(z) {adatok[1]}. emeletre." : $"7. feladat: A(z) {adatok[0]}. kártyával nem utaztak a(z) {adatok[1]}. emeletre.");

            //8.
            Console.WriteLine("8. feladat: Statisztika");
            list.GroupBy(x => x.Datum).ToList().ForEach(x => Console.WriteLine($"{x.Key.ToShortDateString()} - {x.Count()}x"));
        }
    }
}