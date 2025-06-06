using CatalogoCA.Application.DTOs;
using CatalogoCA.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCA.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        public Task Add(ProdutoDTO produtoDto)
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoDTO> GetById(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutoDTO>> GetProdutos()
        {
            throw new NotImplementedException();
        }

        public Task Remove(int? id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ProdutoDTO produtoDto)
        {
            throw new NotImplementedException();
        }
    }
}
