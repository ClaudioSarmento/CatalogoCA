using AutoMapper;
using CatalogoCA.Application.DTOs;
using CatalogoCA.Application.Interfaces;
using CatalogoCA.Domain.Interfaces;

namespace CatalogoCA.Application.Services;


public class CategoriaService : ICategoriaService
{
    private ICategoriaRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoriaService(ICategoriaRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }
    public async Task Add(CategoriaDTO categoriaDto)
    {
        throw new NotImplementedException();
    }

    public Task<CategoriaDTO> GetById(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<CategoriaDTO>> GetCategorias()
    {
        var categoriesEntity = await _categoryRepository.GetCategoriasAsync();
        return _mapper.Map<IEnumerable<CategoriaDTO>>(categoriesEntity);
    }

    public Task Remove(int? id)
    {
        throw new NotImplementedException();
    }

    public Task Update(CategoriaDTO categoriaDto)
    {
        throw new NotImplementedException();
    }
}
