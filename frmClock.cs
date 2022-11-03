using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using NLog;

namespace Clocker
{

    public partial class FrmClock : Form
    {
        // referencia ao logger do NLog para toda a classe...
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private static int getWeekOfYear(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        public FrmClock()
        {
            InitializeComponent();

            // antes da carga e exibicao da tela, ja ajusta os campos do relogio e atualiza a hora:
            updatePanelClock();

            // inicia o timer, disparado a cada 1 segundo.
            timer.Start();
        }

        private void frmClock_Resize(object sender, EventArgs e)
        {
            // calcula a area central da tela para centralizar as horas:
            int xTime = this.Width - lblTime.Width;
            xTime = (xTime < 0) ? 0 : xTime / 2;
            int xSecond = xTime + lblTime.Width - 60;

            // posiciona demais campos alinhados a direita das horas:
            lblTime.Location = new Point(xTime, lblTime.Location.Y);
            lblSecond.Location = new Point(xSecond, lblSecond.Location.Y);
            ckbOff.Location = new Point(lblTime.Location.X + lblTime.Width - 82, ckbOff.Location.Y);

            // posiciona o dia/semana alinhado (25px) a lateral direita.
            lblDay.Location = new Point(this.Width - lblDay.Width - 25, lblDay.Location.Y);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // atualiza a cada segundo as horas do relogio na tela principal:
            updatePanelClock();
        }

        private void updatePanelClock()
        {
            DateTime now = DateTime.Now;

            lblTime.Text = now.ToString("HH:mm");
            lblSecond.Text = now.ToString(":ss");
            lblDate.Text = now.ToString("dddd,  dd  MMMM  yyyy").ToUpper();
            lblDay.Text = "Dia  " + now.DayOfYear.ToString() + "º   |   Semana  " + getWeekOfYear(now) + "ª";

            // atualiza horas das principais cidades (bolsas)
            lblTime1.Text = DateTime.Now.AddHours(-03).ToString("HH:mm"); // Chicago, US
            lblTime2.Text = DateTime.Now.AddHours(-02).ToString("HH:mm"); // New York, US
            lblTime3.Text = DateTime.Now.AddHours(+03).ToString("HH:mm"); // London, UK
            lblTime4.Text = DateTime.Now.AddHours(+04).ToString("HH:mm"); // Frankfurt, DE
            lblTime5.Text = DateTime.Now.AddHours(+07).ToString("HH:mm"); // Dubai, AE
            lblTime6.Text = DateTime.Now.AddHours(+11).ToString("HH:mm"); // Xangai, CN
            lblTime7.Text = DateTime.Now.AddHours(+12).ToString("HH:mm"); // Tokyo, JP
            lblTime8.Text = DateTime.Now.AddHours(+14).ToString("HH:mm"); // Sydney, AU
            lblTime9.Text = DateTime.Now.AddHours(+16).ToString("HH:mm"); // Wellington, NZ
        }

        private void ckbOff_Click(object sender, EventArgs e)
        {
            logger.Trace("Acionado botao [Power Off] para desligar ou reiniciar o computador.");

            DialogResult dialogResult = MessageBox.Show("Clique em [ABORT] para desligar o computador ou [RETRY] para reiniciar o Windows. Para fechar este diálogo clique em [IGNORE].", 
                                                        "ATENÇÃO:  Desligar  Computador", 
                                                        MessageBoxButtons.AbortRetryIgnore,
                                                        MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Abort)
            {
                // ANULAR eh desligar o computador:
                logger.Info("Vai desligar o computador...");
                Process.Start("shutdown", "/s /t 5");
            }
            else if (dialogResult == DialogResult.Retry)
            {
                // REPETIR eh reiniciar o computador:
                logger.Info("Vai reiniciar o computador...");
                Process.Start("shutdown", "/r /t 5");
            }
            else
            {
                // IGNORAR eh fechar este dialogo e prosseguir...
            }
        }
    }
}
