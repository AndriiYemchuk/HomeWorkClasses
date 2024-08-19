using System;

Converter UAH = new Converter();

UAH.USD = 0.024f;
UAH.EUR = 0.022F;
UAH.GBP = 0.019f;

Console.WriteLine("1.Долар, 2.Євро, 3.Фунт");
Console.Write("Оберіть валюту серед зазначених: ");
string currency = Console.ReadLine();
Console.Write("Введіть суму у гривнях: ");
int amount = Convert.ToInt32(Console.ReadLine());

if (currency == "Долар")
{
    UAH.result = (amount * 0.024f);
    UAH.Print();
}
else if (currency == "Євро")
{
    UAH.result = (amount * 0.022f);
    UAH.Print();
}
else if (currency == "Фунт")
{
    UAH.result = (amount * 0.019f);
    UAH.Print();
}
else
{
    Console.WriteLine("Введені некоректні дані!");
}


class Converter
{
    public float USD = 0;
    public float EUR = 0;
    public float GBP = 0;
    public float result;
    public int amount;

    public void Print()
    {
        Console.WriteLine($"Результат: {result}");
    }


}
