using System;
using System.IO;

namespace ImgPosInst.Helper
{
    class Logger
    {
        private static string path = Path.GetTempPath();
        private static readonly string suffix = "info-";
        private static readonly DateTime now = DateTime.Now;
        private static readonly string dateTime = now.ToString("yyyyMMdd-HHmmss-fff");
        private static readonly string fileName = suffix + dateTime + ".log";
        private static string fullPath = Path.Combine(path, fileName);

        public enum LogType
        {
            INFO,
            WARNING,
            ERROR
        }

        public static void Log(LogType type, string message)
        {
            using (StreamWriter writer = new StreamWriter(fullPath, true))
            {
                writer.WriteLine($"[{DateTime.Now}] [{System.Threading.Thread.CurrentThread.ManagedThreadId}] [{type}] {message}");
            }
        }

        public static void SetLogDestination(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Caminho do arquivo de log não pode ser nulo ou vazio.");
            }

            if (!Directory.Exists(path))
            {
                throw new DirectoryNotFoundException("O diretório especificado para o arquivo de log não foi encontrado.");
            }

            Logger.path = path;
            Logger.fullPath = Path.Combine(path, Logger.fileName);
        }

        public static string GetLogDestination()
        {
            return Logger.path;
        }

        public static string GetLogFilename()
        {
            return Logger.fileName;
        }
    }
}
