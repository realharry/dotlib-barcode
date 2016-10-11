using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotBarcode.Core
{
    public interface IBarcode
    {
    }

    public interface IBarcodeItem : IItem, IArchivable
    {
        uint FolderId
        {
            get;
        }
        BarcodeType BarcodeType
        {
            get;
        }
        IBarcode Barcode
        {
            get;
        }
        long Viewed
        {
            get;
        }

    }

    // Scanned barcode
    public interface IBarcodeScan : IBarcodeItem
    {

    }

    // Generated barcode
    public interface IBarcodeRecord : IBarcodeItem
    {

    }

}
