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
            

            DesactivarTextBoxs();
        }
        private void DesactivarTextBoxs()
        {
            txtFx.Enabled = false;
            txtIter.Enabled = false;
            txtMargenError.Enabled = false;
            txtXdXini.Enabled = false;
            txtXiFx.Enabled = false;
            txtXini2.Enabled = false;

            txtFx.Text = null;
            txtIter.Text = null;
            txtMargenError.Text = null;
            txtXdXini.Text = null;
            txtXiFx.Text = null;
            txtXini2.Text = null;
        }
        private void btnBiseccion_Click(object sender, EventArgs e)
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

                            while (c <= iter)
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

                                double Fxr = Math.Abs(resultadoFxr);

                                //-------------------------------- Condiciones del corte del while

                                if (Fxr < tole | error < tole)
                                {
                                    bandera = true;
                                    break;
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

        private void button5_Click(object sender, EventArgs e) => this.Close();

        private void btnReglaFalsa_Click(object sender, EventArgs e)
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

                    double resultadoFxi = 0;
                    double resultadoFxd = 0;

                    //if (AnalizadorDeFunciones.Sintaxis(FuncionFx, X) == true)
                    //{
                        resultadoFxi = AnalizadorDeFunciones.EvaluaFx(VarXi);
                    //}

                    //if (AnalizadorDeFunciones.Sintaxis(FuncionFx, X) == true)
                    //{
                        resultadoFxd = AnalizadorDeFunciones.EvaluaFx(VarXd);
                    //}

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

                            while (c <= iter)
                            {
                                //if (AnalizadorDeFunciones.Sintaxis(FuncionFx, X) == true)
                                //{
                                    resultadoFxi = AnalizadorDeFunciones.EvaluaFx(VarXi);
                                //}

                                //if (AnalizadorDeFunciones.Sintaxis(FuncionFx, X) == true)
                                //{
                                    resultadoFxd = AnalizadorDeFunciones.EvaluaFx(VarXd);
                                //}


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

                                double Fxr = Math.Abs(resultadoFxr);

                                //-------------------------------- Condiciones del corte del while

                                if (Fxr < tole | error < tole)
                                {
                                    bandera = true;
                                    break;
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

        private void btnNewton_Click(object sender, EventArgs e)
        {
            Calculo AnalizadorDeFunciones = new Calculo();

            
            char X = Convert.ToChar("x");
            string FuncionFx = Convert.ToString(txtFx.Text);

            bool condicion = AnalizadorDeFunciones.Sintaxis(FuncionFx, X);

            if (txtFx.Text == "" | txtIter.Text == "" | txtMargenError.Text == "" | txtXdXini.Text == "")
            {
                lblSintaxis.Text = "Uno o varios campos no contienen datos, vuelva a escribirlos";
                lblSintaxis.Visible = true;
            }
            else
            {
                int iter = Convert.ToInt32(txtIter.Text);
                double xr = 0;
                bool bandera = false;

                lblSintaxis.Visible = false;

                double Xini = Convert.ToDouble(txtXdXini.Text); // Convierto a double Xini
                double Fxini = AnalizadorDeFunciones.EvaluaFx(Xini); // Evaluo F(xini) 

                double absFxini = Math.Abs(Fxini);

                double tole = Convert.ToDouble(txtMargenError.Text.Replace(".", ","));

                if (absFxini <= tole) // Pregunto si Fx(ini) es = 0, en caso de que si es porque Xini es la RAIZ.  
                {
                    lblConverge.Text = "SI";
                    lblnfo.Text = "HAY RAIZ";
                    lblIter.Text = "0";
                    lblRaiz.Text = Convert.ToString(Xini);
                }
                else
                {
                    // INICIALIZO VARIABLES 
                    
                    int c = 0;
                    double Xant = 0;

                    //----------------------------------------------

                    while (c <= iter)
                    {
                        c++; // Comienza a contar el contador de Iteraciones

                        //if (AnalizadorDeFunciones.Sintaxis(FuncionFx, X) == true) // Calculo de Fx(xini)
                        //{
                            Fxini = AnalizadorDeFunciones.EvaluaFx(Xini);
                        //}                     
                                             
                        lblSintaxis.Visible = false;

                        double Fxiniprima = AnalizadorDeFunciones.Dx(Xini); // Calculo la derivada de Fx(xini) con CALCULUS

                        if (Fxiniprima == 0 | double.IsNaN(Fxiniprima))
                        {
                            MessageBox.Show("Error: La derivada da valor 0 o no es un numero");

                            break;
                        }

                        xr = (Xini - (Fxini / Fxiniprima));

                        double error = Math.Abs((xr - Xant) / xr); // Calculo el error

                        //----CALCULO DE Fx(xr)-----------------------------------------

                        double Fxr = 0;

                        //if (AnalizadorDeFunciones.Sintaxis(FuncionFx, X) == true)
                        //{
                            Fxr = AnalizadorDeFunciones.EvaluaFx(xr);
                            Fxr = Math.Abs(Fxr); 
                        //}

                        //-------------------------------- Condiciones del corte del while

                        if (Fxr < tole | error < tole)
                        {
                            bandera = true;
                            break;
                        }
                        else
                        {
                          
                            Xini = xr;
                            Xant = xr;
                           
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
                txtFx.Enabled = true;
                txtIter.Enabled = true;
                txtMargenError.Enabled = true;
                txtXdXini.Enabled = true;
                txtXiFx.Enabled = true;
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
                DesactivarTextBoxs();
            }
        }

        private void checkBoxAbierto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAbierto.Checked == true)
            {
                checkBoxCerrado.Enabled = false;
                checkBoxCerrado.Checked = false;
                lblEdit1.Text = "-";
                lblEdit2.Text = "X ini:";
                lblXini2.Text = "X ini 2:";
                btnNewton.Enabled = true;
                btnSecante.Enabled = true;
                txtFx.Enabled = true;
                txtIter.Enabled = true;
                txtMargenError.Enabled = true;
                txtXdXini.Enabled = true;
                txtXini2.Enabled = true;
            }
            else
            {
                btnBiseccion.Enabled = false;
                btnReglaFalsa.Enabled = false;
                btnNewton.Enabled = false;
                btnSecante.Enabled = false;
                lblEdit1.Text = "-";
                lblEdit2.Text = "-";
                lblXini2.Text = "-";
                checkBoxCerrado.Enabled = true;
                DesactivarTextBoxs();
            }
        }

        private void btnSecante_Click(object sender, EventArgs e)
        {
            Calculo AnalizadorDeFunciones = new Calculo();


            char X = Convert.ToChar("x");
            string FuncionFx = Convert.ToString(txtFx.Text);

            bool condicion = AnalizadorDeFunciones.Sintaxis(FuncionFx, X);

            if (txtFx.Text == "" | txtIter.Text == "" | txtMargenError.Text == "" | txtXdXini.Text == "" | txtXini2.Text == "")
            {
                lblSintaxis.Text = "Uno o varios campos no contienen datos, vuelva a escribirlos";
                lblSintaxis.Visible = true;
            }
            else
            {
                int iter = Convert.ToInt32(txtIter.Text);
                double xr = 0;
                bool bandera = false;

                lblSintaxis.Visible = false;

                double Xini = Convert.ToDouble(txtXdXini.Text); // Convierto a double Xini
                double Xini2 = Convert.ToDouble(txtXini2.Text); // Convierto a double Xini2
                double Fxini = AnalizadorDeFunciones.EvaluaFx(Xini); // Evaluo F(xini) 

                double absFxini = Math.Abs(Fxini);

                double tole = Convert.ToDouble(txtMargenError.Text.Replace(".", ","));

                if (absFxini <= tole) // Pregunto si Fx(ini) es = 0, en caso de que si es porque Xini es la RAIZ.  
                {
                    lblConverge.Text = "SI";
                    lblnfo.Text = "HAY RAIZ";
                    lblIter.Text = "0";
                    lblRaiz.Text = Convert.ToString(Xini);
                }
                else
                {
                    // INICIALIZO VARIABLES 

                    int c = 0;
                    double Xant = 0;
                    double Fxini2 = 0;

                    //----------------------------------------------

                    while (c <= iter)
                    {
                        c++; // Comienza a contar el contador de Iteraciones

                        //if (AnalizadorDeFunciones.Sintaxis(FuncionFx, X) == true) // Calculo de Fx(xini)
                        //{
                            Fxini = AnalizadorDeFunciones.EvaluaFx(Xini);
                        //}

                        //if (AnalizadorDeFunciones.Sintaxis(FuncionFx, X) == true) // Calculo de Fx(xini2)
                        //{
                            Fxini2 = AnalizadorDeFunciones.EvaluaFx(Xini2);
                        //}

                        lblSintaxis.Visible = false;

                        xr = ((Fxini2 * Xini) - (Fxini * Xini2)) / (Fxini2 - Fxini);

                        double error = Math.Abs((xr - Xant) / xr); // Calculo el error

                        //----CALCULO DE Fx(xr)-----------------------------------------

                        double Fxr = 0;

                        //if (AnalizadorDeFunciones.Sintaxis(FuncionFx, X) == true)
                        //{
                            Fxr = AnalizadorDeFunciones.EvaluaFx(xr);
                            Fxr = Math.Abs(Fxr);
                        //}

                        //-------------------------------- Condiciones del corte del while

                        if (Fxr < tole | error < tole)
                        {
                            bandera = true;
                            break;
                        }
                        else
                        {
                            Xini = Xini2;
                            Xini2 = xr;
                            Xant = xr;
                            
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


