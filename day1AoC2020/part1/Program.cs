using AoC.Input;

// const string inputFile = "./example.txt";
const string inputFile = "./input.txt";

var lines = Input.ReturnLinesFromInput(inputFile);

List<int> numbers = new List<int>();
foreach(var line in lines){
    numbers.Add(Int32.Parse(line));
}

Console.WriteLine($" Task 1 :{Task1(numbers)}");
Console.WriteLine($" Task 2 :{Task2(numbers)}");

return 0;

int Task1(List<int> numbers){
    for(int i = 0; i < numbers.Count - 1; i++){
        for(int j = i + 1; j < numbers.Count; j++){
            if(numbers[i] + numbers[j] == 2020){
                return(numbers[i] * numbers[j]);
            }
        }
    }
    return -1;    
}

int Task2(List<int> numbers){
    for(int i = 0; i < numbers.Count - 2; i++){
        for(int j = i + 1; j < numbers.Count - 1; j++){
            for(int k = j + 1 ; k < numbers.Count; k++){
                if(numbers[i] + numbers[j] + numbers[k] == 2020){
                    return (numbers[i] * numbers[j] * numbers[k]);
                }
            }
        }
    }
    return -1;
}