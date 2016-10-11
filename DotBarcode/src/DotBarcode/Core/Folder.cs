// using HoloCore.Colors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotBarcode.Core
{
    public interface IFolder : IItem, IArchivable
    {
        ulong ParentFolder
        {
            get;
        }
        int Depth
        {
            get;
        }

        bool IsProtected
        {
            get;
        }
        // Pword ???
        // Separate HashedPasswd ???
        // --> For now, just use the same master password for all folders
        // ....

        //ColorStruct Color1
        //{
        //    get;
        //}
    }
}
