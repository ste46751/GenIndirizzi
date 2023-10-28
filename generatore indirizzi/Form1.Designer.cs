namespace generatore_indirizzi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputHost = new System.Windows.Forms.TextBox();
            this.InputSottoreti = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_tabella = new System.Windows.Forms.ListBox();
            this.bttn_crea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputHost
            // 
            this.InputHost.Location = new System.Drawing.Point(50, 45);
            this.InputHost.Name = "InputHost";
            this.InputHost.Size = new System.Drawing.Size(147, 20);
            this.InputHost.TabIndex = 0;
            // 
            // InputSottoreti
            // 
            this.InputSottoreti.Location = new System.Drawing.Point(289, 45);
            this.InputSottoreti.Name = "InputSottoreti";
            this.InputSottoreti.Size = new System.Drawing.Size(147, 20);
            this.InputSottoreti.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inserisci numero host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inserisci numero sottoreti";
            // 
            // lst_tabella
            // 
            this.lst_tabella.FormattingEnabled = true;
            this.lst_tabella.Location = new System.Drawing.Point(50, 82);
            this.lst_tabella.Name = "lst_tabella";
            this.lst_tabella.Size = new System.Drawing.Size(445, 251);
            this.lst_tabella.TabIndex = 4;
            // 
            // bttn_crea
            // 
            this.bttn_crea.Location = new System.Drawing.Point(555, 35);
            this.bttn_crea.Name = "bttn_crea";
            this.bttn_crea.Size = new System.Drawing.Size(87, 47);
            this.bttn_crea.TabIndex = 5;
            this.bttn_crea.Text = "Crea";
            this.bttn_crea.UseVisualStyleBackColor = true;
            this.bttn_crea.Click += new System.EventHandler(this.bttn_crea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_crea);
            this.Controls.Add(this.lst_tabella);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputSottoreti);
            this.Controls.Add(this.InputHost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputHost;
        private System.Windows.Forms.TextBox InputSottoreti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_tabella;
        private System.Windows.Forms.Button bttn_crea;
    }
}

