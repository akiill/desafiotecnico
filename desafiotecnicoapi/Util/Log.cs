using System;
using System.IO;
using System.Text;

namespace ApiDesafio.Util
{
    public class Log
    {
        static readonly object _locker = new object();
        static string _caminholog;
        bool _ativa;

        public Log(bool ativa, string caminho)
        {
            _ativa = ativa;
            _caminholog = caminho + "\\";
        }

        internal void Escreve(string resultado, bool isJson = false)
        {
            lock (_locker)
            {

                if (_ativa)
                {
                    try
                    {
                        Inicializa();

                        DateTime datalocal = DateTime.Now;

                        StringBuilder Data = new StringBuilder("[").Append(datalocal.ToString("dd/MM/yyyy HH:mm:ss")).Append("] ");

                        FileInfo filenfo = new FileInfo(new StringBuilder(_caminholog).Append("APIDesafio").Append(datalocal.Year.ToString()).Append(datalocal.Month.ToString().PadLeft(2, '0')).Append(datalocal.Day.ToString().PadLeft(2, '0')).Append(".txt").ToString());

                        StreamWriter sw = File.AppendText(filenfo.FullName);

                        if (!isJson)
                            resultado = resultado.Replace("\"", "").Replace("{", "").Replace("}", "").Replace("\r", "").Replace("\n", "");

                        try
                        {
                            sw.WriteLine(Data.ToString() + resultado);
                            //sw.WriteLine(Data.ToString() + resultado, FileOptions.Asynchronous);
                        }
                        catch (Exception)
                        {
                        }

                        sw.Flush();
                        sw.Close();
                        sw.Dispose();
                    }
                    catch (Exception exMsg)
                    {
                        throw new ApplicationException("\nErro na criação do Log" + exMsg);
                    }
                }
                else
                    return;
            }
        }

        private static void Inicializa()
        {
            if (Directory.Exists(_caminholog))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(_caminholog);
                return;
            }
        }
    }
}