namespace UPP
{
    partial class Grajdani
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGrajdani = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_otdel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxNomer = new System.Windows.Forms.TextBox();
            this.tboxStatus = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tboxObrashenie = new System.Windows.Forms.TextBox();
            this.tboxSeria = new System.Windows.Forms.TextBox();
            this.tboxOtchestvo = new System.Windows.Forms.TextBox();
            this.tboxName = new System.Windows.Forms.TextBox();
            this.tboxFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAdmin1 = new System.Windows.Forms.TabPage();
            this.btnAcceptStatus = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabAdmin2 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLoadPens = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabAdmin3 = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLoadJKH = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabGrajdani.SuspendLayout();
            this.tabAdmin1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabAdmin2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabAdmin3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGrajdani);
            this.tabControl1.Controls.Add(this.tabAdmin1);
            this.tabControl1.Controls.Add(this.tabAdmin2);
            this.tabControl1.Controls.Add(this.tabAdmin3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1092, 465);
            this.tabControl1.TabIndex = 4;
            // 
            // tabGrajdani
            // 
            this.tabGrajdani.Controls.Add(this.label6);
            this.tabGrajdani.Controls.Add(this.label8);
            this.tabGrajdani.Controls.Add(this.comboBox_otdel);
            this.tabGrajdani.Controls.Add(this.label7);
            this.tabGrajdani.Controls.Add(this.tboxNomer);
            this.tabGrajdani.Controls.Add(this.tboxStatus);
            this.tabGrajdani.Controls.Add(this.btnSend);
            this.tabGrajdani.Controls.Add(this.tboxObrashenie);
            this.tabGrajdani.Controls.Add(this.tboxSeria);
            this.tabGrajdani.Controls.Add(this.tboxOtchestvo);
            this.tabGrajdani.Controls.Add(this.tboxName);
            this.tabGrajdani.Controls.Add(this.tboxFirstName);
            this.tabGrajdani.Controls.Add(this.label5);
            this.tabGrajdani.Controls.Add(this.label4);
            this.tabGrajdani.Controls.Add(this.label3);
            this.tabGrajdani.Controls.Add(this.label2);
            this.tabGrajdani.Controls.Add(this.label1);
            this.tabGrajdani.Location = new System.Drawing.Point(4, 25);
            this.tabGrajdani.Name = "tabGrajdani";
            this.tabGrajdani.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrajdani.Size = new System.Drawing.Size(1084, 436);
            this.tabGrajdani.TabIndex = 0;
            this.tabGrajdani.Text = "Граждане";
            this.tabGrajdani.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Статус:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Отдел:";
            // 
            // comboBox_otdel
            // 
            this.comboBox_otdel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_otdel.FormattingEnabled = true;
            this.comboBox_otdel.Items.AddRange(new object[] {
            "Регистрация транспорта",
            "Назначение пенсии",
            "ЖКХ"});
            this.comboBox_otdel.Location = new System.Drawing.Point(101, 180);
            this.comboBox_otdel.Name = "comboBox_otdel";
            this.comboBox_otdel.Size = new System.Drawing.Size(558, 24);
            this.comboBox_otdel.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Номер:";
            // 
            // tboxNomer
            // 
            this.tboxNomer.Location = new System.Drawing.Point(101, 146);
            this.tboxNomer.Name = "tboxNomer";
            this.tboxNomer.ReadOnly = true;
            this.tboxNomer.Size = new System.Drawing.Size(558, 22);
            this.tboxNomer.TabIndex = 17;
            // 
            // tboxStatus
            // 
            this.tboxStatus.Location = new System.Drawing.Point(101, 216);
            this.tboxStatus.Name = "tboxStatus";
            this.tboxStatus.ReadOnly = true;
            this.tboxStatus.Size = new System.Drawing.Size(558, 22);
            this.tboxStatus.TabIndex = 16;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(516, 383);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(143, 46);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Отправить обращение";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tboxObrashenie
            // 
            this.tboxObrashenie.Location = new System.Drawing.Point(101, 256);
            this.tboxObrashenie.Multiline = true;
            this.tboxObrashenie.Name = "tboxObrashenie";
            this.tboxObrashenie.Size = new System.Drawing.Size(960, 121);
            this.tboxObrashenie.TabIndex = 13;
            // 
            // tboxSeria
            // 
            this.tboxSeria.Location = new System.Drawing.Point(101, 112);
            this.tboxSeria.Name = "tboxSeria";
            this.tboxSeria.ReadOnly = true;
            this.tboxSeria.Size = new System.Drawing.Size(558, 22);
            this.tboxSeria.TabIndex = 12;
            // 
            // tboxOtchestvo
            // 
            this.tboxOtchestvo.Location = new System.Drawing.Point(101, 78);
            this.tboxOtchestvo.Name = "tboxOtchestvo";
            this.tboxOtchestvo.ReadOnly = true;
            this.tboxOtchestvo.Size = new System.Drawing.Size(558, 22);
            this.tboxOtchestvo.TabIndex = 11;
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(101, 44);
            this.tboxName.Name = "tboxName";
            this.tboxName.ReadOnly = true;
            this.tboxName.Size = new System.Drawing.Size(558, 22);
            this.tboxName.TabIndex = 10;
            // 
            // tboxFirstName
            // 
            this.tboxFirstName.Location = new System.Drawing.Point(101, 10);
            this.tboxFirstName.Name = "tboxFirstName";
            this.tboxFirstName.ReadOnly = true;
            this.tboxFirstName.Size = new System.Drawing.Size(558, 22);
            this.tboxFirstName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Обращение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Серия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия:";
            // 
            // tabAdmin1
            // 
            this.tabAdmin1.Controls.Add(this.btnAcceptStatus);
            this.tabAdmin1.Controls.Add(this.comboBox1);
            this.tabAdmin1.Controls.Add(this.btnLoad);
            this.tabAdmin1.Controls.Add(this.dataGridView1);
            this.tabAdmin1.Location = new System.Drawing.Point(4, 25);
            this.tabAdmin1.Name = "tabAdmin1";
            this.tabAdmin1.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin1.Size = new System.Drawing.Size(1084, 436);
            this.tabAdmin1.TabIndex = 1;
            this.tabAdmin1.Text = "Регистрация транспорта";
            this.tabAdmin1.UseVisualStyleBackColor = true;
            // 
            // btnAcceptStatus
            // 
            this.btnAcceptStatus.Location = new System.Drawing.Point(151, 287);
            this.btnAcceptStatus.Name = "btnAcceptStatus";
            this.btnAcceptStatus.Size = new System.Drawing.Size(137, 32);
            this.btnAcceptStatus.TabIndex = 3;
            this.btnAcceptStatus.Text = "Подтвердить";
            this.btnAcceptStatus.UseVisualStyleBackColor = true;
            this.btnAcceptStatus.Click += new System.EventHandler(this.btnAcceptStatus_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Принято",
            "Отклонено"});
            this.comboBox1.Location = new System.Drawing.Point(294, 292);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(8, 287);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(137, 32);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabAdmin2
            // 
            this.tabAdmin2.Controls.Add(this.comboBox2);
            this.tabAdmin2.Controls.Add(this.button2);
            this.tabAdmin2.Controls.Add(this.btnLoadPens);
            this.tabAdmin2.Controls.Add(this.dataGridView2);
            this.tabAdmin2.Location = new System.Drawing.Point(4, 25);
            this.tabAdmin2.Name = "tabAdmin2";
            this.tabAdmin2.Size = new System.Drawing.Size(1084, 436);
            this.tabAdmin2.TabIndex = 2;
            this.tabAdmin2.Text = "Назначение пенсии";
            this.tabAdmin2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Принято",
            "Отклонено"});
            this.comboBox2.Location = new System.Drawing.Point(294, 292);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Подтвердить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLoadPens
            // 
            this.btnLoadPens.Location = new System.Drawing.Point(8, 287);
            this.btnLoadPens.Name = "btnLoadPens";
            this.btnLoadPens.Size = new System.Drawing.Size(137, 32);
            this.btnLoadPens.TabIndex = 1;
            this.btnLoadPens.Text = "Загрузить";
            this.btnLoadPens.UseVisualStyleBackColor = true;
            this.btnLoadPens.Click += new System.EventHandler(this.btnLoadPens_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 8);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1062, 273);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabAdmin3
            // 
            this.tabAdmin3.Controls.Add(this.comboBox3);
            this.tabAdmin3.Controls.Add(this.button3);
            this.tabAdmin3.Controls.Add(this.btnLoadJKH);
            this.tabAdmin3.Controls.Add(this.dataGridView3);
            this.tabAdmin3.Location = new System.Drawing.Point(4, 25);
            this.tabAdmin3.Name = "tabAdmin3";
            this.tabAdmin3.Size = new System.Drawing.Size(1084, 436);
            this.tabAdmin3.TabIndex = 3;
            this.tabAdmin3.Text = "ЖКХ";
            this.tabAdmin3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Принято",
            "Отклонено"});
            this.comboBox3.Location = new System.Drawing.Point(294, 292);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(151, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Подтвердить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLoadJKH
            // 
            this.btnLoadJKH.Location = new System.Drawing.Point(8, 287);
            this.btnLoadJKH.Name = "btnLoadJKH";
            this.btnLoadJKH.Size = new System.Drawing.Size(137, 32);
            this.btnLoadJKH.TabIndex = 5;
            this.btnLoadJKH.Text = "Загрузить";
            this.btnLoadJKH.UseVisualStyleBackColor = true;
            this.btnLoadJKH.Click += new System.EventHandler(this.btnLoadJKH_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(8, 8);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1062, 273);
            this.dataGridView3.TabIndex = 4;
            // 
            // Grajdani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1102, 468);
            this.Controls.Add(this.tabControl1);
            this.Name = "Grajdani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обращение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Grajdani_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabGrajdani.ResumeLayout(false);
            this.tabGrajdani.PerformLayout();
            this.tabAdmin1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabAdmin2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabAdmin3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGrajdani;
        private System.Windows.Forms.TabPage tabAdmin1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tboxObrashenie;
        private System.Windows.Forms.TextBox tboxSeria;
        private System.Windows.Forms.TextBox tboxOtchestvo;
        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.TextBox tboxFirstName;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tboxStatus;
        private System.Windows.Forms.Button btnAcceptStatus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxNomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_otdel;
        private System.Windows.Forms.TabPage tabAdmin2;
        private System.Windows.Forms.TabPage tabAdmin3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLoadPens;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLoadJKH;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label6;
    }
}

