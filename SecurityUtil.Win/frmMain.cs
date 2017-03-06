using System;
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

        private void btnHardDriveSN_Click(object sender, EventArgs e)
        {
            txtHardDriveSN1.Text = HardDrive.VolumeSerialNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHardDriveSN2.Text = HardDrive.VolumeSerialNumber("D:");
        }
    }
}
