# WeightGoalChecker
A simple C# console application that asks for the user's current weight and goal weight to calculate weight to lose.

## How to run
Open the project in Visual Studio than build and run.

## Code example
```Csharp
Console.Write("Write your current weight: " );
double currentweight = double.Parse(Console.ReadLine());

Console.Write("Write your goal weight: ");
double goalweight = double.Parse(Console.ReadLine());

double FinalMark = (currentweight) - (goalweight);
Console.WriteLine($"Weight to lose {FinalMark}Kgs");
```
