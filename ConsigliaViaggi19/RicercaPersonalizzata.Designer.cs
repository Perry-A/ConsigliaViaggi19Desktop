namespace ConsigliaViaggi19
{
    partial class RicercaPersonalizzata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RicercaPersonalizzata));
            this.mvMin = new System.Windows.Forms.Label();
            this.mvMax = new System.Windows.Forms.Label();
            this.comboBoxMin = new System.Windows.Forms.ComboBox();
            this.comboBoxMax = new System.Windows.Forms.ComboBox();
            this.city = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.applica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mvMin
            // 
            this.mvMin.AutoSize = true;
            this.mvMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvMin.Location = new System.Drawing.Point(79, 182);
            this.mvMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mvMin.Name = "mvMin";
            this.mvMin.Size = new System.Drawing.Size(202, 20);
            this.mvMin.TabIndex = 0;
            this.mvMin.Text = "Media valutazione minima";
            // 
            // mvMax
            // 
            this.mvMax.AutoSize = true;
            this.mvMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvMax.Location = new System.Drawing.Point(79, 257);
            this.mvMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mvMax.Name = "mvMax";
            this.mvMax.Size = new System.Drawing.Size(216, 20);
            this.mvMax.TabIndex = 1;
            this.mvMax.Text = "Media valutazione massima";
            // 
            // comboBoxMin
            // 
            this.comboBoxMin.FormattingEnabled = true;
            this.comboBoxMin.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxMin.Location = new System.Drawing.Point(423, 176);
            this.comboBoxMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMin.Name = "comboBoxMin";
            this.comboBoxMin.Size = new System.Drawing.Size(61, 24);
            this.comboBoxMin.TabIndex = 2;
            this.comboBoxMin.Text = "1";
            this.comboBoxMin.SelectedIndexChanged += new System.EventHandler(this.comboBoxMin_SelectedIndexChanged);
            // 
            // comboBoxMax
            // 
            this.comboBoxMax.FormattingEnabled = true;
            this.comboBoxMax.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxMax.Location = new System.Drawing.Point(423, 251);
            this.comboBoxMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMax.Name = "comboBoxMax";
            this.comboBoxMax.Size = new System.Drawing.Size(61, 24);
            this.comboBoxMax.TabIndex = 3;
            this.comboBoxMax.Text = "5";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(79, 332);
            this.city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(44, 20);
            this.city.TabIndex = 4;
            this.city.Text = "Città";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 327);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 22);
            this.textBox1.TabIndex = 5;
            // 
            // applica
            // 
            this.applica.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.applica.Location = new System.Drawing.Point(227, 448);
            this.applica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applica.Name = "applica";
            this.applica.Size = new System.Drawing.Size(156, 57);
            this.applica.TabIndex = 6;
            this.applica.Text = "Applica";
            this.applica.UseVisualStyleBackColor = true;
            this.applica.Click += new System.EventHandler(this.applica_Click);
            // 
            // RicercaPersonalizzata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 671);
            this.Controls.Add(this.applica);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.city);
            this.Controls.Add(this.comboBoxMax);
            this.Controls.Add(this.comboBoxMin);
            this.Controls.Add(this.mvMax);
            this.Controls.Add(this.mvMin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RicercaPersonalizzata";
            this.Text = "RicercaPersonalizzata";
            this.Load += new System.EventHandler(this.RicercaPersonalizzata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mvMin;
        private System.Windows.Forms.Label mvMax;
        private System.Windows.Forms.ComboBox comboBoxMin;
        private System.Windows.Forms.ComboBox comboBoxMax;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button applica;
    }
}