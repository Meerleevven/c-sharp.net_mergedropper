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
                pnlCrosshair.Left -= 10;
            }
            else if (e.KeyCode == Keys.Right)
            {
                pnlCrosshair.Left += 10;
            }
        }
    }
}
