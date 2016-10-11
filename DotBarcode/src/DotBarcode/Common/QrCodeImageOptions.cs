// using HoloCore.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotBarcode.Common
{
    public struct QrCodeImageOption
    {
        private int width;
        private int height;
        private int margin;
        // private ColorStruct backgroundColor;

        //public QrCodeImageOption(int width, int height, int margin, ColorStruct backgroundColor)
        //{
        //    this.width = width;
        //    this.height = height;
        //    this.margin = margin;
        //    this.backgroundColor = backgroundColor;
        //}
        public QrCodeImageOption(int width, int height, int margin)
        {
            this.width = width;
            this.height = height;
            this.margin = margin;
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public int Margin
        {
            get
            {
                return margin;
            }
            set
            {
                margin = value;
            }
        }
        //public ColorStruct BackgroundColor
        //{
        //    get
        //    {
        //        return backgroundColor;
        //    }
        //    set
        //    {
        //        backgroundColor = value;
        //    }
        //}

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Width:").Append(Width).Append("; ");
            sb.Append("Height:").Append(Height).Append("; ");
            sb.Append("Margin:").Append(Margin).Append("; ");
            // sb.Append("BackgroundColor:").Append(BackgroundColor);
            return sb.ToString();
        }
    }

    public class QrCodeImageOptionWrap
    {
        private QrCodeImageOption qrCodeImageOption;
        public QrCodeImageOptionWrap(QrCodeImageOption qrCodeImageOption)
        {
            this.qrCodeImageOption = qrCodeImageOption;
        }

        public QrCodeImageOption QrCodeImageOption
        {
            get
            {
                return qrCodeImageOption;
            }
        }

        public int Width
        {
            get
            {
                return qrCodeImageOption.Width;
            }
            set
            {
                qrCodeImageOption.Width = value;
            }
        }
        public int Height
        {
            get
            {
                return qrCodeImageOption.Height;
            }
            set
            {
                qrCodeImageOption.Height = value;
            }
        }
        public int Margin
        {
            get
            {
                return qrCodeImageOption.Margin;
            }
            set
            {
                qrCodeImageOption.Margin = value;
            }
        }
        //public ColorStruct BackgroundColor
        //{
        //    get
        //    {
        //        return qrCodeImageOption.BackgroundColor;
        //    }
        //    set
        //    {
        //        qrCodeImageOption.BackgroundColor = value;
        //    }
        //}

        public override string ToString()
        {
            return qrCodeImageOption.ToString();
        }
    }
}
