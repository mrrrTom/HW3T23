// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Welcome to the coube table builder application! \nPlease, insert max integer:");
var input = Console.ReadLine();
var max = default(int);
if (!int.TryParse(input, out max) || max < 1)
{
    Console.WriteLine("Sorry, program could not handle inserted value... Bye!");
}

var result = string.Empty;
for (var i = 1; i <= max; i++)
{
    result += Math.Pow(i, 3);
    if (i != max)
    {
        result += ", ";
    }
}

Console.WriteLine(result);