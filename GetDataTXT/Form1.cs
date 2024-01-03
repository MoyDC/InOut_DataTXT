using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using static System.Collections.Specialized.BitVector32;

namespace GetDataTXT
{
    public partial class Form1 : Form
    {
        private RutaCarpeta rutaCarpeta = new RutaCarpeta();
        private Seccion seccionA = new Seccion();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRutaCarpeta_Click(object sender, EventArgs e)
        {
            // Crea una instancia del cuadro de di�logo FolderBrowserDialog
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // Muestra el cuadro de di�logo
                DialogResult result = folderDialog.ShowDialog();

                // Si el usuario hace clic en 'Aceptar' en el cuadro de di�logo
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    // Actualiza el texto en el TextBox con la ruta seleccionada
                    //textRuta.Text = folderDialog.SelectedPath;
                    rutaCarpeta.SetRuta(folderDialog.SelectedPath);
                    textRuta.Text = rutaCarpeta.GetRuta;
                }



                seccionA.SetSeccion(rutaCarpeta.GetRuta, 0);
                Debug.WriteLine(seccionA.ShowInfo());


                seccionA.ReadArrays();

                string[,] datosArray = null;
                datosArray = seccionA.arrayTE;

                for (int i = 0; i < datosArray.GetLength(0); i++)
                {
                    for (int j = 0; j < datosArray.GetLength(1); j++)
                    {
                        Debug.Write(datosArray[i, j] + " ");
                    }
                    Debug.WriteLine(""); // Nueva l�nea despu�s de cada fila
                }

                // Mostrar informaci�n sobre la carpeta
                //Debug.WriteLine(rutaCarpeta.ShowRuta());

                /*try
                {
                    // Ruta del archivo de texto
                    string rutaArchivo = "D:\\Moy\\Trabajos Moy\\Archivos de Moy\\Trabajo\\- 2D\\A\\LE.txt";

                    // Lee todas las l�neas del archivo
                    string[] lineas = File.ReadAllLines(rutaArchivo);

                    // Verifica si hay datos
                    if (lineas.Length > 0)
                    {
                        // Divide cada l�nea en elementos utilizando el tabulador como separador
                        string[][] datos = new string[lineas.Length][];
                        for (int i = 0; i < lineas.Length; i++)
                        {
                            // Divide la l�nea en elementos utilizando el tabulador como separador
                            datos[i] = lineas[i].Split('\t');
                        }

                        // Ahora, 'datos' es un array bidimensional que contiene los valores del archivo
                        // Puedes acceder a los elementos utilizando indices, por ejemplo: datos[0][0]
                        Debug.WriteLine("");
                        Debug.Write("Datos array");
                        Debug.WriteLine("");
                        // Imprime los datos para verificar
                        for (int i = 0; i < datos.Length; i++)
                        {
                            for (int j = 0; j < datos[i].Length; j++)
                            {
                                Debug.Write(datos[i][j] + " ");
                            }
                            Debug.WriteLine(""); // Nueva l�nea despu�s de cada fila
                        }

                        Debug.WriteLine("Dato Elegido: " + datos[20][2]);
                    }
                    else
                    {
                        Debug.WriteLine("El archivo est� vac�o.");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Error al leer el archivo: {ex.Message}");
                }*/

            }
        }

        private void buttonApagarPrender_Click(object sender, EventArgs e)
        {
            // Si el panel est� visible, lo oculta; de lo contrario, lo hace visible
            panelApagarPrender.Visible = !panelApagarPrender.Visible;

            // Cambia el texto del bot�n de "Apagar" a "Prender" y viceversa
            if (buttonApagarPrender.Text == "Apagar")
            {
                buttonApagarPrender.Text = "Prender";
                // Puedes agregar aqu� cualquier otra acci�n que desees realizar cuando se prenda el panel
            }
            else
            {
                buttonApagarPrender.Text = "Apagar";
                // Puedes agregar aqu� cualquier otra acci�n que desees realizar cuando se apague el panel
            }
        }
    }
}
