﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class frmClock : Form
    {
        public frmClock()
        {
            InitializeComponent();

            // antes da carga e exibicao da tela, ja ajusta os campos do relogio e atualiza a hora:
            updatePanelClock();
        }

        private void frmClock_Load(object sender, EventArgs e)
        {
            // posiciona o dia/semana alinhado (25px) a lateral direita.
            lblDay.Location = new Point(this.Width - lblDay.Width - 25, lblDay.Location.Y);

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
            ckbClose.Location = new Point(lblTime.Location.X + lblTime.Width - 82, ckbClose.Location.Y);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // atualiza a cada segundo as horas do relogio na tela principal:
            updatePanelClock();

            // a cada minuto, executa o scheduler:
            if (DateTime.Now.Second == 0) checkScheduler();
        }

        private void ckbClose_CheckedChanged(object sender, EventArgs e)
        {
            ckbClose.ImageIndex = ckbClose.Checked ? 1 : 0;
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

        private static int getWeekOfYear(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        /*** SERVICO DE MONITORAMENTO DOS APLICATIVOS ***/

        /*** COTACOES DO FOREX INTERROMPIDAS PARA MEDIR CHECK DA PERFORMANCE DAS COTACOES DE MINI CONTRATOS ***/
        static readonly String MT5_XM = @"C:\Apps\B3\XM Global MT5\terminal64.exe";
        static readonly String MT5_GENIAL = @"C:\Apps\B3\MetaTrader 5\terminal64.exe";
        static readonly String MT5_MODAL = @"C:\Apps\B3\ModalMais MetaTrader 5\terminal64.exe";
        // TODO static readonly String TRYD_MODAL = @"C:\Apps\B3\Tryd6\trader.exe";

        static readonly (int dia, int mes)[] FERIADOS_FOREX = {( 1, 1),  // Ano Novo: Confraternizacao Universal
                                                               (25,12)}; // Natal
        /*** FERIADOS ANTECIPADOS 2021 e 2022 ***/
        static readonly (int dia, int mes)[] FERIADOS_BR_B3 = {( 1, 1),  // Ano Novo: Confraternizacao Universal
                                                               //(25, 1),  // Aniversario de Sao Paulo (SP)
                                                               (24, 2),  // Carnaval
                                                               (25, 2),  // Carnaval
                                                               (10, 4),  // Paixao de Cristo
                                                               (21, 4),  // Tiradentes
                                                               ( 1, 5),  // Dia do Trabalho
                                                               //(11, 6),  // Corpus Christi
                                                               (09, 7),  // Revolucao Constitucionalista (SP)
                                                               ( 7, 9),  // Dia da Independencia do Brasil
                                                               (12,10),  // Nossa Senhora Aparecida (Padroeira do Brasil)
                                                               ( 2,11),  // Finados
                                                               (15,11),  // Proclamacao da Republica
                                                               //(20,11),  // Consciencia Negra (SP)
                                                               (24,12),  // Vespera de Natal
                                                               (25,12),  // Natal
                                                               (31,12)}; // Vespera de Ano Novo

        public void checkScheduler()
        {
            bool isMT5GenialOn = false;
            Process procMT5Genial = null;

            bool isMT5ModalOn = false;
            Process procMT5Modal = null;

            //bool isTrydModalOn = false;
            //Process procTrydModal = null;

            bool isMT5XmOn = false;
            Process procMT5Xm = null;

            // busca o estado das instancias do MetaTrader (corretoras) em execucao:
            Process[] processes = Process.GetProcessesByName("terminal64");
            foreach (Process proc in processes)
            {
                String title = proc.MainWindowTitle.ToUpper();
                if (title.Contains("GENIAL"))
                {
                    procMT5Genial = proc;
                    isMT5GenialOn = true;
                }
                if (title.Contains("MODALMAIS"))
                {
                    procMT5Modal = proc;
                    isMT5ModalOn = true;
                }
                if (title.Contains("XM"))
                {
                    procMT5Xm = proc;
                    isMT5XmOn = true;
                }
            }

            // busca o estado das instancias do Tryd (modalmais) em execucao:
            //processes = Process.GetProcessesByName("trader");
            //foreach (Process proc in processes)
            //{
            //    String title = proc.MainWindowTitle.ToUpper();
            //    if (title.Contains("TRYD"))
            //    {
            //        procTrydModal = proc;
            //        isTrydModalOn = true;
            //    }
            //}

            // identifica o dia corrente para verificar os mercados:
            bool isB3Open = false,
                 isFeriadoB3 = false;
            bool isForexOpen = false,
                 isFeriadoForex = false;
            DateTime now = DateTime.Now;
            int dia = now.Day,
                mes = now.Month,
                hor = now.Hour,
                min = now.Minute;
            DayOfWeek dow = now.DayOfWeek;

            // verifica se o dia corrente eh feriado no mercado forex e no mercado b3:
            foreach ((int dia, int mes) feriado in FERIADOS_FOREX)
            {
                if (dia == feriado.dia && mes == feriado.mes)
                {
                    isFeriadoForex = true;
                }
            }
            foreach ((int dia, int mes) feriado in FERIADOS_BR_B3)
            {
                if (dia == feriado.dia && mes == feriado.mes)
                {
                    isFeriadoB3 = true;
                }
            }

            // verifica se os mercados estao abertos ou fechados:
            switch (dow)
            {
                case DayOfWeek.Monday:
                    isForexOpen = !isFeriadoForex; // && (hor < 21);
                    isB3Open = !isFeriadoB3 && ((hor == 8 && min >= 30) || (hor >= 9 && hor <= 17) || (hor == 18 && min <= 30));
                    break;
                case DayOfWeek.Tuesday:
                    isForexOpen = !isFeriadoForex; // && (hor < 21);
                    isB3Open = !isFeriadoB3 && ((hor == 8 && min >= 30) || (hor >= 9 && hor <= 17) || (hor == 18 && min <= 30));
                    break;
                case DayOfWeek.Wednesday:
                    isForexOpen = !isFeriadoForex; // && (hor < 21);
                    isB3Open = !isFeriadoB3 && ((hor == 8 && min >= 30) || (hor >= 9 && hor <= 17) || (hor == 18 && min <= 30));
                    break;
                case DayOfWeek.Thursday:
                    isForexOpen = !isFeriadoForex; // && (hor < 21);
                    isB3Open = !isFeriadoB3 && ((hor == 8 && min >= 30) || (hor >= 9 && hor <= 17) || (hor == 18 && min <= 30));
                    break;
                case DayOfWeek.Friday:
                    isForexOpen = !isFeriadoForex && (hor < 19);
                    isB3Open = !isFeriadoB3 && ((hor == 8 && min >= 30) || (hor >= 9 && hor <= 17) || (hor == 18 && min <= 30));
                    break;
                case DayOfWeek.Saturday:
                    isForexOpen = false;
                    isB3Open = false;
                    break;
                case DayOfWeek.Sunday:
                    isForexOpen = !isFeriadoForex && (hor >= 18);
                    isB3Open = false;
                    break;
            }

            // ativacao ou suspensao do MT para Genial e ModalMais (B3):
            if (isB3Open)
            { // Bolsa do brasil aberta, executar MT5 e TRYD se nao estiverem em execucao:
                if (!isMT5GenialOn)
                {
                    procMT5Genial = openProgram(MT5_GENIAL);
                }
                if (!isMT5ModalOn)
                {
                    procMT5Modal = openProgram(MT5_MODAL);
                }
                //if (!isTrydModalOn)
                //{
                //    // TODO procTrydModal = Process.Start(TRYD_MODAL);
                //}
            }
            else
            { // Bolsa do brasil fechada, encerrar MT5 e TRYD se estiverem em execucao (e check-close ativo):
                if (isMT5GenialOn && ckbClose.Checked)
                {
                    closeProgram(procMT5Genial);
                }
                if (isMT5ModalOn && ckbClose.Checked)
                {
                    closeProgram(procMT5Modal);
                }
                //if (isTrydModalOn && ckbClose.Checked)
                //{
                //    // TODO closeProgram(procTrydModal);
                //}
            }

            // ativacao ou suspensao do MT para XM (Forex):
            if (isForexOpen)
            { // Mercado Forex aberto, executar MT5 se nao estiver em execucao (e check-close ativo):
                if (!isMT5XmOn)
                {
                    procMT5Xm = openProgram(MT5_XM);
                }
            }
            else
            { // Mercado Forex fechado, encerrar MT5 se estiver em execucao:
                if (isMT5XmOn && ckbClose.Checked)
                {
                    closeProgram(procMT5Xm);
                }
            }
        }

        private static Process openProgram(String program)
        {
            Process proc = null;
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo(program);
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;

                proc = Process.Start(startInfo);
            }
            catch (Exception e) {
                Console.WriteLine("{0} Exception caught.", e);
            }

            return proc;
        }

        private static bool closeProgram(Process proc)
        {
            bool result = false;
            try
            {
                if (proc == null || proc.HasExited)
                {
                    result = true; // indica que o programa foi encerrado (nao importa se foi antes).
                }
                else
                {
                    result = proc.CloseMainWindow();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            return result;
        }
    }
}