using System;
using System.IO;

namespace Intelipost.API.Infrastructure.Log
{
    /// <summary>
    /// Classe destinada a fazer o Log, quando autorizado, de todas as requisições feita pela API.
    /// </summary>
    internal class Logger
    {
        /// <summary>
        /// Faz a criação da pasta (C:\InliPost API Log\), se não houver, e insere os arquivos de logs, unitários dentro da mesma.
        /// </summary>
        /// <param name="plainText">O texto aberto para ser gravado no arquivo.</param>
        internal void Insert(string plainText)
        {
            var path = Path.GetDirectoryName("C:\\InteliPost API Log\\");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var completePath = String.Format("{0}\\intelipost_{1}.log", path, DateTime.Now.ToString("ddMMyyyyHHss"));

            File.WriteAllText(completePath, plainText);
        }
    }
}