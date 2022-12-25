using static System.Console;
WriteLine("Enter a five-digit number: ");
int.TryParse(ReadLine(), out int num);
WriteLine(num % 10 == num / 10000 && (num % 100) / 10 == (num / 1000) % 10? "This number is palindrome." : "This number is not palindrome.");
