using FinalADS.Application.Clientes.Assemblers;
using FinalADS.Application.Clientes.Constants;
using FinalADS.Application.Clientes.Contracts;
using FinalADS.Application.Clientes.Dtos;
using FinalADS.Domain.Clientes.Contracts;
using FinalADS.Domain.Clientes.Entities;
using Microsoft.AspNetCore.Http;
using Common;
using System;

namespace FinalADS.Application.Clientes.Services
{
    public class ClienteApplicationService : IClienteApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IClienteRepository _clienteRepository;
        private readonly NewClienteAssembler _newClienteAssembler;

        public ClienteApplicationService(
            IUnitOfWork unitOfWork,
            IClienteRepository clienteRepository,
            NewClienteAssembler newClienteAssembler)
        {
            _unitOfWork = unitOfWork;
            _clienteRepository = clienteRepository;
            _newClienteAssembler = newClienteAssembler;
        }

        public NewClienteResponseDto Register(NewClienteDto newClienteDto)
        {
            try
            {
                Cliente cliente = _newClienteAssembler.ToEntity(newClienteDto);
                _clienteRepository.SaveOrUpdate(cliente);
                return new NewClienteResponseDto
                {
                    HttpStatusCode = StatusCodes.Status201Created,
                    Response = new ApiStringResponse(ClienteAppConstants.ClienteCreado)
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new NewClienteResponseDto
                {
                    HttpStatusCode = StatusCodes.Status500InternalServerError,
                    Response = new ApiStringResponse(ApiConstants.InternalServerError)
                };
            }
        }

    }
}
