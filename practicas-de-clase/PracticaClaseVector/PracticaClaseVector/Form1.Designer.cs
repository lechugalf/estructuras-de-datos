namespace PracticaClaseVector
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_girara = new System.Windows.Forms.Button();
            this.btn_girard = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(22, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(214, 492);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "crear vector de n elementos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "rellenar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "rellenar random de 0 a x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(56, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 22);
            this.textBox3.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "suma";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 34);
            this.button5.TabIndex = 9;
            this.button5.Text = "Promedio";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 382);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 34);
            this.button6.TabIndex = 10;
            this.button6.Text = "mostrar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(21, 422);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 34);
            this.button7.TabIndex = 11;
            this.button7.Text = "mostrar inv";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(21, 474);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 34);
            this.button8.TabIndex = 12;
            this.button8.Text = "borrar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_girara
            // 
            this.btn_girara.Location = new System.Drawing.Point(21, 238);
            this.btn_girara.Name = "btn_girara";
            this.btn_girara.Size = new System.Drawing.Size(111, 34);
            this.btn_girara.TabIndex = 13;
            this.btn_girara.Text = "girarArriba";
            this.btn_girara.UseVisualStyleBackColor = true;
            this.btn_girara.Click += new System.EventHandler(this.btn_girara_Click);
            // 
            // btn_girard
            // 
            this.btn_girard.Location = new System.Drawing.Point(21, 278);
            this.btn_girard.Name = "btn_girard";
            this.btn_girard.Size = new System.Drawing.Size(111, 34);
            this.btn_girard.TabIndex = 14;
            this.btn_girard.Text = "Girar Abajo";
            this.btn_girard.UseVisualStyleBackColor = true;
            this.btn_girard.Click += new System.EventHandler(this.btn_girard_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(21, 318);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 34);
            this.button9.TabIndex = 15;
            this.button9.Text = "Invertir";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_girard);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.btn_girara);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(249, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 529);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(409, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Mi Vector";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btn_girara;
        private System.Windows.Forms.Button btn_girard;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel1;
    }
}

