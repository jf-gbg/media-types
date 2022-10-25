using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaTypes
{
    public class MIMEHelper
    {
        public static Dictionary<string, string> FileExtensionToMIMEType = new Dictionary<string, string>
        {
            [".gif"] = "image/gif",
            [".jpg"] = "image/jpeg",
            [".jpeg"] = "image/jpeg",
            [".png"] = "image/png",
            [".pdf"] = "application/pdf",
            [".txt"] = "text/plain",
            [".zip"] = "application/zip",
        };
    }
}