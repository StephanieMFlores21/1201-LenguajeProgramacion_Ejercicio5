using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMatriz
{
    //NOMBRE: STEPHANIE MARIELA FLORES CASTRO
    //CUENTA: 20181001362
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            //N = Filas, M = Columnas
            int filas, columnas;
            filas = int.Parse(FilastextBox.Text);
            columnas = int.Parse(ColumnastextBox.Text);

            int[,] matriz = new int[filas, columnas];

            //CLASE RANDOM
            Random numerosaleatorios = new Random();
            for (int N = 0; N < matriz.GetLength(0); N++)
            {
                for (int M = 0; M < matriz.GetLength(1); M++)
                {
                    matriz[N, M] = numerosaleatorios.Next(100);
                }
            }

            for (int N = 0; N < matriz.GetLength(0); N++)
            {
                for (int M = 0; M < matriz.GetLength(1); M++)
                {
                    MessageBox.Show("La posicion es: " + filas + ", " + columnas + " = " + matriz[N, M].ToString());
                }
            }
        }
    }
}
