namespace indBD
{
    partial class WorkersRedactor
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.workerCodeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(156, 335);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(101, 40);
            this.confirmButton.TabIndex = 80;
            this.confirmButton.Text = "Text";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Код сотрудника";
            // 
            // fioMaskedTextBox
            // 
            this.fioMaskedTextBox.Location = new System.Drawing.Point(170, 111);
            this.fioMaskedTextBox.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.fioMaskedTextBox.Name = "fioMaskedTextBox";
            this.fioMaskedTextBox.Size = new System.Drawing.Size(162, 20);
            this.fioMaskedTextBox.TabIndex = 77;
            // 
            // workerCodeComboBox
            // 
            this.workerCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerCodeComboBox.FormattingEnabled = true;
            this.workerCodeComboBox.Location = new System.Drawing.Point(170, 84);
            this.workerCodeComboBox.Name = "workerCodeComboBox";
            this.workerCodeComboBox.Size = new System.Drawing.Size(62, 21);
            this.workerCodeComboBox.TabIndex = 76;
            this.workerCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.workerCodeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Должность";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(170, 137);
            this.maskedTextBox1.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(162, 20);
            this.maskedTextBox1.TabIndex = 81;
            // 
            // WorkersRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fioMaskedTextBox);
            this.Controls.Add(this.workerCodeComboBox);
            this.MaximumSize = new System.Drawing.Size(430, 440);
            this.MinimumSize = new System.Drawing.Size(430, 440);
            this.Name = "WorkersRedactor";
            this.Text = "WorkersRedactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox fioMaskedTextBox;
        private System.Windows.Forms.ComboBox workerCodeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}