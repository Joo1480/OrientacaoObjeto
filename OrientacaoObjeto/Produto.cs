using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto
{
    public class Produto
    {
        private int Id { get; set; }
        private string Descricao { get; set;}
        private decimal Valor { get; set;}

        public Produto(int id, string descricao, decimal valor) 
        { 
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }
        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            if (id > 0)
            {
                Id = id;
            }            
        }

        public string getDescriacao()
        {
            return Descricao;
        }
        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public decimal getValor()
        {
            return Valor;
        }
        public void setValor(decimal valor)
        {
            Valor = valor;
        }
    }
}
