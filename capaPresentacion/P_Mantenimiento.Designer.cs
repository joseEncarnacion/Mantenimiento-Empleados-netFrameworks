
namespace capaPresentacion
{
    partial class P_Mantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Mantenimiento));
            this.stageMantenimiento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.edadBox = new System.Windows.Forms.TextBox();
            this.sexoBox = new System.Windows.Forms.TextBox();
            this.sueldoBox = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.codeEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stageMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // stageMantenimiento
            // 
            this.stageMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stageMantenimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeEmp,
            this.nomEmp,
            this.edadEmp,
            this.sexoEmp,
            this.sueldoEmp,
            this.Eliminar,
            this.Editar});
            this.stageMantenimiento.Location = new System.Drawing.Point(215, 110);
            this.stageMantenimiento.Name = "stageMantenimiento";
            this.stageMantenimiento.RowHeadersWidth = 51;
            this.stageMantenimiento.RowTemplate.Height = 24;
            this.stageMantenimiento.Size = new System.Drawing.Size(926, 249);
            this.stageMantenimiento.TabIndex = 0;
            this.stageMantenimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stageMantenimiento_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pantalla de mantenimiento Empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Code";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sueldo";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(100, 121);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(100, 22);
            this.codeBox.TabIndex = 7;
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(100, 162);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(100, 22);
            this.nombreBox.TabIndex = 9;
            // 
            // edadBox
            // 
            this.edadBox.Location = new System.Drawing.Point(100, 207);
            this.edadBox.Name = "edadBox";
            this.edadBox.Size = new System.Drawing.Size(100, 22);
            this.edadBox.TabIndex = 10;
            // 
            // sexoBox
            // 
            this.sexoBox.Location = new System.Drawing.Point(100, 252);
            this.sexoBox.Name = "sexoBox";
            this.sexoBox.Size = new System.Drawing.Size(100, 22);
            this.sexoBox.TabIndex = 11;
            this.sexoBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // sueldoBox
            // 
            this.sueldoBox.Location = new System.Drawing.Point(100, 300);
            this.sueldoBox.Name = "sueldoBox";
            this.sueldoBox.Size = new System.Drawing.Size(100, 22);
            this.sueldoBox.TabIndex = 12;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(163, 382);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(183, 32);
            this.btn_insert.TabIndex = 13;
            this.btn_insert.Text = "Insertar";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(458, 382);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(183, 32);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Editar";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
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
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // P_Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.sueldoBox);
            this.Controls.Add(this.sexoBox);
            this.Controls.Add(this.edadBox);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stageMantenimiento);
            this.Name = "P_Mantenimiento";
            this.Text = "P_Mantenimiento";
            this.Load += new System.EventHandler(this.P_Mantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stageMantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stageMantenimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.TextBox edadBox;
        private System.Windows.Forms.TextBox sexoBox;
        private System.Windows.Forms.TextBox sueldoBox;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoEmp;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}