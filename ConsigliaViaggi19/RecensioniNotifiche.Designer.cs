namespace ConsigliaViaggi19
{
    partial class RecensioniNotifiche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecensioniNotifiche));
            this.comboBoxOrdina = new System.Windows.Forms.ComboBox();
            this.Aggiorna = new System.Windows.Forms.Button();
            this.menuPrincipale = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.immagineUtenteListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titoloValutazioneRecensioneListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.commentoRecensioneListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxOrdina
            // 
            this.comboBoxOrdina.FormattingEnabled = true;
            this.comboBoxOrdina.Items.AddRange(new object[] {
            "Tutte",
            "Dal più recente",
            "Dal meno recente"});
            this.comboBoxOrdina.Location = new System.Drawing.Point(16, 10);
            this.comboBoxOrdina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxOrdina.Name = "comboBoxOrdina";
            this.comboBoxOrdina.Size = new System.Drawing.Size(160, 24);
            this.comboBoxOrdina.TabIndex = 1;
            this.comboBoxOrdina.Text = "Ordina";
            // 
            // Aggiorna
            // 
            this.Aggiorna.Location = new System.Drawing.Point(185, 7);
            this.Aggiorna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Aggiorna.Name = "Aggiorna";
            this.Aggiorna.Size = new System.Drawing.Size(100, 28);
            this.Aggiorna.TabIndex = 2;
            this.Aggiorna.Text = "Aggiorna";
            this.Aggiorna.UseVisualStyleBackColor = true;
            // 
            // menuPrincipale
            // 
            this.menuPrincipale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuPrincipale.Location = new System.Drawing.Point(919, 7);
            this.menuPrincipale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPrincipale.Name = "menuPrincipale";
            this.menuPrincipale.Size = new System.Drawing.Size(165, 27);
            this.menuPrincipale.TabIndex = 3;
            this.menuPrincipale.Text = "Menu Principale";
            this.menuPrincipale.UseVisualStyleBackColor = true;
            this.menuPrincipale.Click += new System.EventHandler(this.menuPrincipale_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(1, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1108, 716);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.Yellow;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.immagineUtenteListView,
            this.titoloValutazioneRecensioneListView,
            this.commentoRecensioneListView});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-4, 11);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1112, 705);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // immagineUtenteListView
            // 
            this.immagineUtenteListView.Text = "immagineUtenteListView";
            this.immagineUtenteListView.Width = 168;
            // 
            // titoloValutazioneRecensioneListView
            // 
            this.titoloValutazioneRecensioneListView.Text = "titoloValutazioneRecensioneListView";
            this.titoloValutazioneRecensioneListView.Width = 257;
            // 
            // commentoRecensioneListView
            // 
            this.commentoRecensioneListView.Text = "commentoRecensioneListView";
            this.commentoRecensioneListView.Width = 280;
            // 
            // RecensioniNotifiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1107, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuPrincipale);
            this.Controls.Add(this.Aggiorna);
            this.Controls.Add(this.comboBoxOrdina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(525, 574);
            this.Name = "RecensioniNotifiche";
            this.Text = "ConsigliaViaggi19 - Notifiche";
            this.Load += new System.EventHandler(this.RecensioniNotifiche_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxOrdina;
        private System.Windows.Forms.Button Aggiorna;
        private System.Windows.Forms.Button menuPrincipale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader immagineUtenteListView;
        private System.Windows.Forms.ColumnHeader titoloValutazioneRecensioneListView;
        private System.Windows.Forms.ColumnHeader commentoRecensioneListView;
    }
}