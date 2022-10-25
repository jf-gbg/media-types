using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaTypes
{
    public class MediaFile : IFile
    {
        public string FileExtension { get; init; }
        public string Name { get; set; } = string.Empty;

        public MediaFile(string fullFileName)
        {
            FileExtension = Path.GetExtension(fullFileName);
            Name = fullFileName;
        }

        public string GetMIMEType() => MIMEHelper.FileExtensionToMIMEType.GetValueOrDefault(
            this.FileExtension, "application/octet-stream");
    }
}