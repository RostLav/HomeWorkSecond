Console.WriteLine("Введите двухзначное число: ");
int twoDigitNumber = Convert.ToInt32(Console.ReadLine());
int ten = twoDigitNumber / 10;
int sumpleNumber = twoDigitNumber % 10;
string firstNumberInString="";
string secondNumberInString="";

if (twoDigitNumber<10 && twoDigitNumber > 99) 
{
    Console.WriteLine("Вы ввели не двухзначное число");
}

if (twoDigitNumber == 10)
{
    Console.WriteLine("Десять");
}
else if (twoDigitNumber == 11)
{
    Console.WriteLine("Одиннадцать");
}
else if (twoDigitNumber == 12)
{
    Console.WriteLine("Двеннадцать");
}
else if (twoDigitNumber == 13)
{
    Console.WriteLine("Триннадцать");
}
else if (twoDigitNumber == 14)
{
    Console.WriteLine("Четырнадцать");
}
else if (twoDigitNumber == 15)
{
    Console.WriteLine("Пятнадцать");
}
else if (twoDigitNumber == 16)
{
    Console.WriteLine("Шестнадцать");
}
else if (twoDigitNumber == 17)
{
    Console.WriteLine("Семнадцать");
}
else if (twoDigitNumber == 18)
{
    Console.WriteLine("Восемнадцать");
}
else if (twoDigitNumber == 19)
{
    Console.WriteLine("Девятнадцать");
}

if (twoDigitNumber > 19)
{
    
if (ten == 2)
{
    firstNumberInString = "Двадцать";
}
else if (ten == 3)
{
    firstNumberInString = "Тридцать";
}
else if (ten == 4)
{
    firstNumberInString = "Сорок";
}
else if (ten == 5)
{
    firstNumberInString = "Пятьдесят";
}
else if (ten == 6)
{
    firstNumberInString = "Шестьдесят";
}
else if (ten == 7)
{
    firstNumberInString = "Семдесят";
}
else if (ten == 8)
{
    firstNumberInString = "Восемдесят";
}
else if (ten == 9)
{
    firstNumberInString = "Девяносто";
}

switch (sumpleNumber)
{
    case 0:
        secondNumberInString = "";
        break;
    case 1:
        secondNumberInString = "Один";
        break;
    case 2:
        secondNumberInString = "Два";
        break;
    case 3:
        secondNumberInString = "Три";
        break;
    case 4:
        secondNumberInString = "Четыре";
        break;
    case 5:
        secondNumberInString = "Пять";
        break;
    case 6:
        secondNumberInString = "Шесть";
        break;
    case 7:
        secondNumberInString = "Семь";
        break;
    case 8:
        secondNumberInString = "Восемь";
        break;
    case 9:
        secondNumberInString = "Девять";
        break;
}

Console.WriteLine($"Вы ввели число {firstNumberInString} {secondNumberInString}");
}
