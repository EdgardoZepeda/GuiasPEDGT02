namespace Calculadora
{
    partial class Ejemplo1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejemplo1));
            this.btnexit = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.BtnMS = new System.Windows.Forms.Button();
            this.btnMmas = new System.Windows.Forms.Button();
            this.btnMmenos = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnretroceso = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnmenos1 = new System.Windows.Forms.Button();
            this.btnsin = new System.Windows.Forms.Button();
            this.btnsinh = new System.Windows.Forms.Button();
            this.btnporcentaje = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btncuadrado = new System.Windows.Forms.Button();
            this.btncos = new System.Windows.Forms.Button();
            this.btncosh = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btncubo = new System.Windows.Forms.Button();
            this.btntan = new System.Windows.Forms.Button();
            this.btntanh = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btnmas = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn10x = new System.Windows.Forms.Button();
            this.btnlog = new System.Windows.Forms.Button();
            this.btnexp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(510, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(53, 51);
            this.btnexit.TabIndex = 0;
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtresultado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(57, 111);
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(429, 42);
            this.txtresultado.TabIndex = 1;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtresultado.TextChanged += new System.EventHandler(this.limpiar_pantalla_TextChanged);
            // 
            // btnMC
            // 
            this.btnMC.Location = new System.Drawing.Point(57, 172);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(48, 36);
            this.btnMC.TabIndex = 2;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.Location = new System.Drawing.Point(111, 172);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(48, 36);
            this.btnMR.TabIndex = 3;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // BtnMS
            // 
            this.BtnMS.Location = new System.Drawing.Point(165, 172);
            this.BtnMS.Name = "BtnMS";
            this.BtnMS.Size = new System.Drawing.Size(48, 36);
            this.BtnMS.TabIndex = 4;
            this.BtnMS.Text = "MS";
            this.BtnMS.UseVisualStyleBackColor = true;
            this.BtnMS.Click += new System.EventHandler(this.BtnMS_Click);
            // 
            // btnMmas
            // 
            this.btnMmas.Location = new System.Drawing.Point(219, 172);
            this.btnMmas.Name = "btnMmas";
            this.btnMmas.Size = new System.Drawing.Size(48, 36);
            this.btnMmas.TabIndex = 5;
            this.btnMmas.Text = "M+";
            this.btnMmas.UseVisualStyleBackColor = true;
            this.btnMmas.Click += new System.EventHandler(this.btnMmas_Click);
            // 
            // btnMmenos
            // 
            this.btnMmenos.Location = new System.Drawing.Point(276, 172);
            this.btnMmenos.Name = "btnMmenos";
            this.btnMmenos.Size = new System.Drawing.Size(48, 36);
            this.btnMmenos.TabIndex = 6;
            this.btnMmenos.Text = "M-";
            this.btnMmenos.UseVisualStyleBackColor = true;
            this.btnMmenos.Click += new System.EventHandler(this.btnMmenos_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(384, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(48, 36);
            this.button6.TabIndex = 7;
            this.button6.Text = "C";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(330, 172);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(48, 36);
            this.btnCE.TabIndex = 8;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnretroceso
            // 
            this.btnretroceso.Location = new System.Drawing.Point(438, 172);
            this.btnretroceso.Name = "btnretroceso";
            this.btnretroceso.Size = new System.Drawing.Size(48, 36);
            this.btnretroceso.TabIndex = 9;
            this.btnretroceso.Text = "←";
            this.btnretroceso.UseVisualStyleBackColor = true;
            this.btnretroceso.Click += new System.EventHandler(this.btnretroceso_Click);
            // 
            // btnraiz
            // 
            this.btnraiz.Location = new System.Drawing.Point(438, 214);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(48, 36);
            this.btnraiz.TabIndex = 17;
            this.btnraiz.Text = "√ ";
            this.btnraiz.UseVisualStyleBackColor = true;
            this.btnraiz.Click += new System.EventHandler(this.btnraiz_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(330, 214);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 36);
            this.btn9.TabIndex = 16;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(384, 214);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(48, 36);
            this.btndividir.TabIndex = 15;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(276, 214);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 36);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(219, 214);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 36);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnmenos1
            // 
            this.btnmenos1.Location = new System.Drawing.Point(165, 214);
            this.btnmenos1.Name = "btnmenos1";
            this.btnmenos1.Size = new System.Drawing.Size(48, 36);
            this.btnmenos1.TabIndex = 12;
            this.btnmenos1.Text = "x^-1";
            this.btnmenos1.UseVisualStyleBackColor = true;
            this.btnmenos1.Click += new System.EventHandler(this.btnmenos1_Click);
            // 
            // btnsin
            // 
            this.btnsin.Location = new System.Drawing.Point(111, 214);
            this.btnsin.Name = "btnsin";
            this.btnsin.Size = new System.Drawing.Size(48, 36);
            this.btnsin.TabIndex = 11;
            this.btnsin.Text = "Sin";
            this.btnsin.UseVisualStyleBackColor = true;
            this.btnsin.Click += new System.EventHandler(this.btnsin_Click);
            // 
            // btnsinh
            // 
            this.btnsinh.Location = new System.Drawing.Point(57, 214);
            this.btnsinh.Name = "btnsinh";
            this.btnsinh.Size = new System.Drawing.Size(48, 36);
            this.btnsinh.TabIndex = 10;
            this.btnsinh.Text = "Sinh";
            this.btnsinh.UseVisualStyleBackColor = true;
            this.btnsinh.Click += new System.EventHandler(this.btnsinh_Click);
            // 
            // btnporcentaje
            // 
            this.btnporcentaje.Location = new System.Drawing.Point(438, 256);
            this.btnporcentaje.Name = "btnporcentaje";
            this.btnporcentaje.Size = new System.Drawing.Size(48, 36);
            this.btnporcentaje.TabIndex = 25;
            this.btnporcentaje.Text = "%";
            this.btnporcentaje.UseVisualStyleBackColor = true;
            this.btnporcentaje.Click += new System.EventHandler(this.btnporcentaje_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(330, 256);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 36);
            this.btn6.TabIndex = 24;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Location = new System.Drawing.Point(384, 256);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(48, 36);
            this.btnmultiplicar.TabIndex = 23;
            this.btnmultiplicar.Text = "*";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(276, 256);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 36);
            this.btn5.TabIndex = 22;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(219, 256);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 36);
            this.btn4.TabIndex = 21;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btncuadrado
            // 
            this.btncuadrado.Location = new System.Drawing.Point(165, 256);
            this.btncuadrado.Name = "btncuadrado";
            this.btncuadrado.Size = new System.Drawing.Size(48, 36);
            this.btncuadrado.TabIndex = 20;
            this.btncuadrado.Text = "x^2";
            this.btncuadrado.UseVisualStyleBackColor = true;
            this.btncuadrado.Click += new System.EventHandler(this.btncuadrado_Click);
            // 
            // btncos
            // 
            this.btncos.Location = new System.Drawing.Point(111, 256);
            this.btncos.Name = "btncos";
            this.btncos.Size = new System.Drawing.Size(48, 36);
            this.btncos.TabIndex = 19;
            this.btncos.Text = "Cos";
            this.btncos.UseVisualStyleBackColor = true;
            this.btncos.Click += new System.EventHandler(this.btncos_Click);
            // 
            // btncosh
            // 
            this.btncosh.Location = new System.Drawing.Point(57, 256);
            this.btncosh.Name = "btncosh";
            this.btncosh.Size = new System.Drawing.Size(48, 36);
            this.btncosh.TabIndex = 18;
            this.btncosh.Text = "Cosh";
            this.btncosh.UseVisualStyleBackColor = true;
            this.btncosh.Click += new System.EventHandler(this.btncosh_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(438, 298);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(48, 78);
            this.btnIgual.TabIndex = 33;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(330, 298);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 36);
            this.btn3.TabIndex = 32;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Location = new System.Drawing.Point(384, 298);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(48, 36);
            this.btnmenos.TabIndex = 31;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(276, 298);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 36);
            this.btn2.TabIndex = 30;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(219, 298);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 36);
            this.btn1.TabIndex = 29;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btncubo
            // 
            this.btncubo.Location = new System.Drawing.Point(165, 298);
            this.btncubo.Name = "btncubo";
            this.btncubo.Size = new System.Drawing.Size(48, 36);
            this.btncubo.TabIndex = 28;
            this.btncubo.Text = "x^3";
            this.btncubo.UseVisualStyleBackColor = true;
            this.btncubo.Click += new System.EventHandler(this.btncubo_Click);
            // 
            // btntan
            // 
            this.btntan.Location = new System.Drawing.Point(111, 298);
            this.btntan.Name = "btntan";
            this.btntan.Size = new System.Drawing.Size(48, 36);
            this.btntan.TabIndex = 27;
            this.btntan.Text = "Tan";
            this.btntan.UseVisualStyleBackColor = true;
            this.btntan.Click += new System.EventHandler(this.btntan_Click);
            // 
            // btntanh
            // 
            this.btntanh.Location = new System.Drawing.Point(57, 298);
            this.btntanh.Name = "btntanh";
            this.btntanh.Size = new System.Drawing.Size(48, 36);
            this.btntanh.TabIndex = 26;
            this.btntanh.Text = "Tanh";
            this.btntanh.UseVisualStyleBackColor = true;
            this.btntanh.Click += new System.EventHandler(this.btntanh_Click);
            // 
            // btnpunto
            // 
            this.btnpunto.Location = new System.Drawing.Point(330, 340);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(48, 36);
            this.btnpunto.TabIndex = 40;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(384, 340);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(48, 36);
            this.btnmas.TabIndex = 39;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            this.btnmas.Click += new System.EventHandler(this.btnmas_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(219, 340);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(105, 36);
            this.btn0.TabIndex = 37;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btn10x
            // 
            this.btn10x.Location = new System.Drawing.Point(165, 340);
            this.btn10x.Name = "btn10x";
            this.btn10x.Size = new System.Drawing.Size(48, 36);
            this.btn10x.TabIndex = 36;
            this.btn10x.Text = "ln";
            this.btn10x.UseVisualStyleBackColor = true;
            this.btn10x.Click += new System.EventHandler(this.btn10x_Click);
            // 
            // btnlog
            // 
            this.btnlog.Location = new System.Drawing.Point(111, 340);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(48, 36);
            this.btnlog.TabIndex = 35;
            this.btnlog.Text = "Log";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // btnexp
            // 
            this.btnexp.Location = new System.Drawing.Point(57, 340);
            this.btnexp.Name = "btnexp";
            this.btnexp.Size = new System.Drawing.Size(48, 36);
            this.btnexp.TabIndex = 34;
            this.btnexp.Text = "exp";
            this.btnexp.UseVisualStyleBackColor = true;
            this.btnexp.Click += new System.EventHandler(this.btnexp_Click);
            // 
            // Ejemplo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(566, 453);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn10x);
            this.Controls.Add(this.btnlog);
            this.Controls.Add(this.btnexp);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btncubo);
            this.Controls.Add(this.btntan);
            this.Controls.Add(this.btntanh);
            this.Controls.Add(this.btnporcentaje);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btncuadrado);
            this.Controls.Add(this.btncos);
            this.Controls.Add(this.btncosh);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnmenos1);
            this.Controls.Add(this.btnsin);
            this.Controls.Add(this.btnsinh);
            this.Controls.Add(this.btnretroceso);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnMmenos);
            this.Controls.Add(this.btnMmas);
            this.Controls.Add(this.BtnMS);
            this.Controls.Add(this.btnMR);
            this.Controls.Add(this.btnMC);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btnexit);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ejemplo1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Ejemplo1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button BtnMS;
        private System.Windows.Forms.Button btnMmas;
        private System.Windows.Forms.Button btnMmenos;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnretroceso;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnmenos1;
        private System.Windows.Forms.Button btnsin;
        private System.Windows.Forms.Button btnsinh;
        private System.Windows.Forms.Button btnporcentaje;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btncuadrado;
        private System.Windows.Forms.Button btncos;
        private System.Windows.Forms.Button btncosh;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btncubo;
        private System.Windows.Forms.Button btntan;
        private System.Windows.Forms.Button btntanh;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn10x;
        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.Button btnexp;
    }
}

