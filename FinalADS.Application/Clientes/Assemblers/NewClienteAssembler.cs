using AutoMapper;
using FinalADS.Application.Clientes.Dtos;
using FinalADS.Domain.Clientes.Entities;
using System;

namespace FinalADS.Application.Clientes.Assemblers
{
    public class NewClienteAssembler
    {
        private readonly IMapper _mapper;

        public NewClienteAssembler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Cliente ToEntity(NewClienteDto newClienteDto)
        {
            Cliente cliente = _mapper.Map<Cliente>(newClienteDto);
           
            return cliente;
        }
    }
}
