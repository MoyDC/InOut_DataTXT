using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace GetDataTXT
{
    internal class Seccion
    {
        //Variables
        private string rutaCarpeta;
        private string seccion;
        private string[,] resultadoArraLE;
        private string[,] resultadoArraPS;
        private string[,] resultadoArraTE;
        private string[,] resultadoArraSS;


        // Método para establecer la Ruta de la Carpeta y la Seccion
        public void SetSeccion(string nuevaRutaCarpeta, int nuevaSeccion)
        {
            rutaCarpeta = nuevaRutaCarpeta;
            seccion = Enum.GetName(typeof(intSeccionFolder), nuevaSeccion);
            //seccion = nuevaSeccion;
        }

        //Metodo para obtener la seccion
        public string GetSeccion
        {
            get{ return seccion; }
        }

        //Metodo para obtener la ruta de la seccion
        public string GetRutaSeccion
        {
            get { return rutaCarpeta + "\\" + seccion; }
        }

        //Metodo para comprobar si existen todos los archivos 
        public bool AllFilesExist()
        {
            int i = 0;

            if (!fileExists("LE.txt")) { i++; }
            if (!fileExists("PS.txt")) { i++; }
            if (!fileExists("TE.txt")) { i++; }
            if (!fileExists("SS.txt")) { i++; }

            if(i>0)
            {
                Debug.WriteLine("Missing files in Seccion '" + GetSeccion + "'");
                Debug.WriteLine("       LE.txt Found? " + fileExists("LE.txt"));
                Debug.WriteLine("       PS.txt Found? " + fileExists("PS.txt"));
                Debug.WriteLine("       TE.txt Found? " + fileExists("TE.txt"));
                Debug.WriteLine("       SS.txt Found? " + fileExists("SS.txt"));
                return false;
            }
            else
            {
                Debug.WriteLine("All the files exist in Seccion '" + GetSeccion + "'");
                return true;
            } 
        }
        //Metodo para comprobar si existen un archivo
        private bool fileExists (string fileTXT)
        {
            string rutaCompleta = GetRutaSeccion + "\\" + fileTXT;
            //Debug.WriteLine(rutaCompleta + ": " + File.Exists(rutaCompleta));
            return File.Exists(rutaCompleta);
        }





        //Metodo para leer los arrays
        public void ReadTXTFiles()
        {
            resultadoArraLE = ObtenerTXTArray(GetRutaSeccion, "LE.txt");
            resultadoArraPS = ObtenerTXTArray(GetRutaSeccion, "PS.txt");
            resultadoArraTE = ObtenerTXTArray(GetRutaSeccion, "TE.txt");
            resultadoArraSS = ObtenerTXTArray(GetRutaSeccion, "SS.txt");
        }

        //Metodo para obtener los datos de cada uno de los array
        public string[,] arrayLE
        {
            get { return resultadoArraLE; }
        }
        public string[,] arrayPS
        {
            get { return resultadoArraPS; }
        }
        public string[,] arrayTE
        {
            get { return resultadoArraTE; }
        }
        public string[,] arraySS
        {
            get { return resultadoArraSS; }
        }

        //Metodo para leer el archvio de texto de los datos y guardar los datos en un array
        private string[,] ObtenerTXTArray(string rutaArray, string archivoLeer)
        {
            string[,] datos = null;

            //Debug.WriteLine("");
            string rutaCompletaArray = rutaArray + "\\" + archivoLeer;
            //Debug.WriteLine("Ruta del array a leer: " + rutaCompletaArray);

            try
            {
                // Lee todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaCompletaArray);

                // Verifica si hay datos
                if (lineas.Length > 0)
                {
                    // Obtén el número máximo de columnas en una fila
                    int maxColumnas = lineas.Max(linea => linea.Split('\t').Length);

                    // Inicializa el array bidimensional
                    datos = new string[lineas.Length, maxColumnas];

                    // Divide cada línea en elementos utilizando el tabulador como separador
                    for (int i = 0; i < lineas.Length; i++)
                    {
                        // Divide la línea en elementos utilizando el tabulador como separador
                        string[] elementos = lineas[i].Split('\t');

                        // Asigna los elementos al array bidimensional
                        for (int j = 0; j < elementos.Length; j++)
                        {
                            datos[i, j] = elementos[j];
                        }
                    }
                }
                else
                {
                    Debug.WriteLine("El archivo está vacío.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            return datos;
        }






        // Método para mostrar información sobre la seccion
        public string ShowInfo()
        {
            return "Ruta de la seccion: " + GetRutaSeccion;
        }

        //enum para obtener la letra de la carpeta de la seccion
        private enum intSeccionFolder
        {
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H,
            I,
            J
        }
    }//End internal class Seccion
}//End namespace GetDataTXT
