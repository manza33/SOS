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
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableBoard = new System.Windows.Forms.TableLayoutPanel();
            this.imageListJeu = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureLetterO = new System.Windows.Forms.PictureBox();
            this.pictureLetterS = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLetterO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLetterS)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTime,
            this.toolstripInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 608);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(12, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(523, 26);
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
            this.miHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(523, 28);
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
            this.miFileCreateJoin.Size = new System.Drawing.Size(224, 26);
            this.miFileCreateJoin.Text = "&Créer/Joindre";
            this.miFileCreateJoin.Click += new System.EventHandler(this.miFileNew_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // miFilePreferences
            // 
            this.miFilePreferences.Name = "miFilePreferences";
            this.miFilePreferences.Size = new System.Drawing.Size(224, 26);
            this.miFilePreferences.Text = "&Préférences...";
            this.miFilePreferences.Click += new System.EventHandler(this.miFilePreferences_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // miFileQuit
            // 
            this.miFileQuit.Name = "miFileQuit";
            this.miFileQuit.Size = new System.Drawing.Size(224, 26);
            this.miFileQuit.Text = "&Quitter";
            this.miFileQuit.Click += new System.EventHandler(this.miFileQuit_Click);
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
            this.panel1.Controls.Add(this.pictureLetterO);
            this.panel1.Controls.Add(this.pictureLetterS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 65);
            this.panel1.TabIndex = 2;
            // 
            // tableBoard
            // 
            this.tableBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableBoard.ColumnCount = 8;
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBoard.Location = new System.Drawing.Point(0, 93);
            this.tableBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableBoard.Name = "tableBoard";
            this.tableBoard.RowCount = 8;
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableBoard.Size = new System.Drawing.Size(523, 515);
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
            // pictureLetterO
            // 
            this.pictureLetterO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureLetterO.BackgroundImage = global::SosForms.Properties.Resources.LetterO;
            this.pictureLetterO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureLetterO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureLetterO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureLetterO.Location = new System.Drawing.Point(262, 7);
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
            this.pictureLetterS.Location = new System.Drawing.Point(206, 7);
            this.pictureLetterS.Name = "pictureLetterS";
            this.pictureLetterS.Size = new System.Drawing.Size(50, 50);
            this.pictureLetterS.TabIndex = 0;
            this.pictureLetterS.TabStop = false;
            this.pictureLetterS.Click += new System.EventHandler(this.pictureLetterS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(523, 634);
            this.Controls.Add(this.tableBoard);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(402, 481);
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "S¤O¤S";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLetterO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLetterS)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem miFilePreferences;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureLetterS;
        private System.Windows.Forms.PictureBox pictureLetterO;
    }
}

