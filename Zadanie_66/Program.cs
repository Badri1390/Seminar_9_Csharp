// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
int m = InputNumber("Введите значение М: ");
int n = InputNumber("Введите значение N: ");
int sum = 0;
SumNumber(m, n, sum);

void SumNumber(int m, int n, int sum)
{

    if (m > n)

    {
        System.Console.WriteLine(sum);
        return;
    }
    sum = sum + (m++);
    SumNumber(m, n, sum);

}






int InputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}