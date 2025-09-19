using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneOrdiniRistorante
{
    public partial class Ristorante : Form
    {
        private string MenuPath = @"../../../../menu.csv";
        private string OrdiniPath = @"../../../../ordini.csv";
        public Menu menu { get; private set; }
        private List<Ordine> Ordini = new();
        private bool EffettuaOrdineAttivo = false;
        public Ristorante()
        {
            InitializeComponent();
            try { menu = new(MenuPath); }
            catch
            {
                MessageBox.Show("File Menu scorretto");
                Environment.Exit(1); //chiude il programma
                return;
            }

            VisualizzaMenu(menu);
        }

        private void VisualizzaMenu(Menu m)
        {
            dtg_Visualizzazione.Rows.Clear();
            foreach (Piatto p in m.ListaMenu)
            {
                dtg_Visualizzazione.Rows.Add(p.Nome, p.Prezzo + " €");
            }
        }

        public Ordine? OttieniOrdine(string nome)
        {
            foreach (Ordine o in Ordini)
            {
                if (o.IDcliente == nome)
                    return o;
            }
            return null;
        }

        private void btn_Ordina_Click(object sender, EventArgs e)
        {
            if (EffettuaOrdineAttivo)
            {
                MessageBox.Show("Già effettuazione di ordine attivo");
                return;
            }
            using (ChiediNomeOrdine cno = new(this))
            {
                if (cno.ShowDialog() == DialogResult.OK)
                {
                   EffettuaOrdine eo = new(this, cno.IDcliente);
                    EffettuaOrdineAttivo = true;
                   eo.Show();
                }
            }
        }

        public void OrdineCompletato (Ordine ordine)
        {
            Ordini.Add(ordine);
            EffettuaOrdineAttivo = false;
            try
            {
                using (StreamWriter sw = new(OrdiniPath, true))
                {
                    foreach (KeyValuePair<Piatto, int> voce in ordine.PiattiOrdinati)
                    {
                        sw.WriteLine($"{ordine.IDcliente};{voce.Key.Nome};{voce.Value};{ordine.CalcolaTotale().Item2}");
                        MessageBox.Show($"{ordine.IDcliente};{voce.Key.Nome};{voce.Value};{ordine.CalcolaTotale().Item2}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nello scrivere il file: " + ex.Message);
            }
            
        }
    }
}
