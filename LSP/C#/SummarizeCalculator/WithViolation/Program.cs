using WithViolation;

var numbers = new int[] { 5, 7, 9, 8, 1, 6, 4 };

SumCalculator sum = new SumCalculator(numbers);
Console.WriteLine($"The sum of all the numbers: {sum.Calculate()}");

Console.WriteLine();

EvenNumbersSumCalculator evenSum = new EvenNumbersSumCalculator(numbers);
Console.WriteLine($"The sum of all the even numbers: {evenSum.Calculate()}");