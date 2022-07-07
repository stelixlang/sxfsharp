using sxfsharp.reads;

namespace sxfsharp;

public class ConfigTest
{
    [SxfField("id")]
    public int Id;
    [SxfField("name")]
    public String Name;

    public ConfigTest()
    {
        Id = new Random().Next(5000);
        Name = "test" + new Random().Next();
    }
}