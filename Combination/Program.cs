using Combination;

Console.WriteLine("Please enter n :");
var Inputn = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter k :");
var Inputk = int.Parse(Console.ReadLine());

var combination = new CombinationCalculator();
var result = combination.Calculate(Inputn, Inputk);

Console.WriteLine($" the rsult is  : {result}");