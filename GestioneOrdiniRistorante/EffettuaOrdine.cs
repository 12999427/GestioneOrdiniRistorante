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
    public partial class EffettuaOrdine : Form
    {
        private const float SOGLIA = 50;
        DataGridView DGV;
        Ristorante ristorante;
        Menu menu;
        Ordine ordine;
        public EffettuaOrdine(Ristorante r, string id)
        {
            InitializeComponent();
            ristorante = r;
            DGV = ristorante.dtg_Visualizzazione;
            menu = r.menu;
            ordine = (r.OttieniOrdine(id) ?? new(id));
            AggiornaUI();
        }

        private void btn_Aggiungi_Click(object sender, EventArgs e)
        {
            if (nmr_quantita.Value <= 0) //in realtà il numericupanddown evita il problema, ma se il Min non fosse impostato a 1, servirebbe
                throw new QuantitaNonValidaException();

            try
            {
                Piatto p = menu.ContienePiatto(txt_NomePiattoDaInserire.Text);
                ordine.AggiungiPiattoOrdinato(p, (int)nmr_quantita.Value);
            }
            catch (PiattoNonTrovatoException)
            {
                MessageBox.Show("Nome piatto invalido");
            }
            AggiornaUI();
        }

        private void AggiornaUI()
        {
            dtg_Visualizzazione.Rows.Clear();
            float totale = 0;
            foreach (KeyValuePair<Piatto, int> voce in ordine.PiattiOrdinati) // KeyValuePair è il tipo di cui è costituito il dict ed ha i campi .Value e .Key
            {
                dtg_Visualizzazione.Rows.Add(voce.Key.Nome, voce.Key.Prezzo + " €", voce.Value);
                totale += voce.Value * voce.Key.Prezzo;
            }

            lbl_PrezzoTot.Text = $"Prezzo totale: {totale} € {(totale > SOGLIA ? $"-5% => {totale * 0.98}" : "")}";
        }

        private void btn_Seleziona_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentCell != null)
            {
                string value = (string)DGV.Rows[DGV.CurrentCell.RowIndex].Cells[0].Value;
                txt_NomePiattoDaInserire.Text = value;
            }
            else
            {
                MessageBox.Show("No cell selected.");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ordine.PiattiOrdinati.Clear();
            AggiornaUI();
        }

        private void btn_Conferma_Click(object sender, EventArgs e)
        {
            float totale = 0;
            string riepilogo = "";
            foreach (KeyValuePair<Piatto, int> voce in ordine.PiattiOrdinati)
            {
                riepilogo += $"{voce.Value}x{voce.Key.Nome}\n";
                totale += voce.Value * voce.Key.Prezzo;
            }
            riepilogo += "Totale: " + totale.ToString() + " €";

            if (totale > SOGLIA)
            {
                totale *= 0.95f;
                riepilogo += $"\nScontato del 5% a {totale} €";
            }

            if (ordine.PiattiOrdinati.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Conferma?\n" + riepilogo,
                    "Conferma",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (result != DialogResult.OK)
                    return;

                ristorante.OrdineCompletato(ordine);
                Close();
            }
            else
            {
                MessageBox.Show("Non hai ordinato niente");
            }
        }

        private void EffettuaOrdine_FormClosing(object sender, FormClosingEventArgs e)
        {
            ristorante.EffettuaOrdineAttivo = false;
        }
    }
}
