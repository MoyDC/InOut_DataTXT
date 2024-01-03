using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataTXT
{
    internal class RutaCarpeta
    {
        //Variables
        private string carpetaRuta;

        // Propiedad para obtener la ruta de la carpeta
        public string GetRuta
        {
            get { return carpetaRuta; }
        }

        // Método para establecer la ruta de la carpeta
        public void SetRuta(string nuevaRuta)
        {
            carpetaRuta = nuevaRuta;
        }

        // Método para imprimir información sobre la carpeta
        public string ShowRuta()
        {
            return "Ruta de la carpeta: " + carpetaRuta;
        }
    }
}
