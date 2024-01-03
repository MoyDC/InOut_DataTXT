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
        private string GetRutaSeccion
        {
            get { return rutaCarpeta + "\\" + seccion; }
        }


        //Metodo para leer los arrays
        public void ReadArrays()
        {
            resultadoArraLE = ObtenerArray(GetRutaSeccion, "LE.txt");
            resultadoArraPS = ObtenerArray(GetRutaSeccion, "PS.txt");
            resultadoArraTE = ObtenerArray(GetRutaSeccion, "TE.txt");
            resultadoArraSS = ObtenerArray(GetRutaSeccion, "SS.txt");
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

        //Metodo para leer el archvio de texto de los datos
        private string[,] ObtenerArray(string rutaArray, string archivoLeer)
        {
            string[,] datos = null;

            Debug.WriteLine("");
            string rutaCompletaArray = rutaArray + "\\" + archivoLeer;
            Debug.WriteLine("Ruta del array: " + rutaCompletaArray);

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

                    // Imprime los datos para verificar
                    /*for (int i = 0; i < datos.GetLength(0); i++)
                    {
                        for (int j = 0; j < datos.GetLength(1); j++)
                        {
                            Debug.Write(datos[i, j] + " ");
                        }
                        Debug.WriteLine(""); // Nueva línea después de cada fila
                    }

                    Debug.WriteLine("Dato Elegido: " + datos[20, 2]);
                    */
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
