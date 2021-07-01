
namespace FrmMatriz
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
            this.FilastextBox = new System.Windows.Forms.TextBox();
            this.FilastexBox = new System.Windows.Forms.Label();
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnastextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FilastextBox
            // 
            this.FilastextBox.Location = new System.Drawing.Point(135, 77);
            this.FilastextBox.Name = "FilastextBox";
            this.FilastextBox.Size = new System.Drawing.Size(146, 20);
            this.FilastextBox.TabIndex = 0;
            // 
            // FilastexBox
            // 
            this.FilastexBox.AutoSize = true;
            this.FilastexBox.Location = new System.Drawing.Point(98, 80);
            this.FilastexBox.Name = "FilastexBox";
            this.FilastexBox.Size = new System.Drawing.Size(31, 13);
            this.FilastexBox.TabIndex = 1;
            this.FilastexBox.Text = "Filas:";
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.Location = new System.Drawing.Point(135, 201);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(110, 41);
            this.Ejecutarbutton.TabIndex = 2;
            this.Ejecutarbutton.Text = "Ejecutar";
            this.Ejecutarbutton.UseVisualStyleBackColor = true;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Columnas:";
            // 
            // ColumnastextBox
            // 
            this.ColumnastextBox.Location = new System.Drawing.Point(135, 132);
            this.ColumnastextBox.Name = "ColumnastextBox";
            this.ColumnastextBox.Size = new System.Drawing.Size(146, 20);
            this.ColumnastextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 302);
            this.Controls.Add(this.ColumnastextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ejecutarbutton);
            this.Controls.Add(this.FilastexBox);
            this.Controls.Add(this.FilastextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilastextBox;
        private System.Windows.Forms.Label FilastexBox;
        private System.Windows.Forms.Button Ejecutarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColumnastextBox;
    }
}

