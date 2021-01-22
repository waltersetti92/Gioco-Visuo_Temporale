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
    public partial class Initial : UserControl
    {
        public Main parentForm { get; set; }
        public Initial()
        {
            InitializeComponent();
        }
        public void setPos(int w, int h)
        {
            int offset = 100;
            Location = new Point(offset, offset);
            Width = w - 2 * offset;
            Height = h - 2 * offset;
        }
        private void Initial_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //parentForm.playbackResourceAudio("MC");       
            parentForm.onStart();
            this.Visible = false;
        }
    }
}
