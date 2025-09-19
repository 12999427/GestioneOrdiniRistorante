using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneOrdiniRistorante
{
    public class Menu
    {
        public List<Piatto> ListaMenu { private set; get; } = new();

        public Menu (List<Piatto> menu)
        {
            ListaMenu = menu;
        }

        public Menu ()
        {
        }

        public Menu (string path)
        {
            CaricaCSV(path);
        }

        public Piatto? ContienePiatto (string Nome)
        {
            foreach (Piatto p in ListaMenu)
            {
                if (p.Nome == Nome)
                    return p;
            }
            return null;
        }

        public void CaricaCSV (string path) //puo lanciare eccezioni
        {
            ListaMenu = new();
            if (!File.Exists(path))
            {
                MessageBox.Show("non c'è");
                throw new FileMenuNonTrovatoException();

            }
            
            using (StreamReader sr = new StreamReader(path))
            {
                string[] header = sr.ReadLine().Split(";");
                if (header[0] != "NomePiatto" || header[1] != "Prezzo")
                    throw new Exception("File menu scorretto");

                while (sr.Peek() != -1)
                {
                    string[] riga = sr.ReadLine().Split(";");
                    ListaMenu.Add(new Piatto(riga[0], float.Parse(riga[1])));
                }
            }
        }
    }
}
