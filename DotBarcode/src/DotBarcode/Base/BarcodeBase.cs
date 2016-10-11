using DotBarcode.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotBarcode.Base
{
    public abstract class BarcodeBase : ItemBase, IBarcode
    {
        // private BarcodeType code;
        private uint folderId;
        private BarcodeType barcodeType;
        private IBarcode barcode;
        private long viewed;

        public BarcodeBase(uint id)
            : this(id, null, null)
        {
        }
        public BarcodeBase(uint id, string name, string description)
            : this(id, name, description, 0U, BarcodeType.Unknown, null)
        {
        }
        public BarcodeBase(uint id, string name, string description, uint folderId, BarcodeType barcodeType, IBarcode barcode)
            : this(id, name, description, folderId, barcodeType, barcode, 0L, 0L, 0L, 0L)
        {
        }
        public BarcodeBase(uint id, string name, string description, uint folderId, BarcodeType barcodeType, IBarcode barcode, long created, long updated, long deleted, long viewed)
            : base(id, name, description, created, updated, deleted)
        {
            // this.code = code;
            this.folderId = folderId;
            this.barcodeType = barcodeType;
            this.barcode = barcode;
            this.viewed = viewed;
        }

        public uint FolderId
        {
            get
            {
                return folderId;
            }
            set
            {
                folderId = value;
            }
        }

        public BarcodeType BarcodeType
        {
            get
            {
                return barcodeType;
            }
            set
            {
                barcodeType = value;
            }
        }
        public IBarcode Barcode
        {
            get
            {
                return barcode;
            }
            set
            {
                barcode = value;
            }
        }

        public long Viewed
        {
            get
            {
                return viewed;
            }
            set
            {
                viewed = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString()).Append("; ");
            // sb.Append("Code: ").Append(Code).Append("; ");
            sb.Append("FolderId:").Append(FolderId).Append("; ");
            sb.Append("BarcodeType:").Append(BarcodeType).Append("; ");
            sb.Append("Barcode:").Append(Barcode).Append("; ");
            sb.Append("Viewed:").Append(Viewed);
            return sb.ToString();
        }
    }


}
