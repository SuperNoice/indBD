namespace indBD
{
    partial class DogovorRedactor
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
            this.clientIdComboBox = new System.Windows.Forms.ComboBox();
            this.codeDogovoraComboBox = new System.Windows.Forms.ComboBox();
            this.DataVidachiMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.minSrokZalogaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.maxSrokZalogaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.razmSsudyMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.procentPerDayMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.procentForStorageMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.garantSrokStorageMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.factDataSoldMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.factSummVikupaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientIdComboBox
            // 
            this.clientIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientIdComboBox.FormattingEnabled = true;
            this.clientIdComboBox.Location = new System.Drawing.Point(207, 54);
            this.clientIdComboBox.Name = "clientIdComboBox";
            this.clientIdComboBox.Size = new System.Drawing.Size(62, 21);
            this.clientIdComboBox.TabIndex = 0;
            this.clientIdComboBox.SelectedIndexChanged += new System.EventHandler(this.clientIdComboBox_SelectedIndexChanged);
            // 
            // codeDogovoraComboBox
            // 
            this.codeDogovoraComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeDogovoraComboBox.FormattingEnabled = true;
            this.codeDogovoraComboBox.Location = new System.Drawing.Point(207, 27);
            this.codeDogovoraComboBox.Name = "codeDogovoraComboBox";
            this.codeDogovoraComboBox.Size = new System.Drawing.Size(62, 21);
            this.codeDogovoraComboBox.TabIndex = 1;
            this.codeDogovoraComboBox.SelectedIndexChanged += new System.EventHandler(this.codeDogovoraComboBox_SelectedIndexChanged);
            // 
            // DataVidachiMaskedTextBox
            // 
            this.DataVidachiMaskedTextBox.Location = new System.Drawing.Point(207, 81);
            this.DataVidachiMaskedTextBox.Mask = "00/00/0000";
            this.DataVidachiMaskedTextBox.Name = "DataVidachiMaskedTextBox";
            this.DataVidachiMaskedTextBox.Size = new System.Drawing.Size(62, 20);
            this.DataVidachiMaskedTextBox.TabIndex = 2;
            this.DataVidachiMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // minSrokZalogaMaskedTextBox
            // 
            this.minSrokZalogaMaskedTextBox.Location = new System.Drawing.Point(207, 107);
            this.minSrokZalogaMaskedTextBox.Mask = "0000";
            this.minSrokZalogaMaskedTextBox.Name = "minSrokZalogaMaskedTextBox";
            this.minSrokZalogaMaskedTextBox.Size = new System.Drawing.Size(32, 20);
            this.minSrokZalogaMaskedTextBox.TabIndex = 3;
            this.minSrokZalogaMaskedTextBox.ValidatingType = typeof(int);
            // 
            // maxSrokZalogaMaskedTextBox
            // 
            this.maxSrokZalogaMaskedTextBox.Location = new System.Drawing.Point(207, 133);
            this.maxSrokZalogaMaskedTextBox.Mask = "0000";
            this.maxSrokZalogaMaskedTextBox.Name = "maxSrokZalogaMaskedTextBox";
            this.maxSrokZalogaMaskedTextBox.Size = new System.Drawing.Size(32, 20);
            this.maxSrokZalogaMaskedTextBox.TabIndex = 4;
            this.maxSrokZalogaMaskedTextBox.ValidatingType = typeof(int);
            // 
            // razmSsudyMaskedTextBox
            // 
            this.razmSsudyMaskedTextBox.Location = new System.Drawing.Point(207, 159);
            this.razmSsudyMaskedTextBox.Mask = "00000";
            this.razmSsudyMaskedTextBox.Name = "razmSsudyMaskedTextBox";
            this.razmSsudyMaskedTextBox.Size = new System.Drawing.Size(38, 20);
            this.razmSsudyMaskedTextBox.TabIndex = 5;
            this.razmSsudyMaskedTextBox.ValidatingType = typeof(int);
            // 
            // procentPerDayMaskedTextBox
            // 
            this.procentPerDayMaskedTextBox.Location = new System.Drawing.Point(207, 185);
            this.procentPerDayMaskedTextBox.Mask = "000";
            this.procentPerDayMaskedTextBox.Name = "procentPerDayMaskedTextBox";
            this.procentPerDayMaskedTextBox.Size = new System.Drawing.Size(25, 20);
            this.procentPerDayMaskedTextBox.TabIndex = 6;
            this.procentPerDayMaskedTextBox.ValidatingType = typeof(int);
            // 
            // procentForStorageMaskedTextBox
            // 
            this.procentForStorageMaskedTextBox.Location = new System.Drawing.Point(207, 211);
            this.procentForStorageMaskedTextBox.Mask = "000";
            this.procentForStorageMaskedTextBox.Name = "procentForStorageMaskedTextBox";
            this.procentForStorageMaskedTextBox.Size = new System.Drawing.Size(25, 20);
            this.procentForStorageMaskedTextBox.TabIndex = 7;
            this.procentForStorageMaskedTextBox.ValidatingType = typeof(int);
            // 
            // garantSrokStorageMaskedTextBox
            // 
            this.garantSrokStorageMaskedTextBox.Location = new System.Drawing.Point(207, 237);
            this.garantSrokStorageMaskedTextBox.Mask = "0000";
            this.garantSrokStorageMaskedTextBox.Name = "garantSrokStorageMaskedTextBox";
            this.garantSrokStorageMaskedTextBox.Size = new System.Drawing.Size(32, 20);
            this.garantSrokStorageMaskedTextBox.TabIndex = 8;
            this.garantSrokStorageMaskedTextBox.ValidatingType = typeof(int);
            // 
            // factDataSoldMaskedTextBox
            // 
            this.factDataSoldMaskedTextBox.Location = new System.Drawing.Point(207, 263);
            this.factDataSoldMaskedTextBox.Mask = "00/00/0000";
            this.factDataSoldMaskedTextBox.Name = "factDataSoldMaskedTextBox";
            this.factDataSoldMaskedTextBox.Size = new System.Drawing.Size(62, 20);
            this.factDataSoldMaskedTextBox.TabIndex = 9;
            this.factDataSoldMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // factSummVikupaMaskedTextBox
            // 
            this.factSummVikupaMaskedTextBox.Location = new System.Drawing.Point(207, 289);
            this.factSummVikupaMaskedTextBox.Mask = "0000000000000000";
            this.factSummVikupaMaskedTextBox.Name = "factSummVikupaMaskedTextBox";
            this.factSummVikupaMaskedTextBox.Size = new System.Drawing.Size(85, 20);
            this.factSummVikupaMaskedTextBox.TabIndex = 10;
            this.factSummVikupaMaskedTextBox.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Код договора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Клиент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дата выдачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Минимальный срок залога";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Максимальный срок залога";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Размер ссуды";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Процент в день";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Процент в день за хранение";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Гарантированный срок хранения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Фактическая сумма выкупа";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Фактическая дата выкупа";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(156, 335);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(101, 40);
            this.confirmButton.TabIndex = 22;
            this.confirmButton.Text = "Text";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(233, 188);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(233, 214);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(241, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "дней";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(241, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "дней";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(241, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "дней";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(248, 162);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "руб";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(296, 292);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "руб";
            // 
            // DogovorRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 401);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.factSummVikupaMaskedTextBox);
            this.Controls.Add(this.factDataSoldMaskedTextBox);
            this.Controls.Add(this.garantSrokStorageMaskedTextBox);
            this.Controls.Add(this.procentForStorageMaskedTextBox);
            this.Controls.Add(this.procentPerDayMaskedTextBox);
            this.Controls.Add(this.razmSsudyMaskedTextBox);
            this.Controls.Add(this.maxSrokZalogaMaskedTextBox);
            this.Controls.Add(this.minSrokZalogaMaskedTextBox);
            this.Controls.Add(this.DataVidachiMaskedTextBox);
            this.Controls.Add(this.codeDogovoraComboBox);
            this.Controls.Add(this.clientIdComboBox);
            this.MaximumSize = new System.Drawing.Size(430, 440);
            this.MinimumSize = new System.Drawing.Size(430, 440);
            this.Name = "DogovorRedactor";
            this.Text = "DogovorRedactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox clientIdComboBox;
        private System.Windows.Forms.ComboBox codeDogovoraComboBox;
        private System.Windows.Forms.MaskedTextBox DataVidachiMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox minSrokZalogaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox maxSrokZalogaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox razmSsudyMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox procentPerDayMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox procentForStorageMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox garantSrokStorageMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox factDataSoldMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox factSummVikupaMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}