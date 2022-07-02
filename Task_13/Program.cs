Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int threeNumber = 0;
if(number<100)
{
    Console.WriteLine("Третьей цифры нет");
}

else //if(number>99 && number<1000)
{
    while (number>999)
    {
        number=number/10;
    }
threeNumber = number%10;
Console.WriteLine(threeNumber);
}

