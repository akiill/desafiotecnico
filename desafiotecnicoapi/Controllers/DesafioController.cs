using ApiDesafio.Models;
using ApiDesafio.Business;
using ApiDesafio.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using System;

namespace ApiDesafio.Controllers
{
    [ApiController]
    [Route("desafio")]
    public class DesafioController : ControllerBase
    {
        private readonly IAPIDesafio _business;

        public DesafioController(IConfiguration configuration)
        {
            _business = new BusinessDesafio(configuration);
        }

        /// <summary>
        /// Api responsável por decompor um número
        /// </summary>
        /// <returns>A partir de um número inteiro, será retornado todos os seus divisores e seus números primos</returns>
        /// <response code="200">Returna os divisores e número primos de um determinado número</response>
        /// <response code="400">Não foi possível decompor o número recebido</response>
        /// <response code="500">Problema interno na execução da decomposição</response>
        [AllowAnonymous]
        [HttpPost]
        [Route("v1/decompor")]
        [ProducesResponseType(typeof(DecomporResponse), 200)]
        public IActionResult PostV1([FromBody] DecomporRequest request)
        {
            try
            {
                DecomporResponse response = _business.DecomporApi(request);

                if (string.IsNullOrEmpty(response.erro))
                {
                    return Ok(response);
                }
                else
                {
                    return BadRequest(response);
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
