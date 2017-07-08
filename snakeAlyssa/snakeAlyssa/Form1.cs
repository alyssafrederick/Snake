using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakeAlyssa
{
    public partial class snakeeee : Form
    {
        Graphics gfx;
        List<Snake> snakes;

        public snakeeee()
        {
            InitializeComponent();
        }

        private void snakeeee_Load(object sender, EventArgs e)
        {
            gfx = CreateGraphics();
            timer.Start();
            snakes = new List<Snake>();
            snakes.Add(new Snake(30, 30, 5, 5));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < snakes.Count; i++)
            {
                snakes[i].Update();
                snakes[i].Render(gfx);
            }
        }

        private void snakeeee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
            {
                snakes[0].Direction = 1;
            }

            if (e.KeyData == Keys.Right)
            {
                snakes[0].Direction = 2;
            }

            if (e.KeyData == Keys.Up)
            {
                snakes[0].Direction = 3;
            }

            if (e.KeyData == Keys.Down)
            {
                snakes[0].Direction = 4;
            }
        }
    }
}
