﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite
{
    public class Endereco
    {
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Cep;
        private string Cidade;
        private string Estado;

        public Endereco(string rua, string numero, string bairro, string cep, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
        }

        public string EnderecoCompleto()
        {
            return Rua + ", " + Numero + "Bairro: " + Bairro + "Cidade: " + Cidade + "/" + Estado;
        }


        public void setRua(string rua) {  Rua = rua; }
        public void setNumero(string numero) { Numero = numero; }
        
        public void setBairro(string bairro) {  Bairro = bairro; }

        public void setCep(string cep) {  Cep = cep; }

        public void setCidade (string cidade) {  Cidade = cidade; }

        public void setEstado(string estado) {  Estado = estado; }



        public string getRua() { return  Rua; }
        public string getNumero() { return  Numero; }

        public string getBairro() { return Bairro; }

        public string getCep() { return Cep; }

        public string getCidade() { return Cidade; }

        public string getEstado() { return Estado; }

        public void InserirNoBanco(Endereco endereco)
        {
            //db.ENDERECO.ADD(endereco)
            //db.savechanges(); 
        }


    }
}
