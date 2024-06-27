using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metalcoin.Core.Dtos.Request
{
    public class ProdutoCadastarRequest
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Status { get; set; }
        public Guid FornecedorId { get; set; }
        public Guid CategoriaId { get; set; }
    }
}
