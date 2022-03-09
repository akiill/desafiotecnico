using System.Collections.Generic;

namespace desafiotecnicodll
{
    public class DivisoresPrimos
    {
        public string erro { get; set; }
        public List<long> divisores { get; set; }
        public List<long> primos { get; set; }

        public DivisoresPrimos()
        {
            erro = string.Empty;
            divisores = new List<long>();
            primos = new List<long>();
        }
        public DivisoresPrimos(string descricaoErro)
        {
            erro = descricaoErro;
        }
    }
}
