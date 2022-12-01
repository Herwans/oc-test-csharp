using OcTestCSharp.Core.Service.Dice;

namespace OcTestCSharp.Test.Core.Stubs;

public class Dice : IDice
{
    private readonly int[] rollsList;

    private int counter;

    public Dice()
    {
        rollsList = new[] { 4, 5, 1, 1, 4, 3, 5, 6, 6, 6, 1, 2, 4, 2, 3, 2, 6, 4, 5, 1, 1, 4, 3, 5, 6, 6, 6, 1, 2, 4, 2, 3, 2, 6 };
        counter = 0;
    }

    public int Roll()
    {
        return rollsList[counter++];
    }
}