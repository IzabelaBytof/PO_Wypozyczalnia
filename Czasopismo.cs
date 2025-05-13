public class Czasopismo : Media{
    public Czasopismo(string tytul, string autor, int rokWydania, decimal cena):base(tytul, autor, rokWydania, cena){
    }
    public override bool SprawdzDostepnosc(){
        return false;
    }
}