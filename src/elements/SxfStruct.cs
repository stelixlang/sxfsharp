namespace sxfsharp.reads;

public class SxfStruct : ISxfElement
{
    public List<Object> Elements { get; protected set; } = new List<object>();
}