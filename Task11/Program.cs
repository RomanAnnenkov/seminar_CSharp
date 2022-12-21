/*
11. Напишите программу, которая 
выводит случайное трёхзначное число 
и удаляет вторую цифру этого числа. 
456 -> 46 
782 -> 72 
918 -> 98 
*/

int DeleteSecondDigitOfThreeDigitNumber(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    return firstDigit*10 + thirdDigit;
}

int threeDigitNumber = new Random().Next(100,1000);
Console.WriteLine($"Трёхзначное число - {threeDigitNumber}");

int deleteSecondDigitOfThreeDigitNumber = DeleteSecondDigitOfThreeDigitNumber(threeDigitNumber);
Console.WriteLine(deleteSecondDigitOfThreeDigitNumber);
