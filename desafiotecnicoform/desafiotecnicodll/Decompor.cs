using System;

namespace desafiotecnicodll
{
    public static class Decompor
    {
        public static DivisoresPrimos CalcularDivisores(long numero)
        {
            DivisoresPrimos divisoresPrimos = new DivisoresPrimos();

            try
            {
                if (numero <= 0)
                {
                    throw new ArgumentException("O número informado não poderá ser Zero ou Negativo");
                }

                long raiz_n;

                if (numero <= 3)
                {
                    for (long i = 1; i <= numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            divisoresPrimos.divisores.Add(i);
                        }
                    }
                }
                else
                {
                    //Utilizado a função Math.Sqrt (raiz quadrada) para reduzir o número de loop(divisões),
                    //com isto ganhamos em performance quando o número passado é um valor grande
                    raiz_n = (long)Math.Sqrt(numero);

                    for (long i = 1; i < raiz_n; i++)
                    {
                        if (numero % i == 0)
                        {
                            divisoresPrimos.divisores.Add(i);
                            divisoresPrimos.divisores.Add(numero / i);
                        }
                    }

                    if (raiz_n * raiz_n == numero) divisoresPrimos.divisores.Add(raiz_n);
                }

                foreach (var item in divisoresPrimos.divisores)
                {
                    if (NumeroPrimo(item))
                    {
                        divisoresPrimos.primos.Add(item);
                    }
                }

                divisoresPrimos.divisores.Sort();
                divisoresPrimos.primos.Sort();

                return divisoresPrimos;
            }
            catch (ArgumentException ex)
            {
                return new DivisoresPrimos(ex.Message);
            }
            catch (Exception ex)
            {
                return new DivisoresPrimos(ex.Message);
            }
        }

        private static bool NumeroPrimo(long numero)
        {
            //Utilizado a função Math.Sqrt (raiz quadrada) para reduzir o número de loop(divisões),
            //com isto ganhamos em performance quando o número passado é um valor grande
            try
            {
                for (int j = 2; j <= Math.Sqrt(numero); j++)
                {
                    if (numero % j == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
