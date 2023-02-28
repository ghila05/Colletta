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


        private void Form1_Load(object sender, EventArgs e)
        {
            if (first)//solo la prima volta che apro il programma
            {
                listView1.View = View.Details;
                listView1.FullRowSelect = true;
                first = false;

                listView1.Columns.Add("UTENTI", 200);
                listView1.Columns.Add("QUOTA", 80);
                

            }


            accounts.Add("NICOLA", 0);
            accounts.Add("FRED", 0);
            accounts.Add("OLPROFESUR", 0);
            accounts.Add("MARCO", 0);


            Stampa();


        }

        public void Stampa()
        {
            listView1.Items.Clear();
            foreach (KeyValuePair<string, double> kvp in accounts)
            {
                ListViewItem item = new ListViewItem(kvp.Key);
                item.SubItems.Add(kvp.Value.ToString());
                listView1.Items.Add(item);

            }
        }
       


        private void button1_Click(object sender, EventArgs e)
        {
            string ut;
            double quota=0;

            ut = textBox1.Text;
            quota = Double.Parse(textBox2.Text);
            if (quota > 0)
            {
                accounts[ut.ToUpper()] += quota;
                Stampa();
            }
            else
            {

                throw new Exception("Quota non valida");
            }
            


        }
    }
}
