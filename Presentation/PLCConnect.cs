using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.Profinet.Melsec;
using HslCommunication.Profinet.Siemens;
using Presentation.Forms;


namespace Presentation
{
    internal class PLCConnect
    {
        public static PLCConnect Instance { get; } = new PLCConnect();


        private MelsecMcNet _mitsuClient;
        private SiemensS7Net _siemensClient;



        // PLC ẢO
        // private MelsecMcServer _melsecServer;
        public MelsecMcNet MitsuClient => _mitsuClient;
        public SiemensS7Net SiemensClient => _siemensClient;
        public bool IsConnected { get; private set; } = false;

        public async Task<bool> ConnectAsync(string ipAddress, int port)
        {
            int plcType = FormConnection.numberPLC;

            try
            {
                // PLC ẢO
                //_melsecServer = new MelsecMcServer();
                //_melsecServer.ServerStart(5007); // 127.0.0.1 5007

                if (plcType == 1) // Mitsubishi FX5U
                {
                    _mitsuClient = new MelsecMcNet(ipAddress, port);
                    _mitsuClient.ConnectTimeOut = 2000;

                    System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Đang kết nối tới Mitsubishi FX5U tại {ipAddress}:{port}...");
                    OperateResult result = await _mitsuClient.ConnectServerAsync();
                    IsConnected = result.IsSuccess;
                }
                else if (plcType == 2) // Siemens S7-1200
                {

                    _siemensClient = new SiemensS7Net(SiemensPLCS.S1200, ipAddress);
                    _siemensClient.Port = port; // Cổng mặc định của Siemens S7-1200 là 102
                    _siemensClient.ConnectTimeOut = 2000;

                    System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Đang kết nối tới Siemens S7-1200 tại {ipAddress}:{port}...");

                    OperateResult result = await Task.Run(() => _siemensClient.ConnectServer());
                    IsConnected = result.IsSuccess;
                }
                if (IsConnected)
                {
                    IsConnected = true;
                    System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Kết nối PLC FX5U thành công!");
                    return true;
                }
                else
                {
                    IsConnected = false;
                    System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Kết nối thất bại!"); return false;
                }
            }
            catch (Exception ex)
            {
                IsConnected = false;
                System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Lỗi ngoại lệ kết nối: {ex.Message}");
                return false;
            }
        }


        public async Task DisconnectAsync()
        {
            System.Diagnostics.Debug.WriteLine("--> [DEBUG]: Bắt đầu ngắt kết nối...");
            if (IsConnected == true)
            {

                await Task.Run(() => _mitsuClient.ConnectClose());

                //await Task.Run(() => _siemensClient.ConnectClose());

                IsConnected = false;
                System.Diagnostics.Debug.WriteLine("--> [DEBUG]: Ngắt kết nối thành công...");
            }
        }

    }
}
