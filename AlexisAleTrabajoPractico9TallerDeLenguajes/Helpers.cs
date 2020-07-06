using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using System.Linq;

namespace AlexisAleTrabajoPractico9TallerDeLenguajes
{
    static class SoporteParaConfiguracion
    {
        static public void CrearArchivoDeConfiguracion(string path)
        {
            if (!File.Exists(path))
            {
                string NuevoArchivo = "destino.dat";

                if (!File.Exists(NuevoArchivo))
                {
                    File.Create(NuevoArchivo);
                }
                File.WriteAllText(NuevoArchivo, path);
            }
            else
            {
                Console.WriteLine("Archivo Existente");
            }
        }
        
        public static string LeerConfiguracion(string Destino)
        {
            BinaryReader LeerBinario = new BinaryReader(File.Open(Destino + @"\destino.dat", FileMode.Open));
            string contenido = LeerBinario.ReadString();
            LeerBinario.Close();
            return contenido;
        }

        public static class ConversorDeMorse
        {
            public static Dictionary<char, string> Diccionario = new Dictionary<char, string>
            {
                {'a', ".-"},
                {'b', "-..."},
                {'c', "-.-."},
                {'d', "-.."},
                {'e', "."},
                {'f', "..-."},
                {'g', "--."},
                {'h', "...."},
                {'i', ".."},
                {'j', ".---"},
                {'k', "-.-"},
                {'l', ".-.."},
                {'m', "--"},
                {'n', "-."},
                {'o', "---"},
                {'p', ".--."},
                {'q', "--.-"},
                {'r', ".-."},
                {'s', "..."},
                {'t', "-"},
                {'u', "..-"},
                {'v', "...-"},
                {'w', ".--"},
                {'x', "-..-"},
                {'y', "-.--"},
                {'z', "--.."},
                {'0', "-----"},
                {'1', ".----"},
                {'2', "..---"},
                {'3', "...--"},
                {'4', "....-"},
                {'5', "....."},
                {'6', "-...."},
                {'7', "--..."},
                {'8', "---.."},
                {'9', "----."},
                {' ', "\\" },
            };
            
            static public string TextoAMorse(string cadena)
            {
                string traduccion = "";

                cadena = cadena.ToLower();

                foreach (char letra in cadena)
                {
                    foreach (KeyValuePair<char, string> elemento in Diccionario)
                    {
                        if (Convert.ToChar(elemento.Key) == letra)
                        {
                            traduccion = traduccion + elemento.Value;
                            break;
                        }
                    }
                }
                Console.WriteLine("TRADUCIDO A CODIGO MORSE:");
                Console.WriteLine(traduccion);
                return traduccion;
            }

            
        }
    }
}
