Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=1 && number<=5)
{
    Console.WriteLine("День недели не является выходным");
}
if (number>=6 && number<=7)
{
    Console.WriteLine("День недели является выходным");
}