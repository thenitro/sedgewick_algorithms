namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public struct Rational
    {
        private int Numerator { get; set; }
        private int Denominator { get; set; }

        public Rational(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Rational operator +(Rational a) => a;
        public static Rational operator -(Rational a) => new Rational(-a.Numerator, -a.Denominator);
        public static Rational operator /(Rational a, int x) => new Rational(a.Numerator / x, a.Denominator / x);

        public static Rational operator +(Rational a, Rational b)
        {
            if (a.Denominator != b.Denominator)
            {
                var temp = a;
                a = new Rational(a.Numerator * b.Denominator, a.Denominator * b.Denominator);
                b = new Rational(b.Numerator * temp.Denominator, b.Denominator * temp.Denominator);
            }

            var subResult = new Rational(a.Numerator + b.Numerator, a.Denominator);
            var gcd = Gdc(subResult.Numerator, subResult.Denominator);

            subResult /= gcd;

            if (subResult.Numerator == 0 || subResult.Denominator == 0)
            {
                return new Rational(0, 0);
            }
            
            return subResult;
        }
        
        public static Rational operator -(Rational a, Rational b)
        {
            if (a.Denominator != b.Denominator)
            {
                var temp = a;
                a = new Rational(a.Numerator * b.Denominator, a.Denominator * b.Denominator);
                b = new Rational(b.Numerator * temp.Denominator, b.Denominator * temp.Denominator);
            }

            var subResult = new Rational(a.Numerator - b.Numerator, a.Denominator);
            var gcd = Gdc(subResult.Numerator, subResult.Denominator);

            subResult /= gcd;

            if (subResult.Numerator == 0 || subResult.Denominator == 0)
            {
                return new Rational(0, 0);
            }
            
            return subResult;
        }

        public static Rational operator *(Rational a, Rational b)
        {
            var subResult = new Rational(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
            var gcd = Gdc(subResult.Numerator, subResult.Denominator);

            return subResult / gcd;
        }
        
        public static Rational operator /(Rational a, Rational b)
        {
            var subResult = new Rational(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
            var gcd = Gdc(subResult.Numerator, subResult.Denominator);

            return subResult / gcd;
        }

        public static int Gdc(int p, int q)
        {
            if (q == 0) return p;
            var r = p % q;
            return Gdc(q, r);
        }

        public override bool Equals(object other)
        {
            var otherRational = (Rational)other;

            return Numerator == otherRational.Numerator &&
                   Denominator == otherRational.Denominator;
        }

        public override string ToString()
        {
            return $"[ Rational num={Numerator}, den={Denominator} ]";
        }
    }
}