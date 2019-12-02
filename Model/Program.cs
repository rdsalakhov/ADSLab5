using System.Collections.Generic;

namespace Model
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<Job>();
            list.Add(new Job(6, 5));
            list.Add(new Job(4, 2));
            list.Add(new Job(6, 3));
            list.Add(new Job(5, 6));
            list.Add(new Job(7, 6));
            list.Add(new Job(1, 1));
            list.Add(new Job(4, 7));
            
            list.Sort(new JobComparer());
        }
    }
}