using AutoMapper;
using ProcessoAvaliacao.Domain.Models;
using ProcessoAvaliacao.WebApi.Dtos;

namespace ProcessoAvaliacao.WebApi
{
    public class WebApiMapperProfile : Profile
    {
        public WebApiMapperProfile()
        {
            CreateMap<Filme, FilmesGetResult>();
            CreateMap<FilmesGet, Pesquisa>();
        }
    }
}
