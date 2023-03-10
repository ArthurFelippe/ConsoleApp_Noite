using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Produto
    {
        private int Id;
        private decimal Valor;
        public string Descricao;

        public Produto(int id, decimal valor,  string descricao)
        {

            Id = id;
            Descricao = descricao;
            Valor = valor;
        }
        public string getDescricao()
        {
            return Descricao;
        }

        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }

       

        public string getId()
        {
            return Id;
        }

        public void setId(string id)
        {
            Id = id;
        }

        public string getValor()
        {
            return Valor;
        }

         public void setValor(decimal valor)
        {
            Valor = valor;
        }

    }
}
