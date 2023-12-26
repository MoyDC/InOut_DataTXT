namespace GetDataTXT
{
    public partial class Form1 : Form
    {
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
                    textRuta.Text = folderDialog.SelectedPath;
                }
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
