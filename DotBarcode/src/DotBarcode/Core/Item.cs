using DotCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotBarcode.Core
{
    // Base for Folder, Barcode, etc...
    public interface IItem : IIdentified
    {
        string Name
        {
            get;
        }
        string Description
        {
            get;
        }
        long Created
        {
            get;
        }
        long Updated
        {
            get;
        }
        long Deleted
        {
            get;
        }

        // isArhived?
        // --> archived resources/folders are stored in a physically different location
        //     (as an encrypted file on OneDrive, rather than in Cred locokcer),
        //     hence this flag is not needed.

    }

}
