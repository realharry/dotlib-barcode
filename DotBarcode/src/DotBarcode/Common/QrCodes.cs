using DotBarcode.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotBarcode.Common
{
    public class QrCode : IQrCode
    {
        private QrCodeFormat format;
        private string content;
        private long timestamp;
        private IDictionary<string, object> metadata;
        // ResultPoints?
        // RawBytes?

        public QrCode(QrCodeFormat format = QrCodeFormat.Unknown, string content = null, long timestamp = 0L, IDictionary<string, object> metadata = null)
        {
            this.format = format;
            this.content = content;
            this.timestamp = timestamp;
            this.metadata = metadata;
        }


        public QrCodeFormat Format
        {
            get
            {
                return format;
            }
            set
            {
                format = value;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        public long Timestamp
        {
            get
            {
                return timestamp;
            }
            set
            {
                timestamp = value;
            }
        }
        public IDictionary<string, object> Metadata
        {
            get
            {
                return metadata;
            }
            set
            {
                metadata = value;
            }
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Format:").Append(Enum.GetName(typeof(QrCodeFormat), Format)).Append("; ");
            sb.Append("Content:").Append(Content).Append("; ");
            sb.Append("Timestamp:").Append(Timestamp).Append("; ");
            sb.Append("Metadata:").Append(Metadata);
            return sb.ToString();
        }


    }
}
