namespace sedgewick_algorithms.Chapter_1.Topic_1_2_DataAbstraction
{
    public class E_1_2_6_CircularRotation
    {
        public bool IsCircularRotation(string strToCheck, string target)
        {
            if (strToCheck.Length != target.Length)
            {
                return false;
            }
            
            var fullString = strToCheck + strToCheck;
            return fullString.IndexOf(target) != -1;
        }
    }
}