using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaCompiler.Models {
    public static class Error {

        //Atrubutes
        static readonly Dictionary<string, int> error = new Dictionary<string, int>
        {
            /*0*/ {"Se espera un digito",               500},
            /*1*/ {"Se espera cerrar el comentario",    501},
            /*2*/ {"Se espera un &",                    502},
            /*3*/ {"Se espera un |",                    503},
            /*4*/ {"Se espera cerrar cadena",           504},
            /*5*/ {"Simbolo no valido",                 505},
        };
    


        public static string getErrorByCode(int idError) {

            string errorMessage = "";

            for (int i = 0; i < error.Count; i++) {

                if (error.ElementAt(i).Value.Equals(idError)) {

                    errorMessage = error.ElementAt(i).Key;
                    break;
                }
            }

            if (errorMessage.Equals("")) {
                MessageBox.Show("No se encontraron errores con ese id.");
            }

            return errorMessage;
        }

    }
}
