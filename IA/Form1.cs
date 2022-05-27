using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IA
{
    public partial class Form1 : Form
    {
        private int[,] mat;
        public Form1()
        {
            InitializeComponent();
            BtnMontarArchivo.Enabled = false;
        }
        private void LlenarConfiguracion()
        {
            CBoxFuncion.Items.Clear();
            CBoxEntrenamiento.Items.Clear();
            CBoxCapas.Items.Clear();
            if (CBoxRed.Text.Equals("Perceptron"))
            {
                CBoxFuncion.Items.Add("Escalon");
                CBoxEntrenamiento.Items.Add("Regla delta");
            }
            else if (CBoxRed.Text.Equals("Adaline"))
            {
                CBoxFuncion.Items.Add("Lineal");
                CBoxEntrenamiento.Items.Add("Regla delta");
            }
            else if (CBoxRed.Text.Equals("Backpropagation"))
            {
                CBoxFuncion.Items.Add("Sigmoide");
                CBoxFuncion.Items.Add("Tangente hiperbolica");
                CBoxEntrenamiento.Items.Add("Propagacion inversa");
            }
            CBoxCapas.Items.Add("Unicapa");
            CBoxCapas.Items.Add("Multicapa");
        }
        private void HabilitarBoton()
        {
            if (CBoxEntrenamiento.Text.Equals("") || CBoxFuncion.Text.Equals(""))
            {
                BtnMontarArchivo.Enabled = false;
            }
            else
            {
                BtnMontarArchivo.Enabled = true;
            }
        }
        private void BtnMontarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Leer(openFile.FileName);
            }
            else
            {
                MessageBox.Show("Error al cargar el archivo");
            }
        }
        private void Leer(string fileName)
        {
            int Ancho = 0, Alto = 0, Entrada = 0, Salida = 0, flagn = 0, flagm = 0;
            FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                while (CicloRevision(linea, flagn, flagm))
                {
                    if (ContinuaEntrando(linea, flagn))
                    {
                        Entrada = Entrada + 1;
                        Alto = Alto + 1;
                        flagn = flagn + 1;
                    }
                    else if (ContinuaSaliendo(linea, flagm))
                    {
                        Salida = Salida + 1;
                        Alto = Alto + 1;
                        flagm = flagm + 1;
                    }
                }
                Ancho = Ancho + 1;
            }
            reader.Close();
            file.Close();
            PintarDatos(Ancho, Entrada, Salida);

        }
        private void PintarDatos(int ancho, int entrada, int salida)
        {
            LabelTamaño.Text = entrada + " x " + salida;
            LabelEntrada.Text = " " + entrada;
            LabelSalida.Text = " " + salida;
            LabelPatron.Text = " " + ancho;
            Imprimir(salida, ancho);
        }
        private Boolean CicloRevision(string linea, int n, int m)
        {
            if (ContinuaEntrando(linea, n) || ContinuaSaliendo(linea, m))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Boolean ContinuaEntrando(string linea, int n)
        {
            try
            {
                string convertir = linea.Split(' ')[n];
                return true;
            }
            catch
            {
                return false;
            }
        }
        private Boolean ContinuaSaliendo(string linea, int m)
        {
            try
            {
                string convertir = linea.Split(':')[m];
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void CBoxRed_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarConfiguracion();
            HabilitarBoton();
        }
        private void CBoxFuncion_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }
        private void CBoxEntrenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            HabilitarBoton();
        }
        private void Inicializacion()
        {
            Random rnd = new Random();
            for (int j = -1; j <= 1; j++)
            {
                Console.WriteLine(rnd.NextDouble());
            }
        }
        public void Imprimir(int salida, int ancho)
        {
            Random rnd = new Random();
            for (int a = 0; a < ancho; a++)
            {
                for (int c = 0; c < salida; c++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        Console.WriteLine(rnd.NextDouble());
                    }
                    Console.Write(mat[a, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
