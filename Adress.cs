using System;



Adress adress1 = new Adress();

adress1.index = 10963;
adress1.country = "Ukraine";
adress1.city = "Kharkiv";
adress1.street = "Universytets'ka";
adress1.house = 23;
adress1.apartament = 112;

adress1.Print();


class Adress
{
    public int index;
    public string country = "No Country Found";
    public string city = "No City Found";
    public string street = "No Street Found";
    public int house;
    public int apartament;

    public void Print()
    {
        Console.WriteLine($"Country: {country}  City: {city}  Street: {street}  Postal Code: {index}  House: {house}  Apartament: {apartament}");
    }
}