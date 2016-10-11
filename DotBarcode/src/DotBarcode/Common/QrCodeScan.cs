using DotBarcode.Base;
using DotBarcode.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotBarcode.Common
{
    public class QrCodeScan : QrCodeItemBase, IQrCodeScan
    {
        public QrCodeScan(uint id)
            : this(id, null, null)
        {
        }
        public QrCodeScan(uint id, string name, string description)
            : this(id, name, description, 0U)
        {
        }
        public QrCodeScan(uint id, string name, string description, uint folderId)
            : this(id, name, description, folderId, QrCodeType.Unknown, null)
        {
        }
        public QrCodeScan(uint id, string name, string description, uint folderId, QrCodeType qrCodeType, IQrCode qrCode)
            : this(id, name, description, folderId, qrCodeType, qrCode, 0L, 0L, 0L, 0L)
        {
        }
        public QrCodeScan(uint id, string name, string description, uint folderId, QrCodeType qrCodeType, IQrCode qrCode, long created, long updated, long deleted, long viewed)
            : base(id, name, description, folderId, qrCodeType, qrCode, created, updated, deleted, viewed)
        {
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }


}
