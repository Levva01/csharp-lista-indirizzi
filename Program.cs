StreamReader fileIndirizzi = File.OpenText("C:\\Users\\vella\\source\\repos\\csharp-lista-indirizzi\\Indirizzi-first.txt");
List<Indirizzo> listaIndirizzi = new List<Indirizzo>();
fileIndirizzi.ReadLine();

while (!fileIndirizzi.EndOfStream)
{
    string riga = fileIndirizzi.ReadLine();

    string[] split = riga.Split(',');

    try
    {
        string name = split[0];
        string surname = split[1];
        string street = split[2];
        string city = split[3];
        string province = split[4];
        string zip = split[5];
        name = name.Replace("- ", "");
        Indirizzo indirizzo = new Indirizzo(name, surname, street, city, province, zip);
        listaIndirizzi.Add(indirizzo);
        Console.WriteLine("{0} importato correttamente", street);

    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Indirizzo non valido -->" + riga);
    }


}

fileIndirizzi.Close();

try
{
    StreamWriter indirizziWriter = File.CreateText("Indirizzi.txt");

    indirizziWriter.WriteLine("Libri preferiti formato bello");

    foreach (Indirizzo indirizzo in listaIndirizzi)
    {
        Console.WriteLine("Salvataggio {0}", indirizzo.Name);
        indirizziWriter.WriteLine();
        indirizziWriter.WriteLine(indirizzo.ToString());
    }

    indirizziWriter.Close();

}
catch (Exception e)
{
    Console.WriteLine("Qualcosa è andato storto: {0}", e.Message);
}
