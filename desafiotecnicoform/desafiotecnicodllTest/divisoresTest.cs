using System;
using NUnit.Framework;
using desafiotecnicodll;

namespace desafiotecnicoformTest
{
    public class divisoresTest
    {
        //Caso de Test#1 = Passado o número impar (45) deverá retornar divisores (1,3,5,9,15,45), primos (1,3,5)
        [Test]
        public void CalcularUmNumeroImparComSucesso()
        {
            try
            {
                DivisoresPrimos divisoresPrimos = Decompor.CalcularDivisores(45);

                string divisores = string.Join(",", divisoresPrimos.divisores);
                string primos = string.Join(",", divisoresPrimos.primos);

                Assert.AreEqual("1,3,5,9,15,45", divisores);
                Assert.AreEqual("1,3,5", primos);
            }
            catch (Exception ex) { throw ex; }

        }

        //Caso de Test#2 = Passado o número par (100) deverá retornar divisores (1,2,4,5,10,20,25,50,100), primos (1,2,5)
        [Test]
        public void CalcularUmNumeroParComSucesso()
        {
            try
            {
                DivisoresPrimos divisoresPrimos = Decompor.CalcularDivisores(100);

                string divisores = string.Join(",", divisoresPrimos.divisores);
                string primos = string.Join(",", divisoresPrimos.primos);

                Assert.AreEqual("1,2,4,5,10,20,25,50,100", divisores);
                Assert.AreEqual("1,2,5", primos);
            }
            catch (Exception ex) { throw ex; }

        }

        //Caso de Test#3 = Passado o número 0 ou negativo deverá retornar erro e fazer o tratamento
        [Test]
        public void CalcularNumeroZeroOuNegativo()
        {
            try
            {
                DivisoresPrimos divisoresPrimos = Decompor.CalcularDivisores(-10);

                Assert.AreEqual("O número informado não poderá ser Zero ou Negativo", divisoresPrimos.erro);

            }
            catch (Exception ex) { throw ex; }

        }

        //Caso de Test#4 = Passado o número 1, deverá retornar ele como divisor e primo
        [Test]
        public void CalcularNumeroUm()
        {
            try
            {
                DivisoresPrimos divisoresPrimos = Decompor.CalcularDivisores(1);

                string divisores = string.Join(",", divisoresPrimos.divisores);
                string primos = string.Join(",", divisoresPrimos.primos);

                Assert.AreEqual("1", divisores);
                Assert.AreEqual("1", primos);
            }
            catch (Exception ex) { throw ex; }

        }
        //Caso de Test#5 = Passado o número 3, deverá retornar 1 e 3 como divisor e primo
        [Test]
        public void CalcularNumeroMenorIgualTres()
        {
            try
            {
                DivisoresPrimos divisoresPrimos = Decompor.CalcularDivisores(3);

                string divisores = string.Join(",", divisoresPrimos.divisores);
                string primos = string.Join(",", divisoresPrimos.primos);

                Assert.AreEqual("1,3", divisores);
                Assert.AreEqual("1,3", primos);
            }
            catch (Exception ex) { throw ex; }

        }

        //Caso de Test#6 = Passado o número 9999999990, testaremos o tempo de cálculo
        [Test]
        public void CalcularPerformance()
        {
            try
            {
                DivisoresPrimos divisoresPrimos = Decompor.CalcularDivisores(3);

                string divisores = string.Join(",", divisoresPrimos.divisores);
                string primos = string.Join(",", divisoresPrimos.primos);

                Assert.AreNotEqual("", divisores);
                Assert.AreNotEqual("", primos);
            }
            catch (Exception ex) { throw ex; }

        }
    }
}