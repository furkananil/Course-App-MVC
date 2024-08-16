namespace CourseApp.Models
{
    public static class Repository
    {
        private static List<Candidate> apps = new();
        public static IEnumerable<Candidate> Apps => apps;
        
        public static void Add(Candidate candidate)
        {
            apps.Add(candidate);
        }
    }
}