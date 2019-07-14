using FinalADS.Application.Clientes.Dtos;

namespace FinalADS.Application.Clientes.Contracts
{
    public interface IClienteApplicationService
    {
        NewClienteResponseDto Register(NewClienteDto newClienteDto);
    }
}
