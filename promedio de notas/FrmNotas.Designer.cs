namespace promedio_de_notas
{
    partial class FrmNotas
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txtNota1 = new TextBox();
            txtNota4 = new TextBox();
            txtNota3 = new TextBox();
            txtNota2 = new TextBox();
            btnSalir = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtPromedio = new TextBox();
            txtCondicion = new TextBox();
            txtNotaBaja = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(461, 30);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE PROMEDIO DE NOTAS";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("SimSun", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(26, 127);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(407, 27);
            txtNombre.TabIndex = 1;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 94);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 2;
            label2.Text = "Estudiante:";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("SimSun", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(48, 171);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(118, 31);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("SimSun", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(210, 171);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(118, 31);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(532, 98);
            label3.Name = "label3";
            label3.Size = new Size(196, 20);
            label3.TabIndex = 5;
            label3.Text = "Registro de Notas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(533, 133);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 8;
            label6.Text = "Nota 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(653, 225);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 9;
            label4.Text = "Nota 4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(539, 224);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 10;
            label5.Text = "Nota 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(649, 135);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 11;
            label7.Text = "Nota 2";
            // 
            // txtNota1
            // 
            txtNota1.Font = new Font("SimSun", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNota1.Location = new Point(530, 175);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(82, 27);
            txtNota1.TabIndex = 12;
            txtNota1.KeyPress += txtNota1_KeyPress;
            // 
            // txtNota4
            // 
            txtNota4.Font = new Font("SimSun", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNota4.Location = new Point(648, 264);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(82, 27);
            txtNota4.TabIndex = 13;
            txtNota4.KeyPress += txtNota1_KeyPress;
            // 
            // txtNota3
            // 
            txtNota3.Font = new Font("SimSun", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNota3.Location = new Point(528, 264);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(82, 27);
            txtNota3.TabIndex = 14;
            txtNota3.KeyPress += txtNota1_KeyPress;
            // 
            // txtNota2
            // 
            txtNota2.Font = new Font("SimSun", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtNota2.Location = new Point(646, 175);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(82, 27);
            txtNota2.TabIndex = 15;
            txtNota2.KeyPress += txtNota1_KeyPress;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("SimSun", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(610, 393);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 31);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(36, 332);
            label8.Name = "label8";
            label8.Size = new Size(152, 20);
            label8.TabIndex = 17;
            label8.Text = "Nota más baja";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(34, 271);
            label9.Name = "label9";
            label9.Size = new Size(196, 20);
            label9.TabIndex = 18;
            label9.Text = "Promedio de notas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(41, 393);
            label10.Name = "label10";
            label10.Size = new Size(108, 20);
            label10.TabIndex = 19;
            label10.Text = "Condición";
            // 
            // txtPromedio
            // 
            txtPromedio.Enabled = false;
            txtPromedio.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPromedio.Location = new Point(264, 270);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(169, 28);
            txtPromedio.TabIndex = 20;
            // 
            // txtCondicion
            // 
            txtCondicion.Enabled = false;
            txtCondicion.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtCondicion.Location = new Point(264, 389);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(169, 28);
            txtCondicion.TabIndex = 21;
            // 
            // txtNotaBaja
            // 
            txtNotaBaja.Enabled = false;
            txtNotaBaja.Font = new Font("SimSun", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNotaBaja.Location = new Point(264, 330);
            txtNotaBaja.Name = "txtNotaBaja";
            txtNotaBaja.Size = new Size(169, 28);
            txtNotaBaja.TabIndex = 22;
            // 
            // FrmNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(774, 447);
            Controls.Add(txtNotaBaja);
            Controls.Add(txtCondicion);
            Controls.Add(txtPromedio);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnSalir);
            Controls.Add(txtNota2);
            Controls.Add(txtNota3);
            Controls.Add(txtNota4);
            Controls.Add(txtNota1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FrmNotas";
            Text = "Promedio de Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txtNota1;
        private TextBox txtNota4;
        private TextBox txtNota3;
        private TextBox txtNota2;
        private Button btnSalir;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtPromedio;
        private TextBox txtCondicion;
        private TextBox txtNotaBaja;
    }
}