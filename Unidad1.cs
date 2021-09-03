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
            btnBiseccion.Enabled = false;
            btnReglaFalsa.Enabled = false;
            btnNewton.Enabled = false;
            btnSecante.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculo AnalizadorDeFunciones = new Calculo();
            
            char X = Convert.ToChar("x");
            string FuncionFx = Convert.ToString(txtFx.Text);

            if (txtFx.Text == "" | txtIter.Text == "" | txtMargenError.Text == "" | txtXiFx.Text == "" | txtXdXini.Text == "")
            {
                lblSintaxis.Text = "Uno o varios campos no contienen datos, vuelva a escribirlos";
                lblSintaxis.Visible = true;
            }
            else
            {
                lblSintaxis.Visible = false;
                double VarXi = Convert.ToDouble(txtXiFx.Text);
                double VarXd = Convert.ToDouble(txtXdXini.Text);
              
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
                        txtXdXini.Text = "";
                        txtXiFx.Text = "";
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
                            double tole = Convert.ToDouble(txtMargenError.Text.Replace(".", ","));
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
        }

        private void button5_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculo AnalizadorDeFunciones = new Calculo();

            char X = Convert.ToChar("x");
            string FuncionFx = Convert.ToString(txtFx.Text);

            if (txtFx.Text == "" | txtIter.Text == "" | txtMargenError.Text == "" | txtXiFx.Text == "" | txtXdXini.Text == "")
            {
                lblSintaxis.Text = "Uno o varios campos no contienen datos, vuelva a escribirlos";
                lblSintaxis.Visible = true;
            }
            else
            {
                lblSintaxis.Visible = false;
                
                double VarXi = Convert.ToDouble(txtXiFx.Text);
                double VarXd = Convert.ToDouble(txtXdXini.Text);

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
                        txtXdXini.Text = "";
                        txtXiFx.Text = "";
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
                            double tole = Convert.ToDouble(txtMargenError.Text.Replace(".", ","));
                            int iter = Convert.ToInt32(txtIter.Text);

                            while (c < iter)
                            {
                                resultadoFxi = AnalizadorDeFunciones.EvaluaFx(VarXi);
                                resultadoFxd = AnalizadorDeFunciones.EvaluaFx(VarXd);

                                double productoFxdxi = resultadoFxd * VarXi;
                                double productoFxixd = resultadoFxi * VarXd;
                                double restoFxdFxi = resultadoFxd - resultadoFxi;

                                c = c + 1;
                                xr = (productoFxdxi - productoFxixd) / restoFxdFxi;
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculo AnalizadorDeFunciones = new Calculo();

            char X = Convert.ToChar("x");
            string FuncionFx = Convert.ToString(txtFx.Text);
            string DerivadaFx = Convert.ToString(txtXiFx.Text);

            if (txtFx.Text == "" | txtIter.Text == "" | txtMargenError.Text == "" | txtXiFx.Text == "" | txtXdXini.Text == "")
            {
                lblSintaxis.Text = "Uno o varios campos no contienen datos, vuelva a escribirlos";
                lblSintaxis.Visible = true;
            }
            else
            {
                lblSintaxis.Visible = false;

                double Xini = Convert.ToDouble(txtXdXini.Text);
                double Fxini = AnalizadorDeFunciones.EvaluaFx(Xini);
                string FxPrima = txtXiFx.Text;

                double absFxini = Math.Abs(Fxini);

                double tole = Convert.ToDouble(txtMargenError.Text);

                if (absFxini < tole)
                {
                    lblConverge.Text = "SI";
                    lblnfo.Text = "HAY RAIZ";
                    lblIter.Text = "0";
                    lblRaiz.Text = Convert.ToString(Xini);
                }
                else
                {
                    int c = 0;
                    double Xant = 0;
                    int iter = Convert.ToInt32(txtIter.Text);
                    double xr = 0;
                    bool bandera = false;

                    while (c < iter)
                    {
                        c = c++;

                        double Fxiniprima = 0;
                        if (AnalizadorDeFunciones.Sintaxis(FuncionFx, X) == true)
                        {
                            Fxini = AnalizadorDeFunciones.EvaluaFx(Xini);
                        }
                        if (AnalizadorDeFunciones.Sintaxis(FxPrima, X) == false)
                        {
                            lblSintaxis.Visible = true;
                            lblSintaxis.Text = "Derivada de la funcion mal escrita";
                        }
                        else
                        {                            
                            lblSintaxis.Visible = false;
                            Fxiniprima = AnalizadorDeFunciones.EvaluaFx(Xini);

                            xr = Xini - (Fxini / Fxiniprima);

                            double error = Math.Abs((xr - Xant) / xr);

                            double Fxr = 0;

                            //------------------------------------------------------------------
                            
                            Xini = xr;

                            Xant = xr;

                            double resultadoFxr = 0;

                            if (AnalizadorDeFunciones.Sintaxis(FuncionFx, X) == true)
                            {
                                resultadoFxr = AnalizadorDeFunciones.EvaluaFx(xr);
                            }
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

        private void checkBoxCerrado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCerrado.Checked == true)
            {
                checkBoxAbierto.Enabled = false;
                checkBoxAbierto.Checked = false;
                lblEdit1.Text = "Variable X(i):";
                lblEdit2.Text = "Variable X(d):";
                btnBiseccion.Enabled = true;
                btnReglaFalsa.Enabled = true;
            }
            else
            {
                btnBiseccion.Enabled = false;
                btnReglaFalsa.Enabled = false;
                btnNewton.Enabled = false;
                btnSecante.Enabled = false;
                lblEdit1.Text = "-";
                lblEdit2.Text = "-";
                checkBoxAbierto.Enabled = true;
            }
        }

        private void checkBoxAbierto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAbierto.Checked == true)
            {
                checkBoxCerrado.Enabled = false;
                checkBoxCerrado.Checked = false;
                lblEdit1.Text = "Derivada F'(x):";
                lblEdit2.Text = "X ini:";
                btnNewton.Enabled = true;
                btnSecante.Enabled = true;
            }
            else
            {
                btnBiseccion.Enabled = false;
                btnReglaFalsa.Enabled = false;
                btnNewton.Enabled = false;
                btnSecante.Enabled = false;
                lblEdit1.Text = "-";
                lblEdit2.Text = "-";
                checkBoxCerrado.Enabled = true;
            }
        }
    }
}
