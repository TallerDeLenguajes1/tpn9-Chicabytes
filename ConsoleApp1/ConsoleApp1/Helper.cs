using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Helpers
{
    static class SoporteParaConfiguracion
    {   
        public static void CrearArchivoDeConfiguracion(string Direccion)
        {
            BinaryWriter BinArch = new BinaryWriter(File.Open("destino.dat", FileMode.Create));
            BinArch.Write(Direccion);
            BinArch.Close();
        }
        public static string LeerConfiguracion()
        {
            BinaryReader BinArchR = new BinaryReader(File.Open("destino.dat", FileMode.Open));
            string Arch = BinArchR.ReadString();
            BinArchR.Close();
            return Arch;
        }
    }
}
