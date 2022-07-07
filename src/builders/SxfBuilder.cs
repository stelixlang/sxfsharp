using System.Text;

namespace sxfsharp.builders;

public abstract class SxfBuilder
{
    public SxfBuilder Owner { get; set; } /* should be protected */
    public WriteStyle WriteStyle = WriteStyle.NORMAL;
    public abstract void Write(int spaceCount, ref StringBuilder builder);
}