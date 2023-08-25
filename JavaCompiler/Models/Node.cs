using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCompiler.Models {
    public class Node {

        //Atributes
        String lexeme;
        int token;
        int row;
        Node nextNode = null;

        //Constructor
        public Node(String lexeme, int token, int row) {
            this.lexeme = lexeme;
            this.token = token;
            this.row = row;
        }

    }
}
