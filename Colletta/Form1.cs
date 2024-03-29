﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Colletta
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool first = true;
        Dictionary<Persona, Soldi> accounts;

        Persona p;
        Soldi s;
        double tot;
        double usd = 0.93;
        double jpy = 0.0070;
        private void Form1_Load(object sender, EventArgs e)
        {
            accounts = new Dictionary<Persona, Soldi>();

            if (first)//solo la prima volta che apro il programma
            {
                listView1.View = View.Details;
                listView1.FullRowSelect = true;
                first = false;

                listView1.Columns.Add("UTENTI", 200);
                listView1.Columns.Add("QUOTA", 100);
                listView1.Columns.Add("VALUTA", 80);

            }

            
        }

        public void Add()
        {
            string v = comboBox_Currency.Text;
            
            ListViewItem item = new ListViewItem(Txt_Nome.Text);
            item.SubItems.Add(Txt_quote.Text);
            item.SubItems.Add(v);
            listView1.Items.Add(item);


            accounts.Add(p, s);

        }

        public void PrintTot() //conversioni
        {
            
            tot = 0;
            foreach (KeyValuePair<Persona, Soldi> kvp in accounts)
            {
               
                if (kvp.Value.Valuta == "EUR")
                {
                    tot += kvp.Value.Importo;
                }
                else if (kvp.Value.Valuta == "USD")
                {
                    tot += kvp.Value.Importo * usd;
                }
                else if (kvp.Value.Valuta == "JPY")
                {
                    tot += kvp.Value.Importo * jpy;
                }
 
            }
           
            label3.Text = ("TOT: "+Convert.ToString(tot));
        }

        private void button1_Click(object sender, EventArgs e) //button add
        {

            p = new Persona(Txt_Nome.Text);
            s = new Soldi(Double.Parse(Txt_quote.Text), Convert.ToString(comboBox_Currency.Text));
          

            Add();
            PrintTot();

        }


        private void button2_Click(object sender, EventArgs e)//button Elimina
        {
            if (String.IsNullOrEmpty(listView1.SelectedItems[0].SubItems[0].Text))
                throw new Exception("Inserire almeno un campo");

            p = new Persona(listView1.SelectedItems[0].SubItems[0].Text);

            accounts.Remove(p);


            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }

            PrintTot();


        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button3_Click_1(object sender, EventArgs e) // ordina alfabeticamentee
        {
            SortedDictionary<Persona, Soldi> temprino = new SortedDictionary<Persona, Soldi>(accounts);
            accounts = new Dictionary<Persona, Soldi>(temprino);


            Update();
        }

        public void Update() // ristampa listview
        {
            listView1.Items.Clear();
            foreach (KeyValuePair<Persona, Soldi> kvp in accounts)
            {
                string[] val = new string[] { Convert.ToString(kvp.Key.Nome), Convert.ToString(kvp.Value.Importo), kvp.Value.Valuta };

                ListViewItem item = new ListViewItem(val);
                listView1.Items.Add(item);

                
            }
        }

        private void button4_Click(object sender, EventArgs e) // ordina secondo l'importo
        {

            Dictionary<Persona, Soldi> tmp = new Dictionary<Persona, Soldi>();

            foreach (KeyValuePair<Persona, Soldi> val in accounts.OrderByDescending(x => x.Value.Importo))
            {
                tmp[val.Key] = val.Value;
            }
            accounts = new Dictionary<Persona, Soldi>(tmp);
            Update();
        }

        private void button5_Click(object sender, EventArgs e)// cerca utente che ha versato una certa valuta
        {
            if (String.IsNullOrEmpty(Txt_search.Text) || String.IsNullOrEmpty(Combo_Valuta.Text))
                throw new Exception("Inserire un prezzo valido");

            s = new Soldi(Double.Parse(Txt_search.Text), Combo_Valuta.Text);
            foreach (KeyValuePair<Persona, Soldi> kvp in accounts)
            {
                if (kvp.Value.Importo == s.Importo)
                {
                    if(kvp.Value.Valuta == s.Valuta)
                    {
                        
                        MessageBox.Show("La persona trovata è "+kvp.Key.Nome);
                        return;
                    }
                }


            }
            MessageBox.Show("nessun utente trovato");
        }
    }
}
