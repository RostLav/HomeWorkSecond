Console.WriteLine("Введите коэффициент А");
double coefficientA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент В");
double coefficientB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент С");
double coefficientC = Convert.ToInt32(Console.ReadLine());
double discriminant = Math.Pow(coefficientB, 2) - 4 * coefficientA * coefficientC;
if (discriminant > 0)
{
    Console.WriteLine($"x1={((double)-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA)}");
    Console.WriteLine($"x2={(-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA)}");
}
else if (discriminant == 0)
{
    Console.WriteLine($"x={(double)-coefficientB / (2 * coefficientA)}");
}
else
{
    Console.WriteLine("Корней не может быть");
}