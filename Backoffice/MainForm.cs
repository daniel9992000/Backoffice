using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Backoffice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LocalDB hilf = new LocalDB();
            test.Text = hilf.testabfrage().ToString();
        }


        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
