Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int oneDigit = number/10;
int secondDigit = oneDigit%10;
Console.WriteLine($"Вторая цифра числа - {secondDigit}");