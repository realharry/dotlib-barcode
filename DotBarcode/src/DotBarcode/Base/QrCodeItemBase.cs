using DotBarcode.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotBarcode.Base
{
    public abstract class QrCodeItemBase : BarcodeBase, IQrCodeItem
    {
        private QrCodeType qrCodeType;
        private IQrCode qrCode;

        public QrCodeItemBase(uint id)
            : this(id, null, null)
        {
        }
        public QrCodeItemBase(uint id, string name, string description)
            : this(id, name, description, 0U)
        {
        }
        public QrCodeItemBase(uint id, string name, string description, uint folderId)
            : this(id, name, description, folderId, QrCodeType.Unknown, null)
        {
        }
        public QrCodeItemBase(uint id, string name, string description, uint folderId, QrCodeType qrCodeType, IQrCode qrCode)
            : this(id, name, description, folderId, qrCodeType, qrCode, 0L, 0L, 0L, 0L)
        {
        }
        public QrCodeItemBase(uint id, string name, string description, uint folderId, QrCodeType qrCodeType, IQrCode qrCode, long created, long updated, long deleted, long viewed)
            : base(id, name, description, folderId, BarcodeType.QrCode, null, created, updated, deleted, viewed)
        {
            this.qrCodeType = qrCodeType;
            this.qrCode = qrCode;
        }

        public QrCodeType QrCodeType
        {
            get
            {
                return qrCodeType;
            }
            set
            {
                qrCodeType = value;
            }
        }

        public IQrCode QrCode
        {
            get
            {
                return qrCode;
            }
            set
            {
                qrCode = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString()).Append("; ");
            sb.Append("QrCodeType:").Append(QrCodeType).Append("; ");
            sb.Append("QrCode:").Append(QrCode);
            return sb.ToString();
        }
    }


}
