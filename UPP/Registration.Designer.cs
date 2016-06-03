namespace UPP
{
    partial class Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxLogin = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.btnAccepted = new System.Windows.Forms.Button();
            this.tboxNomer = new System.Windows.Forms.TextBox();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxFirstName = new System.Windows.Forms.TextBox();
            this.tboxOtchestvo = new System.Windows.Forms.TextBox();
            this.tboxSeria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // tBoxLogin
            // 
            this.tBoxLogin.Location = new System.Drawing.Point(110, 199);
            this.tBoxLogin.MaxLength = 10;
            this.tBoxLogin.Name = "tBoxLogin";
            this.tBoxLogin.Size = new System.Drawing.Size(341, 22);
            this.tBoxLogin.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(110, 233);
            this.tBoxPassword.MaxLength = 10;
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '*';
            this.tBoxPassword.Size = new System.Drawing.Size(341, 22);
            this.tBoxPassword.TabIndex = 3;
            // 
            // btnAccepted
            // 
            this.btnAccepted.Location = new System.Drawing.Point(121, 296);
            this.btnAccepted.Name = "btnAccepted";
            this.btnAccepted.Size = new System.Drawing.Size(255, 29);
            this.btnAccepted.TabIndex = 4;
            this.btnAccepted.Text = "Подтвердить";
            this.btnAccepted.UseVisualStyleBackColor = true;
            this.btnAccepted.Click += new System.EventHandler(this.btnAccepted_Click);
            // 
            // tboxNomer
            // 
            this.tboxNomer.Location = new System.Drawing.Point(110, 165);
            this.tboxNomer.MaxLength = 6;
            this.tboxNomer.Name = "tboxNomer";
            this.tboxNomer.Size = new System.Drawing.Size(341, 22);
            this.tboxNomer.TabIndex = 5;
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(110, 29);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(341, 22);
            this.tboxName.TabIndex = 6;
            // 
            // tboxFirstName
            // 
            this.tboxFirstName.Location = new System.Drawing.Point(110, 63);
            this.tboxFirstName.Name = "tboxFirstName";
            this.tboxFirstName.Size = new System.Drawing.Size(341, 22);
            this.tboxFirstName.TabIndex = 7;
            // 
            // tboxOtchestvo
            // 
            this.tboxOtchestvo.Location = new System.Drawing.Point(110, 97);
            this.tboxOtchestvo.Name = "tboxOtchestvo";
            this.tboxOtchestvo.Size = new System.Drawing.Size(341, 22);
            this.tboxOtchestvo.TabIndex = 8;
            // 
            // tboxSeria
            // 
            this.tboxSeria.Location = new System.Drawing.Point(110, 131);
            this.tboxSeria.MaxLength = 4;
            this.tboxSeria.Name = "tboxSeria";
            this.tboxSeria.Size = new System.Drawing.Size(341, 22);
            this.tboxSeria.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Фамилия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Отчество:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Серия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер:";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 337);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxSeria);
            this.Controls.Add(this.tboxOtchestvo);
            this.Controls.Add(this.tboxFirstName);
            this.Controls.Add(this.tboxName);
            this.Controls.Add(this.tboxNomer);
            this.Controls.Add(this.btnAccepted);
            this.Controls.Add(this.tBoxPassword);
            this.Controls.Add(this.tBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxLogin;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Button btnAccepted;
        private System.Windows.Forms.TextBox tboxNomer;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxFirstName;
        private System.Windows.Forms.TextBox tboxOtchestvo;
        private System.Windows.Forms.TextBox tboxSeria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}