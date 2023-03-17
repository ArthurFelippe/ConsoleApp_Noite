using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Cliente
    {
        private int Id;
        private string Nome;
        private Endereco Endereco;
        private string Telefone;

        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }   

        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public Endereco getEndereco()
        {
            return Endereco;
        }


        public void setNome(string nome)
        {
         

                Nome = nome;
               
    
            }

            public string getNome()
            {
                return Nome;
            }

            public void setId(int id)
            {
            Id = id;
            }

            public int getId()
            {
                return Id;
            }

        }
    }

