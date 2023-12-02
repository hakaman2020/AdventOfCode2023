using System.Diagnostics.CodeAnalysis;
using AoC.Input;

const int RedCubes = 12;
const int BlueCubes = 14;
const int GreenCubes = 13;
//  const string inputFile = "./example.txt";
const string inputFile = "./input.txt";

var lines = Input.ReturnLinesFromInput(inputFile);

Console.WriteLine($"Task1 : {Task1(lines)}");
Console.WriteLine($"Task2 : {Task2(lines)}");

int Task1(IEnumerable<string> lines){
    int sum = 0;

    foreach(var line in lines){
        
        var split = line.Split(':');
        int gamenumber = int.Parse(split[0].Split(' ')[1]);
        
        bool impossibleCombo = false;
        var combos = split[1].Split(';');
        foreach(var combo in combos){
            if(!PossibleCombo(combo)){
                impossibleCombo = true;
                break;
            }
        }
        if(!impossibleCombo){
            sum+= gamenumber;
        }
        
    }
    return sum;
}

int Task2(IEnumerable<string> lines){
   int sum = 0;

    foreach(var line in lines){
        
        var split = line.Split(':');
        
        sum += CalcPower(split[1]);
    }
    return sum;
}


Boolean PossibleCombo(string combo)
{
    int[] BlueGreenRed = [0,0,0];
    var split = combo.Split(new char[]{' ',','}, StringSplitOptions.RemoveEmptyEntries);
    for(int i = 0; i < split.Length; i += 2){
        string currentColor = split[i + 1];
        int amount = int.Parse(split[i]);
        if(currentColor.Equals("blue")){
            if(amount > BlueCubes)
                return false;
        } else if (currentColor.Equals("green")){
            if(amount > GreenCubes)
                return false;
        } else if (currentColor.Equals("red")){
            if(amount > RedCubes)
                return false;
        }
    }
    return true;
}

int CalcPower(string game){
    int[] MinBlueGreenRed = [0, 0, 0];
    var combos = game.Split(';');
    foreach(var combo in combos){
        var split = combo.Split(new char[]{' ',','}, StringSplitOptions.RemoveEmptyEntries);
        for(int i = 0; i < split.Length; i += 2){
            string currentColor = split[i + 1];
            int amount = int.Parse(split[i]);
            if(currentColor.Equals("blue")){
                MinBlueGreenRed[0] = amount > MinBlueGreenRed[0] ? amount : MinBlueGreenRed[0];
            } else if (currentColor.Equals("green")){
                MinBlueGreenRed[1] = amount > MinBlueGreenRed[1] ? amount : MinBlueGreenRed[1];
            } else if (currentColor.Equals("red")){
                MinBlueGreenRed[2] = amount > MinBlueGreenRed[2] ? amount : MinBlueGreenRed[2];
            }
        }
   }
   int sum = 1;
   foreach(int amount in MinBlueGreenRed){
    sum *=amount;
   }
   return sum;
}