public class Wypozyczalnia : IWypozyczalny
    {
        private Media[] media = new Media[] {
            new Ksiazka("W pustyni i w puszczy", "Henryk Sienkiewicz", 1911, 29.99M, 320),
            new Ksiazka("Pan Tadeusz", "Adam Mickiewicz", 1834, 19.99M, 240),
            new Ksiazka("Zbrodnia i kara", "Fiodor Dostojewski", 1866, 24.99M,  450),
            new Ebook("Metro 2033", "Dmitrij Głuchowski", 2005, 14.99M, 1024),
            new Ebook("Wiedźmin", "Andrzej Sapkowski", 1990, 12.99M, 80),
            new Ebook("Gra o tron", "George R.R. Martin", 1996, 18.99M, 120),
            new Czasopismo("National Geographic", "", 2005, 8.99M),
            new Czasopismo("Wiedza i Życie", "", 2005, 6.99M)};


        public void Wypozycz(Klient klient)
        {
            if(klient.IloscWypozyczonychMediow >= 3){
                Console.WriteLine("Niestety, nie możesz wypożyczyć kolejnych mediów! Oddaj najpierw wypożyczone media!"); return;}
            
            Console.WriteLine("Dostępne media:");
            for(int i = 0; i< media.Length; i++)
            {
                if (media[i] != null)
                {
                    Console.WriteLine((i+1) + ": " + media[i].GetType().Name + " - \""+ media[i].Tytul + "\" - status: " + media[i].SprawdzDostepnosc());
                }
            }
            Console.WriteLine("Wybierz media do wypożyczenia:");
            int wybor = Convert.ToInt32(Console.ReadLine());

            if (wybor >= 1 && wybor <= media.Length)
            {
                var medium = media[wybor - 1];
                if (medium != null && medium.SprawdzDostepnosc())
                {
                    medium.Wypozycz(klient);
                    media[wybor - 1] = null; // Ustawiamy referencję na null, żeby wypożyczalnia nie miała już dostępu do wypożyczonego medium
                }
                else
                {
                    Console.WriteLine("Nie można wypożyczyć tego media.");
                }
            }
            else
            {
                Console.WriteLine("Nie ma takiego media.");
            }
        }

        public bool SprawdzDostepnosc()
        {
            //Sprawdzamy czy istnieje conajmniej jedno medium dostępne do wyporzyczenia
            bool jestDostepne = false;
            foreach (var medium in media)
            {
                if (medium != null && medium.SprawdzDostepnosc())
                {
                    jestDostepne = true;
                    break;
                }
            }
            return jestDostepne;
        }
    }