using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCompiler.Models {

    public static class ReservedKeyword {

        //Atrubutes

        static readonly Dictionary<string, int> keyword = new Dictionary<string, int>
        {
            /*0*/  {"var",       200},
            /*1*/  {"print",     201},
            /*2*/  {"true",      202},
            /*3*/  {"false",     203},
            /*4*/  {"if",        204},
            /*5*/  {"else",      205},
            /*6*/  {"while",     206},
            /*7*/  {"string",    207},
            /*8*/  {"int",       208},
            /*9*/  {"double",    209},
            /*10*/ {"Class",     210},
            /*11*/ {"read",      211},
        };

       
        public static int getWordByName(String name) {

            int id = 0;

            for (int i = 0; i < keyword.Count; i++) {

                if (keyword.ElementAt(i).Key.Equals(name)) {
                    
                    id = keyword.ElementAt(i).Value; 
                    break;
                }
            }

            if (id == 0) {
                MessageBox.Show("No se encontro la palabra reservada.");
            }

            return id;
        }

    }
}
