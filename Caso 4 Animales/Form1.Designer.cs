namespace Caso_4_Animales
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLoroImp = new System.Windows.Forms.Button();
            this.btnConejoImp = new System.Windows.Forms.Button();
            this.btnLeonImp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(317, 113);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(141, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Loro, Conejo y Leon";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLoroImp
            // 
            this.btnLoroImp.Location = new System.Drawing.Point(100, 219);
            this.btnLoroImp.Name = "btnLoroImp";
            this.btnLoroImp.Size = new System.Drawing.Size(127, 23);
            this.btnLoroImp.TabIndex = 1;
            this.btnLoroImp.Text = "Loro.ImprimirComida()";
            this.btnLoroImp.UseVisualStyleBackColor = true;
            this.btnLoroImp.Click += new System.EventHandler(this.btnLoroImp_Click);
            // 
            // btnConejoImp
            // 
            this.btnConejoImp.Location = new System.Drawing.Point(317, 219);
            this.btnConejoImp.Name = "btnConejoImp";
            this.btnConejoImp.Size = new System.Drawing.Size(141, 23);
            this.btnConejoImp.TabIndex = 2;
            this.btnConejoImp.Text = "Conejo.ImprimirComida()";
            this.btnConejoImp.UseVisualStyleBackColor = true;
            this.btnConejoImp.Click += new System.EventHandler(this.btnConejoImp_Click);
            // 
            // btnLeonImp
            // 
            this.btnLeonImp.Location = new System.Drawing.Point(544, 219);
            this.btnLeonImp.Name = "btnLeonImp";
            this.btnLeonImp.Size = new System.Drawing.Size(129, 23);
            this.btnLeonImp.TabIndex = 3;
            this.btnLeonImp.Text = "Leon.ImprimirComida()";
            this.btnLeonImp.UseVisualStyleBackColor = true;
            this.btnLeonImp.Click += new System.EventHandler(this.btnLeonImp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeonImp);
            this.Controls.Add(this.btnConejoImp);
            this.Controls.Add(this.btnLoroImp);
            this.Controls.Add(this.btnCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLoroImp;
        private System.Windows.Forms.Button btnConejoImp;
        private System.Windows.Forms.Button btnLeonImp;
    }
}

