using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colletta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool first = true;
        Dictionary<string, string> accounts = new Dictionary<string, string>();


        private void Form1_Load(object sender, EventArgs e)
        {
            if (first)//solo la prima volta che apro il programma
            {
                listView1.View = View.Details;
                listView1.FullRowSelect = true;
                first = false;

                listView1.Columns.Add("UTENTI", 200);
                listView1.Columns.Add("QUOTA", 80);
                listView1.Columns.Add("TOT");

            }


            accounts.Add("NICOLA", "");
            accounts.Add("FRED", "");
            accounts.Add("OLPROFESUR", "");
            accounts.Add("MARCO", "");
            

            Stampa();


        }

        public void Stampa()
        {


            listView1.Items.Clear();
            foreach (KeyValuePair<string, string> kvp in accounts)
            {
                ListViewItem item = new ListViewItem(kvp.Key);
                item.SubItems.Add(kvp.Value);
                //item.SubItems.Add()
                listView1.Items.Add(item);

            }


           
        }
        /*
        public string Somma()
        {
        



        }
       */


        private void button1_Click(object sender, EventArgs e) //button add
        {
            string ut;
            string quota="";


            ut = textBox1.Text;
            
            quota += textBox2.Text;
            quota += ";";
            accounts[ut.ToUpper()] += quota;
            Stampa();
        
        }

        private void button2_Click(object sender, EventArgs e)//button Elimina
        {
            string tot="";
            //acquisisco vaalori del dizionario della riga selezionata
            string ut = listView1.SelectedItems[0].SubItems[0].Text;
            string quote = listView1.SelectedItems[0].SubItems[1].Text;
            MessageBox.Show("quote" + quote);

            string[] q = new string [100];
            q = quote.Split(';');
      
            //ristampo tutte le quote tranne l'ultima
            for(int i=0; i < q.Length - 2; i++)
            {
                tot = tot + q[i] + ";";
            }
 
            accounts[ut] = tot;
            Stampa();

        }
    }
}
