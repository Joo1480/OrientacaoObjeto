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
        private int Id { get; set; }
        private string Nome { get; set; }       
        private string Telefone { get; set;}
        public Cliente(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
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
    }
}
