using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneOrdiniRistorante
{
    internal class Ordine
    {

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
                PiattiOrdinati[piatto]++;
            }
            else
            {
                PiattiOrdinati[piatto] = quantita;
            }
        }

    }
}
