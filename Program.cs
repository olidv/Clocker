using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using NLog;

namespace Digital_Clock
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
            logger.Info("Iniciando aplicacao Clock.exe...");

            // captura evento do sistema para identificar retorno (resume) da hibernacao/suspensao do computador:
            SystemEvents.PowerModeChanged += OnPowerModeChange;

            // aproveita para sincronizar o relogio do sistema na carga deste aplicativo:
            ResyncSystemTime();

            // Carga da aplicacao e apresentacao da tela inicial:
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            logger.Trace("Abrindo tela principal do Clock.exe...");
            Application.Run(new frmClock());
        }

        private static void OnPowerModeChange(object s, PowerModeChangedEventArgs e)
        {
            // efetua nova sincronizacao do relogio do sistema ao retornar da hibernacao/suspensao:
            if (e.Mode == PowerModes.Resume)
            {
                logger.Trace("Reativando programa Clock apos suspensao...");
                ResyncSystemTime();
            }
        }

        static readonly String W32TM = @"C:\Windows\System32\w32tm.exe";

        private static void ResyncSystemTime()
        {
            try
            {
                logger.Trace("Acertando a hora do computador...");

                // configura a sincronizacao do relogio do computador para "time.windows.com":
                ProcessStartInfo startInfoConfig = new ProcessStartInfo(W32TM);
                startInfoConfig.WindowStyle = ProcessWindowStyle.Hidden;
                // indica a lista de dominios a serem utilizados na sincronizacao e efetiva a configuracao:
                startInfoConfig.Arguments = "/config /syncfromflags:MANUAL /manualpeerlist:time.windows.com /reliable:YES";
                // executa o servico timer do windows para a sincronizacao do relogio do sistema:
                Process.Start(startInfoConfig);

                // executa novamente o servico timer do windows para efetivar a configuracao:
                ProcessStartInfo startInfoUpdate = new ProcessStartInfo(W32TM);
                startInfoUpdate.WindowStyle = ProcessWindowStyle.Hidden;
                // apenas indica o argumento /update para persistir a configuracao:
                startInfoUpdate.Arguments = "/config /update";
                Process.Start(startInfoUpdate);

                // executa o servico timer do windows para a sincronizacao do relogio do sistema:
                ProcessStartInfo startInfoResync = new ProcessStartInfo(W32TM);
                startInfoResync.WindowStyle = ProcessWindowStyle.Hidden;
                // forca a sincronizacao do relogio do sistema:
                startInfoResync.Arguments = "/resync";
                Process.Start(startInfoResync);
            }
            catch (Exception e)
            {
                logger.Error("Erro ao tentar acertar a hora do computador: {}", e.Message);
            }
        }
    }
}
