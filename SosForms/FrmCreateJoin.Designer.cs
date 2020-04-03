namespace SosForms
{
    partial class FrmCreateJoin
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
            this.radioButtonNewGame = new System.Windows.Forms.RadioButton();
            this.textBoxNewGame = new System.Windows.Forms.TextBox();
            this.radioButtonJoinGame = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbGames = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // radioButtonNewGame
            // 
            this.radioButtonNewGame.AutoSize = true;
            this.radioButtonNewGame.Checked = true;
            this.radioButtonNewGame.Location = new System.Drawing.Point(13, 13);
            this.radioButtonNewGame.Name = "radioButtonNewGame";
            this.radioButtonNewGame.Size = new System.Drawing.Size(124, 21);
            this.radioButtonNewGame.TabIndex = 0;
            this.radioButtonNewGame.TabStop = true;
            this.radioButtonNewGame.Text = "Nouvelle partie";
            this.radioButtonNewGame.UseVisualStyleBackColor = true;
            // 
            // textBoxNewGame
            // 
            this.textBoxNewGame.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBoxNewGame.Location = new System.Drawing.Point(13, 41);
            this.textBoxNewGame.Name = "textBoxNewGame";
            this.textBoxNewGame.Size = new System.Drawing.Size(100, 22);
            this.textBoxNewGame.TabIndex = 1;
            this.textBoxNewGame.Text = "Nouveau";
            this.textBoxNewGame.TextChanged += new System.EventHandler(this.textBoxNewGame_TextChanged);
            // 
            // radioButtonJoinGame
            // 
            this.radioButtonJoinGame.AutoSize = true;
            this.radioButtonJoinGame.Location = new System.Drawing.Point(13, 70);
            this.radioButtonJoinGame.Name = "radioButtonJoinGame";
            this.radioButtonJoinGame.Size = new System.Drawing.Size(144, 21);
            this.radioButtonJoinGame.TabIndex = 2;
            this.radioButtonJoinGame.Text = "Joindre une partie";
            this.radioButtonJoinGame.UseVisualStyleBackColor = true;
            this.radioButtonJoinGame.CheckedChanged += new System.EventHandler(this.radioButtonJoinGame_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(299, 69);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Actualiser";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(312, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(231, 204);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lbGames
            // 
            this.lbGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGames.HideSelection = false;
            this.lbGames.Location = new System.Drawing.Point(13, 98);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(374, 88);
            this.lbGames.TabIndex = 7;
            this.lbGames.UseCompatibleStateImageBehavior = false;
            this.lbGames.SelectedIndexChanged += new System.EventHandler(this.lbGames_SelectedIndexChanged);
            // 
            // FrmCreateJoin
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(399, 239);
            this.Controls.Add(this.lbGames);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.radioButtonJoinGame);
            this.Controls.Add(this.textBoxNewGame);
            this.Controls.Add(this.radioButtonNewGame);
            this.Name = "FrmCreateJoin";
            this.Text = "FrmCreateJoin";
            this.Load += new System.EventHandler(this.FrmCreateJoin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonNewGame;
        private System.Windows.Forms.TextBox textBoxNewGame;
        private System.Windows.Forms.RadioButton radioButtonJoinGame;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListView lbGames;
    }
}