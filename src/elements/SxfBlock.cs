namespace sxfsharp.reads;

public class SxfBlock : ISxfElement
{
    public List<ISxfElement> UnmanagedElements { get; protected set; } = new List<ISxfElement>();
    public Dictionary<string, Object> Variables { get; protected set; } = new Dictionary<string, object>();
}