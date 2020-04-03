using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SosForms
{
    public partial class FormMain : Form
    {
        //private bool isEmptyTile = true;
        private int Letter = 1;


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
                    var picture = new PictureBox();
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    picture.Dock = DockStyle.Fill;
                    picture.IsAccessible = true;

                    picture.Click += Tile_Click;
                    picture.Cursor = Cursors.Hand;
                    tableBoard.Controls.Add(picture, col, row);

                    picture.MouseEnter += Picture_MouseEnter;
                    picture.MouseLeave += Picture_MouseLeave;
                }
            }
            pictureLetterS.BackColor = Color.LightYellow;

        }

        private void Picture_MouseLeave(object sender, EventArgs e)
        {
            var tile = sender as PictureBox;
            if (tile.IsAccessible)
            {
                tile.Image = null;
            }
        }

        private void Picture_MouseEnter(object sender, EventArgs e)
        {
            var tile = sender as PictureBox;

            if (tile.IsAccessible)
            {
                if (Letter == 1)
                {
                    tile.Image = imageListJeu.Images[0];
                }
                else
                {
                    tile.Image = imageListJeu.Images[1];
                }
            }
        }


        private void Tile_Click(object sender, EventArgs e)
        {
            var tile = sender as PictureBox;
            if (Letter == 1)
            {
                tile.Image = imageListJeu.Images[0];
                tile.IsAccessible = false;
            }
            else
            {
                tile.Image = imageListJeu.Images[1];
                tile.IsAccessible = false;
            }
            tile.SizeMode = PictureBoxSizeMode.StretchImage;
            tile.Dock = DockStyle.Fill;
            tile.BackColor = Color.LightYellow;

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


        private frmPreferences dlgPref = new frmPreferences();
        private void miFilePreferences_Click(object sender, EventArgs e)
        {

            if (dlgPref.ShowDialog() == DialogResult.OK)
            {
                toolstripInfo.Text = $"Vous être loggé en tant que {dlgPref.Login}";
            }
        }

        private void miHelpAbout_Click(object sender, EventArgs e)
        {
            var dlg = new FrmAboutBox();
            dlg.ShowDialog();
        }

        private void miFileNew_Click(object sender, EventArgs e)
        {
            var dlg = new FrmCreateJoin();
            dlg.ShowDialog();
        }
    }
}
