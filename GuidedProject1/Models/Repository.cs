namespace GuidedProject1.Models
{
    public static class Repository
    {
        // Kullanıcıları bellekte kaydedebilmek için
        private static List<Candidate> applications = new List<Candidate>();
        public static IEnumerable<Candidate> Applications => applications;

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}
