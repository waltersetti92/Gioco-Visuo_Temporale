using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;


namespace Visuo_Tempo_WS
{
    public partial class Main : Form
    {
        public static readonly string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        public static readonly string resourcesPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Resources";
        private UserControl currUC = null;
        public SoundPlayer player = null;
        private const string background_image = "Cielo_Stellato.png";
        public Main()
        {
            InitializeComponent();
            initial1.parentForm = this;
            interaction1.parentForm = this;
            initial1.Visible = false;
            interaction1.Visible = false;
            home();
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Image.FromFile(resourcesPath + "\\" + background_image);
        }
        public void home()
        {
            if (currUC != null) currUC.Visible = false;
            initial1.Show();
            currUC = initial1;
        }
        public void playbackResourceAudio(string audioname)
        {
            string s = resourcesPath + "\\" + audioname + ".wav";
            player = new SoundPlayer(s);
            player.Play();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Size size = this.Size;
            initial1.setPos(size.Width, size.Height);
            interaction1.setPos(size.Width, size.Height);
        }
        public void onStart()
        {
            initial1.Visible = false;
            interaction1.Visible = true;
            currUC = interaction1;
        }
    }
}
