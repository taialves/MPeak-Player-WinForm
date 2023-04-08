using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TGlassPlayer;
using TagLib;

namespace PMPlayer
{
    public struct musica
    {
        public Bitmap capa;
        public string path;
        public string nome;
        public int idxImg;
    }

    public partial class Library : Form
    {
        public static List<musica> playList { get; set; }
        private string[] tmpPaths;
        public Library()
        {
            InitializeComponent();
            BlurHelper.EnableBlur(this);
            playList = playList is null ? new List<musica>() : playList;
            PopulateListSongs();
        }

        // Method
        private Bitmap getCapa(string url)
        {
            Bitmap bitmap = null;

            // Verifica se o arquivo tem uma miniatura
            var file = File.Create(url);
            if (file.Tag.Pictures.Length >= 1)
            {
                // Obtém a miniatura
                var picture = file.Tag.Pictures[0];
                // Converte a miniatura em um objeto Bitmap
                bitmap = new System.Drawing.Bitmap(new System.IO.MemoryStream(picture.Data.Data));
            }
            return bitmap;
        }
        private void PopulateListSongs()
        {
            if (playList.Count > 0)
            {
                foreach (musica mus in playList)
                {
                    capas.Images.Add(mus.nome,mus.capa);
                    ListSongs.Items.Add(new ListViewItem(mus.nome, capas.Images.IndexOfKey(mus.nome)));
                }
            }
        }

        // Event
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tmpPaths != null)
            {  
                if (tmpPaths.Length > 0)
                {
                    if (playList.Count == 0)
                    {
                        foreach (string path in tmpPaths)
                        {
                            string nome = path.Split('\\').Last();
                            Bitmap capa = getCapa(path);
                            string caminho = path;

                            playList.Add(new musica
                            {
                                capa = capa,
                                nome = nome,
                                path = caminho
                            });
                        }
                        Main.Play(playList[0]);
                    }
                    else
                    {
                        foreach (string path in tmpPaths)
                        {
                            string nome = path.Split('\\').Last();
                            Bitmap capa = getCapa(path);
                            string caminho = path;

                            playList.Add(new musica
                            {
                                capa = capa,
                                nome = nome,
                                path = caminho,
                                idxImg = capas.Images.IndexOfKey(nome)
                            }) ;
                        }
                    }
                }
            }
            this.Close();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            this.Close();
        }
        private void panelBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tmpPaths = ofd.FileNames;               

                    foreach (string path in tmpPaths)
                    {
                        string nome = path.Split('\\').Last();
                        Bitmap capa = getCapa(path);
                        capas.Images.Add(nome, capa);
                        ListSongs.Items.Add(new ListViewItem(nome, capas.Images.IndexOfKey(nome)));
                    }
                }
            }
        }

        // Api do Windows para mover a janela a partir de um Controle do Windows Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

    }
}
