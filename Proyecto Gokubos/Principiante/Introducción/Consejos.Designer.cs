namespace Proyecto_Gokubos
{
    partial class Consejos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consejos));
            this.Boton_ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Boton_ingresar
            // 
            this.Boton_ingresar.BackColor = System.Drawing.Color.OrangeRed;
            this.Boton_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.Boton_ingresar.FlatAppearance.BorderSize = 3;
            this.Boton_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.Boton_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Boton_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_ingresar.ForeColor = System.Drawing.Color.White;
            this.Boton_ingresar.Location = new System.Drawing.Point(783, 637);
            this.Boton_ingresar.Name = "Boton_ingresar";
            this.Boton_ingresar.Size = new System.Drawing.Size(90, 39);
            this.Boton_ingresar.TabIndex = 15;
            this.Boton_ingresar.Text = "Atras";
            this.Boton_ingresar.UseVisualStyleBackColor = false;
            this.Boton_ingresar.Click += new System.EventHandler(this.Boton_ingresar_Click);
            // 
            // Consejos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 688);
            this.Controls.Add(this.Boton_ingresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1030, 727);
            this.MinimumSize = new System.Drawing.Size(1030, 727);
            this.Name = "Consejos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consejos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Consejos_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton_ingresar;
    }
}