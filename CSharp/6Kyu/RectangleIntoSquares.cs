using System.Collections.Generic;

public class SqInRect
{
    public static List<int> sqInRect(int lng, int wdth)
    {
        if (lng == wdth)
        {
            return null;
        }

        List<int> squareSizes = new List<int>();
        int area = lng * wdth;

        GetSquareSizes (area, lng, wdth, squareSizes);

        return squareSizes;
    }

    private static void GetSquareSizes(
        int area,
        int length,
        int width,
        List<int> squareSizes
    )
    {
        if (length == width)
        {
            squareSizes.Add (length);
            return;
        }

        if (length < width)
        {
            squareSizes.Add (length);

            var remainingArea = area - (length * length);
            var remainingWidth = width - length;
            var remainingLength = remainingArea / remainingWidth;

            if (remainingArea > 0)
            {
                GetSquareSizes (
                    remainingArea,
                    remainingLength,
                    remainingWidth,
                    squareSizes
                );
            }
        }
        else
        {
            squareSizes.Add (width);

            var remainingArea = area - (width * width);
            var remainingLength = length - width;
            var remainingWidth = remainingArea / remainingLength;

            if (remainingArea > 0)
            {
                GetSquareSizes (
                    remainingArea,
                    remainingLength,
                    remainingWidth,
                    squareSizes
                );
            }
        }
    }
}
