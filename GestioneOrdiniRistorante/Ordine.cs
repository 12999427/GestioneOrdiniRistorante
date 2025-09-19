using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneOrdiniRistorante
{
    public class Ordine
    {
        private const float SOGLIA = 50;
        public Dictionary<Piatto, int> PiattiOrdinati { private set; get; } = new();
        public string IDcliente { get; private set; }

        public Ordine (string idcliente)
        {
            IDcliente = idcliente;
        }
        public Ordine(string idcliente, Dictionary<Piatto, int> po)
        {
            IDcliente = idcliente;
            PiattiOrdinati = po;
        }

        public void AggiungiPiattoOrdinato (Piatto piatto, int quantita)
        {
            if (PiattiOrdinati.ContainsKey(piatto))
            {
                PiattiOrdinati[piatto] += quantita;
            }
            else
            {
                PiattiOrdinati[piatto] = quantita;
            }
        }

        public (bool, float) CalcolaTotale ()
        {
            float totale = 0;
            string riepilogo = "";
            foreach (KeyValuePair<Piatto, int> voce in PiattiOrdinati)
            {
                totale += voce.Value * voce.Key.Prezzo;
            }
            if (totale > SOGLIA)
            {
                totale *= 0.95f;
                return (true, totale);
            }
            return (false, totale);
        }

    }
}
