using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using System.Drawing;
using System;
using PMPlayer;
using WMPLib;
using AxWMPLib;
using System.Linq;
using CustomBox.RJControls;
using System.IO;
using System.Reflection;

namespace TGlassPlayer
{
    public partial class Main : Form
    {
        private MMDevice defaultDevice;
        private IconButton btnAtual;
        private static PictureBox capa;
        private static AxWindowsMediaPlayer player { get; set; }
        private static Label nomeMusica { get; set; }
        public static Panel controlPanel { get; set; }
        private static Label duracaoMusica { get; set; }
        public static musica musicaAtual;
        public static Label msgInicial;
        public static RJProgressBar pbSongBar { get; set; }
        public Main()
        {
            InitializeComponent();
            AllowTransparency = true;
            TransparencyKey = BackColor;

            //ativar o buffering duplo para reduzir o flickering
            DoubleBuffered = true;
            btnAtual = btnHome;
            capa = capaSong;
            nomeMusica = lblSongName;
            controlPanel = controlsSongPanel;
            leftBar.Height = btnHome.Height;
            pbSongBar = pbDuration;
            player = wmp;
            player.uiMode = "none";
            duracaoMusica = lblDuracao;
            msgInicial = lblMsgInicial;
            // Naudio
            var enumerator = new MMDeviceEnumerator();
            defaultDevice = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);

            // adicionar o efeito blur
            BlurHelper.EnableBlur(this);
        }

        // Metodos
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }
        private void ativarBotao(object btnSender)
        {
            if (btnAtual != null)
            {
                DesabilitarBtn();

                btnAtual = (IconButton)btnSender;
                btnAtual.ForeColor = Color.Yellow;
                btnAtual.Font = new Font("Gadugi", 10, System.Drawing.FontStyle.Bold);
                leftBar.Location = new System.Drawing.Point(pbh.Width + 1, btnAtual.Location.Y);

            }
            if (btnAtual.Name == "btnLibrary")
            {
                openLibraryicon.Visible = true;
                openLibrary_Click();
            }
            else
            {
                openLibraryicon.Visible = false;
            }
        }
        private void DesabilitarBtn()
        {
            if (btnAtual != null)
            {
                btnAtual.ForeColor = Color.Wheat;
                btnAtual.Font = new Font("Gadugi", 8);
            }
        }
        private void getPeakSong()
        {
            // pega o dispositivo padrao de saida
            var device = (MMDevice)defaultDevice;
            // em um intervalo pequeno de tempo, captura o maior valor da batida nesse trecho
            int value = (int)Math.Round(device.AudioMeterInformation.MasterPeakValue * 500);

            if (value > 200)
            {
                barAnimation.Enabled = true;
                pbh.Height = value + value / 2;
                pbh2.Height = value + +value / 2;
                pbh.BackColor = Color.Fuchsia;
                pbh2.BackColor = Color.Fuchsia;
                timerPulso.Enabled = true;
            }
            else
            {
                pbh.BackColor = Color.Cyan;
                pbh2.BackColor = Color.Cyan;
            }
        }
        private void gerarPulsoBarras()
        {
            if (pbh.Height > 1)
            {
                pbh.Height -= 1;
                pbh2.Height -= 1;
            }
            if (pbh.Height == 0)
            {
                timerPulso.Stop();
            }
        }
        private void openLibrary_Click()
        {
            using (Library lib = new Library())
            {
                lib.ShowDialog();
            }
        }
        public static void Play(musica song)
        {
            msgInicial.Visible = false;
            musicaAtual = song;
            controlPanel.Visible = true;
            player.URL = song.path;
            IWMPMedia media = player.newMedia(player.URL);
            duracaoMusica.Text = media.durationString;
            pbSongBar.Maximum = (int)media.duration;
            capa.Image = song.capa;
            nomeMusica.Text = song.nome;
            player.settings.rate = 1;
            player.Ctlcontrols.play();
        }
        private void playPauseClick()
        {
            switch (player.playState)
            {
                case (WMPPlayState.wmppsPlaying):
                    player.Ctlcontrols.pause();
                    break;
                case (WMPPlayState.wmppsPaused):
                    player.Ctlcontrols.play();
                    break;
                case (WMPPlayState.wmppsStopped):
                    player.Ctlcontrols.play();
                    break;
            }
        }
        private void atualizarMusicaStatus()
        {
            switch (player.playState)
            {
                case (WMPPlayState.wmppsStopped):
                    btnPlayPause.Image = new Bitmap(ButtonsIcons.Images[ButtonsIcons.Images.IndexOfKey("again")]);
                    pbDuration.Value = 0;
                    timerCurrentDuration.Stop();
                    break;
                case (WMPPlayState.wmppsPaused):
                    btnPlayPause.Image = new Bitmap(ButtonsIcons.Images[ButtonsIcons.Images.IndexOfKey("play")]);
                    timerCurrentDuration.Stop();
                    break;
                case (WMPPlayState.wmppsPlaying):
                    btnPlayPause.Image = new Bitmap(ButtonsIcons.Images[ButtonsIcons.Images.IndexOfKey("pause")]);
                    timerCurrentDuration.Start();
                    break;
            }
        }
        private void proxMusica()
        {
            int idx = Library.playList.IndexOf(musicaAtual);
            if (idx < Library.playList.IndexOf(Library.playList.Last()))
            {
                Play(Library.playList[idx + 1]);
            }
            else
            {
                Play(Library.playList[0]);
            }
        }
        private void prevMusica()
        {
            int idx = Library.playList.IndexOf(musicaAtual);
            if (idx > 0)
            {
                Play(Library.playList[idx - 1]);
            }
            else
            {
                Play(Library.playList.Last());
            }
        }
        private void atualizarPosMusica(EventArgs e)
        {
            MouseEventArgs me = e as MouseEventArgs;
            if (me != null)
            {
                double nv = (int)(me.Location.X / (double)pbDuration.Width * pbDuration.Maximum);
                if (nv > 0 && nv < pbSongBar.Maximum)
                {
                    pbDuration.Value = 0;
                    player.Ctlcontrols.currentPosition = nv;
                }
            }
        }

        // Eventos
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AtivarBtn(object btnSender, EventArgs e)
        {
            this.ativarBotao(btnSender);
        }
        private void timerNaudio_Tick(object sender, EventArgs e)
        {
            getPeakSong();
        }
        private void TimerPulso(object sender, EventArgs e)
        {
            gerarPulsoBarras();
        }
        private void openLibrary_Click(object sender, EventArgs e)
        {
            openLibrary_Click();
        }
        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            this.playPauseClick();
        }
        private void wmp_StatusChange(object sender, EventArgs e)
        {
            atualizarMusicaStatus();
        }
        private void timerCurrentDuration_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                pbDuration.Value = (int)player.Ctlcontrols.currentPosition;
                lblDuracaoAtual.Text = player.Ctlcontrols.currentPositionString;
            }
        }
        private void btnNextSong_Click(object sender, EventArgs e)
        {
            this.proxMusica();
        }
        private void btnPrevSong_Click(object sender, EventArgs e)
        {
            this.prevMusica();
        }
        private void pbDuration_Click(object sender, EventArgs e)
        {
            this.atualizarPosMusica(e);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if(Library.playList is null)
            {
                lblMsgInicial.Visible = true;
            }
        }
    }
}
