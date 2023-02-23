using Newtonsoft.Json;

namespace CDCDemo.Data;

public class WorkdayEntity
{
    [JsonIgnore]
    public Guid Sync_ID { get; set; }
    [JsonIgnore]
    public int Language { get; set; }
    [JsonIgnore]
    public int Action { get; set; }
    [JsonIgnore]
    public DateTime As_Of_Entry_DateTime { get; set; }
}
