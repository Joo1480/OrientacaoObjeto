using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    internal class Cliente
    {
        private int Id;
        private string Nome;
        private string Telefone;
        private Endereco Endereco;
        public Cliente(int id, string nome, string telefone, Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }
        public string getNome()
        {
            return Nome;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }
        public string getTelefone()
        {
            return Telefone;
        }
        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
        public Endereco getEndereco()
        {
            return Endereco;
        }
        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }
    }
}
