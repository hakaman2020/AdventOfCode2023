using AoC.Input;

const string inputFile = "./example.txt";
// const string inputFile = "./input.txt";

var lines = Input.ReturnLinesFromInput(inputFile);

foreach(var line in lines){
    Console.WriteLine(line);
}

Console.WriteLine($"Task1 : {Task1()}");
Console.WriteLine($"Task2 : {Task2()}");

int Task1(){
    return -1;
}

int Task2(){
    return -1;
}
