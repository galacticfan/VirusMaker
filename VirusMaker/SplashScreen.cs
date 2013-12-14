using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusMaker
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            splashScreenTimer.Start();
        }

        bool hasTicked = false;

        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            bool currentTick = true;
            if (currentTick != hasTicked && currentTick == true)
            {
                
                splashScreenTimer.Stop();
                this.Close();
            }
        }


    }
}
