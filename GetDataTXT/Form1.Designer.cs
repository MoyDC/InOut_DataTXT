namespace GetDataTXT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            btnRutaCarpeta = new Button();
            textRuta = new TextBox();
            panelApagarPrender = new Panel();
            textApagarPrender = new TextBox();
            panelBoton = new Panel();
            buttonApagarPrender = new Button();
            panelPrincipal.SuspendLayout();
            panelApagarPrender.SuspendLayout();
            panelBoton.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.Lime;
            panelPrincipal.Controls.Add(btnRutaCarpeta);
            panelPrincipal.Controls.Add(textRuta);
            panelPrincipal.Location = new Point(3, 3);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(498, 448);
            panelPrincipal.TabIndex = 0;
            // 
            // btnRutaCarpeta
            // 
            btnRutaCarpeta.Location = new Point(104, 331);
            btnRutaCarpeta.Name = "btnRutaCarpeta";
            btnRutaCarpeta.Size = new Size(233, 62);
            btnRutaCarpeta.TabIndex = 1;
            btnRutaCarpeta.Text = "Buscar ruta de la carpeta";
            btnRutaCarpeta.UseVisualStyleBackColor = true;
            btnRutaCarpeta.Click += btnRutaCarpeta_Click;
            // 
            // textRuta
            // 
            textRuta.Location = new Point(75, 121);
            textRuta.Multiline = true;
            textRuta.Name = "textRuta";
            textRuta.Size = new Size(300, 50);
            textRuta.TabIndex = 0;
            // 
            // panelApagarPrender
            // 
            panelApagarPrender.BackColor = Color.Red;
            panelApagarPrender.Controls.Add(textApagarPrender);
            panelApagarPrender.Location = new Point(517, 9);
            panelApagarPrender.Name = "panelApagarPrender";
            panelApagarPrender.Size = new Size(449, 189);
            panelApagarPrender.TabIndex = 1;
            // 
            // textApagarPrender
            // 
            textApagarPrender.Location = new Point(140, 44);
            textApagarPrender.Name = "textApagarPrender";
            textApagarPrender.Size = new Size(125, 27);
            textApagarPrender.TabIndex = 0;
            textApagarPrender.Text = "Hola Mundo";
            // 
            // panelBoton
            // 
            panelBoton.Controls.Add(buttonApagarPrender);
            panelBoton.Location = new Point(523, 232);
            panelBoton.Name = "panelBoton";
            panelBoton.Size = new Size(445, 205);
            panelBoton.TabIndex = 2;
            // 
            // buttonApagarPrender
            // 
            buttonApagarPrender.Location = new Point(150, 81);
            buttonApagarPrender.Name = "buttonApagarPrender";
            buttonApagarPrender.Size = new Size(162, 83);
            buttonApagarPrender.TabIndex = 0;
            buttonApagarPrender.Text = "Apagar";
            buttonApagarPrender.UseVisualStyleBackColor = true;
            buttonApagarPrender.Click += buttonApagarPrender_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(panelBoton);
            Controls.Add(panelApagarPrender);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panelApagarPrender.ResumeLayout(false);
            panelApagarPrender.PerformLayout();
            panelBoton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Button btnRutaCarpeta;
        private TextBox textRuta;
        private Panel panelApagarPrender;
        private TextBox textApagarPrender;
        private Panel panelBoton;
        private Button buttonApagarPrender;
    }
}
