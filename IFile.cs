using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace media_types
{
    public interface IFile
    {
        string FileExtension { get; init; }
        string Name { get; set; }
    }
}