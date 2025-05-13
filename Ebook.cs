public class Ebook: Media{
    private int rozmiar;
    public Ebook(string tytul, string autor, int rokWydania, decimal cena, int rozmiar) : base(tytul, autor, rokWydania, cena){
        this.rozmiar = rozmiar;
    }
}