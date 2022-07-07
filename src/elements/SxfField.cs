namespace sxfsharp.reads;

public class SxfField : Attribute
{
    public string Alias { get; private set; }

    public SxfField(string alias)
    {
        Alias = alias;
    }

    public SxfField() : this(string.Empty) { }
}