﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    public class Endereco
    {
        private string Rua;
        private string Numero;
        private string Cep;
        private string Bairro;
        private string Cidade;
        private string Estado;

        public Endereco(string rua, string numero, string cep, string bairro, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
        public string getRua()
        {
            return Rua;
        }
        public void setRua(string rua)
        {
            Rua = rua;
        }
        public string getNumero()
        {
            return Numero;
        }
        public void setNumero(string numero)
        {
            Numero = numero;
        }
        public string getCep()
        {
            return Cep;
        }
        public void setCep(string cep)
        {
            Cep = cep;
        }
        public string getBairro() 
        {
            return Bairro;
        }   
        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }
        public string getCidade() 
        { 
            return Cidade;
        }
        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }
        public string getEstado() 
        {
            return Estado;
        }
        public void setEstado(string estado)
        {
            Estado = estado;
        }
    }
}
