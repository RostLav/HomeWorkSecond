Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Сумма А и В = {numberA + numberB}");
}
if (numberA == numberB)
{
    Console.WriteLine($"Произведение А на В = {numberA*numberB}");
}
else if (numberA < numberB)
{
    Console.WriteLine($"Разница А и В = {numberA - numberB}");
}