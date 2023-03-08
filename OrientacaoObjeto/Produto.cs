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
    }
}
