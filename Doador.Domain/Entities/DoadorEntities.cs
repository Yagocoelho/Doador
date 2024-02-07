using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doador.Domain.Entities
{
    public class Doador
    {
        public Doador()
        {

        }


        public int DoadorId { get; set; }
        public string DoadorNome { get; set; }
        public string Cidade { get; set; }
        public string estado { get; set; }
        public int Email { get; set; }
        public int Telefone { get; set; }
        public int Cep { get; set; }
    
    }


    
}
