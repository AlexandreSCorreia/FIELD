using ImgPosInst.Helper;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace ImgPosInst
{
    internal static class Program
    {
        public class Parameters
        {
            public string filePath { get; set; }
        }

        static void Parser(string[] args, ref Parameters parameters)
        {
            for (int i = 0; i < args.Length; i++)
            {
                string arg = args[i];

                if (arg == "--file-path")
                {
                    if (i + 1 < args.Length)
                    {
                        parameters.filePath = args[i + 1];
                        i++;
                    }
                    else
                    {
                        throw new Exception("--file-path option requires one argument.");
                    }
                }
                else
                {
                    throw new Exception("Unrecognized option: " + arg);
                }
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Logger.SetLogDestination(@"./");
            Logger.Log(Logger.LogType.INFO, "ImgPosInst. AlexandreScorreia Tecnologia.");

            if (args.Length < 2)
            {
                Logger.Log(Logger.LogType.ERROR, "--file-path para o arquivo de configurações não foi passado.");
                Environment.Exit(1);
            }

            string argsv = "";
            for (int i = 1; i < args.Length; i++)
            {
                argsv += " " + args[i];
            }

            Logger.Log(Logger.LogType.INFO, argsv);

            Parameters p = new Parameters();

            try
            {
                Program.Parser(args, ref p);
            }
            catch (Exception ex)
            {
                Logger.Log(Logger.LogType.ERROR, $"Ocorreu um erro ao executar a aplicação: {ex.Message}");
                Environment.Exit(1);
            }

            if (!string.IsNullOrEmpty(p.filePath))
            {
                if (File.Exists(p.filePath))
                {
                    //Ler o arquivo json
                    string json = File.ReadAllText(p.filePath);

                    //Deserializar o json em um objeto da classe Person
                    Config config = JsonConvert.DeserializeObject<Config>(json);

                    try
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        ImgPosInst imgPosInst = new ImgPosInst();
                        imgPosInst.config = config;
                        Application.Run(imgPosInst);
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(Logger.LogType.ERROR, $"Ocorreu um erro ao executar a aplicação: {ex.Message}");
                        Environment.Exit(1);
                    }
                }
                else
                {
                    Logger.Log(Logger.LogType.INFO, "Arquivo de configuração não encontrado");
                }
            }
        }
    }
}
