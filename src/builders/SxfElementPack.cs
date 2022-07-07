namespace sxfsharp.builders;

public class SxfElementPack
{
    public object Owner { get; } 
    public object Element { get; }
    public string _comment;

    public SxfElementPack(object _owner, Object _element)
    {
        Owner = _owner;
        Element = _element;
    }

    public SxfElementPack Comment(string comment)
    {
        _comment = comment;
        return this;
    }

    public string Comment()
    {
        return _comment; 
    }


    public object Down()
    {
        return Element;
    }
    
    public SxfBlockBuilder DownAsBlock()
    {
        return (SxfBlockBuilder) Element;
    }
    
    public SxfStructBuilder DownAsStruct()
    {
        return (SxfStructBuilder) Element;
    }

    public SxfBlockBuilder EndAsBlock()
    {
        return (SxfBlockBuilder) Owner;
    }

    public SxfStructBuilder EndAsStruct()
    {
        return (SxfStructBuilder) Owner;
    }


}