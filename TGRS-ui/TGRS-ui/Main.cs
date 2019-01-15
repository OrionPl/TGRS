using System;
using System.Windows.Forms;
using TGRS_CSharp_API;

namespace TGRS_ui
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void getUserLib_Click(object sender, EventArgs e)
        {
            TGRS_API api = new TGRS_API();
          //  api.GetGameLibrary(int.Parse(userIdTB.Text));
        }

        private void getGameButton_Click(object sender, EventArgs e)
        {
            TGRS_API api = new TGRS_API();
            //Game g = api.getGame(int.Parse(gameIdTB.Text));
           // outputRB.Text += g.name + "\n";
        //    outputRB.Text += g.description + "\n";
        }
    }
}
