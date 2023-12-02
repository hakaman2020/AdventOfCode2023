namespace AoC.Input;

public static class Input{

    public static IEnumerable<string> ReturnLinesFromInput(string inputFile)
    {
        IEnumerable<string> lines = File.ReadLines(inputFile);
        return lines;
    }
}