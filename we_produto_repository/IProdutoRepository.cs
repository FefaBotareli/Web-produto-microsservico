using web_produto_domain;

namespace we_produto_repository
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> ListarProdutos();

        Task SalvarProduto(Produto produto);
        Task AtualizarProduto(Produto produto);

        Task RemoverProduto(int id);
    }
}