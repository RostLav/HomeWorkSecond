Console.WriteLine("Введите число А:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C:");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA>numberB && numberB > numberC)
{
    Console.WriteLine("A B C");
}
else if (numberA>numberB && numberA>numberC && numberB < numberC)
{
    Console.WriteLine("A C B");
}
else if (numberA<numberB && numberA > numberC)
{
    Console.WriteLine("B A C");
}
else if (numberB>numberA &&numberB>numberC && numberA < numberC)
{
    Console.WriteLine("B C A");
}
else if (numberC>numberA && numberA > numberB)
{
    Console.WriteLine("C A B");
}
else if (numberC>numberB && numberB > numberA)
{
    Console.WriteLine("C B A");
}