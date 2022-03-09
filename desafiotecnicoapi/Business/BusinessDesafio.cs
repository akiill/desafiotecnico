using System;
using System.Text.Json;
using System.Threading.Tasks;
using ApiDesafio.Interface;
using ApiDesafio.Models;
using ApiDesafio.Util;
using Microsoft.Extensions.Configuration;
using desafiotecnicodll;
using Confluent.Kafka;

namespace ApiDesafio.Business
{
    public class BusinessDesafio : IAPIDesafio
    {
        private IConfiguration Configuration { get; }
        private readonly Log log;

        public BusinessDesafio()
        {
            log = new Log(true, "C:\\temp\\");
        }

        public BusinessDesafio(IConfiguration configuration) : this()
        {
            Configuration = configuration;
            string pathLog = Configuration.GetSection("MySettings").GetSection("pathLog").Value;

            log = new Log(true, pathLog);
        }

        public DecomporResponse DecomporApi(DecomporRequest request)
        {
            DecomporResponse response = new();

            string json = JsonSerializer.Serialize(request);
            log.Escreve("DECOMPOR REQUEST: " + json, true);

            try
            {
                DivisoresPrimos divisoresPrimos = Decompor.CalcularDivisores(request.numero);

                response.DecomporResponseParse(divisoresPrimos);
            }
            catch (Exception ex)
            {
                response.erro = ex.Message;
            }
            finally
            {
                json = JsonSerializer.Serialize(response);
                log.Escreve("DECOMPOR RESPONSE: " + json, true);
            }
            return response;
        }

    }
}