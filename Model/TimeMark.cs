namespace Model
{
    public class TimeMark
    {
        public int FinishTime { get; set; }
        public string FinishedJob { get; set; }

        public TimeMark(string jobName, int time)
        {
            FinishedJob = jobName;
            FinishTime = time;
        }

        public override string ToString()
        {
            return $"{FinishedJob}: {FinishTime}";
        }
    }
}