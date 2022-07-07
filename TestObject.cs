using sxfsharp.reads;

namespace sxfsharp;

public class TestObject
{
    [SxfField("test_value")]
    public int test = 5;
        
    [SxfField("test_double")]
    public double ez = 12;

    public int daad = 5;
    
    [SxfField("test_string")]
    public String helloWorld = "Hello World";

    [SxfField("other")] public TestObject testObject;

    [SxfField("test_array")] public int[] array = new int[] {2173, 72, 7772, 5556};

    [SxfField("elements")] public List<ConfigTest> configs = new List<ConfigTest>()
    {
        new ConfigTest(),
        new ConfigTest(),
        new ConfigTest(),
        new ConfigTest(),
        new ConfigTest(),
        new ConfigTest(),
        new ConfigTest(),
        new ConfigTest(),
        new ConfigTest(),
        new ConfigTest()
    };
}