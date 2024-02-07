using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Entities
{
    public class ProdutoEntities
    {
        public ProdutoEntities()
        {

        }
        

        


        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string DisponibilidadeAdocao { get; set; }
        public string DoadorId { get; set; }
    }
}
