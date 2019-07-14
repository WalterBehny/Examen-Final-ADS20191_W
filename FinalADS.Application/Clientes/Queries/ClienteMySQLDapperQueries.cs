using FinalADS.Application.Clientes.Contracts;
using FinalADS.Application.Clientes.ViewModels;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalADS.Application.Clientes.Queries
{
    public class ClienteMySQLDapperQueries : IClientesQueries
    {
  /*      public void DeleteAccount(string clienteId)
        {
            string sql = @"
                        delete from 
                        account where account_id = @AccountID
                    ;";
            string connectionString = Environment.GetEnvironmentVariable("MYSQL_BANKING_CORE");
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    connection
                    .Query<ClienteDto>(sql, new
                    {
                        ClienteID = clienteId
                    })
                    .ToList();
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    
                }
                finally
                {
                    if (connection.State != System.Data.ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }
            }
        }
        */

        public List<ClienteDto> GetListPaginated(string formatoID, int page = 0, int pageSize = 5)
        {
            string sql = @"
                    SELECT 
                        a.cliente_id AS id,
                        a.titulo,
                        a.resumen,
                        a.contenido,
                        a.formato
                    FROM 
                        articulo a
                    WHERE
                        a.formato=@formato
                    ORDER BY 
                        a.formato ASC;";
            string connectionString = Environment.GetEnvironmentVariable("MYSQL_BANKING_CORE");
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    List<ClienteDto> clientes = connection
                    .Query<ClienteDto>(sql, new
                    {
                        formato = formatoID, 
                        Page = page,
                        PageSize = pageSize
                    })
                    .ToList();
                    return clientes;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    return new List<ClienteDto>();
                }
                finally
                {
                    if (connection.State != System.Data.ConnectionState.Closed)
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
