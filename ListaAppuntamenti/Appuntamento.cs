using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    internal class Appuntamento
    {

        public DateTime dataAppuntamento;
        public DateTime dataOdierna = new DateTime();
        public string nome;
        public string Cognome;
        public string titoloAppuntamento;
        public string luogoAppuntamento;


        public Appuntamento(string nome, string Cognome, string titoloAppuntamento, string luogoAppuntamento, DateTime dataAppuntamento)
        {
            this.nome = nome;
            this.Cognome = Cognome;
            this.titoloAppuntamento = titoloAppuntamento;
            this.luogoAppuntamento = luogoAppuntamento;
            this.dataAppuntamento = dataAppuntamento;
            this.dataOdierna = dataOdierna;
            
        }

        
        public DateTime setcambiaAppuntamento()
        {
            DateTime nuovaData = new DateTime();
        }
        public string getnome()
        {
            return nome;
        }
        public string getCognome()
        {
            return Cognome;
        }
        public string gettitoloAppuntamento()
        {
            return titoloAppuntamento;
        }
        public string getluogoAppuntamento()
        {
            return luogoAppuntamento;   
        }
        public DateTime getdataAppuntamento()
        {
            return dataAppuntamento;
        }
        
        public virtual void ToString()
        {
            Console.WriteLine(nome);
            Console.WriteLine(Cognome);
            Console.WriteLine(titoloAppuntamento);
            Console.WriteLine(luogoAppuntamento);
            Console.WriteLine(dataAppuntamento);
            
        }
        
    }
}
