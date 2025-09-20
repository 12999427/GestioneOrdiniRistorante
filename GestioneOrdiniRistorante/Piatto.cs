using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneOrdiniRistorante
{
    public class Piatto
    {
        public string Nome { get; private set; }
        public float Prezzo { get; private set; }

        public Piatto (string nome, float prezzo)
        {
            if (String.IsNullOrWhiteSpace(nome))
                throw new Exception("Nome invalido");

            if (prezzo <= 0)
                throw new Exception();

            Nome = nome;
            Prezzo = prezzo;
        }
    }
}
