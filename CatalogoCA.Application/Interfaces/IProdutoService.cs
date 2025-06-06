using CatalogoCA.Application.DTOs;

namespace CatalogoCA.Application.Interfaces;

public interface IProdutoService
{
    Task<IEnumerable<ProdutoDTO>> GetProdutos();
    Task<ProdutoDTO> GetById(int? id);
    Task Add(ProdutoDTO produtoDto);
    Task Update(ProdutoDTO produtoDto);
    Task Remove(int? id);
}
