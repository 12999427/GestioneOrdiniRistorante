namespace GestioneOrdiniRistorante
{
    partial class ChiediNomeOrdine
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
            txt_nome = new TextBox();
            btn_OK = new Button();
            lbl_messaggio = new Label();
            SuspendLayout();
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(8, 42);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(241, 23);
            txt_nome.TabIndex = 0;
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(90, 79);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(75, 23);
            btn_OK.TabIndex = 1;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // lbl_messaggio
            // 
            lbl_messaggio.AutoSize = true;
            lbl_messaggio.Location = new Point(56, 9);
            lbl_messaggio.Name = "lbl_messaggio";
            lbl_messaggio.Size = new Size(146, 15);
            lbl_messaggio.TabIndex = 2;
            lbl_messaggio.Text = "Inserisci nome per l'ordine";
            // 
            // ChiediNomeOrdine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 114);
            Controls.Add(lbl_messaggio);
            Controls.Add(btn_OK);
            Controls.Add(txt_nome);
            MaximumSize = new Size(277, 153);
            MinimumSize = new Size(277, 153);
            Name = "ChiediNomeOrdine";
            Text = "ChiediNomeOrdine";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_nome;
        private Button btn_OK;
        private Label lbl_messaggio;
    }
}