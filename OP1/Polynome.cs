using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP1
{
    class Polynome
    {
        public int x;
        public int degree;
        public List<int> coefficients = new ();
        public int GetX
        {
            get { return x; }
        }
        public int GetDegree
        {
            get { return degree; }
        }
        public List<int> GetC
        {
            get { return coefficients; }
        }
        public Polynome()
        {
            Console.WriteLine("Степiнь полiнoмy:");
            degree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X:");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < degree; ++i)
            {
                Console.WriteLine("C{0}:", i + 1);
                coefficients.Add(Convert.ToInt32(Console.ReadLine()));

            }
        }
        public Polynome(int deg, int xVal, List<int> c)
        {
            if (deg == c.Count)
            {
                degree = deg;
                x = xVal;
                foreach (int n in c)
                    coefficients.Add(n);
            }
        }
        public void Display()
        {

            Console.WriteLine("Поточний полiном:");
            Console.Write("Степiнь: {0}, X: {1}, Коефiцiєнти: ", this.GetDegree, this.GetX);
            foreach (int n in coefficients)
            {
                Console.Write(n + " ; ");
            }

            Console.WriteLine();
        }
        public static Polynome AddPolynomes(Polynome a, Polynome b)
        {
            int d, xVal;
            List<int> lc = new ();
            Console.WriteLine("Х нового полiному");
            xVal = Convert.ToInt32(Console.ReadLine());
            if (a.GetDegree > b.GetDegree)
            {
                d = a.GetDegree;
                for (int i = 0; i < b.GetDegree; ++i)
                {
                    lc.Add(a.GetC[i] + b.GetC[i]);
                }
                for (int i = b.GetDegree; i < a.GetDegree; ++i)
                {
                    lc.Add(a.GetC[i]);
                }
            }
            else
            {
                d = b.GetDegree;
                for (int i = 0; i < a.GetDegree; ++i)
                {
                    lc.Add(a.GetC[i] + b.GetC[i]);
                }
                for (int i = a.GetDegree; i < b.GetDegree; ++i)
                {
                    lc.Add(b.GetC[i]);
                }
            }
            Polynome c = new (d, xVal, lc);
            return c;
        }
        public static Polynome SubstractPolynomes(Polynome a, Polynome b)
        {
            int d, xVal;
            List<int> lc = new ();
            Console.WriteLine("Х нового полiному");
            xVal = Convert.ToInt32(Console.ReadLine());
            if (a.GetDegree > b.GetDegree)
            {
                d = a.GetDegree;
                for (int i = 0; i < b.GetDegree; ++i)
                {
                    lc.Add(a.GetC[i] - b.GetC[i]);
                }
                for (int i = b.GetDegree; i < a.GetDegree; ++i)
                {
                    lc.Add(-a.GetC[i]);
                }
            }
            else
            {
                d = b.GetDegree;
                for (int i = 0; i < a.GetDegree; ++i)
                {
                    lc.Add(a.GetC[i] - b.GetC[i]);
                }
                for (int i = a.GetDegree; i < b.GetDegree; ++i)
                {
                    lc.Add(-b.GetC[i]);
                }
            }
            Polynome c = new (d, xVal, lc);
            return c;
        }
        public static Polynome MyltiplyPolynomes(Polynome a, Polynome b)
        {
            int d, xVal;
            d = a.GetDegree * b.GetDegree;
            List<int> lc = new ();
            Console.WriteLine("Х нового полiному");
            xVal = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a.GetDegree; i++)
            {
                for (int j = 0; j < b.GetDegree; j++)
                {
                    lc.Add(a.GetC[i] * b.GetC[j]);
                }
            }

            Polynome c = new (d, xVal, lc);
            return c;
        }
        public void Obsh()
        {

            int xVal;
            xVal = GetX;
            double c;
            double result = 0;
            int i = GetDegree;
            foreach (int n in coefficients)
            {

                c = Math.Pow(xVal, i) * n;
                result += c;
                i--;
            }

            Console.Write(result);
        }
    }

}







