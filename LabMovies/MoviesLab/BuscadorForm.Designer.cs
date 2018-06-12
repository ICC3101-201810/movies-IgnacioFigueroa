namespace MoviesLab
{
    partial class BuscadorForm
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
            this.BusquedaTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PeliculasB = new System.Windows.Forms.Button();
            this.ActoresB = new System.Windows.Forms.Button();
            this.DirectoresB = new System.Windows.Forms.Button();
            this.ProductoresB = new System.Windows.Forms.Button();
            this.EstudiosB = new System.Windows.Forms.Button();
            this.MostrarLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BusquedaTB
            // 
            this.BusquedaTB.Location = new System.Drawing.Point(121, 65);
            this.BusquedaTB.Name = "BusquedaTB";
            this.BusquedaTB.Size = new System.Drawing.Size(527, 22);
            this.BusquedaTB.TabIndex = 0;
            this.BusquedaTB.TextChanged += new System.EventHandler(this.BusquedaTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // PeliculasB
            // 
            this.PeliculasB.Location = new System.Drawing.Point(58, 121);
            this.PeliculasB.Name = "PeliculasB";
            this.PeliculasB.Size = new System.Drawing.Size(117, 34);
            this.PeliculasB.TabIndex = 2;
            this.PeliculasB.Text = "Peliculas";
            this.PeliculasB.UseVisualStyleBackColor = true;
            this.PeliculasB.Click += new System.EventHandler(this.PeliculasB_Click);
            // 
            // ActoresB
            // 
            this.ActoresB.Location = new System.Drawing.Point(181, 121);
            this.ActoresB.Name = "ActoresB";
            this.ActoresB.Size = new System.Drawing.Size(117, 34);
            this.ActoresB.TabIndex = 3;
            this.ActoresB.Text = "Actores";
            this.ActoresB.UseVisualStyleBackColor = true;
            // 
            // DirectoresB
            // 
            this.DirectoresB.Location = new System.Drawing.Point(304, 121);
            this.DirectoresB.Name = "DirectoresB";
            this.DirectoresB.Size = new System.Drawing.Size(117, 34);
            this.DirectoresB.TabIndex = 4;
            this.DirectoresB.Text = "Directores";
            this.DirectoresB.UseVisualStyleBackColor = true;
            // 
            // ProductoresB
            // 
            this.ProductoresB.Location = new System.Drawing.Point(427, 121);
            this.ProductoresB.Name = "ProductoresB";
            this.ProductoresB.Size = new System.Drawing.Size(117, 34);
            this.ProductoresB.TabIndex = 5;
            this.ProductoresB.Text = "Productores";
            this.ProductoresB.UseVisualStyleBackColor = true;
            // 
            // EstudiosB
            // 
            this.EstudiosB.Location = new System.Drawing.Point(550, 121);
            this.EstudiosB.Name = "EstudiosB";
            this.EstudiosB.Size = new System.Drawing.Size(117, 34);
            this.EstudiosB.TabIndex = 6;
            this.EstudiosB.Text = "Estudios";
            this.EstudiosB.UseVisualStyleBackColor = true;
            // 
            // MostrarLB
            // 
            this.MostrarLB.FormattingEnabled = true;
            this.MostrarLB.ItemHeight = 16;
            this.MostrarLB.Location = new System.Drawing.Point(40, 174);
            this.MostrarLB.Name = "MostrarLB";
            this.MostrarLB.Size = new System.Drawing.Size(705, 372);
            this.MostrarLB.TabIndex = 7;
            // 
            // BuscadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.MostrarLB);
            this.Controls.Add(this.EstudiosB);
            this.Controls.Add(this.ProductoresB);
            this.Controls.Add(this.DirectoresB);
            this.Controls.Add(this.ActoresB);
            this.Controls.Add(this.PeliculasB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BusquedaTB);
            this.Name = "BuscadorForm";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.BuscadorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BusquedaTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PeliculasB;
        private System.Windows.Forms.Button ActoresB;
        private System.Windows.Forms.Button DirectoresB;
        private System.Windows.Forms.Button ProductoresB;
        private System.Windows.Forms.Button EstudiosB;
        private System.Windows.Forms.ListBox MostrarLB;
    }
}