using Metalcoin.Core.Dtos.Categorias;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;

namespace Metalcoin.Core.Interfaces.Services
{
    public interface IProdutoService
    {
        Task<ProdutoResponse> CadastrarCategoria(ProdutoCadastarRequest produto);
    }
}
