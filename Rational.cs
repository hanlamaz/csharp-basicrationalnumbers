using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Rational
    {
        int numerator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        int denominator;

        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
        public Rational(int num, int denum)
        {
            Numerator = num;
            Denominator = denum;
        }
        public Rational()
        {
             
            //new Rational(1, 1);
            Numerator = 1;
            Denominator = 1;
        }
        public void RationalDisplay()
        {
            Console.WriteLine("{0} / {1}",Numerator,Denominator);
        }
        public Rational Topla (Rational addValue)
        {
            return new Rational(this.Denominator * addValue.Numerator + this.Numerator * addValue.Denominator, this.Denominator * addValue.Denominator);
        }
        public Rational Cikar(Rational addValue)
        {
            return new Rational(this.Numerator * addValue.Denominator - this.Denominator * addValue.Numerator, this.Numerator * addValue.Denominator);
        }
        public Rational Carp(Rational addValue)
        {
            return new Rational(this.Numerator * addValue.Numerator, this.Denominator * addValue.Denominator);
        }
        public Rational Bol(Rational addValue)
        {
            return new Rational(this.Numerator * addValue.Denominator, this.Denominator * addValue.Numerator);
        }
        private void Sadelestir()
        {
            int kucukeleman;
            int ebob = 1;
            if (Numerator < Denominator)
                kucukeleman = Numerator;
            else
                kucukeleman = Denominator;
            for (int i = kucukeleman; i > 1; i--)
            {
                if (this.Numerator % i == 0 && this.Denominator % i == 0)
                {
                    ebob = i;
                    break;
                }
            }
            this.Numerator = this.Numerator / ebob;
            this.Denominator = this.Denominator / ebob;

                


        
        }
    }
}
