using CDCDemo.Data;
using CDCDemo.Helpers;

namespace CDCDemo.UseCases;

public class UseCase1
{
    public static void RunCase()
    {
        Console.WriteLine("Testing business data changes...");
        foreach (var change in DataHelper.GetBusinessChanges())
        {
            TestCase(change);
        }

        Console.WriteLine("Testing technical data changes...");
        foreach (var change in DataHelper.GetTechnicalChanges())
        {
            TestCase(change);
        }
    }

    private static void TestCase(JobProfile jobProfile)
    {
        string json = JsonHelper.Serialize(jobProfile);
        string hash = HashHelper.GetHash(json);

        Console.WriteLine("json: {0}", json);
        Console.WriteLine("hash: {0}", hash);
    }
}
