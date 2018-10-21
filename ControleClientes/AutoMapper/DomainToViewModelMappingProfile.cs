using AutoMapper;
using ControleClientes.Dominio.Entidades;
using ControleClientes.ViewModels;

namespace ControleClientes.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Agencia, AgenciaViewModel>();
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Conta, ContaViewModel>()
                .ForMember(dest => dest.NomeCliente, opt => opt.MapFrom(src => src.Cliente.Nome))
                .ForMember(dest => dest.TipoConta, opt => opt.MapFrom(src => src.TipoConta.NomeTipoConta));
            CreateMap<TipoConta, TipoContaViewModel>();
        }
    }
}