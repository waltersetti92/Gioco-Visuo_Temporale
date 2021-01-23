using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visuo_Tempo_WS
{
    public partial class Interaction : UserControl
    {
        public Main parentForm { get; set; }
        public int timeleft = 6;
        public Interaction()
        {
            InitializeComponent();
           
        }

        private void Interaction_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            parentForm.playbackResourceAudio("MC");
        }
        public void setPos(int w, int h)
        {

            int offset = 0;
            Location = new Point(offset, offset);
            Width = w - 1 * offset;
            Height = h - 1 * offset;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timeleft > 0)
            {
                timeleft= timeleft-1;
                timerLabel.Text = timeleft.ToString();
                parentForm.playbackResourceAudio("MC");
            }
            else if (timeleft == 0)
            {
                timer1.Stop();
            }
        }
    }
}
