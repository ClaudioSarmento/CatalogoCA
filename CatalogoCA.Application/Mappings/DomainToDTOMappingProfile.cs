using CatalogoCA.Application.DTOs;
using CatalogoCA.Domain.Entities;
using AutoMapper;

namespace CatalogoCA.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
        }
    }
}
