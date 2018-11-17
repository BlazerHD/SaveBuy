namespace SaveBuy
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bEinnahme = new System.Windows.Forms.Button();
            this.bAusgabe = new System.Windows.Forms.Button();
            this.eingabe1 = new System.Windows.Forms.TextBox();
            this.lBetrag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bEinnahme
            // 
            this.bEinnahme.Location = new System.Drawing.Point(64, 307);
            this.bEinnahme.Name = "bEinnahme";
            this.bEinnahme.Size = new System.Drawing.Size(94, 36);
            this.bEinnahme.TabIndex = 0;
            this.bEinnahme.Text = "Einnahme";
            this.bEinnahme.UseVisualStyleBackColor = true;
            this.bEinnahme.Click += new System.EventHandler(this.bEinnahme_Click);
            // 
            // bAusgabe
            // 
            this.bAusgabe.Location = new System.Drawing.Point(274, 307);
            this.bAusgabe.Name = "bAusgabe";
            this.bAusgabe.Size = new System.Drawing.Size(87, 36);
            this.bAusgabe.TabIndex = 1;
            this.bAusgabe.Text = "Ausgabe";
            this.bAusgabe.UseVisualStyleBackColor = true;
            this.bAusgabe.Click += new System.EventHandler(this.bAusgabe_Click);
            // 
            // eingabe1
            // 
            this.eingabe1.Location = new System.Drawing.Point(152, 222);
            this.eingabe1.Name = "eingabe1";
            this.eingabe1.Size = new System.Drawing.Size(128, 22);
            this.eingabe1.TabIndex = 2;
            this.eingabe1.TextChanged += new System.EventHandler(this.eingabe1_TextChanged);
            // 
            // lBetrag
            // 
            this.lBetrag.AutoSize = true;
            this.lBetrag.Location = new System.Drawing.Point(151, 160);
            this.lBetrag.Name = "lBetrag";
            this.lBetrag.Size = new System.Drawing.Size(16, 17);
            this.lBetrag.TabIndex = 3;
            this.lBetrag.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kontostand:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 555);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBetrag);
            this.Controls.Add(this.eingabe1);
            this.Controls.Add(this.bAusgabe);
            this.Controls.Add(this.bEinnahme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SaveBuy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEinnahme;
        private System.Windows.Forms.Button bAusgabe;
        private System.Windows.Forms.TextBox eingabe1;
        private System.Windows.Forms.Label lBetrag;
        private System.Windows.Forms.Label label1;
    }
}

