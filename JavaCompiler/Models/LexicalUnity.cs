using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCompiler.Models {
    public class LexicalUnity {
        readonly Dictionary<string, int> keyword = new Dictionary<string, int>();

        public int GetTokenWord(string lexeme) {

                        //lexema, token
            keyword.Add("boolean", 1);
            keyword.Add("case", 2);
            keyword.Add("catch", 3);
            keyword.Add("char", 4);
            keyword.Add("class", 5);
            keyword.Add("const", 6);
            keyword.Add("double", 7);
            keyword.Add("do", 8);
            keyword.Add("else", 9);
            keyword.Add("false", 10);
            keyword.Add("float", 11);
            keyword.Add("for", 12);
            keyword.Add("if", 13);
            keyword.Add("int", 14);
            keyword.Add("null", 15);
            keyword.Add("private", 16);
            keyword.Add("public", 17);
            keyword.Add("return", 18);
            keyword.Add("static", 19);
            keyword.Add("switch", 20);
            keyword.Add("this", 21);
            keyword.Add("true", 22);
            keyword.Add("try", 23);
            keyword.Add("void", 24);
            keyword.Add("while", 25);
            return 0;
        }

    }
}
