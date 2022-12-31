// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InputNumber("Введите значение для M: ");
int n = InputNumber("Введите значение для N: ");

int InputNumber(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int SumNaturalElements(int m, int n)
{
    if (m == n)
        return n;
    return n + SumNaturalElements(m, n - 1);
}
Console.WriteLine($"Сумма элементов от {m} до {n} равна: {SumNaturalElements(m, n)}");