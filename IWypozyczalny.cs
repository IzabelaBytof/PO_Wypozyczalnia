public interface IWypozyczalny{
    public bool SprawdzDostepnosc();
    public void Wypozycz(Klient klient);
}