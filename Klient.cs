public class Klient{
    private string imie;
    private string nazwisko;
    public static int maksymalnaIloscWypozyczen = 3;
    Media[] wypozyczoneMedia = new Media[maksymalnaIloscWypozyczen];
    public Klient(string imie, string nazwisko){
        this.imie=imie;
        this.nazwisko=nazwisko;
    }
    public int IloscWypozyczonychMediow{
        get{return policzMedia();}
    }
    public int policzMedia(){
        int licznik=0;
        foreach(var media in wypozyczoneMedia){
            if(media!=null){
                licznik++;
            }
        }return licznik;
    }
    public void DodajMedia(Media media){
        for(int i = 0; i < maksymalnaIloscWypozyczen; i++){
            if(wypozyczoneMedia[i]==null){
                wypozyczoneMedia[i]=media;
                break;
            }
        }
    }
}