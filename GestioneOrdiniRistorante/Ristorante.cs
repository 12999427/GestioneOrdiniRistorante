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
        private string OrdiniPath = @"../../../ordini.csv";
        public Menu menu;
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
            foreach (Piatto p in m.ListaMenu)
            {
                dtg_Visualizzazione.Rows.Add(p.Nome, p.Prezzo + " €");
            }
        }
    }
}
