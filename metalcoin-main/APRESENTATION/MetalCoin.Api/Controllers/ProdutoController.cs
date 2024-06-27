using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MetalCoin.Api.Controllers
{
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositories _produtoRepositories;

        public ProdutoController(IProdutoRepositories produtoRepositories) {
            _produtoRepositories = produtoRepositories;

        }

        [HttpGet]
        [Route ("TodosProdutos")]
        public async Task<ActionResult> ObterProduto() {
            var listarProduto = await _produtoRepositories.ObterTodos();

            if (listarProduto.Count == 0) {
                return NoContent();
            }
            return Ok(listarProduto);
        }

        [HttpPost]
        [Route ("CadastrarProdutos")]
        public Task<Produto> CadastarProduto([FromBody] ProdutoCadastarRequest produto) {
            

        }
    }
}
