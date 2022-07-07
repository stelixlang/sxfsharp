using System.Text;

namespace sxfsharp.builders;

public class SxfStructBuilder : SxfBuilder
{

    public List<SxfElementPack> Elements { get; set; } = new List<SxfElementPack>();

    protected SxfStructBuilder(SxfBuilder? owner)
    {
        WriteStyle = owner == null ? WriteStyle.NORMAL : Owner.WriteStyle;
       
    }

    public static SxfStructBuilder Create(SxfBuilder? owner)
    {
        return new SxfStructBuilder(owner);
    }

    public static SxfStructBuilder Create()
    {
        return Create(null);
    }

    public SxfElementPack Add(object element)
    {
        SxfElementPack pack = new SxfElementPack(this, element);
        Elements.Add(pack);
        return pack;
    }

    public override void Write(int spaceCount, ref StringBuilder builder)
    {
        int index = 0;
        builder.Append("[");
        bool hasNext;
        if (HasNext(Elements, index)) {
            do
            {
                SxfElementPack pack = Next(Elements, ref index);
                hasNext = HasNext(Elements, index);
                Object element = pack.Down();

                if (element is SxfBuilder) {
                    if (WriteStyle == WriteStyle.NORMAL) {
                        if (!String.IsNullOrEmpty(pack.Comment())) {
                            builder.Append(Environment.NewLine);
                            Commons.PutSpace(builder, spaceCount + 1);
                            builder.Append("$;").Append(pack.Comment()).Append(" ;$");
                        }
                        builder.Append(Environment.NewLine);
                        Commons.PutSpace(builder, spaceCount + 1);
                    } else {
                        builder.Append(" ");
                    }
                    if (element is SxfStructBuilder) {
                        ((SxfStructBuilder) element).Write(spaceCount + 1, ref builder);
                    } else if (element is SxfBlockBuilder) {
                        ((SxfBlockBuilder) element).Write(spaceCount + 1, ref builder);
                    }

                } else {
                    if (WriteStyle == WriteStyle.NORMAL) {
                        builder.Append(Environment.NewLine);
                        Commons.PutSpace(builder, spaceCount + 1);
                    } else {
                        builder.Append(" ");
                    }
                    builder.Append(Commons.WriteVar(element));
                    if (WriteStyle == WriteStyle.NORMAL) {
                        if (!String.IsNullOrEmpty(pack.Comment())) {
                            builder.Append(" $; ").Append(pack.Comment()).Append(" ;$");
                        }
                    }
                }
                if (hasNext) {
                    if (WriteStyle == WriteStyle.NORMAL) {
                        builder.Append(", ");
                    } else {
                        builder.Append(", ");
                    }
                }



            } while (hasNext);
        }
        if (WriteStyle == WriteStyle.NORMAL) {
            builder.Append(Environment.NewLine);
            Commons.PutSpace(builder, spaceCount);
        } else {
            builder.Append(" ");
        }

        builder.Append("]");
    }
    
    private static bool HasNext(List<SxfElementPack> list, int index)
    {
        return index < list.Count;
    }

    private static SxfElementPack Next(List<SxfElementPack> list, ref int index)
    {
        return list[index++];
    }
}