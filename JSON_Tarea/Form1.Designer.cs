namespace JSON_Tarea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtCarnet = new TextBox();
            label3 = new Label();
            txtnombre = new TextBox();
            label4 = new Label();
            txtedad = new TextBox();
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnElimanar = new Button();
            btnMostrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(129, 27);
            label1.Name = "label1";
            label1.Size = new Size(626, 71);
            label1.TabIndex = 0;
            label1.Text = "Lista de Estudiantes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 193);
            label2.Name = "label2";
            label2.Size = new Size(187, 27);
            label2.TabIndex = 1;
            label2.Text = "Numero de Carnet:";
            // 
            // txtCarnet
            // 
            txtCarnet.Location = new Point(217, 196);
            txtCarnet.Name = "txtCarnet";
            txtCarnet.Size = new Size(174, 27);
            txtCarnet.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(118, 252);
            label3.Name = "label3";
            label3.Size = new Size(93, 27);
            label3.TabIndex = 3;
            label3.Text = "Nombre:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(217, 255);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(174, 27);
            txtnombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(141, 314);
            label4.Name = "label4";
            label4.Size = new Size(61, 27);
            label4.TabIndex = 5;
            label4.Text = "Edad:";
            // 
            // txtedad
            // 
            txtedad.Location = new Point(217, 314);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(174, 27);
            txtedad.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(429, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(403, 221);
            dataGridView1.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(240, 347);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 40);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnElimanar
            // 
            btnElimanar.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnElimanar.Location = new Point(734, 421);
            btnElimanar.Name = "btnElimanar";
            btnElimanar.Size = new Size(98, 40);
            btnElimanar.TabIndex = 9;
            btnElimanar.Text = "Eliminar";
            btnElimanar.UseVisualStyleBackColor = true;
            btnElimanar.Click += btnElimanar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(429, 421);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(98, 40);
            btnMostrar.TabIndex = 10;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(868, 473);
            Controls.Add(btnMostrar);
            Controls.Add(btnElimanar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(txtedad);
            Controls.Add(label4);
            Controls.Add(txtnombre);
            Controls.Add(label3);
            Controls.Add(txtCarnet);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Estudiante";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtCarnet;
        private Label label3;
        private TextBox txtnombre;
        private Label label4;
        private TextBox txtedad;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnElimanar;
        private Button btnMostrar;
    }
}
