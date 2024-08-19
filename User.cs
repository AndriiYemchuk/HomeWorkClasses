using System;



User user = new User();

user.name = "Andrii";
user.login = "yemchukandrii@knute.edu.com";
user.surnom = "Yemchuk";
user.yearsold = 19;

user.Print();

public class User
{
    public string date_of_registration = "19.08.2024";
    public string name = "Not Found";
    public string login = "Enter Login";
    public string surnom = "Not Found";
    public int yearsold;
    public string Date
    {

        get { return date_of_registration; }
    }

    public void Print()
    {
        Console.WriteLine($"Name: {name} Surname: {surnom} Login: {login} Years: {yearsold} You're with us since: {Date}");
    }
}