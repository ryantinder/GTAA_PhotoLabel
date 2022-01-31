using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAA_PhotoLabel.Classes
{
    internal class PhotoFile
    {
        public string filePath;
        public string originalName;

        public PhotoFile(string filepath)
        {
            filePath = filepath;
            originalName = filepath.Split('\\').Last();
        }
    }
}
