namespace Projecto_Login_04_11_2024
{
    partial class Administrador
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.estudiantesUCTDataSet = new Projecto_Login_04_11_2024.EstudiantesUCTDataSet();
            this.estudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantesTableAdapter = new Projecto_Login_04_11_2024.EstudiantesUCTDataSetTableAdapters.EstudiantesTableAdapter();
            this.rUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesUCTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rUTDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.estudiantesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(338, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // estudiantesUCTDataSet
            // 
            this.estudiantesUCTDataSet.DataSetName = "EstudiantesUCTDataSet";
            this.estudiantesUCTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiantesBindingSource
            // 
            this.estudiantesBindingSource.DataMember = "Estudiantes";
            this.estudiantesBindingSource.DataSource = this.estudiantesUCTDataSet;
            // 
            // estudiantesTableAdapter
            // 
            this.estudiantesTableAdapter.ClearBeforeFill = true;
            // 
            // rUTDataGridViewTextBoxColumn
            // 
            this.rUTDataGridViewTextBoxColumn.DataPropertyName = "RUT";
            this.rUTDataGridViewTextBoxColumn.HeaderText = "RUT";
            this.rUTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rUTDataGridViewTextBoxColumn.Name = "rUTDataGridViewTextBoxColumn";
            this.rUTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 575);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesUCTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EstudiantesUCTDataSet estudiantesUCTDataSet;
        private System.Windows.Forms.BindingSource estudiantesBindingSource;
        private EstudiantesUCTDataSetTableAdapters.EstudiantesTableAdapter estudiantesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
    }
}