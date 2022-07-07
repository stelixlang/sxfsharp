namespace sxfsharp.builders;

public class SxfVariable
{
    public string Alias { get; private set; }
    public object Value { get; set; }

    public SxfVariable(string alias, object value)
    {
        Alias = alias;
        Value = value;
    }
    
}