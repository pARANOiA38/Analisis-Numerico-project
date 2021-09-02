using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;

namespace TP1_AnalisisNumerico2021
{
    public partial class Unidad1 : Form
    {
        public Unidad1()
        {
            InitializeComponent();
            lblSintaxis.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculo AnalizadorDeFunciones = new Calculo();
            
            char X = Convert.ToChar("x");
            string FuncionFx = Convert.ToString(txtFx.Text);
            int VarXii = Convert.ToInt32(txtXi.Text);
            int VarXdd = Convert.ToInt32(txtXd.Text);

            double VarXi = Convert.ToDouble(VarXii);
            double VarXd = Convert.ToDouble(VarXdd);

            bool condicion = AnalizadorDeFunciones.Sintaxis(FuncionFx, X);

            if (condicion == false)
            {
                lblSintaxis.Visible = true;
                lblSintaxis.Text = "Error de sintaxis, vuelve a escribir la funcion F(x)";
            }
            else
            {
                lblSintaxis.Visible = false;

                double resultadoFxi = AnalizadorDeFunciones.EvaluaFx(VarXi);
                double resultadoFxd = AnalizadorDeFunciones.EvaluaFx(VarXd);
                double productoFxiFxd = resultadoFxd * resultadoFxi;

                if (productoFxiFxd > 0)
                {
                    lblSintaxis.Visible = true;
                    lblSintaxis.Text = "Vuelve a ingresar X(d) y X(i)";
                    txtXd.Text = "";
                    txtXi.Text = "";
                }
                else
                {
                    lblSintaxis.Visible = false;
                    if (productoFxiFxd == 0)
                    {
                        if (resultadoFxi == 0)
                        {
                            lblConverge.Text = "SI";
                            lblRaiz.Text = Convert.ToString(VarXi);
                            lblnfo.Text = "Xi es la Raiz";
                        }
                        else
                        {
                            lblConverge.Text = "SI";
                            lblRaiz.Text = Convert.ToString(VarXd);
                            lblnfo.Text = "Xd es la Raiz";
                        }
                    }
                    else
                    {
                        double xr = 0;
                        bool bandera = false;
                        double xant = 0;
                        int c = 0;
                        double tole = Convert.ToDouble(txtMargenError.Text);
                        int iter = Convert.ToInt32(txtIter.Text);

                        while (c < iter)
                        {
                            resultadoFxi = AnalizadorDeFunciones.EvaluaFx(VarXi);

                            c = c + 1;
                            xr = ((VarXi + VarXd) / 2);
                            double error = Math.Abs((xr - xant) / xr);

                            //----------------------------------------------------------------

                            double resultadoFxr = AnalizadorDeFunciones.EvaluaFx(xr);

                            double productoXiXr = (resultadoFxr * resultadoFxi);

                            if (productoXiXr < 0)
                            {
                                VarXd = xr;
                            }
                            else
                            {
                                VarXi = xr;
                            }

                            xant = xr;

                            double Fxr = 0;

                            //--- Lo de abajo lo hice asi porque math.abs() me tira un 0... :/--

                            if (resultadoFxr < 0)
                            {
                                Fxr = resultadoFxr * -1;
                            }
                            else
                            {
                                Fxr = resultadoFxr;
                            }

                            //-------------------------------- Condiciones del corte del while

                            if (Fxr < tole)
                            {
                                bandera = true;
                                break;
                            }
                            else
                            {
                                if (error < tole)
                                {
                                    bandera = true;
                                    break;
                                }
                            }

                        }

                        if (!bandera)
                        {
                            lblConverge.Text = "NO";
                            lblnfo.Text = "ITERACIONES MAXIMAS SUPERADAS";
                        }
                        else
                        {
                            lblConverge.Text = "SI";
                            lblnfo.Text = "HAY RAIZ";
                            lblIter.Text = Convert.ToString(c);
                            lblRaiz.Text = Convert.ToString(xr);

                        }

                    }
                }

            }


        }

        private void button5_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}
