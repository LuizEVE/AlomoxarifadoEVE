using AlmoxarifadoBackAPI.DTO;
using AlmoxarifadoBackAPI.Models;
using AlmoxarifadoBackAPI.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlmoxarifadoBackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepositorio _db;
        public ProdutoController(IProdutoRepositorio db)
        {
            _db = db;

        }

        [HttpGet("/listaProdutos")]
        public IActionResult listaCategorias()
        {
            return Ok(_db.GetAll());
        }

        [HttpPost("/Produtos")]
        public IActionResult listaCategorias(ProdutoDTO produto)
        {
            return Ok(_db.GetAll().Where(x=>x.IdProduto==produto.IdProduto));
        }

        [HttpPost("/criarProduto")]
        public IActionResult criarProduto(ProdutoCadastroDTO produto)
        {

            var novoProduto = new Produto()
            {
                Descricao = produto.Descricao,
                UnMdedida = produto.UnMdedida,
                EPermanente = produto.EPermanente,
                EstoqueAtual = produto.EstoqueAtual,
                PrecoProduto = produto.PrecoProduto,
                IdCategoria = produto.IdCategoria
            };
            //_categorias.Add(novaCategoria);
            _db.Add(novoProduto);
            return Ok("Cadastro com Sucesso");
        }

        //[HttpDelete("/removercategoria")]
        //public IActionResult removerCategorias(CategoriaDTO categoria)
        //{
        //    var itemPesquisado = _categorias.FirstOrDefault(x => x.Codigo == categoria.Codigo);

        //    if (itemPesquisado != null)
        //    {
        //        _categorias.Remove(itemPesquisado);
        //        return Ok("Removido com sucesso");
        //    }
        //    else
        //    {
        //        return Ok("Produdo não localizado");
        //    }

            
        //}



    }
}
