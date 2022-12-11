// Напишите программу которая на вход принимает три числа
// и проверяет существует ли треугольник со сторонами такой длинны.

Console.Clear();

int EnterLengthSegment(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Triangle(int a, int b, int c)
{
    if(a + b < c || b + c < a || a + c < b)
    {
        Console.Write("Соответствует треугольнику!!");
    }
    else
    {
        Console.Write("Не треугольник.");
    }
}
int a = EnterLengthSegment("Укажите длинну стороны a: ");
int b = EnterLengthSegment("Укажите длинну стороны b: ");
int c = EnterLengthSegment("Укажите длинну стороны c: ");
Triangle(a, b, c);
