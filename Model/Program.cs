using System;
using System.Collections.Generic;

namespace Model
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<Tuple<int, int>>();
            list.Add(new Tuple<int, int>(7, 8));
            list.Add(new Tuple<int, int>(4, 4));
            list.Add(new Tuple<int, int>(2, 1));
            list.Add(new Tuple<int, int>(5, 7));
            list.Add(new Tuple<int, int>(2, 3));
            list.Add(new Tuple<int, int>(6, 5));
            list.Add(new Tuple<int, int>(5, 4));
            var schedule = ScheduleCreator.FromListOfTuples(list);
        }
    }
}