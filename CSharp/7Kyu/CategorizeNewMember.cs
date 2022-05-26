using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        var output = new List<string>(data.Length);

        data
            .ToList()
            .ForEach(x =>
            {
                var age = x[0];
                var handicap = x[1];

                if (age >= 55 && handicap > 7)
                {
                    output.Add("Senior");
                }
                else
                {
                    output.Add("Open");
                }
            });

        return output;
    }
}
