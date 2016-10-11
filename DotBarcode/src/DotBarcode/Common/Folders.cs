// using HoloCore.Colors;
using DotBarcode.Base;
using DotBarcode.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotBarcode.Common
{
    public class Folder : ItemBase, IFolder
    {
        private ulong parentFolder;
        private int depth;
        private bool isPasswordProtected;
        // private ColorStruct color1;

        //public Folder(uint id)
        //    : this(id, null, null)
        //{
        //}
        //public Folder(uint id, string name, string description)
        //    : this(id, name, description, 0UL, 0, false, ColorStruct.Transparent)
        //{
        //}
        //public Folder(uint id, string name, string description, ulong parentFolder, int depth, bool isPasswordProtected, ColorStruct color1)
        //    : this(id, name, description, parentFolder, depth, isPasswordProtected, color1, 0L, 0L, 0L)
        //{
        //}
        //public Folder(uint id, string name, string description, ulong parentFolder, int depth, bool isPasswordProtected, ColorStruct color1, long created, long updated, long deleted)
        //    : base(id, name, description, created, updated, deleted)
        //{
        //    this.parentFolder = parentFolder;
        //    this.depth = depth;
        //    this.isPasswordProtected = isPasswordProtected;
        //    this.color1 = color1;
        //}
        public Folder(uint id)
            : this(id, null, null)
        {
        }
        public Folder(uint id, string name, string description)
            : this(id, name, description, 0UL, 0, false)
        {
        }
        public Folder(uint id, string name, string description, ulong parentFolder, int depth, bool isPasswordProtected)
            : this(id, name, description, parentFolder, depth, isPasswordProtected, 0L, 0L, 0L)
        {
        }
        public Folder(uint id, string name, string description, ulong parentFolder, int depth, bool isPasswordProtected, long created, long updated, long deleted)
            : base(id, name, description, created, updated, deleted)
        {
            this.parentFolder = parentFolder;
            this.depth = depth;
            this.isPasswordProtected = isPasswordProtected;
        }

        public ulong ParentFolder
        {
            get
            {
                return parentFolder;
            }
            set
            {
                parentFolder = value;
            }
        }
        public int Depth
        {
            get
            {
                return depth;
            }
            set
            {
                depth = value;
            }
        }
        public bool IsProtected
        {
            get
            {
                return isPasswordProtected;
            }
            set
            {
                isPasswordProtected = value;
            }
        }
        //public ColorStruct Color1
        //{
        //    get
        //    {
        //        return color1;
        //    }
        //    set
        //    {
        //        color1 = value;
        //    }
        //}

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString()).Append("; ");
            sb.Append("ParentFolder:").Append(ParentFolder).Append("; ");
            sb.Append("Depth:").Append(Depth).Append("; ");
            sb.Append("IsProtected:").Append(IsProtected).Append("; ");
            // sb.Append("Color1:").Append(Color1);
            return sb.ToString();
        }
    }

    public static class Folders
    {
    }

}
