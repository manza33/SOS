using Newtonsoft.Json;
using SosForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SosForms
{
    public partial class FormMain : Form
    {
        private const int BoardSize = 8;
        //private bool isEmptyTile = true;
        private int Letter = 1;
        private const string WebApiLink = "http://localhost:61927/games";
        private readonly frmPreferences dlgPref = new frmPreferences();
        private readonly FrmCreateJoin dlgCreateJoin = new FrmCreateJoin();
        private readonly FrmAboutBox dlgAbout = new FrmAboutBox();
        private GameOnline LatestGame = null;
        private int MyPlayerNum = 1;
        //private GameOnline GameData = null;
        private Label[,] Labels = new Label[BoardSize, BoardSize];
        private Label[,] LabelsDir = new Label[BoardSize, BoardSize];

        private Color PlayerOneColor = Color.MistyRose;
        private Color PlayerTwoColor = Color.Lavender;

        public FormMain()
        {
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {

            for (int col = 0; col < tableBoard.ColumnCount; col++)
            {
                for (int row = 0; row < tableBoard.RowCount; row++)
                {

                    var label = new Label();                    

                    label.Dock = DockStyle.Fill;
                    label.TextAlign = ContentAlignment.MiddleCenter;
                    label.Text = String.Empty;
                    label.Font = Font;
                    label.Font = new Font("Arial", 40, FontStyle.Bold);

                    label.ImageAlign = ContentAlignment.MiddleCenter;
                    label.ImageList = imageListJeu;
                    label.ImageIndex = -1;
                    label.Tag = null;
                    label.IsAccessible = true;
                    
                    Labels[col, row] = label;

                    label.Click += Tile_Click;
                    tableBoard.Controls.Add(label, col, row);


                    var picture = new PictureBox();
                    picture.BackColor = Color.Yellow;
                    tableBoard.Controls.Add(picture, col, row);

                    label.MouseEnter += Picture_MouseEnter;
                    label.MouseLeave += Picture_MouseLeave;
                }
            }

            panel1.BackColor = PlayerOneColor;

            timerGame_Tick(timerGame, EventArgs.Empty);
            miFileCreateJoin_Click(miFileCreateJoin, EventArgs.Empty);
        }

        private void Picture_MouseLeave(object sender, EventArgs e)
        {
            var tile = sender as Label;
            if (tile.IsAccessible)
            {
                tile.ImageIndex = -1;
            }
        }

        private void Picture_MouseEnter(object sender, EventArgs e)
        {
            var tile = sender as Label;

            if (tile.IsAccessible)
            {
                if (Letter == 1)
                {
                    tile.ImageIndex = 0;
                }
                else
                {
                    tile.ImageIndex = 1;
                }
            }
        }

        private async void Tile_Click(object sender, EventArgs e)
        {
            var label = sender as Label;

            if(label == null)
            {
                return;
            }
            Cursor = Cursors.WaitCursor;
            try
            {
                using (var http = new HttpClient())
                {

                    var play = new PositionAndLetter(tableBoard.GetColumn(label), tableBoard.GetRow(label), Letter);
                    var request = new HttpRequestMessage(new HttpMethod("PATCH"), $"{ WebApiLink }/{ dlgCreateJoin.GameName}");

                    request.Content = new StringContent(
                        JsonConvert.SerializeObject(play),
                        System.Text.Encoding.UTF8,
                        "application/json"
                    );

                    var response = await http.SendAsync(request);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        ProcessReceivedGame(JsonConvert.DeserializeObject<GameOnline>(
                            await response.Content.ReadAsStringAsync()
                        ));
                    }
                    else
                    {
                        MessageBox.Show(this, response.ReasonPhrase, "Proposition Refusée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(this, ex.Message, "Envoi de la proposition", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException ex)
            {
                MessageBox.Show(this, ex.Message, "Données reçues", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }            
            timerGame_Tick(timerGame, EventArgs.Empty);
        }

        private void pictureLetterS_Click(object sender, EventArgs e)
        {
            Letter = 1;
            pictureLetterS.BackColor = Color.LightYellow;
            pictureLetterO.BackColor = Color.Empty;
        }

        private void pictureLetterO_Click(object sender, EventArgs e)
        {
            Letter = -1;
            pictureLetterO.BackColor = Color.LightYellow;
            pictureLetterS.BackColor = Color.Empty;
        }

        private void miFileQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void miFilePreferences_Click(object sender, EventArgs e)
        {
            if (dlgPref.ShowDialog(this) == DialogResult.OK)
            {
                toolstripInfo.Text = $"Vous être loggé en tant que {dlgPref.Login}";
            }
        }

        private void miHelpAbout_Click(object sender, EventArgs e)
        {
            dlgAbout.ShowDialog(this);
        }

        private async void miFileCreateJoin_Click(object sender, EventArgs e)
        {
            if (dlgCreateJoin.ShowDialog() == DialogResult.OK)
            {
                Partie.Text = $"{dlgCreateJoin.GameName}";
                timerGame_Tick(timerGame, EventArgs.Empty);
            }
        }

        private async void timerGame_Tick(object sender, EventArgs e)
        {
            try
            {
                using (var http = new HttpClient())
                {
                    var response = await http.GetStringAsync($"{WebApiLink}/{dlgCreateJoin.GameName}");
                    ProcessReceivedGame( JsonConvert.DeserializeObject<GameOnline>(response) );

                }
            }
            catch (HttpRequestException ex)
            {
                toolstripInfo.Text = $@"/!\ Erreur serveur : { ex.Message }";
            }
            catch (JsonException ex)
            {
                toolstripInfo.Text = $@"/!\ Erreur données : { ex.Message }";
            }            
        }

        private void ProcessReceivedGame(GameOnline game)
        {
            if(LatestGame == null || !game.Tiles.SequenceEqual(LatestGame.Tiles))
            {
                LatestGame = game;
                UpdateBoard();
            }
        }

        private Cursor UpdateCurPlayer()
        {
            if (!LatestGame.CurPlayer.HasValue)
            {
                timerGame.Stop();
                return Cursors.Default;
            }
            panelBoard.BackColor = toolstripInfo.BackColor = LatestGame.CurPlayer.Value == 1
                ? PlayerOneColor
                : PlayerTwoColor;
            if(LatestGame.CurPlayer == MyPlayerNum)
            {
                labelInfos.Text = "A ton tour!";
                return Cursors.Hand;
            }
            else
            {
                labelInfos.Text = "Merci d'attendre";
                return Cursors.WaitCursor;
            }
        }

        private void UpdateBoard()
        {
            labelPlayerNum.Text = MyPlayerNum.ToString();
            toolstripInfo.Text = "Récupération des données";
            SuspendLayout();
            Console.WriteLine("UpdateBoard");

            try
            {
                Cursor cursor = UpdateCurPlayer();

                var col = 0;
                var row = 0;

                foreach (var tile in LatestGame.Tiles)
                {
                    var label = Labels[col, row];

                    label.Text = "";
                    label.ImageIndex = (tile.Letter + 3) % 3 - 1;
                    label.Cursor = cursor;
                    label.Tag = null;
                    label.Font = new Font("Arial", 20, FontStyle.Bold);

                    if (label.ImageIndex != -1)
                    {
                        label.IsAccessible = false;
                    }

                    if(tile.SosPlayers[0] == 1 && tile.SosPlayers[1] == -1)
                    {
                    
                        label.BackColor = Color.Violet;
                    }
                    else if(tile.SosPlayers[0] == 1)
                    {       
                        //label.BackColor = PlayerOneColor;
                    }
                    else if (tile.SosPlayers[1] == -1)
                    {
                        //label.BackColor = PlayerTwoColor;
                    }
                    else
                    {
                        label.BackColor = Color.White;
                    }

                    if (++col >= BoardSize)
                    {
                        row++;
                        col = 0;
                    }
                }
            }
            finally
            {
                ResumeLayout();
            }            
        }

        private void miGamePlayer_Click(object sender, EventArgs e)
        {            
            var menuItem = sender as ToolStripMenuItem;            

            MyPlayerNum = int.Parse((string)menuItem.Tag);
            miGamePlayer1.Checked = MyPlayerNum == 1;
            miGamePlayer2.Checked = MyPlayerNum == -1;
            panel1.BackColor = MyPlayerNum == 1 ? PlayerOneColor : PlayerTwoColor;
            UpdateBoard();

        }


    }
}
