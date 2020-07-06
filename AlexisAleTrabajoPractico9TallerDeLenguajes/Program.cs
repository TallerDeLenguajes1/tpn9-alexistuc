using System;
using System.IO;
using static AlexisAleTrabajoPractico9TallerDeLenguajes.SoporteParaConfiguracion;

namespace AlexisAleTrabajoPractico9TallerDeLenguajes
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = Directory.GetCurrentDirectory();
            //string ruta = @"C:\Users\usuario\Documents\myPenDrive\Taller de Lenguaje I\2020\trabajo practico 9\tpn9 - alexistuc\AlexisAleTrabajoPractico9TallerDeLenguajes";
            SoporteParaConfiguracion.CrearArchivoDeConfiguracion(ruta);
            string DataDirectory = SoporteParaConfiguracion.LeerConfiguracion(ruta);

            //string fecha = DateTime.Now.ToString("dd-MM-yy");
            /*if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            */
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta + @"Morse\");
            }
            Console.WriteLine("Segun el archivo de configuracion se creo un directorio llamado " + DataDirectory + ", en el cual se guardaran todos los archivos\n");

            Console.Write("Ingrese una frase para traducirla a morse: ");
            string aTraducir = Console.ReadLine();


            //TEXTO A MORSE
            string TextToMorse = ConversorDeMorse.TextoAMorse(aTraducir.ToUpper());
            //string fecha = ConversorDeMorse.TextoAMorse(TextToMorse, DataDirectory);
            //ConversorDeMorse.MorseToMp3(TextToMorse, DataDirectory, fecha);

            //*********************** MORSE A TEXTO ***********************//
            //ConversorDeMorse.CrearTextoTxt(DataDirectory, fecha);


            Console.WriteLine("\nLas corrspondientes traducciones se guardaron dentro del directorio " + DataDirectory);

            // TODO: Implement Functionality Here

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
