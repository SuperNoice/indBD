namespace indBD
{
    partial class CategoryRedactor
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
            this.itemNameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.categoryCodeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Код категории";
            // 
            // itemNameMaskedTextBox
            // 
            this.itemNameMaskedTextBox.Location = new System.Drawing.Point(172, 170);
            this.itemNameMaskedTextBox.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.itemNameMaskedTextBox.Name = "itemNameMaskedTextBox";
            this.itemNameMaskedTextBox.Size = new System.Drawing.Size(162, 20);
            this.itemNameMaskedTextBox.TabIndex = 61;
            // 
            // categoryCodeComboBox
            // 
            this.categoryCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryCodeComboBox.FormattingEnabled = true;
            this.categoryCodeComboBox.Location = new System.Drawing.Point(172, 143);
            this.categoryCodeComboBox.Name = "categoryCodeComboBox";
            this.categoryCodeComboBox.Size = new System.Drawing.Size(62, 21);
            this.categoryCodeComboBox.TabIndex = 59;
            this.categoryCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryCodeComboBox_SelectedIndexChanged);
            // 
            // CategoryRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 401);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemNameMaskedTextBox);
            this.Controls.Add(this.categoryCodeComboBox);
            this.MaximumSize = new System.Drawing.Size(430, 440);
            this.MinimumSize = new System.Drawing.Size(430, 440);
            this.Name = "CategoryRedactor";
            this.Text = "CategoryRedactor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox itemNameMaskedTextBox;
        private System.Windows.Forms.ComboBox categoryCodeComboBox;
    }
}