namespace SosForms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolstripInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileCreateJoin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miFilePreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.miGame = new System.Windows.Forms.ToolStripMenuItem();
            this.miGamePlayer1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miGamePlayer2 = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPlayerNum = new System.Windows.Forms.Label();
            this.labelInfos = new System.Windows.Forms.Label();
            this.labeltitre = new System.Windows.Forms.Label();
            this.Partie = new System.Windows.Forms.Label();
            this.pictureLetterO = new System.Windows.Forms.PictureBox();
            this.pictureLetterS = new System.Windows.Forms.PictureBox();
            this.tableBoard = new System.Windows.Forms.TableLayoutPanel();
            this.imageListJeu = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.panelBoard = new System.Windows.Forms.Panel();
            this.imageListDir = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLetterO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLetterS)).BeginInit();
            this.tableBoard.SuspendLayout();
            this.panelBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTime,
            this.toolstripInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(12, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(607, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTime
            // 
            this.toolStripTime.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTime.Name = "toolStripTime";
            this.toolStripTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripTime.Size = new System.Drawing.Size(44, 20);
            this.toolStripTime.Text = "00:00";
            // 
            // toolstripInfo
            // 
            this.toolstripInfo.Name = "toolstripInfo";
            this.toolstripInfo.Size = new System.Drawing.Size(88, 20);
            this.toolstripInfo.Text = "Aucune info";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miGame,
            this.miHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(607, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileCreateJoin,
            this.toolStripMenuItem1,
            this.miFilePreferences,
            this.toolStripMenuItem2,
            this.miFileQuit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(66, 24);
            this.miFile.Text = "&Fichier";
            // 
            // miFileCreateJoin
            // 
            this.miFileCreateJoin.Name = "miFileCreateJoin";
            this.miFileCreateJoin.Size = new System.Drawing.Size(181, 26);
            this.miFileCreateJoin.Text = "&Créer/Joindre";
            this.miFileCreateJoin.Click += new System.EventHandler(this.miFileCreateJoin_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // miFilePreferences
            // 
            this.miFilePreferences.Name = "miFilePreferences";
            this.miFilePreferences.Size = new System.Drawing.Size(181, 26);
            this.miFilePreferences.Text = "&Préférences...";
            this.miFilePreferences.Click += new System.EventHandler(this.miFilePreferences_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 6);
            // 
            // miFileQuit
            // 
            this.miFileQuit.Name = "miFileQuit";
            this.miFileQuit.Size = new System.Drawing.Size(181, 26);
            this.miFileQuit.Text = "&Quitter";
            this.miFileQuit.Click += new System.EventHandler(this.miFileQuit_Click);
            // 
            // miGame
            // 
            this.miGame.CheckOnClick = true;
            this.miGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miGamePlayer1,
            this.miGamePlayer2});
            this.miGame.Name = "miGame";
            this.miGame.Size = new System.Drawing.Size(60, 24);
            this.miGame.Text = "&Partie";
            // 
            // miGamePlayer1
            // 
            this.miGamePlayer1.BackColor = System.Drawing.Color.MistyRose;
            this.miGamePlayer1.Checked = true;
            this.miGamePlayer1.CheckOnClick = true;
            this.miGamePlayer1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miGamePlayer1.Name = "miGamePlayer1";
            this.miGamePlayer1.Size = new System.Drawing.Size(224, 26);
            this.miGamePlayer1.Tag = "1";
            this.miGamePlayer1.Text = "Rose";
            this.miGamePlayer1.Click += new System.EventHandler(this.miGamePlayer_Click);
            // 
            // miGamePlayer2
            // 
            this.miGamePlayer2.BackColor = System.Drawing.Color.Lavender;
            this.miGamePlayer2.CheckOnClick = true;
            this.miGamePlayer2.Name = "miGamePlayer2";
            this.miGamePlayer2.Size = new System.Drawing.Size(224, 26);
            this.miGamePlayer2.Tag = "-1";
            this.miGamePlayer2.Text = "Violet";
            this.miGamePlayer2.Click += new System.EventHandler(this.miGamePlayer_Click);
            // 
            // miHelp
            // 
            this.miHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelpAbout});
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(30, 24);
            this.miHelp.Text = "&?";
            // 
            // miHelpAbout
            // 
            this.miHelpAbout.Name = "miHelpAbout";
            this.miHelpAbout.Size = new System.Drawing.Size(158, 26);
            this.miHelpAbout.Text = "&A Propos..";
            this.miHelpAbout.Click += new System.EventHandler(this.miHelpAbout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPlayerNum);
            this.panel1.Controls.Add(this.labelInfos);
            this.panel1.Controls.Add(this.labeltitre);
            this.panel1.Controls.Add(this.Partie);
            this.panel1.Controls.Add(this.pictureLetterO);
            this.panel1.Controls.Add(this.pictureLetterS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 65);
            this.panel1.TabIndex = 2;
            // 
            // labelPlayerNum
            // 
            this.labelPlayerNum.AutoSize = true;
            this.labelPlayerNum.Location = new System.Drawing.Point(499, 25);
            this.labelPlayerNum.Name = "labelPlayerNum";
            this.labelPlayerNum.Size = new System.Drawing.Size(46, 17);
            this.labelPlayerNum.TabIndex = 5;
            this.labelPlayerNum.Text = "label1";
            // 
            // labelInfos
            // 
            this.labelInfos.AutoSize = true;
            this.labelInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfos.Location = new System.Drawing.Point(7, 34);
            this.labelInfos.Name = "labelInfos";
            this.labelInfos.Size = new System.Drawing.Size(83, 17);
            this.labelInfos.TabIndex = 4;
            this.labelInfos.Text = "En attente";
            // 
            // labeltitre
            // 
            this.labeltitre.AutoSize = true;
            this.labeltitre.Location = new System.Drawing.Point(7, 13);
            this.labeltitre.Name = "labeltitre";
            this.labeltitre.Size = new System.Drawing.Size(53, 17);
            this.labeltitre.TabIndex = 3;
            this.labeltitre.Text = "Partie :";
            // 
            // Partie
            // 
            this.Partie.AutoSize = true;
            this.Partie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Partie.Location = new System.Drawing.Point(66, 13);
            this.Partie.Name = "Partie";
            this.Partie.Size = new System.Drawing.Size(83, 17);
            this.Partie.TabIndex = 2;
            this.Partie.Text = "En attente";
            // 
            // pictureLetterO
            // 
            this.pictureLetterO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureLetterO.BackgroundImage = global::SosForms.Properties.Resources.LetterO;
            this.pictureLetterO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLetterO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLetterO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLetterO.Location = new System.Drawing.Point(305, 8);
            this.pictureLetterO.Name = "pictureLetterO";
            this.pictureLetterO.Size = new System.Drawing.Size(50, 50);
            this.pictureLetterO.TabIndex = 1;
            this.pictureLetterO.TabStop = false;
            this.pictureLetterO.Click += new System.EventHandler(this.pictureLetterO_Click);
            // 
            // pictureLetterS
            // 
            this.pictureLetterS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureLetterS.BackgroundImage = global::SosForms.Properties.Resources.LetterS;
            this.pictureLetterS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLetterS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLetterS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLetterS.InitialImage = global::SosForms.Properties.Resources.LetterO;
            this.pictureLetterS.Location = new System.Drawing.Point(249, 8);
            this.pictureLetterS.Name = "pictureLetterS";
            this.pictureLetterS.Size = new System.Drawing.Size(50, 50);
            this.pictureLetterS.TabIndex = 0;
            this.pictureLetterS.TabStop = false;
            this.pictureLetterS.Click += new System.EventHandler(this.pictureLetterS_Click);
            // 
            // tableBoard
            // 
            this.tableBoard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableBoard.BackColor = System.Drawing.Color.White;
            this.tableBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableBoard.ColumnCount = 8;
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableBoard.Controls.Add(this.label1, 0, 0);
            this.tableBoard.Location = new System.Drawing.Point(19, 22);
            this.tableBoard.Margin = new System.Windows.Forms.Padding(0);
            this.tableBoard.Name = "tableBoard";
            this.tableBoard.RowCount = 8;
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableBoard.Size = new System.Drawing.Size(570, 570);
            this.tableBoard.TabIndex = 3;
            // 
            // imageListJeu
            // 
            this.imageListJeu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListJeu.ImageStream")));
            this.imageListJeu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListJeu.Images.SetKeyName(0, "LetterS.png");
            this.imageListJeu.Images.SetKeyName(1, "LetterO.png");
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 2000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // panelBoard
            // 
            this.panelBoard.Controls.Add(this.tableBoard);
            this.panelBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBoard.Location = new System.Drawing.Point(0, 93);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(607, 614);
            this.panelBoard.TabIndex = 4;
            // 
            // imageListDir
            // 
            this.imageListDir.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDir.ImageStream")));
            this.imageListDir.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDir.Images.SetKeyName(0, "TREFL10QM-UR34JJ927-050dfb7fdd3d-512.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(607, 733);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(625, 780);
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "S¤O¤S";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLetterO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLetterS)).EndInit();
            this.tableBoard.ResumeLayout(false);
            this.tableBoard.PerformLayout();
            this.panelBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileCreateJoin;
        private System.Windows.Forms.ToolStripMenuItem miFileQuit;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripMenuItem miHelpAbout;
        private System.Windows.Forms.ToolStripStatusLabel toolstripInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableBoard;
        private System.Windows.Forms.ImageList imageListJeu;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureLetterS;
        private System.Windows.Forms.PictureBox pictureLetterO;
        private System.Windows.Forms.Label Partie;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.ToolStripMenuItem miFilePreferences;
        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.ToolStripMenuItem miGame;
        private System.Windows.Forms.ToolStripMenuItem miGamePlayer1;
        private System.Windows.Forms.ToolStripMenuItem miGamePlayer2;
        private System.Windows.Forms.Label labeltitre;
        private System.Windows.Forms.Label labelInfos;
        private System.Windows.Forms.Label labelPlayerNum;
        private System.Windows.Forms.ImageList imageListDir;
        private System.Windows.Forms.Label label1;
    }
}

