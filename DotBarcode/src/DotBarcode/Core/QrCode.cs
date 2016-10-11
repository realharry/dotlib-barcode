using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotBarcode.Core
{
    public interface IQrCode : IBarcode
    {
        // TBD.
    }

    public interface IQrCodeItem : IBarcodeItem
    {
        QrCodeType QrCodeType
        {
            get;
        }
        IQrCode QrCode
        {
            get;
        }

    }

    public interface IQrCodeScan : IQrCodeItem, IBarcodeScan
    {
    }

    public interface IQrCodeRecord : IQrCodeItem, IBarcodeRecord
    {
    }

}
