using System;


Employee person1 = new Employee();

Console.Write("Введіть імʼя співробітника: ");
person1.name = Console.ReadLine();
Console.Write("Введіть прізвище співробітника: ");
person1.surname = Console.ReadLine();


if (person1.name == "Андрій"&&person1.surname == "Ємчук")
{
    person1.expirience = 2;
    person1.role = "senior";
    person1.salary = 40000;
    person1.wage = (5/100)*person1.salary;
    person1.tax = (18/100)*person1.salary;
    person1.Print();
}
else
{
    Console.WriteLine("Співробітника не знайдено!");
}


public class Employee
{

    public string name = "Unknown";
    public string surname = "Unknown";
    public int expirience = 0;
    public string role = "junior";
    public float salary = 0;
    public float wage = 0;
    public float tax = 0;

    public void Print()
    {
        Console.WriteLine($"Імʼя: {name} Прізвище: {surname} Років досвіду: {expirience} Посада: {role} Оклад: {wage}грн. Податок: {tax}грн.");
    }

}