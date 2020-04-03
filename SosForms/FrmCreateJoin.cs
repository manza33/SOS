using Newtonsoft.Json;
using SosForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SosForms
{
    public partial class FrmCreateJoin : Form
    {
        private const string WebApiLink = "http://localhost:61927/games";

        public FrmCreateJoin()
        {
            InitializeComponent();
        }

        private void FrmCreateJoin_Load(object sender, EventArgs e)
        {
            btnRefresh_Click(btnRefresh, EventArgs.Empty);
        }

        private void textBoxNewGame_TextChanged(object sender, EventArgs e) => UpdateOkButton();

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO : Se connecter a : http://localhost:61927/games
                using (var http = new HttpClient())
                {
                    var response = await http.GetStringAsync(WebApiLink);
                    var data = JsonConvert.DeserializeObject<IDictionary<string, GameOnline>>(response);

                }
            }
            catch(HttpRequestException ex)
            {
                MessageBox.Show(this, ex.Message, "Connexion a l'API", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateOkButton();
        }

        public string GameName => radioButtonJoinGame.Checked
            ? lbGames.SelectedItems?.ToString()
            : textBoxNewGame.Text;

        private void UpdateOkButton() => btnOk.Enabled = GameName != null && GameName != String.Empty;


        private void lbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOkButton();
        }

        private void radioButtonJoinGame_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNewGame.Enabled = radioButtonNewGame.Checked;
            lbGames.Enabled = radioButtonJoinGame.Checked;
            UpdateOkButton();

        }
    }
}
