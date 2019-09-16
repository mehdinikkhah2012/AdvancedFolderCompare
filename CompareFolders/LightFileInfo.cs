using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CompareDir
{
    public class LightFileInfo
    {
        public FileInfo FileInfo;
        public string FullName;
        public DateTime LastWriteTime;

        public LightFileInfo(FileInfo fileInfo)
        {
            this.FileInfo = fileInfo;
            this.FullName = fileInfo.FullName;
            this.LastWriteTime = fileInfo.LastWriteTime;
        }
    }
}
