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
        Dictionary<string, double> accounts = new Dictionary<string, double>();


        Dictionary<Persona, Soldi> account = new Dictionary<Persona, Soldi>();

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


            }


            accounts.Add("NICOLA", 0);
            accounts.Add("FRED", 0);
            accounts.Add("OLPROFESUR", 0);
            accounts.Add("MARCO", 0);
            



        }

        public void Add()
        {
            ListViewItem item = new ListViewItem(comboBox1.Text);
            item.SubItems.Add(textBox2.Text);
            listView1.Items.Add(item);
            PrintTot();   
        }

        public void PrintTot()
        {
            tot = 0;
            foreach (KeyValuePair<string, double> kvp in accounts)
            {
                //MessageBox.Show(Convert.ToString(kvp.Value));
                tot += kvp.Value;
            }

            label3.Text = ("TOT: "+Convert.ToString(tot));
        }

        private void button1_Click(object sender, EventArgs e) //button add
        {
            string ut="";
            string quota="";
            ut = comboBox1.Text;
            quota += textBox2.Text;
            if (Double.Parse(quota) < 0)
            {
                throw new Exception("invalid value");
            }
            accounts[ut] += Double.Parse(quota);

            Add();


        }


        private void button2_Click(object sender, EventArgs e)//button Elimina
        {
            string tot="";
            string ut = listView1.SelectedItems[0].SubItems[0].Text;
            string quote = listView1.SelectedItems[0].SubItems[1].Text;


            accounts[ut] -= Double.Parse(quote);


            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }

            PrintTot();





        }

        private void button3_Click(object sender, EventArgs e)//modifica
        {
            string ut = listView1.SelectedItems[0].SubItems[0].Text;
            double quote = Double.Parse(listView1.SelectedItems[0].SubItems[1].Text);
            double newq = 0;
            newq = Double.Parse(textBox2.Text);
            if (newq < 0)
            {
                throw new Exception("invalid value");
            }

            quote -= newq;

            //MessageBox.Show(Convert.ToString(quote));

            if (quote < 0)
            {
                accounts[ut] += (-quote);
            }
            else
            {
                accounts[ut] -= quote;
            }


            listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;




            PrintTot();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ut = listView1.SelectedItems[0].SubItems[0].Text;
            string quote = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox1.Text = ut;
            textBox2.Text = quote;
        }
    }
}
