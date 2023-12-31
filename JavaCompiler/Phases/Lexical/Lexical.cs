﻿using JavaCompiler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCompiler.Phases.Lexical {
    public class Lexical {

        //Atributes
        Node cursor = null, position;
        int state = 0, column, valueTM, rowNumber = 1;
        int item = 0;
        String lexeme = "";
        Boolean finderError = false;

        int[,] matrizTrancision = new int[,] 
            
            {
                       //  l    d    +    -    *    /    >    <    =    !    &    |    .    ,    ;    ?    #    $    "   eb   col  nl   tab  eof  oc    :
               /* 0 */ {   1,   2,  103, 104, 105,  5,   8,   9,   10,  11,  12,  13, 116, 117, 118, 119, 126, 127,  14,   0,   0,   0,   0,   0, 506,  15},
               /* 1 */ {   1,   1,  100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100},
               /* 2 */ {  101,  2,  101, 101, 101, 101, 101, 101, 101, 101, 101, 101,  3 , 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101, 101},
               /* 3 */ {  500,  4,  500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500, 500},
               /* 4 */ {  102,  4,  102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102, 102},
               /* 5 */ {  106, 106, 106, 106,  6 , 106, 106, 106, 106, 106, 106, 106, 106, 106, 106, 106, 106, 106, 106, 106, 106, 106, 106, 106, 106, 106},
               /* 6 */ {   6 ,  6,   6 ,  6 ,  7 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 },
               /* 7 */ {   6 ,  6,   6 ,  6 ,  6 ,  0 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 ,  6 },
               /* 8 */ {  107, 107, 107, 107, 107, 107, 107, 107, 110, 107, 107, 107, 107, 107, 107, 107, 107, 107, 107, 107, 107, 107, 107, 107, 107, 107},
               /* 9 */ {  108, 108, 108, 108, 108, 108, 108, 108, 111, 108, 108, 108, 108, 108, 108, 108, 108, 108, 108, 108, 108, 108, 108, 108, 108, 108},
              /* 10 */ {  502, 502, 502, 502, 502, 502, 502, 502, 109, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502, 502},
              /* 11 */ {  115, 115, 115, 115, 115, 115, 115, 115, 112, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115, 115},
              /* 12 */ {  503, 503, 503, 503, 503, 503, 503, 503, 503, 503, 113, 503, 503, 503, 503, 503, 503, 503, 503, 503, 503, 503, 503, 503, 503, 503},
              /* 13 */ {  504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 114, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504, 504},
              /* 14 */ {   14,  14,  14,  14,  14,  14,  14,  14,  14, 104,  14,  14,  14,  14,  14,  14,  14,  14, 128,  14, 505,  14,  14,  14,  14,  14},
              /* 15 */ {  502, 502, 502, 502, 502, 502,  25,  25, 130,  25,  25,  25,  25,  25,  25,  25,  25,  25,  25,  25,  25,  25,  25,  25,  25,  25},

            };
         
        public void showMatriz () {

            for (int i = 0; i < matrizTrancision.GetLength(0); i++) {
                for (int j = 0; j < matrizTrancision.GetLength(1); j++) {
                    System.Diagnostics.Debug.Write(matrizTrancision[i,j] + "\n");
                }
            }

        }

        public void mainLoop (List<char> sourceCode) {

            for (int i = 0; i < sourceCode.Count; i++) {
                if (Char.IsNumber(sourceCode[i])){
                    MessageBox.Show("Es numero we " + i);
                }
            }

        }

    }
}
