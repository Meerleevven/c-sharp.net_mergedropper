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
            bool crossLeft, crossRight;
            int crosshairSpeed = 10;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Height = 575;
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
            if ((e.KeyCode == Keys.Space))
            {
                fallMovement();
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
;
            

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
            pbNamNam.Top = fall;
            fall = 440;
        }

        private void fellasUpgrade()
        {
            
        }
    }
}
