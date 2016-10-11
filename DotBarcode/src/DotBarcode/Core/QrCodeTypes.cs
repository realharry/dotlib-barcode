using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DotBarcode.Core
{
    public enum QrCodeType
    {
        Unknown = 0,
        PlainText,
        WebsiteURL,
        ProductURL,
        MapURL,
        GeoLocation,
        EmailAddress,
        ContactInfo,
        CalendarEvent,
        ISBN,
        // etc..
        // ...

        // business card
        // ...

        // password?
        // encrypted text?
        // wifi?
        // ...
    }

    public static class QrCodeTypes
    {
    }
}
