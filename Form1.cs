using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _sideproject_mergedropper
{
    public partial class Form1 : Form
    {
            int fall;
            int currentfella = 0;
            bool crossLeft, crossRight;
            int crosshairSpeed = 10;
            List<PictureBox> theFellas = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Height = 575;
            fellas();
            foreach (PictureBox fellas in theFellas)
            {
                fellas.Visible = false;
                fellas.Top = fall;

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left) 
            {
                crossLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                crossRight = true;
            }
            if ((e.KeyCode == Keys.Space && currentfella < theFellas.Count))
            {
               PictureBox dropfella = theFellas[currentfella];
                dropfella.Visible = true;
                dropfella.Top = fall;
                currentfella++;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                crossLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                crossRight = false;
            }
            if ((e.KeyCode == Keys.Space))
            {
            }
        }

        private void tmrmain_Tick(object sender, EventArgs e)
        {
            fall = 440;

            if (crossLeft == true && pnlCrosshair.Left > 133)
            {
                pnlCrosshair.Left -= crosshairSpeed;
            }
            if(crossRight == true && pnlCrosshair.Left + (pnlCrosshair.Width + 40) < this.ClientSize.Width)
            {
                pnlCrosshair.Left += crosshairSpeed;
            }
 
        }

        private void fallMovement()
        {

        }

        private void fellas()
        {
            theFellas.Add(pbNamNam);
            theFellas.Add(pbMonkol);
            theFellas.Add(pbElbowpad);
            theFellas.Add(pbHandwraps);
            theFellas.Add(pbWaikru);
            theFellas.Add(pbBoxinggloves);
            theFellas.Add(pbShinguards);
            theFellas.Add(pbThaipads);
            theFellas.Add(pbBoxingbag);
            theFellas.Add(pbBoxingring);

        }
    }
}
