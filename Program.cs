using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace s2_zestaw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*----------------------------------------------------
                               Zadanie 1.
            ----------------------------------------------------*/

            List<int> lista1 = new List<int>() { 4, 12, 7, 19, 3, 15, 8, 21, 6 };

            Console.WriteLine(lista1.Find(x => x > 10));
            Console.WriteLine(lista1.Find(x => x % 3 == 0));

            lista1.RemoveAll(x => x < 5);
            foreach (int i in lista1)
            {
                Console.WriteLine(i);
            }

            /*----------------------------------------------------
                               Zadanie 2.
            ----------------------------------------------------*/

            List<int> lista2 = new List<int>() { 5, 14, 22, 3, 17, 8, 10, 31, 6, 27 };

            var parzyste = lista2.Where(x => x % 2 == 0);
            var wieksze15 = lista2.Where(x => x > 15);

            var malejaco = lista2.OrderDescending();
            var suma = lista2.Sum();
            var srednia = lista2.Average();
            var najwieksza = malejaco.First();

            /*----------------------------------------------------
                               Zadanie 3.
            ----------------------------------------------------*/
            //klasa Student w oddzielnym pliku .cs
            List<Student> studenci = new List<Student>();
            studenci.Add(new Student() { Imie = "Jan", Wiek = 20, Srednia = 4.2 });
            studenci.Add(new Student() { Imie = "Anna", Wiek = 22, Srednia = 4.8 });
            studenci.Add(new Student() { Imie = "Piotr", Wiek = 20, Srednia = 3.5 });
            studenci.Add(new Student() { Imie = "Kasia", Wiek = 20, Srednia = 4.6 });

            var anna = studenci.Find(x => x.Imie == "Anna");
            var powyzejSredniej = studenci.Find(x => x.Srednia > 4.5);

            Console.WriteLine($"{anna.Imie}, {anna.Wiek}, {anna.Srednia}");
            Console.WriteLine($"{powyzejSredniej.Imie}, {powyzejSredniej.Wiek}, {powyzejSredniej.Srednia}");

            /*----------------------------------------------------
                               Zadanie 4.
            ----------------------------------------------------*/

            var studenciSrednia = studenci.FindAll(x => x.Srednia > 4);
            var studenciSort = studenci.OrderBy(x => x.Srednia);
            var studenciImiona = studenci.Select(x => x.Imie);
            var sredniaSrednich = studenci.Average(x => x.Srednia);


            /*----------------------------------------------------
                               Zadanie 5.
            ----------------------------------------------------*/

            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"Jan", 4},
                {"Anna", 5 },
                {"Piotr", 3},
                {"Kasia", 5 },
                {"Tomek", 2 }
            };

            var oceny5 = dict.Where(x => x.Value == 5);
            var oceny4 = dict.Where(x => x.Value == 4);

            var ocenySort = dict.OrderByDescending(x => x.Value);

            foreach(var pair in dict)
            {
                Console.WriteLine(pair.Key);
            }

            /*----------------------------------------------------
                                Zadanie 6.
            ----------------------------------------------------*/

            List<int> liczby = new List<int>() { 12, 5, 8, 19, 23, 4, 16, 7, 30 };

            var wiekszeNiz20 = liczby.Find(x => x > 20);
            var parzyste2 = liczby.FindAll(x => x % 2 == 0);

            var wiekszeNiz10 = liczby.Where(x => x > 20);
            var liczbySort = liczby.OrderBy(x => x);
            
            foreach (int l in wiekszeNiz10) { Console.WriteLine(l); }
            foreach (int l in liczbySort) { Console.WriteLine(l); }
        }
    }
}