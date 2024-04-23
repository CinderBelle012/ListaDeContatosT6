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
                if (value.Length == 13)
                {
                    telefone = value;
                }
                else
                {
                    Telefone = "(00) 0000-0000";
                }
            }
        }

        public Contato()
        {
            Nome = "Claudia";
            Sobrenome = "Genésio II";
            Telefone = "11 4002-8922";
            
        }
    }
}



















