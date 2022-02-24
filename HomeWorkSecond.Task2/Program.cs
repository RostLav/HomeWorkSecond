Console.WriteLine("Введите координату Х:");
int coordinateX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int coordinateY = Convert.ToInt32(Console.ReadLine());

if (coordinateX > 0 && coordinateY > 0)
{
    Console.WriteLine("Точка принадлежит I четверти");
}
else if (coordinateX < 0 && coordinateY > 0)
{
    Console.WriteLine("Точка принадлежит II четверти");
}
else if (coordinateX <0 && coordinateY < 0)
{
    Console.WriteLine("Точка принадлежит III четверти");
}
else
{
    Console.WriteLine("Точка принадлежит IV четверти");
}