start:
Console.WriteLine("Введите первое число");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите второе число");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Выберите операцию: + (сложение), - (вычитание), * (умножение), / (деление)");

string operation = Console.ReadLine();
double result = 0;

switch (operation)
{
    case "+":
        result = num1 + num2;
        Console.WriteLine(result);
        goto start;
    case "-":
        result = num1 - num2;
        Console.WriteLine(result);
        goto start;
    case "*":
        result = num1 * num2;
        Console.WriteLine(result);
        goto start;
    case "/":
        if (num1 != 0 || num2 != 0)
        {
            result = num1 / num2;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
        goto start;
    default:
        Console.WriteLine("Неправильное значение");
        goto start;
}
