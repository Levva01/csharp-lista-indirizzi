// See https://aka.ms/new-console-template for more information


public class Indirizzo
{
    public string Name { get; }
    public string Surname { get; }
    public string Street { get; }
    public string City { get; }
    public string Province { get; }
    public string Zip { get; }

    public Indirizzo(string Name, string Surname, string Street, string City, string Province, string Zip)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Street = Street;
        this.City = City;
        this.Province = Province;
        this.Zip = Zip;
    }
}