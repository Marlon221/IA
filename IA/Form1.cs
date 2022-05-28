using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace IA
{
    public partial class Form1 : Form
    {
        private string FileName = "Pesos_Y_Umbrales.txt";
        public Form1()
        {
            InitializeComponent();
            BtnMontarArchivo.Enabled = false;
            GboxDatos.Enabled = false;
        }
        // Seleccion tipo de neurona a entrenar
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
        //habilitar o deshabilitar opcion de montar banco de datos
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
        //Montar banco de datos
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
        //Leer banco de datos
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
        //Mostrar parametros de matriz de datos
        private void PintarDatos(int ancho, int entrada, int salida)
        {
            LabelTamaño.Text = entrada + " x " + salida;
            LabelEntrada.Text = " " + entrada;
            LabelSalida.Text = " " + salida;
            LabelPatron.Text = " " + ancho;
            GboxDatos.Enabled = true;
            LlenarMatriz(salida, entrada);
        }
        //Conteo de entradas, salidas y patrones
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
        //Habilitar boton para montar banco de datos
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
        //Inicializar pesos y umbrales
        private void LlenarMatriz(int salida, int entrada)
        {
            double[,] matriz = new double[entrada, salida];
            double recupera;
            Random aleatorio = new Random();
            for (int i = 0; i < entrada; i++)
            {
                for (int J = 0; J < salida; J++)
                {
                    recupera = aleatorio.Next(-10, 11);
                    matriz[i, J] = (recupera) / 10;
                }
            }
            double[] array = new double[salida];
            Random randomize = new Random();
            for (int k = 0; k < salida; k++)
            {
                recupera = aleatorio.Next(-10, 11);
                array[k] = (recupera) / 10;
            }
            GuardarPesosUmbrales(matriz, array, entrada, salida);
        }
        //Funcion de activacion y algoritmos de entrenamiento
        private void FuncionActivacion(double[,] matriz, double[] array, int entrada, int salida)
        {
            if (CBoxFuncion.Text == "Escalon")
            {
                for (int i = 0; i < entrada + 1; i++)
                {
                    for (int valor = 0; valor < salida + 1; valor++)
                    {
                        if(matriz[i, valor] >= 0)
                        {
                            //calculo de S, Yr escalon,  y error lineal
                        }
                        else if(matriz[i, valor] < 0){
                            //calculo de S, Yr escalon,  y error lineal
                        }
                    }
                }
                for (int k = 0; k < salida + 1; k++)
                {
                    if (array[k] >= 0)
                    {
                        //calculo de S, Yr escalon,  y error lineal
                    }
                    else if (array[k] < 0)
                    {
                        //calculo de S, Yr escalon,  y error lineal
                    }
                }
            }
        }
        //Guardar en archivo
        private void GuardarPesosUmbrales(double[,] matriz, double[] array, int entrada, int salida)
        {
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Create);
                StreamWriter writer = new StreamWriter(file);
                for (int i = 0; i < entrada; i++)
                {
                    for (int J = 0; J < salida; J++)
                    {
                        writer.WriteLine($"peso: {matriz[i,J]}");
                    }
                }
                for (int k = 0; k < salida; k++)
                {
                    writer.WriteLine($"umbral: {array[k]}");
                }
                writer.Close();
                file.Close();
                MessageBox.Show("Archivo guardado con exito");
            }
            catch (Exception e)
            {
                MessageBox.Show("No Se Pudo Cargar El Archivo" + e.Message);
            }
        }
        //Iniciar entrenamiento
        private void BtnEntrenar_Click()
        {
            //Procedimientos de entrenamiento
        }
    }
}
