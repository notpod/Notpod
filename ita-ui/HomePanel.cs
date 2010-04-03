using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iTunesAgent.UI
{
    public partial class HomePanel : UserControl
    {
        public HomePanel()
        {
            InitializeComponent();
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {
            updateVersionInformation();
        }

        private void updateVersionInformation()
        {
            labelVersionInformation.Text = "You are running the newest version, " + Application.ProductVersion;
        }
    }
}
