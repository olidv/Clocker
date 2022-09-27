using System;
using System.Windows.Forms;
using NLog;

namespace Clocker
{
    static class Program
    {
        // referencia ao logger do NLog para toda a classe...
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Carga da aplicacao e apresentacao da tela inicial:
            logger.Trace("Configuracao inicial para apresentacao da tela principal...");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            logger.Trace("Abrindo tela principal do Clock.exe...");
            Application.Run(new FrmClock());
        }
    }
}
