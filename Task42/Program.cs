/* Задача 42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10 */

// 23 / 2 1 22

Console.Write("Введите число для преобразования в двоичную систему счисления: ");
int number = Convert.ToInt32(Console.ReadLine());

int convertDecimalToBinary = ConvertDecimalToBinary(number);
Console.WriteLine(convertDecimalToBinary);

int ConvertDecimalToBinary(int num)
{
    int result = 0;
    int ostatok = 0;
    int multiplyer = 1;

    while(num != 0)
    {   
        ostatok = num%2;
        result = result + ostatok * multiplyer;
        num = num / 2;
        multiplyer *= 10;

    }

    return result;
}