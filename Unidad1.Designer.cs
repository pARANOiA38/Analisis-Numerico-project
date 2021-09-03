namespace TP1_AnalisisNumerico2021
{
    partial class Unidad1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblEdit1 = new System.Windows.Forms.Label();
            this.lblEdit2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.txtXiFx = new System.Windows.Forms.TextBox();
            this.txtXdXini = new System.Windows.Forms.TextBox();
            this.txtIter = new System.Windows.Forms.TextBox();
            this.txtMargenError = new System.Windows.Forms.TextBox();
            this.lblSintaxis = new System.Windows.Forms.Label();
            this.btnBiseccion = new System.Windows.Forms.Button();
            this.btnReglaFalsa = new System.Windows.Forms.Button();
            this.btnNewton = new System.Windows.Forms.Button();
            this.btnSecante = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblConverge = new System.Windows.Forms.Label();
            this.lblRaiz = new System.Windows.Forms.Label();
            this.lblIter = new System.Windows.Forms.Label();
            this.lblnfo = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBoxCerrado = new System.Windows.Forms.CheckBox();
            this.checkBoxAbierto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Función F(x):";
            // 
            // lblEdit1
            // 
            this.lblEdit1.AutoSize = true;
            this.lblEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit1.Location = new System.Drawing.Point(17, 77);
            this.lblEdit1.Name = "lblEdit1";
            this.lblEdit1.Size = new System.Drawing.Size(15, 20);
            this.lblEdit1.TabIndex = 1;
            this.lblEdit1.Text = "-";
            // 
            // lblEdit2
            // 
            this.lblEdit2.AutoSize = true;
            this.lblEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit2.Location = new System.Drawing.Point(17, 114);
            this.lblEdit2.Name = "lblEdit2";
            this.lblEdit2.Size = new System.Drawing.Size(15, 20);
            this.lblEdit2.TabIndex = 2;
            this.lblEdit2.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Iteraciones Max:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Margen de error:";
            // 
            // txtFx
            // 
            this.txtFx.Location = new System.Drawing.Point(156, 41);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(100, 20);
            this.txtFx.TabIndex = 5;
            // 
            // txtXiFx
            // 
            this.txtXiFx.Location = new System.Drawing.Point(156, 79);
            this.txtXiFx.Name = "txtXiFx";
            this.txtXiFx.Size = new System.Drawing.Size(100, 20);
            this.txtXiFx.TabIndex = 6;
            // 
            // txtXdXini
            // 
            this.txtXdXini.Location = new System.Drawing.Point(156, 116);
            this.txtXdXini.Name = "txtXdXini";
            this.txtXdXini.Size = new System.Drawing.Size(100, 20);
            this.txtXdXini.TabIndex = 7;
            // 
            // txtIter
            // 
            this.txtIter.Location = new System.Drawing.Point(178, 152);
            this.txtIter.Name = "txtIter";
            this.txtIter.Size = new System.Drawing.Size(100, 20);
            this.txtIter.TabIndex = 8;
            // 
            // txtMargenError
            // 
            this.txtMargenError.Location = new System.Drawing.Point(178, 189);
            this.txtMargenError.Name = "txtMargenError";
            this.txtMargenError.Size = new System.Drawing.Size(100, 20);
            this.txtMargenError.TabIndex = 9;
            // 
            // lblSintaxis
            // 
            this.lblSintaxis.AutoSize = true;
            this.lblSintaxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintaxis.ForeColor = System.Drawing.Color.Red;
            this.lblSintaxis.Location = new System.Drawing.Point(3, 3);
            this.lblSintaxis.Name = "lblSintaxis";
            this.lblSintaxis.Size = new System.Drawing.Size(342, 16);
            this.lblSintaxis.TabIndex = 10;
            this.lblSintaxis.Text = "Error de sintaxix, vuelva a escribir la función F(x)";
            // 
            // btnBiseccion
            // 
            this.btnBiseccion.Location = new System.Drawing.Point(30, 248);
            this.btnBiseccion.Name = "btnBiseccion";
            this.btnBiseccion.Size = new System.Drawing.Size(75, 23);
            this.btnBiseccion.TabIndex = 11;
            this.btnBiseccion.Text = "Bisección";
            this.btnBiseccion.UseVisualStyleBackColor = true;
            this.btnBiseccion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReglaFalsa
            // 
            this.btnReglaFalsa.Location = new System.Drawing.Point(153, 248);
            this.btnReglaFalsa.Name = "btnReglaFalsa";
            this.btnReglaFalsa.Size = new System.Drawing.Size(75, 23);
            this.btnReglaFalsa.TabIndex = 12;
            this.btnReglaFalsa.Text = "Regla falsa";
            this.btnReglaFalsa.UseVisualStyleBackColor = true;
            this.btnReglaFalsa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNewton
            // 
            this.btnNewton.Location = new System.Drawing.Point(270, 248);
            this.btnNewton.Name = "btnNewton";
            this.btnNewton.Size = new System.Drawing.Size(75, 23);
            this.btnNewton.TabIndex = 13;
            this.btnNewton.Text = "Newton-R";
            this.btnNewton.UseVisualStyleBackColor = true;
            this.btnNewton.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSecante
            // 
            this.btnSecante.Location = new System.Drawing.Point(383, 248);
            this.btnSecante.Name = "btnSecante";
            this.btnSecante.Size = new System.Drawing.Size(75, 23);
            this.btnSecante.TabIndex = 14;
            this.btnSecante.Text = "Secante";
            this.btnSecante.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Converge:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Raíz:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Número de iteraciones:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Información adicional:";
            // 
            // lblConverge
            // 
            this.lblConverge.AutoSize = true;
            this.lblConverge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConverge.Location = new System.Drawing.Point(101, 291);
            this.lblConverge.Name = "lblConverge";
            this.lblConverge.Size = new System.Drawing.Size(12, 16);
            this.lblConverge.TabIndex = 19;
            this.lblConverge.Text = "-";
            // 
            // lblRaiz
            // 
            this.lblRaiz.AutoSize = true;
            this.lblRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaiz.Location = new System.Drawing.Point(67, 316);
            this.lblRaiz.Name = "lblRaiz";
            this.lblRaiz.Size = new System.Drawing.Size(12, 16);
            this.lblRaiz.TabIndex = 20;
            this.lblRaiz.Text = "-";
            // 
            // lblIter
            // 
            this.lblIter.AutoSize = true;
            this.lblIter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIter.Location = new System.Drawing.Point(193, 343);
            this.lblIter.Name = "lblIter";
            this.lblIter.Size = new System.Drawing.Size(12, 16);
            this.lblIter.TabIndex = 21;
            this.lblIter.Text = "-";
            // 
            // lblnfo
            // 
            this.lblnfo.AutoSize = true;
            this.lblnfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnfo.Location = new System.Drawing.Point(184, 370);
            this.lblnfo.Name = "lblnfo";
            this.lblnfo.Size = new System.Drawing.Size(12, 16);
            this.lblnfo.TabIndex = 22;
            this.lblnfo.Text = "-";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(358, 392);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Volver al menú";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBoxCerrado
            // 
            this.checkBoxCerrado.AutoSize = true;
            this.checkBoxCerrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCerrado.Location = new System.Drawing.Point(76, 225);
            this.checkBoxCerrado.Name = "checkBoxCerrado";
            this.checkBoxCerrado.Size = new System.Drawing.Size(127, 17);
            this.checkBoxCerrado.TabIndex = 24;
            this.checkBoxCerrado.Text = "Metodos cerrados";
            this.checkBoxCerrado.UseVisualStyleBackColor = true;
            this.checkBoxCerrado.CheckedChanged += new System.EventHandler(this.checkBoxCerrado_CheckedChanged);
            // 
            // checkBoxAbierto
            // 
            this.checkBoxAbierto.AutoSize = true;
            this.checkBoxAbierto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAbierto.Location = new System.Drawing.Point(303, 224);
            this.checkBoxAbierto.Name = "checkBoxAbierto";
            this.checkBoxAbierto.Size = new System.Drawing.Size(123, 17);
            this.checkBoxAbierto.TabIndex = 25;
            this.checkBoxAbierto.Text = "Metodos abiertos";
            this.checkBoxAbierto.UseVisualStyleBackColor = true;
            this.checkBoxAbierto.CheckedChanged += new System.EventHandler(this.checkBoxAbierto_CheckedChanged);
            // 
            // Unidad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 427);
            this.Controls.Add(this.checkBoxAbierto);
            this.Controls.Add(this.checkBoxCerrado);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblnfo);
            this.Controls.Add(this.lblIter);
            this.Controls.Add(this.lblRaiz);
            this.Controls.Add(this.lblConverge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSecante);
            this.Controls.Add(this.btnNewton);
            this.Controls.Add(this.btnReglaFalsa);
            this.Controls.Add(this.btnBiseccion);
            this.Controls.Add(this.lblSintaxis);
            this.Controls.Add(this.txtMargenError);
            this.Controls.Add(this.txtIter);
            this.Controls.Add(this.txtXdXini);
            this.Controls.Add(this.txtXiFx);
            this.Controls.Add(this.txtFx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblEdit2);
            this.Controls.Add(this.lblEdit1);
            this.Controls.Add(this.label1);
            this.Name = "Unidad1";
            this.Text = "Unidad1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEdit1;
        private System.Windows.Forms.Label lblEdit2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.TextBox txtXiFx;
        private System.Windows.Forms.TextBox txtXdXini;
        private System.Windows.Forms.TextBox txtIter;
        private System.Windows.Forms.TextBox txtMargenError;
        private System.Windows.Forms.Label lblSintaxis;
        private System.Windows.Forms.Button btnBiseccion;
        private System.Windows.Forms.Button btnReglaFalsa;
        private System.Windows.Forms.Button btnNewton;
        private System.Windows.Forms.Button btnSecante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblConverge;
        private System.Windows.Forms.Label lblRaiz;
        private System.Windows.Forms.Label lblIter;
        private System.Windows.Forms.Label lblnfo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBoxCerrado;
        private System.Windows.Forms.CheckBox checkBoxAbierto;
    }
}