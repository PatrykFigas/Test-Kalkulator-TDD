using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTDD
{
    public class Fraction
    {
        public int Licznik { get; private set; }
        public int Mianownik { get; private set; }

        public Fraction(int licznik, int mianownik)
        {
            if (mianownik == 0)
                throw new DivideByZeroException("Mianownik nie może być zerem.");

            int nwm = NWD(Math.Abs(licznik), Math.Abs(mianownik));
            Licznik = licznik / nwm;
            Mianownik = mianownik / nwm;

            // znak ułamka zawsze w liczniku
            if (Mianownik < 0)
            {
                Licznik *= -1;
                Mianownik *= -1;
            }
        }

        public static Fraction operator +(Fraction a, Fraction b) =>
            new Fraction(a.Licznik * b.Mianownik + b.Licznik * a.Mianownik,
                         a.Mianownik * b.Mianownik);

        public static Fraction operator -(Fraction a, Fraction b) =>
            new Fraction(a.Licznik * b.Mianownik - b.Licznik * a.Mianownik,
                         a.Mianownik * b.Mianownik);

        public static Fraction operator *(Fraction a, Fraction b) =>
            new Fraction(a.Licznik * b.Licznik, a.Mianownik * b.Mianownik);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Licznik == 0)
                throw new DivideByZeroException("Nie można dzielić przez 0.");
            return new Fraction(a.Licznik * b.Mianownik, a.Mianownik * b.Licznik);
        }

        public override string ToString() => $"{Licznik}/{Mianownik}";

        public double ToDouble() => (double)Licznik / Mianownik;

        private int NWD(int a, int b) => b == 0 ? a : NWD(b, a % b);
    }
}

