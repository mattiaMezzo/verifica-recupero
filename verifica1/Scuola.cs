using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica1
{
    internal class Scuola
    {
        
            string nome;
            string indirizzo;
            string apertura;
            string chiusura;

            List<alunno>
            alunni = new List<alunno>();

            Scuola(string nome, string indirizzo, string apertura, string chiusura)
            {
                this.nome = nome;
                this.indirizzo = indirizzo;
                this.apertura = apertura;
                this.chiusura = chiusura;
            }

        public void aggiungiAlunno(string nome, string cognome, int eta)
        {
            alunni.Add(nome, cognome, eta);
        }
    }
    
}
