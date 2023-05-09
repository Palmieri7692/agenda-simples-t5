using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace agenda_simples_t5
{
    internal class Contato
    {
        // Variáveis locais da classe Contato.
        // Acessíveis apenas pela calsse Contato.
        private string primeiroNome;
        private string sobrenome;
        private string telefone;
        //PROPRIEDADES da classe Contato.
        //Acessíveis per qualquer parte desse programa.
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "00-000000-0000";
                }
            }
        }
        //Constutor da classe 
        public Contato()
        {
            PrimeiroNome = "João";
            Sobrenome = "Da Silva";
            Telefone = "22-988888-8776";
        }

        //Sobrecatga de método
        public Contato(string primeiroNome, string sobrenome, string telefone)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }
        // Sonreescrota do método Tostirng ()
    
        public override string ToString()
        {
            //Melhor utilizar String.Empty invés de "". 
            string saida = String.Empty;
            saida += String.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saida += String.Format("{0}-{1}-{2}", 
                Telefone.Substring(0, 1), 
                Telefone.Substring(2, 6), 
                Telefone.Substring(7, 10));
            return saída;
        }
    }
}   