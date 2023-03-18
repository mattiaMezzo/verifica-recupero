using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica1
{
    internal class alunno
    {
        string nome;
        string cognome;
        int eta;
        alunno(string nome, string cognome, int eta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.eta = eta;
        }

        public string toString()
        {
            return nome + cognome + eta.ToString();
        }

        public string annata()
        {
            if (eta <= 16)
            {
                return "biennio";
            }
            else
            {
                return "triennio";
            }
        }
        
        //commento
}
