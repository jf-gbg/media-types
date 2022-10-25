using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaTypes
{
    public interface IFile
    {
        string FileExtension { get; init; }
        string Name { get; set; }
    }
}