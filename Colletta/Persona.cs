using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colletta
{
    public class Persona
    {
        string nome, cognome, id;

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Id { get; set; }

        Random rnd = new Random();


        public Persona(string nome, string cognome, string id)
        {
            Nome = nome;
            Cognome = cognome;
            Id = nome+cognome+rnd.Next(0,100); 
           
        }
           
        

        public bool Equals(Persona p)
        {
            if (p == null) return false;
            else
            {
                if (p.id == this.Id) return true;
                else return false;
            }


        }

        public override int GetHashCode()
        {
           //da fare
        }

    }
}
