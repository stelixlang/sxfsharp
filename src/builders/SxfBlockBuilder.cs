using System.Text;

namespace sxfsharp.builders;

public class SxfBlockBuilder : SxfBuilder
{

    private List<object> elements;
    private bool SpaceAfter;

    protected SxfBlockBuilder()
    {
        elements = new List<object>(); 
    }

    public static SxfBlockBuilder Create()
    {
        return new SxfBlockBuilder();
    }

    public SxfElementPack Add(string alias, object variable)
    {
        SxfElementPack pack = new SxfElementPack(this, variable);
        elements.Add(new SxfVariable(alias, pack));
        return pack;
    }

    public SxfElementPack Add(object variable)
    {
        SxfElementPack pack = new SxfElementPack(this, variable);
        elements.Add(pack);
        return pack;
    }




    public override void Write(int spaceCount, ref StringBuilder builder)
    {
        int index = 0;
        builder.Append("{");
        spaceCount++;

        bool lastWasBlock = false;
        if (HasNext(elements, index))
        {
            bool hasNext;
            do
            {
                Object element = Next(elements, ref index);
                hasNext = HasNext(elements, index);
                if (WriteStyle == WriteStyle.NORMAL)
                {
                    if (SpaceAfter && lastWasBlock)
                    {
                        builder.Append(Environment.NewLine);
                    }

                    builder.Append(Environment.NewLine);
                    Commons.PutSpace(builder, spaceCount);
                }
                else
                {
                    builder.Append(" ");
                }


                if (element is SxfVariable) {
                    SxfVariable variable = (SxfVariable) element;
                    SxfElementPack sxfPack = (SxfElementPack) variable.Value;
                    Object value = sxfPack.Down();

                    if (value is SxfBuilder) {
                        if (value is SxfBlockBuilder) {
                            if (WriteStyle == WriteStyle.NORMAL)
                            {
                                lastWasBlock = true;
                                if (!String.IsNullOrEmpty(sxfPack.Comment()))
                                {
                                    builder.Append("$; ").Append(sxfPack.Comment()).Append(" ;$")
                                        .Append(Environment.NewLine);
                                    Commons.PutSpace(builder, spaceCount);
                                }
                            }

                            builder.Append(Commons.ClearName(variable.Alias)).Append(" => ");
                            ((SxfBlockBuilder) value).Write(spaceCount, ref builder);
                        } else if (value is SxfStructBuilder) {
                            if (WriteStyle == WriteStyle.NORMAL)
                            {
                                if (!String.IsNullOrEmpty(sxfPack.Comment()))
                                {
                                    builder.Append("$; ").Append(sxfPack.Comment()).Append(" ;$")
                                        .Append(Environment.NewLine);
                                    Commons.PutSpace(builder, spaceCount);
                                }
                            }
                            
                            builder.Append(Commons.ClearName(variable.Alias)).Append(": ");
                            ((SxfStructBuilder) value).Write(spaceCount, ref builder);
                        }

                    } else {
                        builder.Append(Commons.ClearName(variable.Alias)).Append(": ");
                        builder.Append(Commons.WriteVar(value));
                        if (!String.IsNullOrEmpty(sxfPack.Comment()))
                        {
                            builder.Append(" $; ").Append(sxfPack.Comment()).Append(" ;$");
                        }

                    }

                } else {
                    SxfElementPack elementPack = (SxfElementPack) element;
                    SxfBuilder sxfElement = (SxfBuilder) elementPack.Down();

                    if (!String.IsNullOrEmpty(elementPack.Comment()) && WriteStyle == WriteStyle.NORMAL)
                    {
                        builder.Append("$; ").Append(elementPack.Comment()).Append(" ;$");
                        builder.Append(Environment.NewLine);
                        Commons.PutSpace(builder, spaceCount);
                    }

                    if (sxfElement is SxfBlockBuilder) {
                        SxfBlockBuilder downBlock = (SxfBlockBuilder) sxfElement;
                        downBlock.Write(spaceCount, ref builder);
                    }

                    if (sxfElement is SxfStructBuilder)
                    {
                        SxfStructBuilder downBlock = (SxfStructBuilder) sxfElement;
                        downBlock.Write(spaceCount, ref builder);
                    }

                }

                if (hasNext)
                {
                    if (WriteStyle == WriteStyle.INLINE)
                    {
                        builder.Append(", ");
                    }
                    else
                    {
                        builder.Append(",");
                    }
                }

            } while (hasNext);

            if (WriteStyle == WriteStyle.NORMAL)
            {
                builder.Append(Environment.NewLine);
                Commons.PutSpace(builder, spaceCount - 1);
            }
            else
            {
                builder.Append(" ");
            }

            builder.Append("}");

        }
    }

    private static bool HasNext(List<object> list, int index)
    {
        return index < list.Count;
    }

    private static object Next(List<object> list, ref int index)
    {
        return list[index++];
    }
    
    
    public override string ToString() {
        StringBuilder builder = new StringBuilder();
        Write(0, ref builder);
        return builder.ToString();
    }
}