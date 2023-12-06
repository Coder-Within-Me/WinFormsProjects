using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormPoC
{
    public partial class LoadingForm : Form
    {
        //private bool isCancelled = false;
        private BackgroundWorker backgroundWorker;
        public LoadingForm(BackgroundWorker backgroundWorker)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.backgroundWorker = backgroundWorker;
        }
        //public bool IsCancelled => isCancelled;
        public void UpdateProgress(int progress)
        {
            progressBar.Value = progress;
        }
        private void LoadingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //isCancelled = true;
            backgroundWorker.CancelAsync();
        }
    }
}
