using AutoMapper;
using DevIO.Api.DTO;
using DevIO.Business.Models;

namespace DevIO.Api.Configurations
{
    public class AutoMapperConfig : Profile
        /** 15:46
         
         * Ele faz a inicialização desta classe de forma automatica.
         * Devido a classE Profile, faz o "dE"D
         */
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorDTO>().ReverseMap();
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
            CreateMap<Endereco, EnderecoDTO>().ReverseMap(); 
        }
    }
}
