﻿namespace ConsigliaViaggi19
{
    partial class MenuPrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipale));
            this.tipiStruttureComboBox = new System.Windows.Forms.ComboBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cercaButton = new System.Windows.Forms.Button();
            this.ricercaPersonalizzataLinkLabel = new System.Windows.Forms.LinkLabel();
            this.notificheButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.struttureListView = new System.Windows.Forms.ListView();
            this.immagineColonna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.infoStrutturaColonna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dettagliStrutturaColonna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tipiStruttureComboBox
            // 
            this.tipiStruttureComboBox.FormattingEnabled = true;
            this.tipiStruttureComboBox.Items.AddRange(new object[] {
            "Tutte le Categorie",
            "Hotel",
            "Ristorante",
            "Attrazioni"});
            this.tipiStruttureComboBox.Location = new System.Drawing.Point(10, 11);
            this.tipiStruttureComboBox.Name = "tipiStruttureComboBox";
            this.tipiStruttureComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipiStruttureComboBox.TabIndex = 0;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(136, 12);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // cercaButton
            // 
            this.cercaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cercaButton.BackgroundImage")));
            this.cercaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cercaButton.Location = new System.Drawing.Point(255, 11);
            this.cercaButton.Name = "cercaButton";
            this.cercaButton.Size = new System.Drawing.Size(25, 21);
            this.cercaButton.TabIndex = 3;
            this.cercaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cercaButton.UseVisualStyleBackColor = true;
            // 
            // ricercaPersonalizzataLinkLabel
            // 
            this.ricercaPersonalizzataLinkLabel.AutoSize = true;
            this.ricercaPersonalizzataLinkLabel.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ricercaPersonalizzataLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.ricercaPersonalizzataLinkLabel.Location = new System.Drawing.Point(285, 15);
            this.ricercaPersonalizzataLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ricercaPersonalizzataLinkLabel.Name = "ricercaPersonalizzataLinkLabel";
            this.ricercaPersonalizzataLinkLabel.Size = new System.Drawing.Size(135, 13);
            this.ricercaPersonalizzataLinkLabel.TabIndex = 4;
            this.ricercaPersonalizzataLinkLabel.TabStop = true;
            this.ricercaPersonalizzataLinkLabel.Text = "Ricerca Personalizzata";
            // 
            // notificheButton
            // 
            this.notificheButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notificheButton.Location = new System.Drawing.Point(470, 11);
            this.notificheButton.Name = "notificheButton";
            this.notificheButton.Size = new System.Drawing.Size(75, 23);
            this.notificheButton.TabIndex = 7;
            this.notificheButton.Text = "Notifiche";
            this.notificheButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Location = new System.Drawing.Point(562, 11);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(100, 23);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // struttureListView
            // 
            this.struttureListView.BackColor = System.Drawing.Color.LimeGreen;
            this.struttureListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.immagineColonna,
            this.infoStrutturaColonna,
            this.dettagliStrutturaColonna});
            this.struttureListView.FullRowSelect = true;
            this.struttureListView.HideSelection = false;
            this.struttureListView.Location = new System.Drawing.Point(11, 56);
            this.struttureListView.Margin = new System.Windows.Forms.Padding(2);
            this.struttureListView.Name = "struttureListView";
            this.struttureListView.Size = new System.Drawing.Size(651, 430);
            this.struttureListView.TabIndex = 9;
            this.struttureListView.UseCompatibleStateImageBehavior = false;
            this.struttureListView.View = System.Windows.Forms.View.Details;
            // 
            // immagineColonna
            // 
            this.immagineColonna.Text = "Immagine";
            this.immagineColonna.Width = 122;
            // 
            // infoStrutturaColonna
            // 
            this.infoStrutturaColonna.Text = "Info";
            this.infoStrutturaColonna.Width = 311;
            // 
            // dettagliStrutturaColonna
            // 
            this.dettagliStrutturaColonna.Text = "Dettagli";
            this.dettagliStrutturaColonna.Width = 245;
            // 
            // MenuPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(683, 497);
            this.Controls.Add(this.struttureListView);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.notificheButton);
            this.Controls.Add(this.tipiStruttureComboBox);
            this.Controls.Add(this.ricercaPersonalizzataLinkLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.cercaButton);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(698, 534);
            this.Name = "MenuPrincipale";
            this.Text = "ConsigliaViaggi19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tipiStruttureComboBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Button cercaButton;
        private System.Windows.Forms.LinkLabel ricercaPersonalizzataLinkLabel;
        private System.Windows.Forms.Button notificheButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListView struttureListView;
        private System.Windows.Forms.ColumnHeader immagineColonna;
        private System.Windows.Forms.ColumnHeader infoStrutturaColonna;
        private System.Windows.Forms.ColumnHeader dettagliStrutturaColonna;
    }
}