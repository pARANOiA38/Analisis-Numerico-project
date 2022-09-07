using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_AnalisisNumerico2021
{
    public partial class Unidad2 : Form
    {
        public Unidad2()
        {
            InitializeComponent();
            

        }

        private void GenerarMatriz()
        {
            int dimension = int.Parse(dimensionX.Text);
            
            int puntoX = 30;
            int puntoY = 30;

            Matriz.Controls.Clear();

            for (int col = 0; col < dimension + 1; col++)
            {
                for (int row = 0; row < dimension ; row++)
                {
                    TextBox b = new TextBox();
                    b.Text = (row + 1).ToString();
                    b.Location = new Point(puntoX, puntoY);
                    b.Size = new Size(55, 55);
                    Matriz.Controls.Add(b);
                    Matriz.Show();
                    puntoY += 35;
                    //string nombre = "(" + row.ToString() + "," + col.ToString() + ")";
                }

                puntoY = 30;
                puntoX += 105;
            }

        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            int valor = 0;

            if (dimensionX.Text == "-")
            {
                dimensionX.Text = "2";
                dimensionY.Text = "2";

                GenerarMatriz();
            }
            else
            {
                valor = Convert.ToInt32(dimensionX.Text);
                
                if (valor < 9)
                {
                    valor = Convert.ToInt32(dimensionX.Text) + 1;
                    dimensionX.Text = Convert.ToString(valor);
                    dimensionY.Text = Convert.ToString(valor);

                    GenerarMatriz();
                }
            }
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            int valor = 0;

            if (dimensionX.Text != "2")
            {
                valor = Convert.ToInt32(dimensionX.Text) - 1;
                dimensionX.Text = Convert.ToString(valor);
                dimensionY.Text = Convert.ToString(valor);

                GenerarMatriz();
            }
        }
    }
}
