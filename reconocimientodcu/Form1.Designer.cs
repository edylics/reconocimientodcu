
namespace reconocimientodcu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(38, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(76, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insertar Imagen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro De Estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "Colegio Santa Cruz.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(395, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero Unico:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(458, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefono:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(581, 176);
            this.txtNum.Multiline = true;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(265, 40);
            this.txtNum.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(581, 222);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(265, 40);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(581, 268);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(265, 40);
            this.txtCorreo.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(581, 314);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(265, 40);
            this.txtTelefono.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(519, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 55);
            this.button2.TabIndex = 12;
            this.button2.Text = "Capturar Estudiante";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(814, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 55);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cerrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(729, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 46);
            this.button4.TabIndex = 14;
            this.button4.Text = "Registro ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 583);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

