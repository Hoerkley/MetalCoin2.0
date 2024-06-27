using Metalcoin.Core.Domain;
using Metalcoin.Core.Dtos.Request;
using Metalcoin.Core.Dtos.Response;
using Metalcoin.Core.Interfaces.Repositories;
using Metalcoin.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalCoin.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepositories _produtoRepositories;

        public ProdutoService(IProdutoRepositories produtoRepositories) {
            _produtoRepositories = produtoRepositories;
        }
        public async Task<ProdutoResponse> CadastrarCategoria(ProdutoCadastarRequest produto) {
            var produtoExiste = await _produtoRepositories.BuscarPorNome(produto.Nome);

            if (produtoExiste != null) {
                return null;
            }

            var produtoEntidade = new Produto
            {
                Nome = produto.Nome,
                Descricao = produto.Descricao,
                Valor = produto.Valor,
                DataCadastro = DateTime.Now,
                DataAlteracao = Convert.ToDateTime(0),
                Status = produto.Status,
                CategoriaId = produto.CategoriaId,
                FornecedorId = produto.FornecedorId,
            };

            await _produtoRepositories.Adicionar(produtoEntidade);
            var response = new ProdutoResponse
            {
                Id = produtoEntidade.Id,
                Nome = produtoEntidade.Nome,
                Descricao = produtoEntidade.Descricao,
                Valor = produtoEntidade.Valor,
                DataCadastro = DateTime.Now,
                DataAlteracao = Convert.ToDateTime(0),
                Status = produtoEntidade.Status,
                CategoriaId = produtoEntidade.CategoriaId,
                FornecedorId = produtoEntidade.FornecedorId
            };
            return response;
        }
    }
}
