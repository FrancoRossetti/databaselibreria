namespace TrabajoPractico_DB
{
    partial class Form_PreciosLibros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Libro = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_Codigo_Libro = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Libro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Libro
            // 
            this.dgv_Libro.AllowUserToDeleteRows = false;
            this.dgv_Libro.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Libro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Libro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Precio});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(238)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Libro.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Libro.Location = new System.Drawing.Point(288, 30);
            this.dgv_Libro.Name = "dgv_Libro";
            this.dgv_Libro.ReadOnly = true;
            this.dgv_Libro.RowTemplate.Height = 30;
            this.dgv_Libro.Size = new System.Drawing.Size(250, 432);
            this.dgv_Libro.TabIndex = 54;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(24, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 24);
            this.label21.TabIndex = 55;
            this.label21.Text = "Codigo Libro";
            // 
            // txt_Codigo_Libro
            // 
            this.txt_Codigo_Libro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo_Libro.Location = new System.Drawing.Point(148, 55);
            this.txt_Codigo_Libro.Name = "txt_Codigo_Libro";
            this.txt_Codigo_Libro.Size = new System.Drawing.Size(123, 31);
            this.txt_Codigo_Libro.TabIndex = 60;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Form_PreciosLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(111)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(550, 474);
            this.Controls.Add(this.txt_Codigo_Libro);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.dgv_Libro);
            this.Name = "Form_PreciosLibros";
            this.Text = "Form_PreciosLibros";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Libro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Libro;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_Codigo_Libro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}