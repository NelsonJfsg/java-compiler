using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaCompiler.Files {
    public static class FileUtilities {

        public static List<char> readFileByChar(string @path) {

            //Read char
            var list = new List<char>();

            StreamReader inputFile = new StreamReader(path);
            //StreamWriter outputFile = new StreamWriter(path);

            for (int i = 0; !inputFile.EndOfStream; i++) {
                char line = (char)inputFile.Read();
                list.Add(line);
            }

            return list;
        }

        public static List<char> readBoxByChar(RichTextBox box) {

            //Read char
            var list = new List<char>();

            for (int i = 0; i < box.Text.Length; i++) {
                list.Add((char)box.Text[i]);
            }

            return list;
        }

         public static string readAllFile(string path) {

            //Read all file.
            return File.ReadAllText(path);
            
        }

    }
}
