using static System.Console;
WriteLine("Enter a number to output a table cubes from 1 to: ");
int.TryParse(ReadLine(), out int n);
int i = 1;
while (i<= n)
{
    WriteLine($"cube numbers {i} = {Math.Pow(i, 3)}");
    i++;
}