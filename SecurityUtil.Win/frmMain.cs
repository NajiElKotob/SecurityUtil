using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNETHeroes.SecurityUtil.Hardware;
using DotNETHeroes.SecurityUtil.Cryptography;

namespace SecurityUtil.Win
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGUID_Click(object sender, EventArgs e)
        {
            txtGUID.Text = Randomness.GenerateNewGuid();
        }

        private void btnProcessorId_Click(object sender, EventArgs e)
        {
            txtProcessorId.Text = Processor.ProcessorId();
        }
    }
}
