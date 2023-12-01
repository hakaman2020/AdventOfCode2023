using AoC.Input;

const string inputFile = "./example.txt";
// const string inputFile = "./input.txt";

var lines = Input.ReturnLinesFromInput(inputFile);

foreach(var line in lines){
    Console.WriteLine(line);
}

Console.WriteLine($"Task1 : {Task1(lines)}");
Console.WriteLine($"Task2 : {Task2(lines)}");

int Task1(IEnumerable<string> lines){
    return -1;
}

int Task2(IEnumerable<string> lines){
    return -1;
}
