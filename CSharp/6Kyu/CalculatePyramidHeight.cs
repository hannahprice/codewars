using System.Collections.Generic;

public class Kata
{
    public static int PyramidHeight(int n)
    {
        var pyramid = new Stack<int>();

        var totalNumberOfCubesInPyramid = 1;
        pyramid.Push(1);

        while (totalNumberOfCubesInPyramid < n)
        {
            var nextLayer = pyramid.Count + 1;

            var numberOfCubesNeededForNextLayer = nextLayer * nextLayer;
            var totalNumberOfCubesNeeded =
                totalNumberOfCubesInPyramid + numberOfCubesNeededForNextLayer;

            if (totalNumberOfCubesNeeded <= n)
            {
                pyramid.Push (numberOfCubesNeededForNextLayer);
                totalNumberOfCubesInPyramid += numberOfCubesNeededForNextLayer;
            }
            else
            {
                break;
            }
        }

        return pyramid.Count;
    }
}
