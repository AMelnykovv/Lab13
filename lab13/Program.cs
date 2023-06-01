using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13
{
    using System;

    class Wigwam
    {
        public double a { get; set; }
        public double H { get; set; }
        public double h { get; set; }

        public Wigwam() // конструктор без параметрів
        {
            a = 0;
            H = 0;
            h = 0;
        }

        public Wigwam(double aVal, double HVal, double hVal) // конструктор з параметрами
        {
            a = aVal;
            H = HVal;
            h = hVal;
        }

        public double GetArea() // площа
        {
            double l = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(H - h, 2));
            return a * (H + h) / 2 + l * H / 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int N = 3;
            Wigwam[] wigwams = new Wigwam[N];

            // заповнення масиву
            wigwams[0] = new Wigwam(6, 8, 3);
            wigwams[1] = new Wigwam(7, 9, 4);
            wigwams[2] = new Wigwam(5, 7, 2);

            // інфо про об'єкти класу (вивід)
            Console.WriteLine("Дані про вігвам:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Вігвам {i + 1}: a = {wigwams[i].a}, H = {wigwams[i].H}, h = {wigwams[i].h}, S = {wigwams[i].GetArea()}");
            }

            // сортування масиву за площею через лямбду
            Array.Sort(wigwams, (x, y) => x.GetArea().CompareTo(y.GetArea()));

            // інфа про відсортований масив
            Console.WriteLine("Дані про вігвам після сортування:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Вігвам {i + 1}: a = {wigwams[i].a}, H = {wigwams[i].H}, h = {wigwams[i].h}, S = {wigwams[i].GetArea()}");
            }

            Console.ReadKey();
        }
    }
}
