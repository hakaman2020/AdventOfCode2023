using System.Diagnostics.CodeAnalysis;
using AoC.Input;

//const string inputFile = "./example.txt";
const string inputFile = "./input.txt";
//const string inputFile ="./example2.txt";
var lines = Input.ReturnLinesFromInput(inputFile);





Console.WriteLine($"Task1 : {Task1(lines)}");
Console.WriteLine($"Task2 : {Task2(lines)}");

int Task1(IEnumerable<string> lines){
    List<int> numbers = new();
    char[] chars = { '1', '2', '3', '4', '5', '6', 
                       '7', '8', '9', '0'};
    foreach(string line in lines){
        string number= "";
        int index = 0;
        bool first = true;
        char prevchar =' ';
        while(index != -1){
            
            index = line.IndexOfAny(chars, index);
            if (index != -1)
            {
                prevchar = line[index];
                if (first){
                    number += line[index];
                    first = false;
                }
                index++;
            }
            else{
                number += prevchar;
                numbers.Add(int.Parse(number));
            }
        }
    }
    int sum = 0;
    foreach (var num in numbers){
        sum += num;
    }
    return sum;
}

int Task2(IEnumerable<string> lines){
    List<int> numbers = new();
    string[] numberlist = {"0","1","2","3","4","5","6","7","8","9",
                            "one","two","three","four","five","six","seven","eight","nine"};
    
    foreach(string line in lines){
        string number= "";
        
        int index = int.MaxValue;
        foreach (string num in numberlist){
            int temp = line.IndexOf(num);
            if (temp == -1)
                continue;
            if (temp < index){
                index = temp;
            }
        }

        if(line[index] == 'o')
            number += "1";
        else if(line[index] == 't' && line[index+1] =='w')
            number += "2";
        else if (line[index] =='t' && line[index + 1] == 'h')
            number +="3";
        else if (line[index] == 'f' && line[index + 1] == 'o')
            number +="4";
        else if (line[index] == 'f' && line[index + 1] == 'i')
            number += "5";
        else if (line[index] =='s' && line[index +1] == 'i')
            number +="6";
        else if (line[index] == 's' && line[index + 1] =='e')
            number +="7";
        else if (line[index] == 'e')
            number +="8";
        else if (line[index] == 'n')
            number +="9";
        else
            number += line[index];

        index = 0;
        foreach (string num in numberlist){
            int temp = line.LastIndexOf(num);
            if (temp > index){
                index = temp;
            }
        }
        
        if(line[index] == 'o')
            number += "1";
        else if(line[index] == 't' && line[index+1] =='w')
            number += "2";
        else if (line[index] =='t' && line[index + 1] == 'h')
            number +="3";
        else if (line[index] == 'f' && line[index + 1] == 'o')
            number +="4";
        else if (line[index] == 'f' && line[index + 1] == 'i')
            number += "5";
        else if (line[index] =='s' && line[index +1] == 'i')
            number +="6";
        else if (line[index] == 's' && line[index + 1] =='e')
            number +="7";
        else if (line[index] == 'e')
            number +="8";
        else if (line[index] == 'n')
            number +="9";
        else
            number += line[index];




        numbers.Add(int.Parse(number));
    }
    int sum = 0;
    foreach (var num in numbers){
        sum += num;
    }
    return sum;
}
