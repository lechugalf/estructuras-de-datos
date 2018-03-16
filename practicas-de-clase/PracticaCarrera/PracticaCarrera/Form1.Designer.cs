namespace PracticaCarrera
{
    partial class Carrera
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
            this.txtBx_jug1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_jug2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_carrera = new System.Windows.Forms.TextBox();
            this.btn_jugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBx_jug1
            // 
            this.txtBx_jug1.Location = new System.Drawing.Point(64, 60);
            this.txtBx_jug1.Name = "txtBx_jug1";
            this.txtBx_jug1.Size = new System.Drawing.Size(103, 27);
            this.txtBx_jug1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "#1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "#2";
            // 
            // txtBx_jug2
            // 
            this.txtBx_jug2.Location = new System.Drawing.Point(231, 60);
            this.txtBx_jug2.Name = "txtBx_jug2";
            this.txtBx_jug2.Size = new System.Drawing.Size(103, 27);
            this.txtBx_jug2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres";
            // 
            // txtBx_carrera
            // 
            this.txtBx_carrera.Location = new System.Drawing.Point(36, 168);
            this.txtBx_carrera.Multiline = true;
            this.txtBx_carrera.Name = "txtBx_carrera";
            this.txtBx_carrera.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBx_carrera.Size = new System.Drawing.Size(298, 392);
            this.txtBx_carrera.TabIndex = 5;
            // 
            // btn_jugar
            // 
            this.btn_jugar.Location = new System.Drawing.Point(95, 114);
            this.btn_jugar.Name = "btn_jugar";
            this.btn_jugar.Size = new System.Drawing.Size(186, 30);
            this.btn_jugar.TabIndex = 6;
            this.btn_jugar.Text = "¡Jugar!";
            this.btn_jugar.UseVisualStyleBackColor = true;
            this.btn_jugar.Click += new System.EventHandler(this.btn_jugar_Click);
            // 
            // Carrera
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(378, 590);
            this.Controls.Add(this.btn_jugar);
            this.Controls.Add(this.txtBx_carrera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBx_jug2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_jug1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Carrera";
            this.Text = "Carrera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_jug1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBx_jug2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_carrera;
        private System.Windows.Forms.Button btn_jugar;
    }
}

