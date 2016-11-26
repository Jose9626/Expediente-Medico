namespace Progra_3
{
    partial class V_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Login));
            this.label_user = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.comboBox_rol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Location = new System.Drawing.Point(75, 34);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(80, 20);
            this.label_user.TabIndex = 0;
            this.label_user.Text = "Usuario:";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass.Location = new System.Drawing.Point(44, 85);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(111, 20);
            this.label_pass.TabIndex = 1;
            this.label_pass.Text = "Contraseña:";
            // 
            // textBox_user
            // 
            this.textBox_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.Location = new System.Drawing.Point(180, 31);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(298, 26);
            this.textBox_user.TabIndex = 2;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(180, 82);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(298, 26);
            this.textBox_pass.TabIndex = 3;
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.PaleGreen;
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enter.Location = new System.Drawing.Point(315, 182);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(163, 35);
            this.button_enter.TabIndex = 4;
            this.button_enter.Text = "ENTRAR";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.LightCoral;
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(180, 182);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(129, 35);
            this.button_cancel.TabIndex = 5;
            this.button_cancel.Text = "CANCELAR";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // comboBox_rol
            // 
            this.comboBox_rol.AutoCompleteCustomSource.AddRange(new string[] {
            "Paciente",
            "Secretario (a)",
            "Enfermero (a)",
            "Doctor (a)",
            "Administrador de Sistemas"});
            this.comboBox_rol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_rol.Items.AddRange(new object[] {
            "Paciente",
            "Funcionario"});
            this.comboBox_rol.Location = new System.Drawing.Point(180, 128);
            this.comboBox_rol.Name = "comboBox_rol";
            this.comboBox_rol.Size = new System.Drawing.Size(298, 28);
            this.comboBox_rol.TabIndex = 6;
            this.comboBox_rol.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Entrar como:";
            // 
            // V_Login
            // 
            this.AcceptButton = this.button_enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.button_cancel;
            this.ClientSize = new System.Drawing.Size(522, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_rol);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "V_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expediente Médico: login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ComboBox comboBox_rol;
        private System.Windows.Forms.Label label1;
    }
}

