namespace ProjetoInterFront
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.buttonInst = new System.Windows.Forms.Button();
            this.buttonFace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelNTemConta = new System.Windows.Forms.Label();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.statusPass = new System.Windows.Forms.Label();
            this.statusUser = new System.Windows.Forms.Label();
            this.Registrar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(301, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(432, 404);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(692, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 31);
            this.Exit.TabIndex = 1;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // buttonInst
            // 
            this.buttonInst.FlatAppearance.BorderSize = 0;
            this.buttonInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInst.Image = ((System.Drawing.Image)(resources.GetObject("buttonInst.Image")));
            this.buttonInst.Location = new System.Drawing.Point(418, 363);
            this.buttonInst.Name = "buttonInst";
            this.buttonInst.Size = new System.Drawing.Size(41, 31);
            this.buttonInst.TabIndex = 1;
            this.buttonInst.UseVisualStyleBackColor = true;
            // 
            // buttonFace
            // 
            this.buttonFace.FlatAppearance.BorderSize = 0;
            this.buttonFace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFace.Image = ((System.Drawing.Image)(resources.GetObject("buttonFace.Image")));
            this.buttonFace.Location = new System.Drawing.Point(371, 363);
            this.buttonFace.Name = "buttonFace";
            this.buttonFace.Size = new System.Drawing.Size(41, 31);
            this.buttonFace.TabIndex = 1;
            this.buttonFace.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login ";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(38, 114);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(131, 21);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "Nome do Usuario:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(185, 111);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(198, 26);
            this.textBoxUser.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Crimson;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(308, 225);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 40);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(111, 171);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(58, 21);
            this.labelPass.TabIndex = 3;
            this.labelPass.Text = "Senha:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(185, 168);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(198, 26);
            this.textBoxPassword.TabIndex = 4;
            // 
            // labelNTemConta
            // 
            this.labelNTemConta.AutoSize = true;
            this.labelNTemConta.Location = new System.Drawing.Point(38, 373);
            this.labelNTemConta.Name = "labelNTemConta";
            this.labelNTemConta.Size = new System.Drawing.Size(154, 21);
            this.labelNTemConta.TabIndex = 3;
            this.labelNTemConta.Text = "Não tem uma conta?";
            // 
            // buttonEmail
            // 
            this.buttonEmail.FlatAppearance.BorderSize = 0;
            this.buttonEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmail.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmail.Image")));
            this.buttonEmail.Location = new System.Drawing.Point(324, 363);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(41, 31);
            this.buttonEmail.TabIndex = 1;
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // statusPass
            // 
            this.statusPass.AutoSize = true;
            this.statusPass.ForeColor = System.Drawing.Color.Crimson;
            this.statusPass.Location = new System.Drawing.Point(192, 197);
            this.statusPass.Name = "statusPass";
            this.statusPass.Size = new System.Drawing.Size(0, 21);
            this.statusPass.TabIndex = 6;
            // 
            // statusUser
            // 
            this.statusUser.AutoSize = true;
            this.statusUser.ForeColor = System.Drawing.Color.Crimson;
            this.statusUser.Location = new System.Drawing.Point(192, 140);
            this.statusUser.Name = "statusUser";
            this.statusUser.Size = new System.Drawing.Size(0, 21);
            this.statusUser.TabIndex = 6;
            this.statusUser.Click += new System.EventHandler(this.statusUser_Click);
            // 
            // Registrar
            // 
            this.Registrar.AutoSize = true;
            this.Registrar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.ForeColor = System.Drawing.Color.Crimson;
            this.Registrar.Location = new System.Drawing.Point(198, 373);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(95, 21);
            this.Registrar.TabIndex = 3;
            this.Registrar.Text = "Registre-se";
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 404);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.statusUser);
            this.Controls.Add(this.statusPass);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.labelNTemConta);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEmail);
            this.Controls.Add(this.buttonFace);
            this.Controls.Add(this.buttonInst);
            this.Controls.Add(this.pictureBoxLogo);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button buttonInst;
        private System.Windows.Forms.Button buttonFace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelNTemConta;
        private System.Windows.Forms.Button buttonEmail;
        private System.Windows.Forms.Label statusPass;
        private System.Windows.Forms.Label statusUser;
        private System.Windows.Forms.Label Registrar;
    }
}

