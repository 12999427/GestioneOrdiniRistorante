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
    public partial class ChiediNomeOrdine : Form
    {
        Ristorante ristorante;
        public string IDcliente { get; private set; } = "";
        public ChiediNomeOrdine(Ristorante r)
        {
            InitializeComponent();
            ristorante = r;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_nome.Text))
            {
                MessageBox.Show("Inserisci nome valido");
                return;
            }
            else if (ristorante.OttieniOrdine(txt_nome.Text) != null)
            {
                DialogResult result = MessageBox.Show(
                    "Vuoi aggiungere nuovi ordini al cliente già esistente?\n",
                    "Conferma",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );
                if (result != DialogResult.OK)
                {
                    Close();
                }
            }

            IDcliente = txt_nome.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
