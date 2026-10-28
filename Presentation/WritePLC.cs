using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    internal class WritePLC
    {
        public static async Task<bool> WriteBitAsync(string address, bool value)
        {
            if (!PLCConnect.Instance.IsConnected)
            {
                System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Chưa kết nối tới PLC!");
                return false;
            }
            try
            {
                await PLCConnect.Instance.MitsuClient.WriteAsync(address, value);

                //await PLCConnect.Instance.SiemensClient.WriteAsync(address, value);

                System.Diagnostics.Debug.WriteLine($"--> [DEBUG]: Đã ghi {address} = {value}");
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"--> [DEBUG]: Lỗi ghi {address}: {ex.Message}");
                return false;
            }
        }


        public static async Task<bool> WriteWordAsync(string address, ushort value)
        {
            if (!PLCConnect.Instance.IsConnected)
            {
                System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Chưa kết nối tới PLC!");
                return false;
            }
            try
            {

                await PLCConnect.Instance.MitsuClient.WriteAsync(address, value);

                //await PLCConnect.Instance.SiemensClient.WriteAsync(address, value);

                System.Diagnostics.Debug.WriteLine($"--> [DEBUG]: Đã ghi {address} = {value}");
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"--> [DEBUG]: Lỗi ghi {address}: {ex.Message}");
                return false;
            }
        }


        public static async Task<bool> WriteDWordAsync(string address, uint value)
        {
            if (!PLCConnect.Instance.IsConnected)
            {
                System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Chưa kết nối tới PLC!");
                return false;
            }
            try
            {
                await PLCConnect.Instance.MitsuClient.WriteAsync(address, value);

                //await PLCConnect.Instance.SiemensClient.WriteAsync(address, value);

                System.Diagnostics.Debug.WriteLine($"--> [DEBUG]: Đã ghi {address} = {value}");
                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"--> [DEBUG]: Lỗi ghi {address}: {ex.Message}");
                return false;
            }
        }


        public static async Task<bool> WriteDWordFloatAsync(string address, float value)
        {
            if (!PLCConnect.Instance.IsConnected)
            {
                System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Chưa kết nối tới PLC!");
                return false;
            }
            try
            {
                await PLCConnect.Instance.MitsuClient.WriteAsync(address, value);

                //await PLCConnect.Instance.SiemensClient.WriteAsync(address, value);

                System.Diagnostics.Debug.WriteLine($"--> [DEBUG]: Đã ghi {address} = {value}");
                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"--> [DEBUG]: Lỗi ghi {address}: {ex.Message}");
                return false;
            }
        }
    }
}
