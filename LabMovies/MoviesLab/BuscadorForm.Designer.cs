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
            this.SalirB = new System.Windows.Forms.Button();
            this.InformacionLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BusquedaTB
            // 
            this.BusquedaTB.Location = new System.Drawing.Point(91, 53);
            this.BusquedaTB.Margin = new System.Windows.Forms.Padding(2);
            this.BusquedaTB.Name = "BusquedaTB";
            this.BusquedaTB.Size = new System.Drawing.Size(396, 20);
            this.BusquedaTB.TabIndex = 0;
            this.BusquedaTB.TextChanged += new System.EventHandler(this.BusquedaTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // PeliculasB
            // 
            this.PeliculasB.Location = new System.Drawing.Point(44, 98);
            this.PeliculasB.Margin = new System.Windows.Forms.Padding(2);
            this.PeliculasB.Name = "PeliculasB";
            this.PeliculasB.Size = new System.Drawing.Size(88, 28);
            this.PeliculasB.TabIndex = 2;
            this.PeliculasB.Text = "Peliculas";
            this.PeliculasB.UseVisualStyleBackColor = true;
            this.PeliculasB.Click += new System.EventHandler(this.PeliculasB_Click);
            // 
            // ActoresB
            // 
            this.ActoresB.Location = new System.Drawing.Point(136, 98);
            this.ActoresB.Margin = new System.Windows.Forms.Padding(2);
            this.ActoresB.Name = "ActoresB";
            this.ActoresB.Size = new System.Drawing.Size(88, 28);
            this.ActoresB.TabIndex = 3;
            this.ActoresB.Text = "Actores";
            this.ActoresB.UseVisualStyleBackColor = true;
            this.ActoresB.Click += new System.EventHandler(this.ActoresB_Click);
            // 
            // DirectoresB
            // 
            this.DirectoresB.Location = new System.Drawing.Point(228, 98);
            this.DirectoresB.Margin = new System.Windows.Forms.Padding(2);
            this.DirectoresB.Name = "DirectoresB";
            this.DirectoresB.Size = new System.Drawing.Size(88, 28);
            this.DirectoresB.TabIndex = 4;
            this.DirectoresB.Text = "Directores";
            this.DirectoresB.UseVisualStyleBackColor = true;
            this.DirectoresB.Click += new System.EventHandler(this.DirectoresB_Click);
            // 
            // ProductoresB
            // 
            this.ProductoresB.Location = new System.Drawing.Point(320, 98);
            this.ProductoresB.Margin = new System.Windows.Forms.Padding(2);
            this.ProductoresB.Name = "ProductoresB";
            this.ProductoresB.Size = new System.Drawing.Size(88, 28);
            this.ProductoresB.TabIndex = 5;
            this.ProductoresB.Text = "Productores";
            this.ProductoresB.UseVisualStyleBackColor = true;
            this.ProductoresB.Click += new System.EventHandler(this.ProductoresB_Click);
            // 
            // EstudiosB
            // 
            this.EstudiosB.Location = new System.Drawing.Point(412, 98);
            this.EstudiosB.Margin = new System.Windows.Forms.Padding(2);
            this.EstudiosB.Name = "EstudiosB";
            this.EstudiosB.Size = new System.Drawing.Size(88, 28);
            this.EstudiosB.TabIndex = 6;
            this.EstudiosB.Text = "Estudios";
            this.EstudiosB.UseVisualStyleBackColor = true;
            this.EstudiosB.Click += new System.EventHandler(this.EstudiosB_Click);
            // 
            // MostrarLB
            // 
            this.MostrarLB.FormattingEnabled = true;
            this.MostrarLB.Location = new System.Drawing.Point(30, 141);
            this.MostrarLB.Margin = new System.Windows.Forms.Padding(2);
            this.MostrarLB.Name = "MostrarLB";
            this.MostrarLB.Size = new System.Drawing.Size(470, 420);
            this.MostrarLB.TabIndex = 7;
            this.MostrarLB.Click += new System.EventHandler(this.MostrarLB_Click);
            this.MostrarLB.SelectedIndexChanged += new System.EventHandler(this.MostrarLB_SelectedIndexChanged);
            // 
            // SalirB
            // 
            this.SalirB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirB.Location = new System.Drawing.Point(667, 29);
            this.SalirB.Name = "SalirB";
            this.SalirB.Size = new System.Drawing.Size(166, 53);
            this.SalirB.TabIndex = 9;
            this.SalirB.Text = "Salir y Guardar";
            this.SalirB.UseVisualStyleBackColor = true;
            this.SalirB.Click += new System.EventHandler(this.SalirB_Click);
            // 
            // InformacionLB
            // 
            this.InformacionLB.FormattingEnabled = true;
            this.InformacionLB.Location = new System.Drawing.Point(539, 141);
            this.InformacionLB.Name = "InformacionLB";
            this.InformacionLB.Size = new System.Drawing.Size(294, 420);
            this.InformacionLB.TabIndex = 10;
            this.InformacionLB.SelectedIndexChanged += new System.EventHandler(this.InformacionLB_SelectedIndexChanged);
            // 
            // BuscadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 576);
            this.Controls.Add(this.InformacionLB);
            this.Controls.Add(this.SalirB);
            this.Controls.Add(this.MostrarLB);
            this.Controls.Add(this.EstudiosB);
            this.Controls.Add(this.ProductoresB);
            this.Controls.Add(this.DirectoresB);
            this.Controls.Add(this.ActoresB);
            this.Controls.Add(this.PeliculasB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BusquedaTB);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BuscadorForm";
            this.Text = "Buscador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BuscadorForm_FormClosing);
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
        private System.Windows.Forms.Button SalirB;
        private System.Windows.Forms.ListBox InformacionLB;
    }
}