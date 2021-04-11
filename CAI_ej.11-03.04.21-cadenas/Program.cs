using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_ej._11_03._04._21_cadenas
//Ej 11: Reemplace en una cadena ingresada por el usuario todas 
//las vocales acentuadas por vocales sin acento y presente el resultado.	
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            string palabraConTildes = "áéíóúñ";
            //vocales = ["áéíóúñ"];
            Console.WriteLine("Ingrese una frase.");
            texto = Console.ReadLine();
            Console.WriteLine(texto.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u"));

            Console.ReadKey();
        }
    }
}
  
