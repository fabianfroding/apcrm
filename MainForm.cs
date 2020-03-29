using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APCRM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTNSelectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string selectedDir;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                selectedDir = fbd.SelectedPath;
                TBSelectedDir.Text = selectedDir;
                
                
            }
        }
    }
}
