namespace DolgozatProject
{
    public class Dolgozat
    {
        private List<int> pontok;
        public Dolgozat()
        {
            pontok = new List<int>();
        }

        public void PontFelvesz(int x)
        {
            if (x < -1 || x > 100)
            {
                throw new ArgumentException("A pontszámnak -1 és 100 közé kell esnie",
                    nameof(x));
            }
            pontok.Add(x);
        }

        public bool MindenkiMegirta
        {
            get
            {
                int index = 0;
                while (index < pontok.Count && pontok[index] != -1) 
                {
                    index++;
                }
                return index == pontok.Count;
            }
        }

        public int Bukas
        {
            get
            {
                int darab = 0;
                foreach (var pont in pontok)
                {
                    if (pont > -1 && pont < 50)
                    {
                        darab++;
                    }
                }
                return darab;
                // LINQ -> Language INtegrated Query
                //return pontok.Count(pont => pont > -1 && pont < 50);
            }
        }

        public int Elegseges
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Kozepes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Jo
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Jeles
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool Gyanus(int kivalok)
        {
            throw new NotImplementedException();
        }

        public bool Ervenytelen
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}