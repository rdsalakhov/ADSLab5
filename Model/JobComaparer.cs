using System;
using System.Collections.Generic;

namespace Model
{
    public class JobComparer : IComparer<Job>
    {
        public int Compare(Job x, Job y)
        {
            if (x.FirstStage == x.SecondStage)
                return -1;
            return Math.Min(x.FirstStage, y.SecondStage).CompareTo(Math.Min(x.SecondStage, y.FirstStage));
        }
    }
}