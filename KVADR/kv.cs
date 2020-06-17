using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVADR
{
    class kv
    {
            int k = 1;
            int count = 0;
            double a;
            double b;
            double c;
            double d;
            double x1;
            double x2;
            string error = "";
            double[] itog = new double[1];
            public double A
            {
                set
                {
                    if (count == 0)
                    { a = value; }
                    else
                    {
                        throw new Exception("попытка изменить коэффициент не допустима ");
                    }
                }
                get { return a; }
            }
            public double B
            {
                set
                {
                    if (count == 0)
                    { b = value; }
                    else
                    {
                        throw new Exception("попытка изменить коэффициент не допустима ");
                    }
                }
                get { return b; }
            }
            public double C
            {
                set
                {
                    if (count == 0)
                    { c = value; }
                    else
                    {
                        throw new Exception("попытка изменить коэффициент не допустима ");
                    }
                }
                get { return c; }
            }
            public double D()
            {
                d = Math.Pow(b, 2) - 4 * a * c;
                return d;
            }
            public double X1
            {
                get { return x1; }
            }
            public double X2
            {
                get { return x2; }
            }
            public kv()
            {
                A = 0;
                B = 0;
                C = 0;
            }
            public kv(string a1, string b1, string c1)
            {
                bool na = Double.TryParse(a1, out a);
                bool nb = Double.TryParse(b1, out b);
                bool nc = Double.TryParse(c1, out c);
                if (na == false)
                {
                    error += "коэффициент А-не число   ";
                }
                if (nb == false)
                {
                    error += "коэффициент B-не число   ";
                }
                if (nc == false)
                {
                    error += "коэффициент C-не число   ";
                }
                if (error.Length != 0)
                {
                    throw new Exception(error);
                }
            }
            public kv(double a1, double b1, double c1)
            {

                a = a1;
                b = b1;
                c = c1;
            }
            public double[] Decision()
            {
                count++;
                if ((A != 0) && (B != 0) && (C == 0))
                {
                    x1 = 0;
                    x2 = -b;
                    itog[0] = X1;
                    Array.Resize(ref itog, k + 1);
                    itog[1] = X2;
                }
                if ((A == 0) && (B == 0) && (C == 0))
                {
                    throw new Exception("любое число");
                    //itog[0] = double.NegativeInfinity;
                    //itog[1] = double.PositiveInfinity;
                }
                if (((A == 0) && (B == 0) && (C != 0)) || ((A != 0) && (B == 0) && (C > 0)))
                {
                    throw new Exception("нет корней");
                }
                if (((A != 0) && (B == 0) && (C == 0)) || ((A == 0) && (B != 0) && (C == 0)))
                {
                    x1 = 0;
                    itog[0] = x1;
                }
                if (((A > 0) && (B == 0) && (C < 0)) || ((A < 0) && (B == 0) && (C > 0)))
                {
                    x1 = Math.Sqrt(-c / a);
                    x2 = -1 * Math.Sqrt(-c / a);
                    itog[0] = X1;
                    Array.Resize(ref itog, k + 1);
                    itog[1] = X2;

                }
                if ((A == 0) && (B != 0) && (C != 0))
                {
                    x1 = -c / b;
                    itog[0] = x1;

                }
                if ((A != 0) && (B != 0) && (C != 0))
                {
                    if (D() == 0)
                    {
                        x1 = -b / 2 * a;
                        itog[0] = x1;
                    }
                    if (D() > 0)
                    {
                        x1 = (-b + Math.Sqrt(d)) / (2 * a);
                        x2 = (-b - Math.Sqrt(d)) / (2 * a);
                        itog[0] = X1;
                        Array.Resize(ref itog, k + 1);
                        itog[1] = X2;
                    }
                    if (D() < 0)
                    {
                        throw new Exception("нет корней");
                    }

                }
                return itog;
            }

            public override string ToString()
            {
                string s = "";
                if (itog.Length == 1)
                {
                    s = "x=" + itog[0];
                }
                else
                {
                    s = "x1=" + itog[0] + "   x2=" + itog[1];
                }
                return s;
            }
    }
}
