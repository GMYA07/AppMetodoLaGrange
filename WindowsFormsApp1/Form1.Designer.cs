namespace WindowsFormsApp1
{
    partial class Form1
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
            this.puntoX = new System.Windows.Forms.TextBox();
            this.puntoY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaPuntos = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSolucion = new System.Windows.Forms.Button();
            this.labelPolinomio = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metodo La Grange";
            // 
            // puntoX
            // 
            this.puntoX.Location = new System.Drawing.Point(93, 153);
            this.puntoX.Margin = new System.Windows.Forms.Padding(2);
            this.puntoX.Name = "puntoX";
            this.puntoX.Size = new System.Drawing.Size(41, 20);
            this.puntoX.TabIndex = 1;
            this.puntoX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // puntoY
            // 
            this.puntoY.Location = new System.Drawing.Point(159, 153);
            this.puntoY.Margin = new System.Windows.Forms.Padding(2);
            this.puntoY.Name = "puntoY";
            this.puntoY.Size = new System.Drawing.Size(41, 20);
            this.puntoY.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar Puntos\r\n          (x,y)";
            // 
            // tablaPuntos
            // 
            this.tablaPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPuntos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.tablaPuntos.Location = new System.Drawing.Point(319, 123);
            this.tablaPuntos.Margin = new System.Windows.Forms.Padding(2);
            this.tablaPuntos.Name = "tablaPuntos";
            this.tablaPuntos.RowHeadersWidth = 51;
            this.tablaPuntos.RowTemplate.Height = 24;
            this.tablaPuntos.Size = new System.Drawing.Size(425, 120);
            this.tablaPuntos.TabIndex = 4;
            this.tablaPuntos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 125;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.Width = 125;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(41, 217);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 26);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Puntos";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSolucion
            // 
            this.btnSolucion.Location = new System.Drawing.Point(159, 217);
            this.btnSolucion.Margin = new System.Windows.Forms.Padding(2);
            this.btnSolucion.Name = "btnSolucion";
            this.btnSolucion.Size = new System.Drawing.Size(103, 26);
            this.btnSolucion.TabIndex = 6;
            this.btnSolucion.Text = "Resolver";
            this.btnSolucion.UseVisualStyleBackColor = true;
            this.btnSolucion.Click += new System.EventHandler(this.btnSolucion_Click);
            // 
            // labelPolinomio
            // 
            this.labelPolinomio.AutoSize = true;
            this.labelPolinomio.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPolinomio.Location = new System.Drawing.Point(37, 347);
            this.labelPolinomio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPolinomio.Name = "labelPolinomio";
            this.labelPolinomio.Size = new System.Drawing.Size(94, 19);
            this.labelPolinomio.TabIndex = 7;
            this.labelPolinomio.Text = "Polinomio: ";
            this.labelPolinomio.Click += new System.EventHandler(this.labelPolinomio_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(473, 257);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Limpiar puntos";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 489);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelPolinomio);
            this.Controls.Add(this.btnSolucion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tablaPuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.puntoY);
            this.Controls.Add(this.puntoX);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox puntoX;
        private System.Windows.Forms.TextBox puntoY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaPuntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSolucion;
        private System.Windows.Forms.Label labelPolinomio;
        private System.Windows.Forms.Button btnClear;
    }
}

