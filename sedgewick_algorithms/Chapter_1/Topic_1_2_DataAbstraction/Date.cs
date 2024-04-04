namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class Date
    {
        public int Month { get; }
        public int Day { get; }
        public int Year { get; }

        public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Month}/{Day}/{Year}";
        }

        public override bool Equals(object other)
        {
            if (this == other) return true;
            if (other == null) return false;
            if (GetType() != other.GetType()) return false;

            var otherDate = other as Date;
            if (otherDate == null) return false;
            
            if (Day != otherDate.Day) return false;
            if (Month != otherDate.Month) return false;
            if (Year != otherDate.Year) return false;
            
            return true;
        }
    }
}