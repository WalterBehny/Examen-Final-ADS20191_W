using FinalADS.Application.Clientes.ViewModels;
using System.Collections.Generic;

namespace FinalADS.Application.Clientes.Contracts
{
    public interface IClientesQueries
    {
        List<ClienteDto> GetListPaginated(string formatoID, int page = 0, int pageSize = 5);
        //void DeleteCliente(long clienteId); 
    }
}
