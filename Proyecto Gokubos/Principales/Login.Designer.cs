namespace Proyecto_Gokubos
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Boton_ingresar = new System.Windows.Forms.Button();
            this.Boton_cancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Registrar = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
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
            this.Boton_ingresar.Location = new System.Drawing.Point(109, 526);
            this.Boton_ingresar.Name = "Boton_ingresar";
            this.Boton_ingresar.Size = new System.Drawing.Size(122, 53);
            this.Boton_ingresar.TabIndex = 6;
            this.Boton_ingresar.Text = "Ingresar";
            this.Boton_ingresar.UseVisualStyleBackColor = false;
            this.Boton_ingresar.Click += new System.EventHandler(this.Boton_ingresar_Click);
            // 
            // Boton_cancelar
            // 
            this.Boton_cancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.Boton_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Boton_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.Boton_cancelar.FlatAppearance.BorderSize = 3;
            this.Boton_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Boton_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Boton_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_cancelar.ForeColor = System.Drawing.Color.White;
            this.Boton_cancelar.Location = new System.Drawing.Point(288, 526);
            this.Boton_cancelar.Name = "Boton_cancelar";
            this.Boton_cancelar.Size = new System.Drawing.Size(122, 53);
            this.Boton_cancelar.TabIndex = 7;
            this.Boton_cancelar.Text = "Cancelar";
            this.Boton_cancelar.UseVisualStyleBackColor = false;
            this.Boton_cancelar.Click += new System.EventHandler(this.Boton_cancelar_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(251, 417);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 17);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(251, 468);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(168, 17);
            this.textBox2.TabIndex = 5;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Registrar
            // 
            this.Registrar.AutoSize = true;
            this.Registrar.BackColor = System.Drawing.Color.Transparent;
            this.Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.LinkColor = System.Drawing.Color.Red;
            this.Registrar.Location = new System.Drawing.Point(115, 596);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(101, 15);
            this.Registrar.TabIndex = 8;
            this.Registrar.TabStop = true;
            this.Registrar.Text = "Registrar usuario";
            this.Registrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Registrar_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(297, 596);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 15);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Olvide mi contraseña";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 672);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Boton_cancelar);
            this.Controls.Add(this.Boton_ingresar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(525, 700);
            this.MinimumSize = new System.Drawing.Size(525, 700);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_ingresar;
        private System.Windows.Forms.Button Boton_cancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel Registrar;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

