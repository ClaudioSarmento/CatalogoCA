﻿using CatalogoCA.Domain.Entities;

namespace CatalogoCA.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetProdutosAsync();
        Task<Produto> GetByIdAsync(int? id);
        Task<Produto> CreateAsync(Produto product);
        Task<Produto> UpdateAsync(Produto product);
        Task<Produto> RemoveAsync(Produto product);
    }
}
