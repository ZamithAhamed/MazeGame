using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSoundPlayer = new System.Media.SoundPlayer(@"C:\Users\Zamith\Music\MidwayGauntletG010.wav");
        System.Media.SoundPlayer startSoundPlayer1 = new System.Media.SoundPlayer(@"C:\Users\Zamith\Music\swchewy.wav");
        public Form1()
        {
            InitializeComponent();
            reset();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            startSoundPlayer1.Play();
            reset();
            MessageBox.Show("Failed!!, Try Again");
        }

        private void FinishPoint_MouseEnter(object sender, EventArgs e)
        {
            startSoundPlayer.Play();
            MessageBox.Show("Congrats!!");
            Close();
        }

        private void reset() {
            
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10,10);
            Cursor.Position = PointToScreen(startingPoint);
        }

    }
}
