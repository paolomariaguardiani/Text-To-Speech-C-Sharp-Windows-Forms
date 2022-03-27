namespace TextToSpeech
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labIstruzioni = new System.Windows.Forms.Label();
            this.testoDaAscoltare = new System.Windows.Forms.TextBox();
            this.btnAscolta = new System.Windows.Forms.Button();
            this.btnCancella = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.btnRiprendi = new System.Windows.Forms.Button();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.comboBoxVoci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnPaste = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // labIstruzioni
            // 
            this.labIstruzioni.AutoSize = true;
            this.labIstruzioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labIstruzioni.Location = new System.Drawing.Point(191, 15);
            this.labIstruzioni.Name = "labIstruzioni";
            this.labIstruzioni.Size = new System.Drawing.Size(424, 20);
            this.labIstruzioni.TabIndex = 0;
            this.labIstruzioni.Text = "INSERISCI QUI SOTTO IL TESTO DA ASCOLTARE";
            // 
            // testoDaAscoltare
            // 
            this.testoDaAscoltare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testoDaAscoltare.Location = new System.Drawing.Point(31, 108);
            this.testoDaAscoltare.Multiline = true;
            this.testoDaAscoltare.Name = "testoDaAscoltare";
            this.testoDaAscoltare.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.testoDaAscoltare.Size = new System.Drawing.Size(743, 288);
            this.testoDaAscoltare.TabIndex = 1;
            // 
            // btnAscolta
            // 
            this.btnAscolta.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAscolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscolta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAscolta.Location = new System.Drawing.Point(31, 430);
            this.btnAscolta.Name = "btnAscolta";
            this.btnAscolta.Size = new System.Drawing.Size(116, 41);
            this.btnAscolta.TabIndex = 2;
            this.btnAscolta.Text = "ASCOLTA";
            this.btnAscolta.UseVisualStyleBackColor = false;
            this.btnAscolta.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCancella
            // 
            this.btnCancella.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancella.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancella.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancella.Location = new System.Drawing.Point(519, 430);
            this.btnCancella.Name = "btnCancella";
            this.btnCancella.Size = new System.Drawing.Size(116, 41);
            this.btnCancella.TabIndex = 3;
            this.btnCancella.Text = "CANCELLA";
            this.btnCancella.UseVisualStyleBackColor = false;
            this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPausa.Location = new System.Drawing.Point(153, 430);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(116, 41);
            this.btnPausa.TabIndex = 4;
            this.btnPausa.Text = "PAUSA";
            this.btnPausa.UseVisualStyleBackColor = false;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // btnRiprendi
            // 
            this.btnRiprendi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRiprendi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRiprendi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRiprendi.Location = new System.Drawing.Point(275, 430);
            this.btnRiprendi.Name = "btnRiprendi";
            this.btnRiprendi.Size = new System.Drawing.Size(116, 41);
            this.btnRiprendi.TabIndex = 6;
            this.btnRiprendi.Text = "RIPRENDI";
            this.btnRiprendi.UseVisualStyleBackColor = false;
            this.btnRiprendi.Click += new System.EventHandler(this.btnRiprendi_Click);
            // 
            // btnRegistra
            // 
            this.btnRegistra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistra.Location = new System.Drawing.Point(397, 430);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(116, 41);
            this.btnRegistra.TabIndex = 7;
            this.btnRegistra.Text = "REGISTRA";
            this.btnRegistra.UseVisualStyleBackColor = false;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEsci.Location = new System.Drawing.Point(658, 430);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(116, 41);
            this.btnEsci.TabIndex = 9;
            this.btnEsci.Text = "ESCI";
            this.btnEsci.UseVisualStyleBackColor = false;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // comboBoxVoci
            // 
            this.comboBoxVoci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoci.FormattingEnabled = true;
            this.comboBoxVoci.Location = new System.Drawing.Point(351, 503);
            this.comboBoxVoci.Name = "comboBoxVoci";
            this.comboBoxVoci.Size = new System.Drawing.Size(423, 21);
            this.comboBoxVoci.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "SELEZIONA LA LINGUA INSTALLATA";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(35, 549);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(112, 20);
            this.lblVolume.TabIndex = 14;
            this.lblVolume.Text = "VOLUME = 80";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(234, 540);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(238, 45);
            this.trackBarVolume.TabIndex = 15;
            this.trackBarVolume.TickFrequency = 5;
            this.trackBarVolume.Value = 80;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 1;
            this.trackBarSpeed.Location = new System.Drawing.Point(234, 591);
            this.trackBarSpeed.Maximum = 5;
            this.trackBarSpeed.Minimum = -5;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(238, 45);
            this.trackBarSpeed.TabIndex = 17;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(35, 591);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(117, 20);
            this.lblSpeed.TabIndex = 16;
            this.lblSpeed.Text = "VELOCITA\' = 0";
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.SystemColors.Info;
            this.btnPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaste.Image = global::TextToSpeech.Properties.Resources.clipboard1_piccola;
            this.btnPaste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaste.Location = new System.Drawing.Point(31, 41);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(121, 61);
            this.btnPaste.TabIndex = 18;
            this.btnPaste.Text = "INCOLLA";
            this.btnPaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVoci);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.btnRiprendi);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnCancella);
            this.Controls.Add(this.btnAscolta);
            this.Controls.Add(this.testoDaAscoltare);
            this.Controls.Add(this.labIstruzioni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text To Speech";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labIstruzioni;
        private System.Windows.Forms.TextBox testoDaAscoltare;
        private System.Windows.Forms.Button btnAscolta;
        private System.Windows.Forms.Button btnCancella;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Button btnRiprendi;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.ComboBox comboBoxVoci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button btnPaste;
    }
}

