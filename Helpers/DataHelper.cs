using CDCDemo.Data;

namespace CDCDemo.Helpers
{
    public class DataHelper
    {
        public static IReadOnlyList<JobProfile> GetTechnicalChanges()
        {
            return new List<JobProfile> 
            {
                new JobProfile 
                {
                    Sync_ID = Guid.Parse("6ea73b60-861b-4872-b6a7-ed899e4d7b34")
                },
                new JobProfile 
                {
                    Sync_ID = Guid.Parse("6ea73b60-861b-4872-b6a7-ed899e4d7b35") // <--- change
                },
                new JobProfile 
                {
                    Sync_ID = Guid.Parse("6ea73b60-861b-4872-b6a7-ed899e4d7b36") // <--- change
                }
            };
        }

        public static IReadOnlyList<JobProfile> GetBusinessChanges()
        {
            return new List<JobProfile> 
            {
                new JobProfile 
                {
                    Job_Profile_ID = "P45007810A" // <--- initial
                },
                new JobProfile 
                {
                    Job_Profile_ID = "P45007810B"  // <--- change
                },
                new JobProfile 
                {
                    Job_Profile_ID = "P45007810A"// <--- back to initial
                }
            };
        }
    }
}
