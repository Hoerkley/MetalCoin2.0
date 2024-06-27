using Metalcoin.Core.Abstracts;

namespace Metalcoin.Core.Domain
{
    public class Produto : Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

        public bool Status { get; set; }

        /* EF Relation */
        public Guid FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set;}

    }
}
