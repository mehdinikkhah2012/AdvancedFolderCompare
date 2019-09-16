using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CompareDir
{
    public class FileCompareItem
    {
        private FileInfo file1Info;
        private FileInfo file2Info;

        public string File1Path { get; set; }
        public string File2Path { get; set; }
        public string DifferenceType { get; set; }

        public FileCompareItem(FileInfo file1Info, FileInfo file2Info, string differenceType)
        {
            if (file1Info != null)
            {
                this.file1Info = file1Info;
                File1Path = file1Info.FullName;
            }

            if (file2Info != null)
            {
                this.file2Info = file2Info;
                File2Path = file2Info.FullName;
            }

            this.DifferenceType = differenceType;
        }
    }
}
