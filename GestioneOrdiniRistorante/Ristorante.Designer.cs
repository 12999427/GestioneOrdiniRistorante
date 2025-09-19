namespace GestioneOrdiniRistorante
{
    partial class Ristorante
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dtg_Visualizzazione = new DataGridView();
            Piatto = new DataGridViewTextBoxColumn();
            Prezzo = new DataGridViewTextBoxColumn();
            lbl_titolo = new Label();
            btn_Ordina = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_Visualizzazione).BeginInit();
            SuspendLayout();
            // 
            // dtg_Visualizzazione
            // 
            dtg_Visualizzazione.AllowUserToAddRows = false;
            dtg_Visualizzazione.AllowUserToDeleteRows = false;
            dtg_Visualizzazione.AllowUserToResizeColumns = false;
            dtg_Visualizzazione.AllowUserToResizeRows = false;
            dtg_Visualizzazione.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_Visualizzazione.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Visualizzazione.Columns.AddRange(new DataGridViewColumn[] { Piatto, Prezzo });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtg_Visualizzazione.DefaultCellStyle = dataGridViewCellStyle1;
            dtg_Visualizzazione.Location = new Point(12, 62);
            dtg_Visualizzazione.MultiSelect = false;
            dtg_Visualizzazione.Name = "dtg_Visualizzazione";
            dtg_Visualizzazione.ReadOnly = true;
            dtg_Visualizzazione.RowHeadersVisible = false;
            dtg_Visualizzazione.RowTemplate.Height = 25;
            dtg_Visualizzazione.Size = new Size(776, 376);
            dtg_Visualizzazione.TabIndex = 0;
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
            // lbl_titolo
            // 
            lbl_titolo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_titolo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_titolo.Location = new Point(254, 2);
            lbl_titolo.Name = "lbl_titolo";
            lbl_titolo.Size = new Size(344, 45);
            lbl_titolo.TabIndex = 1;
            lbl_titolo.Text = "Trattoria da Marco T.";
            lbl_titolo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Ordina
            // 
            btn_Ordina.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Ordina.Location = new Point(660, 12);
            btn_Ordina.Name = "btn_Ordina";
            btn_Ordina.Size = new Size(128, 36);
            btn_Ordina.TabIndex = 2;
            btn_Ordina.Text = "Ordina";
            btn_Ordina.UseVisualStyleBackColor = true;
            btn_Ordina.Click += btn_Ordina_Click;
            // 
            // Ristorante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Ordina);
            Controls.Add(lbl_titolo);
            Controls.Add(dtg_Visualizzazione);
            Name = "Ristorante";
            Text = "Ristorante";
            ((System.ComponentModel.ISupportInitialize)dtg_Visualizzazione).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dtg_Visualizzazione;
        private Label lbl_titolo;
        private DataGridViewTextBoxColumn Piatto;
        private DataGridViewTextBoxColumn Prezzo;
        private Button btn_Ordina;
    }
}