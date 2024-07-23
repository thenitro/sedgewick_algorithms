using System.Collections.Generic;
using System.IO;
using System.Text;

namespace sedgewick_algorithms.Chapter_1.Topic_1_3_BagsQueuesAndStacks
{
    public class E_1_3_43_ListingFiles
    {
        public string Solution(string pathTo)
        {
            return SolutionHelper(pathTo, string.Empty);
        }

        private string SolutionHelper(string pathTo, string indent)
        {
            var result = new StringBuilder();
            var queue = new Queue<string>();
            
            foreach (var newEntry in Directory.EnumerateFileSystemEntries(pathTo))
            {
                queue.Enqueue(newEntry);
            }

            while (queue.Count > 0)
            {
                var currentEntry = queue.Dequeue();
                
                result.AppendLine(indent + " " + currentEntry);
                
                if (Directory.Exists(currentEntry))
                {
                    result.Append(SolutionHelper(currentEntry, indent + "-"));
                }
            }
            
            return result.ToString();
        }
    }
}