using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace NotepadGAP
{
    static class Gerenciador
    {
        public static string FolderPath { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
        public static string FileName { get; set; } = "arquivo";
        public static string FileExt { get; set; } = ".txt";
        public static string FilePath => FolderPath + FileName + FileExt;
        public static bool FileOpen { get; set; } = false;
        public static string[] Recentes
        {
            get
            {
                return Recentes;
            }

            private set
            {

            }
        }

    }
}
