using System;
using System.Threading.Tasks;

namespace lab08
{
    public interface IQRCodeScanner
    {
        Task<string> ScanQRCodeAsync();
    }
}
