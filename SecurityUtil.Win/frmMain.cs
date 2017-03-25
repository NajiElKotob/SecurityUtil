using System;
using System.Windows.Forms;
using DotNETHeroes.SecurityUtil;


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
            txtGUID.Text = DotNETHeroes.SecurityUtil.Cryptography.Randomness.GenerateNewGuid();
        }

        private void btnProcessorId_Click(object sender, EventArgs e)
        {
            txtProcessorId.Text = DotNETHeroes.SecurityUtil.Hardware.Processor.ProcessorId();
        }

        private void btnHardDriveSN_Click(object sender, EventArgs e)
        {
            txtHardDriveSN1.Text = DotNETHeroes.SecurityUtil.Hardware.HardDrive.VolumeSerialNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHardDriveSN2.Text = DotNETHeroes.SecurityUtil.Hardware.HardDrive.VolumeSerialNumber("D:");
        }

        private void btnComputeHash_Click(object sender, EventArgs e)
        {
            txtHashing.Text = DotNETHeroes.SecurityUtil.Cryptography.Hashing.ComputeHash("Hello",
                                                        DotNETHeroes.SecurityUtil.Cryptography.HashAlgorithmEnum.SHA256, 
                                                        DotNETHeroes.SecurityUtil.Cryptography.FormatEnum.Hex);
        }

        private void btnMACAddresses_Click(object sender, EventArgs e)
        {
            string[] macAddresses = DotNETHeroes.SecurityUtil.Hardware.NIC.MacAddresses();
            if (macAddresses != null)
            {
                cboMACAddresses.Items.AddRange(macAddresses);
            }else
            {
                cboMACAddresses.Items.Add("No MAC address found!");
            }

            cboMACAddresses.SelectedIndex = 0;
            
        }
    }
}
