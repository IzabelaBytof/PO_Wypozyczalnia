public abstract class Media : IWypozyczalny
{
    private string tytul;
    public string Tytul
    {
        get { return tytul; }
    }
    private decimal cena;
    private string autor;
    private int rokWydania;

    public Media(string tytul, string autor, int rokWydania, decimal cena)
    {
        this.tytul = tytul;
        this.autor = autor;
        this.rokWydania = rokWydania;
        this.cena = cena;
    }
    public void Wypozycz(Klient klient)
    {

    }
    public virtual bool SprawdzDostepnosc()
    {
        return true;
    }
}