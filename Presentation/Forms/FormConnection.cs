using HslCommunication.Core;
using HslCommunication.Profinet.Melsec;
using NModbus;
using NModbus.Device;
using Presentation.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FormConnection : Form
    {

        public FormConnection()
        {
            InitializeComponent();
        }

        private void FormConnection_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            string IpAddress = txtIPAddress.Text?.Trim() ?? string.Empty;
            int.TryParse(txtPort.Text?.Trim(), out int port);
            // int port = int.TryParse(txtPort.Text?.Trim(), out int parsedPort) ? parsedPort : 5007;
            await PLCConnect.Instance.ConnectAsync(IpAddress, port);
        }



        private async void buttonDisconnect_Click(object sender, EventArgs e)
        {
            await PLCConnect.Instance.DisconnectAsync();
        }
        public static int numberPLC;

        private void comboBoxCPUType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check xem đang chọn loại PLC nào
            string selectedPlc = cbbListPLC.SelectedItem?.ToString() ?? string.Empty;
            if (selectedPlc.Contains("Mitsubishi FX5U"))
            {
                //txtPort.Clear();
                txtPort.Text = "5002";

                numberPLC = 1;
                System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Loại PLC Chọn là: {numberPLC}");

            }
            else if (selectedPlc.Contains("Siemens S7-1200"))
            {
                txtPort.Text = "102";
                numberPLC = 2;
                System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Loại PLC Chọn là: {numberPLC}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        bool CtrlConnectPLC;

        private async void timer1_Tick(object sender, EventArgs e)
        {
            CtrlConnectPLC = PLCConnect.Instance.IsConnected;
            if (CtrlConnectPLC == true)
            {
                lblStatusConnectPLC.Text = "Connected";
                lblStatusConnectPLC.ForeColor = Color.Green;
            }
            else
            {
                lblStatusConnectPLC.Text = "NoConnected";
                lblStatusConnectPLC.ForeColor = Color.Red;
            }

            if (CtrlConnectPLC == true)
            {
                bool? m5Status = await ReadPLC.ReadBitAsync("M5");
                System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Status M5: {m5Status}");


                //short? valD10 = await ReadPLC.ReadWorkAsync("D10");
                //if (valD10.HasValue)
                //{
                //    txtReadD10.Text = valD10.Value.ToString();
                //}
                //else
                //{
                //    txtReadD10.Text = "Error"; // Hoặc để trống "" nếu đọc thất bại
                //}

                txtReadD10.Text = (await ReadPLC.ReadWorkAsync("D10"))?.ToString() ?? "";
                txtReadDworkD100.Text = (await ReadPLC.ReadDWorkAsync("D100"))?.ToString() ?? "";
                txtReadFloadD200.Text = (await ReadPLC.ReadFloatAsync("D200"))?.ToString() ?? "";





            }
        }

        private void txtIPAddress_TextChanged(object sender, EventArgs e)
        {

        }
        private bool _trangThaiM01 = false;

        private async void button1_Click(object sender, EventArgs e)
        {
            if (CtrlConnectPLC == true)
            {
                bool valueToWrite = !_trangThaiM01;


                bool isSuccess = await WritePLC.WriteBitAsync("M10", valueToWrite);
                System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Trạng thái M10 mới new: {valueToWrite}");


                if (isSuccess)
                {
                    _trangThaiM01 = valueToWrite;

                    System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Trạng thái M10 mới: {_trangThaiM01}");

                    panelText.BackColor = _trangThaiM01 ? Color.Green : Color.Red;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Ghi dữ liệu xuống PLC thất bại!");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void txtD0_TextChanged(object sender, EventArgs e)
        {
            if (!ushort.TryParse(txtD0.Text, out ushort value))
                return;
            await WritePLC.WriteWordAsync("D0", value);
        }


        private async void txtD100_TextChanged(object sender, EventArgs e)
        {
            if (!uint.TryParse(txtD100.Text, out uint value))
                return;

            await WritePLC.WriteDWordAsync("D100", value);
        }

        private async void txtFloatD200_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(txtFloatD200.Text, out float value))
                return;

            await WritePLC.WriteDWordFloatAsync("D200", value);
        }

        private void txtReadD10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

