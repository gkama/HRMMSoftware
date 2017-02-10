using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Microsoft.Office.Interop.Word;

namespace HRMMSoftware
{
    class FileToText
    {
        private string FilePath { get; set; }

        //Constructor
        public FileToText(string FilePath)
        {
            this.FilePath = FilePath;
        }

        private readonly Application _application;
        private Document _document;

        //
        public string ReadAll()
        {           
            return "";
        }
    }
}
