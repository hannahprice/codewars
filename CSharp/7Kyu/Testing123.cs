using System.Collections.Generic;

public class LineNumbering
{
    public static List<string> Number(List<string> lines)
    {
        for (int i = 0; i < lines.Count; i++)
        {
            var lineNumber = i + 1;
            lines[i] = $"{lineNumber}: {lines[i]}";
        }

        return lines;
    }
}
