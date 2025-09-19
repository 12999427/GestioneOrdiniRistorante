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
        DataGridView DGV;
        Ristorante ristorante;
        Menu menu;
        Ordine ordine;
        public EffettuaOrdine(Ristorante r)
        {
            InitializeComponent();
            ristorante = r;
            DGV = ristorante.dtg_Visualizzazione;
            menu = r.menu;
            ordine = new("a"); //DA MODIFICARE
        }

        private void btn_Aggiungi_Click(object sender, EventArgs e)
        {
            Piatto? p = menu.ContienePiatto(txt_NomePiattoDaInserire.Text);
            if (p != null)
            {
                ordine.AggiungiPiattoOrdinato(p, 1);
            }
            else
            {
                MessageBox.Show("Nome piatto invalido");
            }
        }

        private void btn_Seleziona_Click(object sender, EventArgs e)
        {

            if (DGV.CurrentCell != null)
            {
                string value = (string)DGV.CurrentCell.Value;
                txt_NomePiattoDaInserire.Text = value;
            }
            else
            {
                MessageBox.Show("No cell selected.");
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }
    }
}
