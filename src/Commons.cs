using System.Text;
using System.Text.RegularExpressions;

namespace sxfsharp;

public class Commons
{
    public static void PutSpace(StringBuilder stringBuilder, int count) {
        for (int i = 0; i < Math.Max(0, count * 4); i++) {
            stringBuilder.Append(" ");
        }
    }

    private static string[] notSupportedNames = { "false", "true", "null" };
    private static Regex validIdentifierPattern = new Regex("[^A-Za-z0-9]");

    public static String? WriteVar(Object? obj) {
        if (obj is string) {
            return "\"" + obj + "\"";
        }
        if (obj == null) return "null";
        return obj.ToString();
    }

    public static String RemoveQuotes(string data) {
        if (data.Contains("\"")) {
            return data.Replace("\"", "");
        }
        return data;
    }

    public static String ClearName(String name) {
        if (validIdentifierPattern.IsMatch(name)) {
            return "\"" + name + "\"";
        }

        foreach (string check in notSupportedNames) {
            if (name.ToLower().Equals(check)) {
                return "\"" + name + "\"";
            }
        }

        return name;
    }
}