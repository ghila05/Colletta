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
        Dictionary<Persona, double> accounts = new Dictionary<Persona, double>();


        Persona p;
        Soldi s;


        double tot;

        private void Form1_Load(object sender, EventArgs e)
        {

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


            
            accounts.Add(p, s.importo);


        }

        public void PrintTot()
        {

            //da riusare
            tot = 0;
            foreach (KeyValuePair<Persona, double> kvp in accounts)
            {
                //MessageBox.Show(Convert.ToString(kvp.Value));
                tot += kvp.Value;
            }

            label3.Text = ("TOT: "+Convert.ToString(tot));
        }

        private void button1_Click(object sender, EventArgs e) //button add
        {

            p = new Persona(Txt_Nome.Text);
            s = new Soldi(Double.Parse(Txt_quote.Text), Convert.ToString(comboBox_Currency.Text));


            Add();

        }


        private void button2_Click(object sender, EventArgs e)//button Elimina
        {
            p = new Persona(listView1.SelectedItems[0].SubItems[0].Text);

            accounts.Remove(p);


            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }

            //PrintTot();





        }

        private void button3_Click(object sender, EventArgs e)//modifica
        {
            string ut = listView1.SelectedItems[0].SubItems[0].Text;
            double quote = Double.Parse(listView1.SelectedItems[0].SubItems[1].Text);
            double newq = 0;
            newq = Double.Parse(Txt_quote.Text);
            if (newq < 0)
            {
                throw new Exception("invalid value");
            }

            quote -= newq;

            //MessageBox.Show(Convert.ToString(quote));

            if (quote < 0)
            {
//accounts[ut] += (-quote);
            }
            else
            {
  //              accounts[ut] -= quote;
            }


            listView1.SelectedItems[0].SubItems[1].Text = Txt_quote.Text;




            PrintTot();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_Nome.Text = listView1.SelectedItems[0].SubItems[0].Text;
            Txt_quote.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox_Currency.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
