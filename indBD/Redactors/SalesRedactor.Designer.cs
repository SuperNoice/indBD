namespace indBD
{
    partial class SalesRedactor
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
            this.label8 = new System.Windows.Forms.Label();
            this.workerСomboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.soldDataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.costMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.saleCodeComboBox = new System.Windows.Forms.ComboBox();
            this.uchetniyCodeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Сотрудник";
            // 
            // workerСomboBox
            // 
            this.workerСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerСomboBox.FormattingEnabled = true;
            this.workerСomboBox.Location = new System.Drawing.Point(195, 150);
            this.workerСomboBox.Name = "workerСomboBox";
            this.workerСomboBox.Size = new System.Drawing.Size(62, 21);
            this.workerСomboBox.TabIndex = 76;
            this.workerСomboBox.SelectedIndexChanged += new System.EventHandler(this.workerСomboBox_SelectedIndexChanged);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(156, 335);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(101, 40);
            this.confirmButton.TabIndex = 75;
            this.confirmButton.Text = "Text";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(109, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Дата продажи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Цена продажи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Учётный код";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Код продажи";
            // 
            // soldDataMaskedTextBox
            // 
            this.soldDataMaskedTextBox.Location = new System.Drawing.Point(195, 177);
            this.soldDataMaskedTextBox.Mask = "00/00/0000";
            this.soldDataMaskedTextBox.Name = "soldDataMaskedTextBox";
            this.soldDataMaskedTextBox.Size = new System.Drawing.Size(62, 20);
            this.soldDataMaskedTextBox.TabIndex = 66;
            this.soldDataMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // costMaskedTextBox
            // 
            this.costMaskedTextBox.Location = new System.Drawing.Point(195, 124);
            this.costMaskedTextBox.Mask = "0000000000000000000000000000000000";
            this.costMaskedTextBox.Name = "costMaskedTextBox";
            this.costMaskedTextBox.Size = new System.Drawing.Size(126, 20);
            this.costMaskedTextBox.TabIndex = 61;
            // 
            // saleCodeComboBox
            // 
            this.saleCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.saleCodeComboBox.FormattingEnabled = true;
            this.saleCodeComboBox.Location = new System.Drawing.Point(195, 70);
            this.saleCodeComboBox.Name = "saleCodeComboBox";
            this.saleCodeComboBox.Size = new System.Drawing.Size(62, 21);
            this.saleCodeComboBox.TabIndex = 60;
            this.saleCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.saleCodeComboBox_SelectedIndexChanged);
            // 
            // uchetniyCodeComboBox
            // 
            this.uchetniyCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uchetniyCodeComboBox.FormattingEnabled = true;
            this.uchetniyCodeComboBox.Location = new System.Drawing.Point(195, 97);
            this.uchetniyCodeComboBox.Name = "uchetniyCodeComboBox";
            this.uchetniyCodeComboBox.Size = new System.Drawing.Size(62, 21);
            this.uchetniyCodeComboBox.TabIndex = 59;
            this.uchetniyCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.uchetniyCodeComboBox_SelectedIndexChanged);
            // 
            // SalesRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 401);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.workerСomboBox);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.soldDataMaskedTextBox);
            this.Controls.Add(this.costMaskedTextBox);
            this.Controls.Add(this.saleCodeComboBox);
            this.Controls.Add(this.uchetniyCodeComboBox);
            this.MaximumSize = new System.Drawing.Size(430, 440);
            this.MinimumSize = new System.Drawing.Size(430, 440);
            this.Name = "SalesRedactor";
            this.Text = "SalesRedactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox workerСomboBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox soldDataMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox costMaskedTextBox;
        private System.Windows.Forms.ComboBox saleCodeComboBox;
        private System.Windows.Forms.ComboBox uchetniyCodeComboBox;
    }
}