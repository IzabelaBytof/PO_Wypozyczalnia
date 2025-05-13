public class Ksiazka : Media{
    private int liczbaStron;
    public Ksiazka(string tytul, string autor, int rokWydania, decimal cena, int liczbaStron) : base(tytul, autor, rokWydania, cena){
        this.liczbaStron = liczbaStron;
    }
}