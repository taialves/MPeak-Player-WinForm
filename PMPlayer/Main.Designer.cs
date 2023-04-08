using System.Drawing;
using System.Windows.Forms;

namespace TGlassPlayer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.leftBar = new System.Windows.Forms.Panel();
            this.timerNaudio = new System.Windows.Forms.Timer(this.components);
            this.timerPulso = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbh = new System.Windows.Forms.Panel();
            this.pbh2panel = new System.Windows.Forms.Panel();
            this.pbh2 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnLibrary = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.controlsSongPanel = new System.Windows.Forms.Panel();
            this.btnPlayPause = new CustomBox.RJControls.RJButton();
            this.ButtonsIcons = new System.Windows.Forms.ImageList(this.components);
            this.pbDuration = new CustomBox.RJControls.RJProgressBar();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.btnNextSong = new System.Windows.Forms.PictureBox();
            this.lblSongName = new System.Windows.Forms.Label();
            this.btnPrevSong = new System.Windows.Forms.PictureBox();
            this.lblDuracaoAtual = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.capaSong = new System.Windows.Forms.PictureBox();
            this.openLibraryicon = new System.Windows.Forms.Label();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MusicControls = new System.Windows.Forms.Timer(this.components);
            this.timerCurrentDuration = new System.Windows.Forms.Timer(this.components);
            this.barAnimation = new System.Windows.Forms.Timer(this.components);
            this.lblMsgInicial = new System.Windows.Forms.Label();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.pbh2panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.controlsSongPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNextSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBar.Controls.Add(this.pictureBox2);
            this.panelBar.Controls.Add(this.btn_close);
            this.panelBar.Controls.Add(this.pictureBox3);
            this.panelBar.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(7, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(185, 13);
            this.panelBar.TabIndex = 3;
            this.panelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(6, 6);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(9, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(6, 6);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 3;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(37, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 6);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // leftBar
            // 
            this.leftBar.BackColor = System.Drawing.Color.White;
            this.leftBar.Location = new System.Drawing.Point(11, 109);
            this.leftBar.Name = "leftBar";
            this.leftBar.Size = new System.Drawing.Size(5, 29);
            this.leftBar.TabIndex = 10;
            // 
            // timerNaudio
            // 
            this.timerNaudio.Enabled = true;
            this.timerNaudio.Interval = 50;
            this.timerNaudio.Tick += new System.EventHandler(this.timerNaudio_Tick);
            // 
            // timerPulso
            // 
            this.timerPulso.Interval = 10;
            this.timerPulso.Tick += new System.EventHandler(this.TimerPulso);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pbh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 570);
            this.panel3.TabIndex = 16;
            // 
            // pbh
            // 
            this.pbh.BackColor = System.Drawing.Color.Cyan;
            this.pbh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbh.Location = new System.Drawing.Point(0, 561);
            this.pbh.Name = "pbh";
            this.pbh.Size = new System.Drawing.Size(7, 9);
            this.pbh.TabIndex = 0;
            // 
            // pbh2panel
            // 
            this.pbh2panel.BackColor = System.Drawing.Color.Transparent;
            this.pbh2panel.Controls.Add(this.pbh2);
            this.pbh2panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbh2panel.Location = new System.Drawing.Point(192, 0);
            this.pbh2panel.Name = "pbh2panel";
            this.pbh2panel.Size = new System.Drawing.Size(7, 570);
            this.pbh2panel.TabIndex = 16;
            // 
            // pbh2
            // 
            this.pbh2.BackColor = System.Drawing.Color.Cyan;
            this.pbh2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbh2.Location = new System.Drawing.Point(0, 561);
            this.pbh2.Name = "pbh2";
            this.pbh2.Size = new System.Drawing.Size(7, 9);
            this.pbh2.TabIndex = 0;
            // 
            // iconButton5
            // 
            this.iconButton5.AutoSize = true;
            this.iconButton5.BackColor = System.Drawing.Color.Transparent;
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Gadugi", 8F);
            this.iconButton5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Monument;
            this.iconButton5.IconColor = System.Drawing.Color.Azure;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 17;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(19, 250);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(129, 28);
            this.iconButton5.TabIndex = 21;
            this.iconButton5.Text = "   Notifications";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.AtivarBtn);
            // 
            // iconButton6
            // 
            this.iconButton6.BackColor = System.Drawing.Color.Transparent;
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Gadugi", 8F);
            this.iconButton6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.FireFlameCurved;
            this.iconButton6.IconColor = System.Drawing.Color.Azure;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 17;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(19, 285);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(129, 28);
            this.iconButton6.TabIndex = 22;
            this.iconButton6.Text = "   Settings";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.AtivarBtn);
            // 
            // iconButton4
            // 
            this.iconButton4.AutoSize = true;
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Gadugi", 8F);
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Crown;
            this.iconButton4.IconColor = System.Drawing.Color.Azure;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 17;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(19, 213);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(129, 28);
            this.iconButton4.TabIndex = 23;
            this.iconButton4.Text = "   Premium";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.AtivarBtn);
            // 
            // btnLibrary
            // 
            this.btnLibrary.AutoSize = true;
            this.btnLibrary.BackColor = System.Drawing.Color.Transparent;
            this.btnLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibrary.FlatAppearance.BorderSize = 0;
            this.btnLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Gadugi", 8F);
            this.btnLibrary.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLibrary.IconChar = FontAwesome.Sharp.IconChar.FolderClosed;
            this.btnLibrary.IconColor = System.Drawing.Color.Azure;
            this.btnLibrary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibrary.IconSize = 17;
            this.btnLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.Location = new System.Drawing.Point(19, 178);
            this.btnLibrary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(129, 28);
            this.btnLibrary.TabIndex = 24;
            this.btnLibrary.Text = "   Your Library";
            this.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibrary.UseVisualStyleBackColor = false;
            this.btnLibrary.Click += new System.EventHandler(this.AtivarBtn);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Gadugi", 8F);
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.iconButton2.IconColor = System.Drawing.Color.Azure;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 17;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(19, 143);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(129, 28);
            this.iconButton2.TabIndex = 25;
            this.iconButton2.Text = "   Search";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.AtivarBtn);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnHome.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 17;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(19, 109);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(128, 28);
            this.btnHome.TabIndex = 26;
            this.btnHome.Text = "   Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.AtivarBtn);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.lblMsgInicial);
            this.panel4.Controls.Add(this.controlsSongPanel);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.capaSong);
            this.panel4.Controls.Add(this.openLibraryicon);
            this.panel4.Controls.Add(this.wmp);
            this.panel4.Controls.Add(this.panelBar);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.iconButton5);
            this.panel4.Controls.Add(this.pbh2panel);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.iconButton6);
            this.panel4.Controls.Add(this.leftBar);
            this.panel4.Controls.Add(this.iconButton4);
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.Controls.Add(this.btnLibrary);
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 570);
            this.panel4.TabIndex = 27;
            // 
            // controlsSongPanel
            // 
            this.controlsSongPanel.Controls.Add(this.btnPlayPause);
            this.controlsSongPanel.Controls.Add(this.pbDuration);
            this.controlsSongPanel.Controls.Add(this.lblDuracao);
            this.controlsSongPanel.Controls.Add(this.btnNextSong);
            this.controlsSongPanel.Controls.Add(this.lblSongName);
            this.controlsSongPanel.Controls.Add(this.btnPrevSong);
            this.controlsSongPanel.Controls.Add(this.lblDuracaoAtual);
            this.controlsSongPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlsSongPanel.Location = new System.Drawing.Point(7, 459);
            this.controlsSongPanel.Name = "controlsSongPanel";
            this.controlsSongPanel.Size = new System.Drawing.Size(185, 106);
            this.controlsSongPanel.TabIndex = 34;
            this.controlsSongPanel.Visible = false;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlayPause.BorderRadius = 22;
            this.btnPlayPause.BorderSize = 0;
            this.btnPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayPause.FlatAppearance.BorderSize = 0;
            this.btnPlayPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.ImageIndex = 1;
            this.btnPlayPause.ImageList = this.ButtonsIcons;
            this.btnPlayPause.Location = new System.Drawing.Point(70, 60);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(38, 37);
            this.btnPlayPause.TabIndex = 33;
            this.btnPlayPause.TextColor = System.Drawing.Color.White;
            this.btnPlayPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // ButtonsIcons
            // 
            this.ButtonsIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ButtonsIcons.ImageStream")));
            this.ButtonsIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ButtonsIcons.Images.SetKeyName(0, "pause");
            this.ButtonsIcons.Images.SetKeyName(1, "play");
            this.ButtonsIcons.Images.SetKeyName(2, "again");
            this.ButtonsIcons.Images.SetKeyName(3, "dance");
            // 
            // pbDuration
            // 
            this.pbDuration.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.pbDuration.ChannelHeight = 6;
            this.pbDuration.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.pbDuration.ForeColor = System.Drawing.Color.White;
            this.pbDuration.Location = new System.Drawing.Point(6, 47);
            this.pbDuration.Name = "pbDuration";
            this.pbDuration.ShowMaximun = false;
            this.pbDuration.ShowValue = CustomBox.RJControls.TextPosition.None;
            this.pbDuration.Size = new System.Drawing.Size(168, 10);
            this.pbDuration.SliderColor = System.Drawing.Color.Yellow;
            this.pbDuration.SliderHeight = 6;
            this.pbDuration.Step = 1;
            this.pbDuration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDuration.SymbolAfter = "";
            this.pbDuration.SymbolBefore = "";
            this.pbDuration.TabIndex = 29;
            this.pbDuration.Value = 25;
            this.pbDuration.Click += new System.EventHandler(this.pbDuration_Click);
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblDuracao.Location = new System.Drawing.Point(146, 32);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(28, 13);
            this.lblDuracao.TabIndex = 32;
            this.lblDuracao.Text = "2:15";
            // 
            // btnNextSong
            // 
            this.btnNextSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextSong.Image = ((System.Drawing.Image)(resources.GetObject("btnNextSong.Image")));
            this.btnNextSong.Location = new System.Drawing.Point(151, 71);
            this.btnNextSong.Name = "btnNextSong";
            this.btnNextSong.Size = new System.Drawing.Size(10, 18);
            this.btnNextSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNextSong.TabIndex = 30;
            this.btnNextSong.TabStop = false;
            this.btnNextSong.Click += new System.EventHandler(this.btnNextSong_Click);
            // 
            // lblSongName
            // 
            this.lblSongName.AutoEllipsis = true;
            this.lblSongName.BackColor = System.Drawing.Color.Black;
            this.lblSongName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSongName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblSongName.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblSongName.Location = new System.Drawing.Point(0, 0);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(185, 24);
            this.lblSongName.TabIndex = 32;
            this.lblSongName.Text = "Nome da Musica";
            this.lblSongName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevSong
            // 
            this.btnPrevSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevSong.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevSong.Image")));
            this.btnPrevSong.Location = new System.Drawing.Point(23, 71);
            this.btnPrevSong.Name = "btnPrevSong";
            this.btnPrevSong.Size = new System.Drawing.Size(10, 18);
            this.btnPrevSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPrevSong.TabIndex = 30;
            this.btnPrevSong.TabStop = false;
            this.btnPrevSong.Click += new System.EventHandler(this.btnPrevSong_Click);
            // 
            // lblDuracaoAtual
            // 
            this.lblDuracaoAtual.AutoSize = true;
            this.lblDuracaoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.lblDuracaoAtual.Location = new System.Drawing.Point(6, 32);
            this.lblDuracaoAtual.Name = "lblDuracaoAtual";
            this.lblDuracaoAtual.Size = new System.Drawing.Size(34, 13);
            this.lblDuracaoAtual.TabIndex = 32;
            this.lblDuracaoAtual.Text = "00:56";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(7, 565);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 5);
            this.panel2.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(61, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "P e a k";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14F);
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(87, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "M";
            // 
            // capaSong
            // 
            this.capaSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.capaSong.ErrorImage = ((System.Drawing.Image)(resources.GetObject("capaSong.ErrorImage")));
            this.capaSong.Image = global::PMPlayer.Properties.Resources.giphy;
            this.capaSong.InitialImage = ((System.Drawing.Image)(resources.GetObject("capaSong.InitialImage")));
            this.capaSong.Location = new System.Drawing.Point(16, 377);
            this.capaSong.Name = "capaSong";
            this.capaSong.Size = new System.Drawing.Size(168, 79);
            this.capaSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.capaSong.TabIndex = 28;
            this.capaSong.TabStop = false;
            // 
            // openLibraryicon
            // 
            this.openLibraryicon.AutoSize = true;
            this.openLibraryicon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openLibraryicon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.openLibraryicon.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.openLibraryicon.Location = new System.Drawing.Point(165, 182);
            this.openLibraryicon.Name = "openLibraryicon";
            this.openLibraryicon.Size = new System.Drawing.Size(19, 20);
            this.openLibraryicon.TabIndex = 27;
            this.openLibraryicon.Text = ">";
            this.openLibraryicon.Visible = false;
            this.openLibraryicon.Click += new System.EventHandler(this.openLibrary_Click);
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(16, 319);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(162, 57);
            this.wmp.TabIndex = 18;
            this.wmp.StatusChange += new System.EventHandler(this.wmp_StatusChange);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(85, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 1);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MusicControls
            // 
            this.MusicControls.Enabled = true;
            // 
            // timerCurrentDuration
            // 
            this.timerCurrentDuration.Enabled = true;
            this.timerCurrentDuration.Tick += new System.EventHandler(this.timerCurrentDuration_Tick);
            // 
            // barAnimation
            // 
            this.barAnimation.Interval = 500;
            // 
            // lblMsgInicial
            // 
            this.lblMsgInicial.Location = new System.Drawing.Point(16, 346);
            this.lblMsgInicial.Name = "lblMsgInicial";
            this.lblMsgInicial.Size = new System.Drawing.Size(165, 30);
            this.lblMsgInicial.TabIndex = 36;
            this.lblMsgInicial.Text = "Selecione sua melhor playlis e Divirta-se !";
            this.lblMsgInicial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(199, 570);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pbh2panel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.controlsSongPanel.ResumeLayout(false);
            this.controlsSongPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNextSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capaSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox btn_close;
        private Panel panelBar;
        private Panel leftBar;
        private System.Windows.Forms.Timer timerNaudio;
        private System.Windows.Forms.Timer timerPulso;
        private Panel panel3;
        private Panel pbh;
        private Panel pbh2panel;
        private Panel pbh2;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btnLibrary;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panel4;
        private Label openLibraryicon;
        public AxWMPLib.AxWindowsMediaPlayer wmp;
        private PictureBox capaSong;
        private PictureBox btnNextSong;
        private CustomBox.RJControls.RJProgressBar pbDuration;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox btnPrevSong;
        private Label lblDuracao;
        private Label lblDuracaoAtual;
        private Label lblSongName;
        private Timer MusicControls;
        private ImageList ButtonsIcons;
        private CustomBox.RJControls.RJButton btnPlayPause;
        private Panel controlsSongPanel;
        private Timer timerCurrentDuration;
        private Panel panel2;
        private Timer barAnimation;
        private Label lblMsgInicial;
    }
}