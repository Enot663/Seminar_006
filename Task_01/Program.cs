// Напишите программу которая на вход принимает три числа
// и проверяет существует ли треугольник со сторонами такой длинны.

Console.Clear();

Console.Write("Введите первое число x=  ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите второе число y=  ");
int y = int.Parse(Console.ReadLine());

Console.Write("Введите третье число z=  ");
int z = int.Parse(Console.ReadLine());

if(x + y < z || x + z < y || z + y < x)
{
    Console.Write("Соответствует треугольнику!!");
}
else
{
    Console.Write("Не треугольник!!");
}
