using FinalADS.Domain.Accounts.Entities;
using AutoMapper;
using FinalADS.Application.Accounts.Dtos;
using FinalADS.Domain.Clientes.Entities;
using FinalADS.Application.Clientes.Dtos;

namespace FinalADS.Application.Accounts.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<NewClienteDto, Cliente>()
                /*
                .ForMember(
                    dest => dest.Customer,
                    opts => opts.MapFrom(
                        src => new Customer(src.CustomerId)
                    )
                )
                */
                .ReverseMap();            
        }
    }
}
