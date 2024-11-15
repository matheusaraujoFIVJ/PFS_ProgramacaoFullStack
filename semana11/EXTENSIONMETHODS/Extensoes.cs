using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXTENSIONMETHODS;

    public static class Extensoes
    {
        public static double ElevadoA(this double numero, double expoente)
        {
            return Math.Pow(numero, expoente);
        }

                public static string removerAcentos(this string texto)
        {
            string comAcentos = "á à â ä ã Á À Â Ä Ã é è ê ë É È Ê Ë í ì î ï Í Ì Î Ï ó ò ô ö õ Ó Ò Ô Ö Õ ú ù û ü Ú Ù Û Ü ç Ç";
            string semAcentos = "a a a a a A A A A A e e e e E E E E i i i i I I I I o o o o o O O O O O u u u u U U U U c C ";

            for (int i = 0; i < comAcentos.Length; i++)
            
                texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            
            return texto;
        }
    }
