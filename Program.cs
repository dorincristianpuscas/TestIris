using TestIris;

var balancedBracketInput = "{[(]}";
Console.WriteLine(BalancedBracketsProblem.Solve(balancedBracketInput));

var singleNumberInput = new int[] { 4, 2, 2, 5, 5 };
Console.WriteLine(SingleNumberProblem.SolveWithInputValidations(singleNumberInput));
Console.WriteLine(SingleNumberProblem.SolveWithoutInputValidations(singleNumberInput));

Console.ReadKey();