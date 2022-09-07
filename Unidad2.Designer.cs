namespace TP1_AnalisisNumerico2021
{
    partial class Unidad2
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMetodo = new System.Windows.Forms.ComboBox();
            this.dimensionX = new System.Windows.Forms.Label();
            this.btnAumentar = new System.Windows.Forms.Button();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dimensionY = new System.Windows.Forms.Label();
            this.Matriz = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "GAUSS-JORDAN Y GAUSS-SEIDEL:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(648, 509);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(124, 40);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtMetodo
            // 
            this.txtMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMetodo.FormattingEnabled = true;
            this.txtMetodo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtMetodo.Items.AddRange(new object[] {
            "Gauss-Seidel",
            "Gauss-Jordan"});
            this.txtMetodo.Location = new System.Drawing.Point(12, 509);
            this.txtMetodo.Name = "txtMetodo";
            this.txtMetodo.Size = new System.Drawing.Size(121, 21);
            this.txtMetodo.TabIndex = 3;
            // 
            // dimensionX
            // 
            this.dimensionX.AutoSize = true;
            this.dimensionX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionX.Location = new System.Drawing.Point(154, 512);
            this.dimensionX.Name = "dimensionX";
            this.dimensionX.Size = new System.Drawing.Size(15, 20);
            this.dimensionX.TabIndex = 4;
            this.dimensionX.Text = "-";
            // 
            // btnAumentar
            // 
            this.btnAumentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAumentar.Location = new System.Drawing.Point(243, 507);
            this.btnAumentar.Name = "btnAumentar";
            this.btnAumentar.Size = new System.Drawing.Size(28, 29);
            this.btnAumentar.TabIndex = 7;
            this.btnAumentar.Text = "+";
            this.btnAumentar.UseVisualStyleBackColor = true;
            this.btnAumentar.Click += new System.EventHandler(this.btnAumentar_Click);
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuir.Location = new System.Drawing.Point(277, 507);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(28, 29);
            this.btnDisminuir.TabIndex = 8;
            this.btnDisminuir.Text = "-";
            this.btnDisminuir.UseVisualStyleBackColor = true;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            // 
            // dimensionY
            // 
            this.dimensionY.AutoSize = true;
            this.dimensionY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimensionY.Location = new System.Drawing.Point(208, 512);
            this.dimensionY.Name = "dimensionY";
            this.dimensionY.Size = new System.Drawing.Size(15, 20);
            this.dimensionY.TabIndex = 10;
            this.dimensionY.Text = "-";
            // 
            // Matriz
            // 
            this.Matriz.Location = new System.Drawing.Point(13, 44);
            this.Matriz.Name = "Matriz";
            this.Matriz.Size = new System.Drawing.Size(759, 457);
            this.Matriz.TabIndex = 11;
            // 
            // Unidad2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Matriz);
            this.Controls.Add(this.dimensionY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDisminuir);
            this.Controls.Add(this.btnAumentar);
            this.Controls.Add(this.dimensionX);
            this.Controls.Add(this.txtMetodo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Name = "Unidad2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidad2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox txtMetodo;
        private System.Windows.Forms.Label dimensionX;
        private System.Windows.Forms.Button btnAumentar;
        private System.Windows.Forms.Button btnDisminuir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dimensionY;
        private System.Windows.Forms.Panel Matriz;
    }
}