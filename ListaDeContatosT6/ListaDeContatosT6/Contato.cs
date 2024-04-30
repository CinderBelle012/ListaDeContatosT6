using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContatosT6
{
    internal class Contato
    {
        private string nome;
        private string sobrenome;
        private string telefone;

        //Propriedades. São os metodos "get"  e "set"
        // get = leitura
        //set = definição
        // é possivel ser somente leitura, ou somente definição...
        public string Nome
        {

            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }

        }
        public string Sobrenome
        {

            get
            {
                return sobrenome;
            }
            set
            {
                sobrenome = value;
            }


        }
        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "11999999999";
                }
            }
        }

        public Contato()
        {
            Nome = "Claudia";
            Sobrenome = "Genésio II";
            Telefone = "11999999999";
            
        }

        //Sobrecarga do método construtor 

        public Contato (string nome, string sobrenome, string telefone)
        {
            Nome = nome;    
            Sobrenome = sobrenome;  
            Telefone = telefone;   
        }
        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0} {1}", Nome, Sobrenome);
            saida += String.Format("({0}) {1}-{2}",
                Telefone.Substring(0, 2),
                Telefone.Substring(2, 5),
                Telefone.Substring(7, 4));


            return saida;
        }
    }
   
}



















