using System;
namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sehirler = new Dictionary<string, int>();
            sehirler.Add("Samsun" , 55);
            sehirler.Add("İstanbul", 34);
            sehirler.Add("Edirne", 22);
            sehirler.Add("Ankara", 06);
            sehirler.Add("İzmir", 35);

            Console.WriteLine(sehirler.Count);

            foreach (var key in sehirler.Keys)
            {
                Console.WriteLine("Sehirler: " + key );
            }
            foreach (var value in sehirler.Values)
            {
                Console.WriteLine("Plaka: " + value);
            }





        }
    }
}