﻿namespace Colletta
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_quote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Currency = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Txt_search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Combo_Valuta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(347, 34);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(512, 413);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "User:";
            // 
            // Txt_quote
            // 
            this.Txt_quote.Location = new System.Drawing.Point(115, 121);
            this.Txt_quote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_quote.Multiline = true;
            this.Txt_quote.Name = "Txt_quote";
            this.Txt_quote.Size = new System.Drawing.Size(117, 27);
            this.Txt_quote.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quote:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 185);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(731, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOT: 0 ";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(115, 30);
            this.Txt_Nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Nome.Multiline = true;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(121, 27);
            this.Txt_Nome.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Currency:";
            // 
            // comboBox_Currency
            // 
            this.comboBox_Currency.FormattingEnabled = true;
            this.comboBox_Currency.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "JPY"});
            this.comboBox_Currency.Location = new System.Drawing.Point(115, 79);
            this.comboBox_Currency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Currency.Name = "comboBox_Currency";
            this.comboBox_Currency.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Currency.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 462);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "Alphabetical order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(525, 463);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 42);
            this.button4.TabIndex = 14;
            this.button4.Text = "Money order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(164, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 63);
            this.button5.TabIndex = 15;
            this.button5.Text = "SEARCH";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Txt_search
            // 
            this.Txt_search.Location = new System.Drawing.Point(58, 338);
            this.Txt_search.Multiline = true;
            this.Txt_search.Name = "Txt_search";
            this.Txt_search.Size = new System.Drawing.Size(100, 34);
            this.Txt_search.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search from money:";
            // 
            // Combo_Valuta
            // 
            this.Combo_Valuta.FormattingEnabled = true;
            this.Combo_Valuta.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "JPY"});
            this.Combo_Valuta.Location = new System.Drawing.Point(58, 377);
            this.Combo_Valuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Combo_Valuta.Name = "Combo_Valuta";
            this.Combo_Valuta.Size = new System.Drawing.Size(100, 24);
            this.Combo_Valuta.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 516);
            this.Controls.Add(this.Combo_Valuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_search);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox_Currency);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_quote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_quote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Currency;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox Txt_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Combo_Valuta;
    }
}

