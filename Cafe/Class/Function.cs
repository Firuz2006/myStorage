using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cafe.Class
{
    public static class Function
    {
        public static string GenerateFileName()
        {
            return string.Format(@"{0}.jpg", Guid.NewGuid()); 
        }

        public static void RenameFile(FileInfo originalFile, string newName)
        {
            originalFile.MoveTo(newName);
        }
    }
}
