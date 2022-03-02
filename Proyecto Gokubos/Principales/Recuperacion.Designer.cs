namespace Proyecto_Gokubos
{
    partial class Recuperacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperacion));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Boton_ingresar = new System.Windows.Forms.Button();
            this.Boton_cancelar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(286, 411);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 17);
            this.textBox1.TabIndex = 1;
            // 
            // Boton_ingresar
            // 
            this.Boton_ingresar.BackColor = System.Drawing.Color.OrangeRed;
            this.Boton_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.Boton_ingresar.FlatAppearance.BorderSize = 3;
            this.Boton_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Boton_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Boton_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_ingresar.ForeColor = System.Drawing.Color.White;
            this.Boton_ingresar.Location = new System.Drawing.Point(117, 513);
            this.Boton_ingresar.Name = "Boton_ingresar";
            this.Boton_ingresar.Size = new System.Drawing.Size(122, 53);
            this.Boton_ingresar.TabIndex = 3;
            this.Boton_ingresar.Text = "Recuperar";
            this.Boton_ingresar.UseVisualStyleBackColor = false;
            this.Boton_ingresar.Click += new System.EventHandler(this.Boton_ingresar_Click);
            // 
            // Boton_cancelar
            // 
            this.Boton_cancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.Boton_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.Boton_cancelar.FlatAppearance.BorderSize = 3;
            this.Boton_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Boton_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Boton_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_cancelar.ForeColor = System.Drawing.Color.White;
            this.Boton_cancelar.Location = new System.Drawing.Point(269, 513);
            this.Boton_cancelar.Name = "Boton_cancelar";
            this.Boton_cancelar.Size = new System.Drawing.Size(122, 53);
            this.Boton_cancelar.TabIndex = 4;
            this.Boton_cancelar.Text = "Cancelar";
            this.Boton_cancelar.UseVisualStyleBackColor = false;
            this.Boton_cancelar.Click += new System.EventHandler(this.Boton_cancelar_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(286, 461);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 17);
            this.textBox2.TabIndex = 2;
            // 
            // Recuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 661);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Boton_cancelar);
            this.Controls.Add(this.Boton_ingresar);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 700);
            this.MinimumSize = new System.Drawing.Size(525, 700);
            this.Name = "Recuperacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Recuperacion_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Boton_ingresar;
        private System.Windows.Forms.Button Boton_cancelar;
        private System.Windows.Forms.TextBox textBox2;

    }
}