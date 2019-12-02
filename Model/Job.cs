namespace Model
{
    public class Job
    {
        private static char namer = 'A';
        
        public int FirstStage { get; set; }
        
        public int SecondStage { get; set; }
        
        public string Name { get; }

        public Job(int fStage, int secStage)
        {
            FirstStage = fStage;
            SecondStage = secStage;
            Name = namer.ToString();
            if (namer == 'Z')
            {
                namer = 'A';
            }
            else
            {
                namer++;
            }
        }

        static void ResetNames()
        {
            namer = 'A';
        }

        public override string ToString()
        {
            return Name;
        }
    }
}