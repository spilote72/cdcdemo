using Newtonsoft.Json;

namespace CDCDemo.Data;

public class JobProfile : WorkdayEntity
{
    [JsonIgnore]
    public int ID { get; set; }
    public string Job_Profile_ID { get; set; }
    public string Job_Title { get; set; }
    public string Compensation_Grade_ID { get; set; }
    public bool Inactive { get; set; }

    public JobProfile()
    {
        ID = 100;
        Job_Profile_ID = "P45007810A";
        Job_Title = "Conseiller principal - Gestion du risque";
        Compensation_Grade_ID = "NV-10";
        Inactive = false;
        Sync_ID = Guid.Parse("6ea73b60-861b-4872-b6a7-ed899e4d7b34");
        Language = 0;
        Action = 1;
        As_Of_Entry_DateTime = new DateTime(2023, 2, 22, 17, 0, 0);
    }
}
