using JobMercadoLivre.Request;
using JobMercadoLivre.Request.Pedidos;
using JobMercadoLivre.Request.Produtos;
using JobMercadoLivre.Request.Produtos.Garantia;
using Microsoft.AspNetCore.Mvc;

namespace JobMercadoLivre.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        public void Autenticacao()
        {
            Token.TokenML();
            ////////Token.Gerar_Conta_teste();

            ////Produto
            //Produto.AddNovoProtudo();
            //Editar_Preco.EditarPreco();
            //Editar_Estoque.EditarQuantidadeEstoque();
            //Editar_Categoria.AlterarCategoriaDoProduto();
            //Editar_Titulo.AlterarTituloAnuncio();
            //Editar_Unidade_Marca.AlterarUnidadeEmarca();
            //Editar_Video.AlterarVideo();
            //Sem_Garantia.SemGarantia();
            //Fabricante_e_Vendedor.AlterarGarantiaFabricanteEvendedor();


            ////Pedido
            //GET.Buscar_Os_Pedidos_De_Um_Vendedor();
            //GET.ChecarSaldoEmConta();
            //GET.ConsultarDadosPessoais();
            //GET.NotasDeOrdem();
            //GET.Ordem();
            //GET.PagamentosAceitosPeloVendedor();
            //GET.PedidoMLB();
        }
    }
}