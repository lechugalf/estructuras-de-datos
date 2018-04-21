namespace Agenda2
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
            this.txtBx_salida = new System.Windows.Forms.TextBox();
            this.txtBx_tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBx_ema = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBx_pos = new System.Windows.Forms.TextBox();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txtBx_eda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_apm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBx_app = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBx_salida
            // 
            this.txtBx_salida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_salida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(36)))), ((int)(((byte)(86)))));
            this.txtBx_salida.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBx_salida.ForeColor = System.Drawing.Color.White;
            this.txtBx_salida.Location = new System.Drawing.Point(26, 158);
            this.txtBx_salida.Multiline = true;
            this.txtBx_salida.Name = "txtBx_salida";
            this.txtBx_salida.Size = new System.Drawing.Size(734, 318);
            this.txtBx_salida.TabIndex = 48;
            // 
            // txtBx_tel
            // 
            this.txtBx_tel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_tel.Location = new System.Drawing.Point(533, 71);
            this.txtBx_tel.MaxLength = 10;
            this.txtBx_tel.Name = "txtBx_tel";
            this.txtBx_tel.Size = new System.Drawing.Size(130, 20);
            this.txtBx_tel.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Telefono";
            // 
            // txtBx_ema
            // 
            this.txtBx_ema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_ema.Location = new System.Drawing.Point(533, 45);
            this.txtBx_ema.MaxLength = 25;
            this.txtBx_ema.Name = "txtBx_ema";
            this.txtBx_ema.Size = new System.Drawing.Size(130, 20);
            this.txtBx_ema.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Posición";
            // 
            // txtBx_pos
            // 
            this.txtBx_pos.Location = new System.Drawing.Point(40, 29);
            this.txtBx_pos.Name = "txtBx_pos";
            this.txtBx_pos.Size = new System.Drawing.Size(49, 20);
            this.txtBx_pos.TabIndex = 49;
            this.txtBx_pos.Text = "0";
            // 
            // btn_listar
            // 
            this.btn_listar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_listar.Location = new System.Drawing.Point(515, 117);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(98, 23);
            this.btn_listar.TabIndex = 47;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.Location = new System.Drawing.Point(411, 117);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(98, 23);
            this.btn_eliminar.TabIndex = 45;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.Location = new System.Drawing.Point(307, 117);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(98, 23);
            this.btn_buscar.TabIndex = 44;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.Location = new System.Drawing.Point(203, 117);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(98, 23);
            this.btn_agregar.TabIndex = 43;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txtBx_eda
            // 
            this.txtBx_eda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_eda.Location = new System.Drawing.Point(533, 19);
            this.txtBx_eda.MaxLength = 3;
            this.txtBx_eda.Name = "txtBx_eda";
            this.txtBx_eda.Size = new System.Drawing.Size(130, 20);
            this.txtBx_eda.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Edad";
            // 
            // txtBx_apm
            // 
            this.txtBx_apm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_apm.Location = new System.Drawing.Point(323, 71);
            this.txtBx_apm.MaxLength = 15;
            this.txtBx_apm.Name = "txtBx_apm";
            this.txtBx_apm.Size = new System.Drawing.Size(130, 20);
            this.txtBx_apm.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Apellido Materno";
            // 
            // txtBx_app
            // 
            this.txtBx_app.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_app.Location = new System.Drawing.Point(323, 45);
            this.txtBx_app.MaxLength = 15;
            this.txtBx_app.Name = "txtBx_app";
            this.txtBx_app.Size = new System.Drawing.Size(130, 20);
            this.txtBx_app.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Apellido Paterno";
            // 
            // txtBx_nom
            // 
            this.txtBx_nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBx_nom.Location = new System.Drawing.Point(323, 19);
            this.txtBx_nom.MaxLength = 25;
            this.txtBx_nom.Name = "txtBx_nom";
            this.txtBx_nom.Size = new System.Drawing.Size(130, 20);
            this.txtBx_nom.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 498);
            this.Controls.Add(this.txtBx_salida);
            this.Controls.Add(this.txtBx_tel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBx_ema);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBx_pos);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txtBx_eda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBx_apm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBx_app);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBx_nom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Agenda Ordenada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_salida;
        private System.Windows.Forms.TextBox txtBx_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBx_ema;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBx_pos;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txtBx_eda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_apm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBx_app;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_nom;
        private System.Windows.Forms.Label label1;
    }
}

