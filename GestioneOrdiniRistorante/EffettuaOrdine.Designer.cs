namespace GestioneOrdiniRistorante
{
    partial class EffettuaOrdine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btn_Aggiungi = new Button();
            btn_Reset = new Button();
            lbl_PrezzoTot = new Label();
            btn_Seleziona = new Button();
            txt_NomePiattoDaInserire = new TextBox();
            btn_Conferma = new Button();
            dtg_Visualizzazione = new DataGridView();
            Piatto = new DataGridViewTextBoxColumn();
            Prezzo = new DataGridViewTextBoxColumn();
            Quantita = new DataGridViewTextBoxColumn();
            nmr_quantita = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dtg_Visualizzazione).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_quantita).BeginInit();
            SuspendLayout();
            // 
            // btn_Aggiungi
            // 
            btn_Aggiungi.Location = new Point(12, 41);
            btn_Aggiungi.Name = "btn_Aggiungi";
            btn_Aggiungi.Size = new Size(194, 23);
            btn_Aggiungi.TabIndex = 0;
            btn_Aggiungi.Text = "Aggiungi Piatto Selezionato";
            btn_Aggiungi.UseVisualStyleBackColor = true;
            btn_Aggiungi.Click += btn_Aggiungi_Click;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(93, 12);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(83, 23);
            btn_Reset.TabIndex = 1;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // lbl_PrezzoTot
            // 
            lbl_PrezzoTot.Location = new Point(229, 41);
            lbl_PrezzoTot.Name = "lbl_PrezzoTot";
            lbl_PrezzoTot.Size = new Size(200, 23);
            lbl_PrezzoTot.TabIndex = 3;
            lbl_PrezzoTot.Text = "Prezzo Totale: 1";
            // 
            // btn_Seleziona
            // 
            btn_Seleziona.Location = new Point(12, 12);
            btn_Seleziona.Name = "btn_Seleziona";
            btn_Seleziona.Size = new Size(75, 23);
            btn_Seleziona.TabIndex = 4;
            btn_Seleziona.Text = "Seleziona";
            btn_Seleziona.UseVisualStyleBackColor = true;
            btn_Seleziona.Click += btn_Seleziona_Click;
            // 
            // txt_NomePiattoDaInserire
            // 
            txt_NomePiattoDaInserire.Location = new Point(263, 12);
            txt_NomePiattoDaInserire.Name = "txt_NomePiattoDaInserire";
            txt_NomePiattoDaInserire.Size = new Size(188, 23);
            txt_NomePiattoDaInserire.TabIndex = 5;
            // 
            // btn_Conferma
            // 
            btn_Conferma.Location = new Point(182, 11);
            btn_Conferma.Name = "btn_Conferma";
            btn_Conferma.Size = new Size(75, 23);
            btn_Conferma.TabIndex = 6;
            btn_Conferma.Text = "Conferma";
            btn_Conferma.UseVisualStyleBackColor = true;
            btn_Conferma.Click += btn_Conferma_Click;
            // 
            // dtg_Visualizzazione
            // 
            dtg_Visualizzazione.AllowUserToAddRows = false;
            dtg_Visualizzazione.AllowUserToDeleteRows = false;
            dtg_Visualizzazione.AllowUserToResizeColumns = false;
            dtg_Visualizzazione.AllowUserToResizeRows = false;
            dtg_Visualizzazione.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_Visualizzazione.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Visualizzazione.Columns.AddRange(new DataGridViewColumn[] { Piatto, Prezzo, Quantita });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_Visualizzazione.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_Visualizzazione.Location = new Point(12, 70);
            dtg_Visualizzazione.MultiSelect = false;
            dtg_Visualizzazione.Name = "dtg_Visualizzazione";
            dtg_Visualizzazione.ReadOnly = true;
            dtg_Visualizzazione.RowHeadersVisible = false;
            dtg_Visualizzazione.RowTemplate.Height = 25;
            dtg_Visualizzazione.Size = new Size(478, 399);
            dtg_Visualizzazione.TabIndex = 7;
            // 
            // Piatto
            // 
            Piatto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Piatto.HeaderText = "Piatto";
            Piatto.Name = "Piatto";
            Piatto.ReadOnly = true;
            Piatto.Width = 63;
            // 
            // Prezzo
            // 
            Prezzo.HeaderText = "Prezzo";
            Prezzo.Name = "Prezzo";
            Prezzo.ReadOnly = true;
            // 
            // Quantita
            // 
            Quantita.HeaderText = "Quantita";
            Quantita.Name = "Quantita";
            Quantita.ReadOnly = true;
            // 
            // nmr_quantita
            // 
            nmr_quantita.Location = new Point(457, 14);
            nmr_quantita.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nmr_quantita.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmr_quantita.Name = "nmr_quantita";
            nmr_quantita.Size = new Size(31, 23);
            nmr_quantita.TabIndex = 8;
            nmr_quantita.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // EffettuaOrdine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 481);
            Controls.Add(nmr_quantita);
            Controls.Add(dtg_Visualizzazione);
            Controls.Add(txt_NomePiattoDaInserire);
            Controls.Add(btn_Seleziona);
            Controls.Add(btn_Conferma);
            Controls.Add(lbl_PrezzoTot);
            Controls.Add(btn_Reset);
            Controls.Add(btn_Aggiungi);
            Name = "EffettuaOrdine";
            Text = "EffettuaOrdine";
            ((System.ComponentModel.ISupportInitialize)dtg_Visualizzazione).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_quantita).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Aggiungi;
        private Button btn_Reset;
        private Label lbl_PrezzoTot;
        private Button btn_Seleziona;
        private TextBox txt_NomePiattoDaInserire;
        private Button btn_Conferma;
        public DataGridView dtg_Visualizzazione;
        private DataGridViewTextBoxColumn Piatto;
        private DataGridViewTextBoxColumn Prezzo;
        private DataGridViewTextBoxColumn Quantita;
        private NumericUpDown nmr_quantita;
    }
}