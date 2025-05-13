public class Program
{
    public static void Main(string[] args)
    {
        var wypozyczalnia = new Wypozyczalnia();

        var klient1 = new Klient("Jan", "Kowalski");

        var klient2 = new Klient("Anna", "Nowak");

        wypozyczalnia.Wypozycz(klient1);

        wypozyczalnia.Wypozycz(klient1);

        wypozyczalnia.Wypozycz(klient1);

        wypozyczalnia.Wypozycz(klient1);  // klient1 próbuje wypożyczyć już 4 media, co jest niepoprawne

        wypozyczalnia.Wypozycz(klient2);

        wypozyczalnia.Wypozycz(klient2);

        Console.WriteLine("Dostępność wypożyczalni: " + wypozyczalnia.SprawdzDostepnosc()); // powinno zwrócić wartość true, bo są jeszcze 2 media do wypożyczenia    // Tworzenie obiektów klas pochodnych
    }
}
