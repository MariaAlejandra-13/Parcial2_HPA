namespace Presentacion
{
    partial class FrmLogin
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
            label1 = new Label();
            Contraseña = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 144);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contraseña.Location = new Point(178, 213);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(89, 21);
            Contraseña.TabIndex = 1;
            Contraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(178, 168);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(423, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(178, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(423, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.HotTrack;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(257, 323);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(289, 32);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Iniciar sesión";
            btnIngresar.TextAlign = ContentAlignment.TopCenter;
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(317, 63);
            label2.Name = "label2";
            label2.Size = new Size(168, 30);
            label2.TabIndex = 5;
            label2.Text = "Inicio de Sesión";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(Contraseña);
            Controls.Add(label1);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Contraseña;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Label label2;
    }
}