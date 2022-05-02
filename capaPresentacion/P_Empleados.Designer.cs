
namespace capaPresentacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.codeEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeEmp,
            this.nomEmp,
            this.edadEmp,
            this.sexoEmp,
            this.sueldoEmp});
            this.dataGridView1.Location = new System.Drawing.Point(32, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(756, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(305, 42);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(274, 29);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "Listado de Empleados";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(209, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // codeEmp
            // 
            this.codeEmp.DataPropertyName = "codeEmp";
            this.codeEmp.HeaderText = "Codigo";
            this.codeEmp.MinimumWidth = 6;
            this.codeEmp.Name = "codeEmp";
            this.codeEmp.Width = 125;
            // 
            // nomEmp
            // 
            this.nomEmp.DataPropertyName = "nomEmp";
            this.nomEmp.HeaderText = "Nombre";
            this.nomEmp.MinimumWidth = 6;
            this.nomEmp.Name = "nomEmp";
            this.nomEmp.Width = 125;
            // 
            // edadEmp
            // 
            this.edadEmp.DataPropertyName = "edadEmp";
            this.edadEmp.HeaderText = "Edad";
            this.edadEmp.MinimumWidth = 6;
            this.edadEmp.Name = "edadEmp";
            this.edadEmp.Width = 125;
            // 
            // sexoEmp
            // 
            this.sexoEmp.DataPropertyName = "sexoEmp";
            this.sexoEmp.HeaderText = "Sexo";
            this.sexoEmp.MinimumWidth = 6;
            this.sexoEmp.Name = "sexoEmp";
            this.sexoEmp.Width = 125;
            // 
            // sueldoEmp
            // 
            this.sueldoEmp.DataPropertyName = "sueldoEmp";
            this.sueldoEmp.HeaderText = "Sueldo";
            this.sueldoEmp.MinimumWidth = 6;
            this.sueldoEmp.Name = "sueldoEmp";
            this.sueldoEmp.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoEmp;
    }
}

