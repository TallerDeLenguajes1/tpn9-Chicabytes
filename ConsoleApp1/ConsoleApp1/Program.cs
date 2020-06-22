using System;
using Helpers;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Conf_Leida;
            string DireccionArch = @"C:\Users\giuli\Documents\Facultad\Taller1\TP9\"; 
            if (File.Exists("destino.dat"))
            {
                Conf_Leida = SoporteParaConfiguracion.LeerConfiguracion();
            }
            else
            {
                SoporteParaConfiguracion.CrearArchivoDeConfiguracion(DireccionArch);
                Conf_Leida = SoporteParaConfiguracion.LeerConfiguracion();
            }
            MoverArch(Conf_Leida);
        }

        public static void MoverArch(string Config)
        {
            Directory.CreateDirectory(Config);
            string Directorios = Directory.GetCurrentDirectory();
            string[] ArreArchDirectory = Directory.GetFiles(Directorios);
            foreach (string Archivo in ArreArchDirectory)
            {
                if (Archivo.Contains(".mp3") || Archivo.Contains(".txt"))
                {
                    string[] Cambio = Archivo.Split(@"\");
                    int Longitud = Cambio.Length;
                    Directory.Move(Archivo, Config +@"\"+ Cambio[Longitud-1]);
                }
            }
        }
    }
}
