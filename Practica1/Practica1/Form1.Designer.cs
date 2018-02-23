namespace Data
{
    partial class Form_Practica1
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
            this.Lbl_Date = new System.Windows.Forms.Label();
            this.Lbl_ReadDate = new System.Windows.Forms.Label();
            this.GrpBx_Direction = new System.Windows.Forms.GroupBox();
            this.PicBx_Direction = new System.Windows.Forms.PictureBox();
            this.GrpBx_Level = new System.Windows.Forms.GroupBox();
            this.PrBar_Level = new System.Windows.Forms.ProgressBar();
            this.GrpBx_Sensors = new System.Windows.Forms.GroupBox();
            this.PicBx_Sensor2 = new System.Windows.Forms.PictureBox();
            this.PicBx_Sensor1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Procces = new System.Windows.Forms.Label();
            this.TxtBx_Procces = new System.Windows.Forms.TextBox();
            this.Btn_Procces = new System.Windows.Forms.Button();
            this.GrpBx_Date = new System.Windows.Forms.GroupBox();
            this.Btn_SetDate = new System.Windows.Forms.Button();
            this.Dtp_SetDate = new System.Windows.Forms.DateTimePicker();
            this.Lbl_SetDate = new System.Windows.Forms.Label();
            this.TxtBx_SetDate = new System.Windows.Forms.TextBox();
            this.GrpBx_Direction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Direction)).BeginInit();
            this.GrpBx_Level.SuspendLayout();
            this.GrpBx_Sensors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Sensor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Sensor1)).BeginInit();
            this.GrpBx_Date.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Date
            // 
            this.Lbl_Date.AutoSize = true;
            this.Lbl_Date.Location = new System.Drawing.Point(317, 189);
            this.Lbl_Date.Name = "Lbl_Date";
            this.Lbl_Date.Size = new System.Drawing.Size(107, 20);
            this.Lbl_Date.TabIndex = 14;
            this.Lbl_Date.Text = "YYYY/MM/DD";
            // 
            // Lbl_ReadDate
            // 
            this.Lbl_ReadDate.AutoSize = true;
            this.Lbl_ReadDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ReadDate.Location = new System.Drawing.Point(190, 189);
            this.Lbl_ReadDate.Name = "Lbl_ReadDate";
            this.Lbl_ReadDate.Size = new System.Drawing.Size(117, 20);
            this.Lbl_ReadDate.TabIndex = 13;
            this.Lbl_ReadDate.Text = "Fecha de lectura";
            // 
            // GrpBx_Direction
            // 
            this.GrpBx_Direction.Controls.Add(this.PicBx_Direction);
            this.GrpBx_Direction.Location = new System.Drawing.Point(430, 74);
            this.GrpBx_Direction.Name = "GrpBx_Direction";
            this.GrpBx_Direction.Size = new System.Drawing.Size(200, 100);
            this.GrpBx_Direction.TabIndex = 11;
            this.GrpBx_Direction.TabStop = false;
            this.GrpBx_Direction.Text = "Dirección";
            // 
            // PicBx_Direction
            // 
            this.PicBx_Direction.BackColor = System.Drawing.Color.LightGray;
            this.PicBx_Direction.Location = new System.Drawing.Point(73, 26);
            this.PicBx_Direction.Name = "PicBx_Direction";
            this.PicBx_Direction.Size = new System.Drawing.Size(64, 58);
            this.PicBx_Direction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBx_Direction.TabIndex = 1;
            this.PicBx_Direction.TabStop = false;
            // 
            // GrpBx_Level
            // 
            this.GrpBx_Level.Controls.Add(this.PrBar_Level);
            this.GrpBx_Level.Location = new System.Drawing.Point(224, 74);
            this.GrpBx_Level.Name = "GrpBx_Level";
            this.GrpBx_Level.Size = new System.Drawing.Size(200, 100);
            this.GrpBx_Level.TabIndex = 12;
            this.GrpBx_Level.TabStop = false;
            this.GrpBx_Level.Text = "Nivel";
            // 
            // PrBar_Level
            // 
            this.PrBar_Level.Location = new System.Drawing.Point(18, 36);
            this.PrBar_Level.MarqueeAnimationSpeed = 35;
            this.PrBar_Level.Name = "PrBar_Level";
            this.PrBar_Level.Size = new System.Drawing.Size(163, 39);
            this.PrBar_Level.TabIndex = 0;
            // 
            // GrpBx_Sensors
            // 
            this.GrpBx_Sensors.Controls.Add(this.PicBx_Sensor2);
            this.GrpBx_Sensors.Controls.Add(this.PicBx_Sensor1);
            this.GrpBx_Sensors.Location = new System.Drawing.Point(18, 74);
            this.GrpBx_Sensors.Name = "GrpBx_Sensors";
            this.GrpBx_Sensors.Size = new System.Drawing.Size(200, 100);
            this.GrpBx_Sensors.TabIndex = 10;
            this.GrpBx_Sensors.TabStop = false;
            this.GrpBx_Sensors.Text = "Sensores";
            // 
            // PicBx_Sensor2
            // 
            this.PicBx_Sensor2.BackColor = System.Drawing.Color.LightGray;
            this.PicBx_Sensor2.Location = new System.Drawing.Point(108, 26);
            this.PicBx_Sensor2.Name = "PicBx_Sensor2";
            this.PicBx_Sensor2.Size = new System.Drawing.Size(58, 58);
            this.PicBx_Sensor2.TabIndex = 1;
            this.PicBx_Sensor2.TabStop = false;
            // 
            // PicBx_Sensor1
            // 
            this.PicBx_Sensor1.BackColor = System.Drawing.Color.LightGray;
            this.PicBx_Sensor1.Location = new System.Drawing.Point(34, 26);
            this.PicBx_Sensor1.Name = "PicBx_Sensor1";
            this.PicBx_Sensor1.Size = new System.Drawing.Size(58, 58);
            this.PicBx_Sensor1.TabIndex = 0;
            this.PicBx_Sensor1.TabStop = false;
            // 
            // Lbl_Procces
            // 
            this.Lbl_Procces.AutoSize = true;
            this.Lbl_Procces.Location = new System.Drawing.Point(32, 27);
            this.Lbl_Procces.Name = "Lbl_Procces";
            this.Lbl_Procces.Size = new System.Drawing.Size(62, 20);
            this.Lbl_Procces.TabIndex = 9;
            this.Lbl_Procces.Text = "Entrada";
            // 
            // TxtBx_Procces
            // 
            this.TxtBx_Procces.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Procces.Location = new System.Drawing.Point(111, 24);
            this.TxtBx_Procces.Name = "TxtBx_Procces";
            this.TxtBx_Procces.Size = new System.Drawing.Size(192, 27);
            this.TxtBx_Procces.TabIndex = 8;
            // 
            // Btn_Procces
            // 
            this.Btn_Procces.Location = new System.Drawing.Point(319, 24);
            this.Btn_Procces.Name = "Btn_Procces";
            this.Btn_Procces.Size = new System.Drawing.Size(105, 27);
            this.Btn_Procces.TabIndex = 7;
            this.Btn_Procces.Text = "Procesar";
            this.Btn_Procces.UseVisualStyleBackColor = true;
            this.Btn_Procces.Click += new System.EventHandler(this.Btn_Procces_Click);
            // 
            // GrpBx_Date
            // 
            this.GrpBx_Date.Controls.Add(this.TxtBx_SetDate);
            this.GrpBx_Date.Controls.Add(this.Btn_SetDate);
            this.GrpBx_Date.Controls.Add(this.Dtp_SetDate);
            this.GrpBx_Date.Controls.Add(this.Lbl_SetDate);
            this.GrpBx_Date.Location = new System.Drawing.Point(18, 213);
            this.GrpBx_Date.Name = "GrpBx_Date";
            this.GrpBx_Date.Size = new System.Drawing.Size(612, 86);
            this.GrpBx_Date.TabIndex = 15;
            this.GrpBx_Date.TabStop = false;
            // 
            // Btn_SetDate
            // 
            this.Btn_SetDate.Location = new System.Drawing.Point(285, 34);
            this.Btn_SetDate.Name = "Btn_SetDate";
            this.Btn_SetDate.Size = new System.Drawing.Size(105, 27);
            this.Btn_SetDate.TabIndex = 12;
            this.Btn_SetDate.Text = "Ajustar";
            this.Btn_SetDate.UseVisualStyleBackColor = true;
            this.Btn_SetDate.Click += new System.EventHandler(this.Btn_SetDate_Click);
            // 
            // Dtp_SetDate
            // 
            this.Dtp_SetDate.CustomFormat = "";
            this.Dtp_SetDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_SetDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_SetDate.Location = new System.Drawing.Point(116, 34);
            this.Dtp_SetDate.MaxDate = new System.DateTime(2027, 12, 31, 0, 0, 0, 0);
            this.Dtp_SetDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.Dtp_SetDate.Name = "Dtp_SetDate";
            this.Dtp_SetDate.Size = new System.Drawing.Size(150, 27);
            this.Dtp_SetDate.TabIndex = 11;
            // 
            // Lbl_SetDate
            // 
            this.Lbl_SetDate.AutoSize = true;
            this.Lbl_SetDate.Location = new System.Drawing.Point(41, 38);
            this.Lbl_SetDate.Name = "Lbl_SetDate";
            this.Lbl_SetDate.Size = new System.Drawing.Size(62, 20);
            this.Lbl_SetDate.TabIndex = 10;
            this.Lbl_SetDate.Text = "Entrada";
            // 
            // TxtBx_SetDate
            // 
            this.TxtBx_SetDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_SetDate.Location = new System.Drawing.Point(408, 34);
            this.TxtBx_SetDate.Name = "TxtBx_SetDate";
            this.TxtBx_SetDate.Size = new System.Drawing.Size(147, 27);
            this.TxtBx_SetDate.TabIndex = 13;
            // 
            // Form_Practica1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(647, 345);
            this.Controls.Add(this.GrpBx_Date);
            this.Controls.Add(this.Lbl_Date);
            this.Controls.Add(this.Lbl_ReadDate);
            this.Controls.Add(this.GrpBx_Direction);
            this.Controls.Add(this.GrpBx_Level);
            this.Controls.Add(this.GrpBx_Sensors);
            this.Controls.Add(this.Lbl_Procces);
            this.Controls.Add(this.TxtBx_Procces);
            this.Controls.Add(this.Btn_Procces);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Practica1";
            this.Text = "Práctica Bits y Bytes";
            this.GrpBx_Direction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Direction)).EndInit();
            this.GrpBx_Level.ResumeLayout(false);
            this.GrpBx_Sensors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Sensor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBx_Sensor1)).EndInit();
            this.GrpBx_Date.ResumeLayout(false);
            this.GrpBx_Date.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Date;
        private System.Windows.Forms.Label Lbl_ReadDate;
        private System.Windows.Forms.GroupBox GrpBx_Direction;
        private System.Windows.Forms.GroupBox GrpBx_Level;
        private System.Windows.Forms.ProgressBar PrBar_Level;
        private System.Windows.Forms.GroupBox GrpBx_Sensors;
        private System.Windows.Forms.PictureBox PicBx_Sensor2;
        private System.Windows.Forms.PictureBox PicBx_Sensor1;
        private System.Windows.Forms.Label Lbl_Procces;
        private System.Windows.Forms.TextBox TxtBx_Procces;
        private System.Windows.Forms.Button Btn_Procces;
        private System.Windows.Forms.GroupBox GrpBx_Date;
        private System.Windows.Forms.Button Btn_SetDate;
        private System.Windows.Forms.DateTimePicker Dtp_SetDate;
        private System.Windows.Forms.Label Lbl_SetDate;
        private System.Windows.Forms.PictureBox PicBx_Direction;
        private System.Windows.Forms.TextBox TxtBx_SetDate;
    }
}

