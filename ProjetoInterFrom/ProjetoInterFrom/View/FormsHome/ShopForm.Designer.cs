namespace ProjetoInterFrom.View.FormsHome
{
    partial class ShopForm
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
            this.checkBoxConfirmed = new System.Windows.Forms.CheckBox();
            this.labelDateInitial = new System.Windows.Forms.Label();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.labelDias = new System.Windows.Forms.Label();
            this.labelPagar = new System.Windows.Forms.Label();
            this.iconButtonAlugar = new FontAwesome.Sharp.IconButton();
            this.iconButtonConsultar = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerInicial = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // checkBoxConfirmed
            // 
            this.checkBoxConfirmed.AutoSize = true;
            this.checkBoxConfirmed.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxConfirmed.Location = new System.Drawing.Point(49, 227);
            this.checkBoxConfirmed.Name = "checkBoxConfirmed";
            this.checkBoxConfirmed.Size = new System.Drawing.Size(170, 25);
            this.checkBoxConfirmed.TabIndex = 0;
            this.checkBoxConfirmed.Text = "Confirmar Aluguel";
            this.checkBoxConfirmed.UseVisualStyleBackColor = true;
            // 
            // labelDateInitial
            // 
            this.labelDateInitial.AutoSize = true;
            this.labelDateInitial.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateInitial.Location = new System.Drawing.Point(45, 87);
            this.labelDateInitial.Name = "labelDateInitial";
            this.labelDateInitial.Size = new System.Drawing.Size(100, 21);
            this.labelDateInitial.TabIndex = 1;
            this.labelDateInitial.Text = "Data Inicial";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateEnd.Location = new System.Drawing.Point(45, 127);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(91, 21);
            this.labelDateEnd.TabIndex = 1;
            this.labelDateEnd.Text = "Data Final";
            // 
            // labelDias
            // 
            this.labelDias.AutoSize = true;
            this.labelDias.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDias.Location = new System.Drawing.Point(45, 191);
            this.labelDias.Name = "labelDias";
            this.labelDias.Size = new System.Drawing.Size(0, 21);
            this.labelDias.TabIndex = 3;
            // 
            // labelPagar
            // 
            this.labelPagar.AutoSize = true;
            this.labelPagar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagar.Location = new System.Drawing.Point(199, 191);
            this.labelPagar.Name = "labelPagar";
            this.labelPagar.Size = new System.Drawing.Size(0, 21);
            this.labelPagar.TabIndex = 3;
            // 
            // iconButtonAlugar
            // 
            this.iconButtonAlugar.BackColor = System.Drawing.Color.Crimson;
            this.iconButtonAlugar.FlatAppearance.BorderSize = 0;
            this.iconButtonAlugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAlugar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonAlugar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAlugar.ForeColor = System.Drawing.Color.White;
            this.iconButtonAlugar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAlugar.IconColor = System.Drawing.Color.White;
            this.iconButtonAlugar.IconSize = 16;
            this.iconButtonAlugar.Location = new System.Drawing.Point(49, 276);
            this.iconButtonAlugar.Name = "iconButtonAlugar";
            this.iconButtonAlugar.Rotation = 0D;
            this.iconButtonAlugar.Size = new System.Drawing.Size(209, 51);
            this.iconButtonAlugar.TabIndex = 4;
            this.iconButtonAlugar.Text = "Alugar";
            this.iconButtonAlugar.UseVisualStyleBackColor = false;
            this.iconButtonAlugar.Click += new System.EventHandler(this.iconButtonAlugar_Click);
            // 
            // iconButtonConsultar
            // 
            this.iconButtonConsultar.BackColor = System.Drawing.Color.Crimson;
            this.iconButtonConsultar.FlatAppearance.BorderSize = 0;
            this.iconButtonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonConsultar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonConsultar.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonConsultar.ForeColor = System.Drawing.Color.White;
            this.iconButtonConsultar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonConsultar.IconColor = System.Drawing.Color.White;
            this.iconButtonConsultar.IconSize = 16;
            this.iconButtonConsultar.Location = new System.Drawing.Point(264, 276);
            this.iconButtonConsultar.Name = "iconButtonConsultar";
            this.iconButtonConsultar.Rotation = 0D;
            this.iconButtonConsultar.Size = new System.Drawing.Size(209, 51);
            this.iconButtonConsultar.TabIndex = 4;
            this.iconButtonConsultar.Text = "Consultar Preco";
            this.iconButtonConsultar.UseVisualStyleBackColor = false;
            this.iconButtonConsultar.Click += new System.EventHandler(this.iconButtonConsultar_Click);
            // 
            // dateTimePickerInicial
            // 
            this.dateTimePickerInicial.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerInicial.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInicial.Location = new System.Drawing.Point(203, 82);
            this.dateTimePickerInicial.Name = "dateTimePickerInicial";
            this.dateTimePickerInicial.Size = new System.Drawing.Size(260, 26);
            this.dateTimePickerInicial.TabIndex = 5;
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerFinal.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(203, 122);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(260, 26);
            this.dateTimePickerFinal.TabIndex = 5;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 448);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.dateTimePickerInicial);
            this.Controls.Add(this.iconButtonConsultar);
            this.Controls.Add(this.iconButtonAlugar);
            this.Controls.Add(this.labelPagar);
            this.Controls.Add(this.labelDias);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.labelDateInitial);
            this.Controls.Add(this.checkBoxConfirmed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShopForm";
            this.Text = "Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxConfirmed;
        private System.Windows.Forms.Label labelDateInitial;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Label labelDias;
        private System.Windows.Forms.Label labelPagar;
        private FontAwesome.Sharp.IconButton iconButtonAlugar;
        private FontAwesome.Sharp.IconButton iconButtonConsultar;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicial;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
    }
}