﻿using FinalADS.Application.Accounts.Contracts;
using FinalADS.Application.Accounts.Dtos;
using FinalADS.Application.Accounts.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Common;
using System;
using System.Collections.Generic;
using FinalADS.Application.Accounts.Constants;

namespace Banking.API.Controllers
{
    [Produces("application/json")]
    [Consumes("application/json")]
    
    [Route("api/autor/")]
    [ApiController]
    
    public class AccountsController : ControllerBase
    {
        private readonly IAccountApplicationService _accountApplicationService;
        private readonly IAccountQueries _accountQueries;

        public AccountsController(IAccountApplicationService accountApplicationService, IAccountQueries accountQueries)
        {
            _accountApplicationService = accountApplicationService;
            _accountQueries = accountQueries;
        }
        
        //[HttpDelete("delete")]
        //public IActionResult Delete(long accountId)
        //{
        //    try
        //    {
        //        _accountQueries.DeleteAccount(accountId);
        //        return StatusCode(StatusCodes.Status200OK,  AccountAppConstants.AccountDelete);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return StatusCode(StatusCodes.Status500InternalServerError, new ApiStringResponse(ApiConstants.InternalServerError));
        //    }
        //}


        [HttpPost("registra")]
        //[HttpPost("{autorId}/registra")]
        public IActionResult Register([FromBody] NewAccountDto newAccountDto)
        { 
            NewAccountResponseDto response = _accountApplicationService.Register(newAccountDto);
            return StatusCode(response.HttpStatusCode, response.Response);
        }

        
        [HttpGet("lista")]
        public IActionResult GetListPaginated( [FromQuery]int page = 0, [FromQuery]int pageSize = 10)
        {
            try
            {
                List<AccountDto> accounts = _accountQueries.GetListPaginated(page, pageSize);
                return StatusCode(StatusCodes.Status200OK, accounts);
            }
            catch (Exception ex)
            {
                //TODO: Log exception async, for now write exception in the console
                Console.WriteLine(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiStringResponse(ApiConstants.InternalServerError));
            }
        }
    }
}
