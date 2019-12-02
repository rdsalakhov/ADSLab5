using System;
using System.Collections.Generic;

namespace Model
{
    public static class ScheduleCreator
    {
        private static List<TimeMark> ScheduleFirstStage(List<Job> jobList)
        {
            var firstStageSchedule = new List<TimeMark>();
            int currentTime = 0;
            for (int i = 0; i < jobList.Count; i++)
            {
                currentTime += jobList[i].FirstStage;
                firstStageSchedule.Add(new TimeMark(jobList[i].Name, currentTime));
            }

            return firstStageSchedule;
        }

        private static List<TimeMark> ScheduleSecondStage(List<Job> jobList, List<TimeMark> firstStageSchedule)
        {
            var secondStageSchedule = new List<TimeMark>();
            secondStageSchedule.Add(new TimeMark("Chill time", jobList[0].FirstStage));
            int currentTime = jobList[0].FirstStage + jobList[0].SecondStage;
            secondStageSchedule.Add(new TimeMark(jobList[0].Name, currentTime));
            
            for (int i = 1; i < jobList.Count; i++)
            {
                bool ready = true;
                for (int j = 0; j <= i; j++)
                {
                    if (firstStageSchedule[j].FinishTime > currentTime)
                    {
                        ready = false;
                        currentTime = firstStageSchedule[j].FinishTime;
                        secondStageSchedule.Add(new TimeMark("Chill time", currentTime));
                        i--;
                        break;
                    }
                }
                if (ready)
                {
                    currentTime += jobList[i].SecondStage;
                    secondStageSchedule.Add(new TimeMark(jobList[i].Name, currentTime));
                }
            }

            return secondStageSchedule;
        }
        
        private static Tuple<List<TimeMark>, List<TimeMark>> FromJobList(List<Job> jobList)
        {
            var firstStageSchedule = ScheduleFirstStage(jobList);
            var secondStageSchedule = ScheduleSecondStage(jobList, firstStageSchedule);

            return new Tuple<List<TimeMark>, List<TimeMark>>(firstStageSchedule, secondStageSchedule);
        }

        private static List<Job> FromTuplesToJobList(List<Tuple<int, int>> jobLengths)
        {
            Job.ResetNames();
            var jobList = new List<Job>();
            foreach (var tuple in jobLengths)
            {
                jobList.Add(new Job(tuple.Item1, tuple.Item2));
            }

            jobList.Sort(new JobComparer());
            return jobList;
        }
        
        public static Tuple<List<TimeMark>, List<TimeMark>> FromListOfTuples(List<Tuple<int, int>> jobLengths)
        {
            var jobList = FromTuplesToJobList(jobLengths);

            var schedule = FromJobList(jobList);

            return schedule;
        }
    }
}