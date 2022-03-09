using System;
using Microsoft.Extensions.Configuration;
using Xunit;
using ApiDesafio.Business;
using ApiDesafio.Models;

namespace desafiotecnicoapiTest
{
    public class divisoresTest
    {
        private static BusinessDesafio Business;
        private static bool Iniciou = false;

        //Caso de Test#1 = Passado o número impar (45) deverá retornar divisores (1,3,5,9,15,45), primos (1,3,5)
        [Fact]
        public void CalcularUmNumeroImparComSucesso()
        {
            try
            {
                Inicializar();

                DecomporResponse divisoresPrimos = Business.DecomporApi(new DecomporRequest { email="teste@exemplo.com", numero=45 });

                string divisores = string.Join(",", divisoresPrimos.divisores);
                string primos = string.Join(",", divisoresPrimos.primos);

                Assert.Equal("1,3,5,9,15,45", divisores);
                Assert.Equal("1,3,5", primos);
            }
            catch (Exception ) { throw; }
        }

        //Caso de Test#2 = Passado o número par (100) deverá retornar divisores (1,2,4,5,10,20,25,50,100), primos (1,2,5)
        [Fact]
        public void CalcularUmNumeroParComSucesso()
        {
            try
            {
                Inicializar();

                DecomporResponse divisoresPrimos = Business.DecomporApi(new DecomporRequest { email = "teste@exemplo.com", numero = 100 });

                string divisores = string.Join(",", divisoresPrimos.divisores);
                string primos = string.Join(",", divisoresPrimos.primos);

                Assert.Equal("1,2,4,5,10,20,25,50,100", divisores);
                Assert.Equal("1,2,5", primos);
            }
            catch (Exception) { throw; }
        }

        //Caso de Test#3 = Passado o número 0 ou negativo deverá retornar erro e fazer o tratamento
        [Fact]
        public void CalcularNumeroZeroOuNegativo()
        {
            try
            {
                Inicializar();

                DecomporResponse divisoresPrimos = Business.DecomporApi(new DecomporRequest { email = "teste@exemplo.com", numero = -10 });

                Assert.Equal("O número informado não poderá ser Zero ou Negativo", divisoresPrimos.erro);

            }
            catch (Exception) { throw; }
        }

        //Caso de Test#4 = Passado o número 1, deverá retornar ele como divisor e primo
        [Fact]
        public void CalcularNumeroUm()
        {
            try
            {
                Inicializar();

                DecomporResponse divisoresPrimos = Business.DecomporApi(new DecomporRequest { email = "teste@exemplo.com", numero = 1 });

                string divisores = string.Join(",", divisoresPrimos.divisores);
                string primos = string.Join(",", divisoresPrimos.primos);

                Assert.Equal("1", divisores);
                Assert.Equal("1", primos);
            }
            catch (Exception) { throw; }
        }

        //Caso de Test#5 = Passado o número 3, deverá retornar 1 e 3 como divisor e primo
        [Fact]
        public void CalcularNumeroMenorIgualTres()
        {
            try
            {
                Inicializar();

                DecomporResponse divisoresPrimos = Business.DecomporApi(new DecomporRequest { email = "teste@exemplo.com", numero = 3 });

                string divisores = string.Join(",", divisoresPrimos.divisores);
                string primos = string.Join(",", divisoresPrimos.primos);

                Assert.Equal("1,3", divisores);
                Assert.Equal("1,3", primos);
            }
            catch (Exception) { throw; }
        }

        //Caso de Test#6 = Passado o número 9999999990, testaremos o tempo de cálculo
        [Fact]
        public void CalcularPerformance()
        {
            try
            {
                Inicializar();

                DecomporResponse divisoresPrimos = Business.DecomporApi(new DecomporRequest { email = "teste@exemplo.com", numero = 9999999990 });

                string divisores = string.Join(",", divisoresPrimos.divisores);
                string primos = string.Join(",", divisoresPrimos.primos);

                Assert.NotEqual("", divisores);
                Assert.NotEqual("", primos);
            }
            catch (Exception) { throw; }
        }

        private static void Inicializar()
        {
            if (!Iniciou)
            {
                Business = new(GetConfiguration());
                Iniciou = true;
            }
        }

        private static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(System.IO.Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

            IConfiguration config = builder.Build();

            return config;
        }
    }
}
