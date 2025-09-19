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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            btn_Aggiungi = new Button();
            btn_Reset = new Button();
            dtg_Visualizzazione = new DataGridView();
            Piatto = new DataGridViewTextBoxColumn();
            Prezzo = new DataGridViewTextBoxColumn();
            lbl_PrezzoTot = new Label();
            btn_Seleziona = new Button();
            txt_NomePiattoDaInserire = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_Visualizzazione).BeginInit();
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
            // dtg_Visualizzazione
            // 
            dtg_Visualizzazione.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_Visualizzazione.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Visualizzazione.Columns.AddRange(new DataGridViewColumn[] { Piatto, Prezzo });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dtg_Visualizzazione.DefaultCellStyle = dataGridViewCellStyle6;
            dtg_Visualizzazione.Location = new Point(12, 75);
            dtg_Visualizzazione.Name = "dtg_Visualizzazione";
            dtg_Visualizzazione.RowHeadersVisible = false;
            dtg_Visualizzazione.RowTemplate.Height = 25;
            dtg_Visualizzazione.Size = new Size(439, 375);
            dtg_Visualizzazione.TabIndex = 2;
            // 
            // Piatto
            // 
            Piatto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Piatto.HeaderText = "Piatto";
            Piatto.Name = "Piatto";
            Piatto.Width = 63;
            // 
            // Prezzo
            // 
            Prezzo.HeaderText = "Prezzo";
            Prezzo.Name = "Prezzo";
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
            txt_NomePiattoDaInserire.Location = new Point(229, 12);
            txt_NomePiattoDaInserire.Name = "txt_NomePiattoDaInserire";
            txt_NomePiattoDaInserire.Size = new Size(222, 23);
            txt_NomePiattoDaInserire.TabIndex = 5;
            // 
            // EffettuaOrdine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 462);
            Controls.Add(txt_NomePiattoDaInserire);
            Controls.Add(btn_Seleziona);
            Controls.Add(lbl_PrezzoTot);
            Controls.Add(dtg_Visualizzazione);
            Controls.Add(btn_Reset);
            Controls.Add(btn_Aggiungi);
            Name = "EffettuaOrdine";
            Text = "EffettuaOrdine";
            ((System.ComponentModel.ISupportInitialize)dtg_Visualizzazione).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Aggiungi;
        private Button btn_Reset;
        private DataGridView dtg_Visualizzazione;
        private DataGridViewTextBoxColumn Piatto;
        private DataGridViewTextBoxColumn Prezzo;
        private Label lbl_PrezzoTot;
        private Button btn_Seleziona;
        private TextBox txt_NomePiattoDaInserire;
    }
}