using AutoMapper;
using ControleClientes.Dominio.Entidades;
using ControleClientes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleClientes.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AgenciaViewModel, Agencia>();
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ContaViewModel, Conta>();
            CreateMap<TipoContaViewModel, TipoConta>();
        }
    }
}