using System.Collections.Generic;
using desafiotecnicodll;

namespace ApiDesafio.Models
{
    public class DecomporResponse
    {
        public string erro { get; set; }
        public List<long> divisores { get; set; }
        public List<long> primos { get; set; }

        public DecomporResponse()
        {
            erro = string.Empty;
            divisores = new List<long>();
            primos = new List<long>();
        }
        public DecomporResponse(string descricaoErro)
        {
            erro = descricaoErro;
        }

        public DecomporResponse DecomporResponseParse(DivisoresPrimos divisoresPrimos)
        {
            erro = divisoresPrimos.erro;
            divisores = divisoresPrimos.divisores;
            primos = divisoresPrimos.primos;
            return this;
        }
    }
}