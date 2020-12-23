using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HslCommunication.Profinet.Omron;

namespace CSharp_OmronCP
{
    public partial class Form1 : Form
    {
        private OmronHostLink hostlink;
        public Form1()
        {
            InitializeComponent();
            hostlink = new OmronHostLink();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshPort();
        }

        private void RefreshPort()
        {
            cmbPort.Items.Clear();
            String[] myPort;
            myPort = SerialPort.GetPortNames();
            try
            {
                for (short i = 0; i <= myPort.Length - 1; i++)
                {
                    cmbPort.Items.Add(myPort[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

            if (myPort.Length >= 1)
            {
                cmbBaudRate.SelectedIndex = 0;
                cmbPort.SelectedIndex = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Nilai Baud Rate yang bisa digunakan
            cmbBaudRate.Items.Add(9600);
            cmbBaudRate.Items.Add(19200);
            cmbBaudRate.Items.Add(38400);
            cmbBaudRate.Items.Add(57600);
            cmbBaudRate.Items.Add(115200);

            RefreshPort();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            hostlink.SerialPortInni(sp =>
            {
                sp.PortName = cmbPort.Text;
                sp.BaudRate = Int16.Parse(cmbBaudRate.Text);
                sp.DataBits = 7;
                sp.StopBits = StopBits.One;
                sp.Parity = Parity.Even;
            });
            try
            {
                hostlink.Open();
                hostlink.IsClearCacheBeforeRead = true;
                HideOrShow(true);
                CmbValueBool.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideOrShow(bool status)
        {
            cmbPort.Enabled = !status;
            cmbBaudRate.Enabled = !status;
            BtnConnect.Enabled = !status;
            BtnRefresh.Enabled = !status;
            BtnDisconnect.Enabled = status;
            GBReadDM.Enabled = status;
            GBReadBit.Enabled = status;
            GBWriteBit.Enabled = status;
            GBWriteWord.Enabled = status;
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                hostlink.Close();
                HideOrShow(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var res = hostlink.ReadUInt16("D0");
            var res = hostlink.ReadUInt16("D" + NUPD.Value);
            if (res.IsSuccess)
                TxtResultD.Text = Convert.ToString(res.Content);
            else
                MessageBox.Show(res.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // var res = hostlink.ReadInt16("D0");
            var res = hostlink.ReadInt16("D" + NUPD.Value);
            if (res.IsSuccess)
                TxtResultD.Text = Convert.ToString(res.Content);
            else
                MessageBox.Show(res.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // var res = hostlink.ReadFloat("D0");
            var res = hostlink.ReadFloat("D" + NUPD.Value);
            if (res.IsSuccess)
                TxtResultD.Text = Convert.ToString(res.Content);
            else
                MessageBox.Show(res.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var res = hostlink.ReadBool(TxtWBit.Text);
            if (res.IsSuccess)
                TxtResultBit.Text = Convert.ToString(res.Content);
            else
                MessageBox.Show(res.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // read output 100.00
            // var res = hostlink.ReadBool("C100.00");
            var res = hostlink.ReadBool(TxtWBit.Text);
            if (res.IsSuccess)
                TxtResultBit.Text = Convert.ToString(res.Content);
            else
                MessageBox.Show(res.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var res = hostlink.Write(TxtWriteBit.Text,Convert.ToBoolean(CmbValueBool.Text));
            if (res.IsSuccess)
                MessageBox.Show("Write Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(res.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var res = hostlink.Write(TxtWriteWord.Text, (short)NUPValue.Value);
            if (res.IsSuccess)
                MessageBox.Show("Write Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(res.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
