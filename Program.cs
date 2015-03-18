using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational ra = new Rational();
            Rational ra1 = new Rational(8,7);
            Rational ra2 = new Rational(1,0);
            Rational ra3 = new Rational(15,27);
            ra.RationalDisplay();
            ra1.RationalDisplay();
            ra2.RationalDisplay();
            Rational ra4;
            ra4 = ra.Topla(ra1);
            ra4.RationalDisplay();
            Rational ra5;
            ra5 = ra.Cikar(ra1);
            ra5.RationalDisplay();
            Rational ra6;
            ra6 = ra1.Carp(ra3);
            ra6.RationalDisplay();
            Rational ra7;
            ra7 = ra1.Bol(ra3);
            ra7.RationalDisplay();
        }
    }
}
