using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    internal class ReadPLC
    {
        public static async Task<bool?> ReadBitAsync(string address)
        {
            if (!PLCConnect.Instance.IsConnected)
            {
                System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Chưa kết nối tới PLC!");
                return false;
            }
            try
            {
                var result = await PLCConnect.Instance.MitsuClient.ReadBoolAsync(address);

                //var result = await PLCConnect.Instance.SiemensClient.ReadBoolAsync(address);


                if (result.IsSuccess)
                {
                    return result.Content;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Đọc {address} thất bại: {result.Message}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"--> [DEBUG]: Lỗi ghi {address}: {ex.Message}");
                return false;
            }
        }

        public static async Task<short?> ReadWorkAsync(string address)
        {
            if (!PLCConnect.Instance.IsConnected)
            {
                System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Chưa kết nối tới PLC!");
                return null;
            }
            try
            {
                var result = await PLCConnect.Instance.MitsuClient.ReadInt16Async(address);

                //var result = await PLCConnect.Instance.SiemensClient.ReadInt16Async(address);

                if (result.IsSuccess)
                {
                    return result.Content;
                }
                System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Đọc Word {address} thất bại: {result.Message}");
                return null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Lỗi ngoại lệ Word {address}: {ex.Message}");
                return null;
            }
        }

        public static async Task<int?> ReadDWorkAsync(string address)
        {
            if (!PLCConnect.Instance.IsConnected)
            {
                System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Chưa kết nối tới PLC!");
                return null;
            }
            try
            {
                var result = await PLCConnect.Instance.MitsuClient.ReadInt32Async(address);

                //var result = await PLCConnect.Instance.SiemensClient.ReadInt32Async(address);

                if (result.IsSuccess)
                {
                    return result.Content;
                }
                System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Đọc Word {address} thất bại: {result.Message}");
                return null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Lỗi ngoại lệ Word {address}: {ex.Message}");
                return null;
            }
        }

        public static async Task<float?> ReadFloatAsync(string address)
        {
            if (!PLCConnect.Instance.IsConnected)
            {
                System.Diagnostics.Debug.WriteLine("---> [DEBUG]: Chưa kết nối tới PLC!");
                return null;
            }
            try
            {
                var result = await PLCConnect.Instance.MitsuClient.ReadFloatAsync(address);

                //var result = await PLCConnect.Instance.SiemensClient.ReadFloatAsync(address);

                if (result.IsSuccess)
                {
                    return result.Content;
                }
                System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Đọc Word {address} thất bại: {result.Message}");
                return null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"---> [DEBUG]: Lỗi ngoại lệ Word {address}: {ex.Message}");
                return null;
            }
        }
    }
}
