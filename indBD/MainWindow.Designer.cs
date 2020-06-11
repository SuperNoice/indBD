namespace indBD
{
    partial class MainWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainDataGridView = new System.Windows.Forms.DataGridView();
            this.dogovorButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.salesButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.clientsButton = new System.Windows.Forms.Button();
            this.workersButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.reqestButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.requestСomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDataGridView
            // 
            this.mainDataGridView.AllowUserToAddRows = false;
            this.mainDataGridView.AllowUserToDeleteRows = false;
            this.mainDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.mainDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.mainDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.mainDataGridView.Location = new System.Drawing.Point(12, 82);
            this.mainDataGridView.Name = "mainDataGridView";
            this.mainDataGridView.ReadOnly = true;
            this.mainDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.mainDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.mainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mainDataGridView.Size = new System.Drawing.Size(1120, 507);
            this.mainDataGridView.TabIndex = 0;
            // 
            // dogovorButton
            // 
            this.dogovorButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dogovorButton.Location = new System.Drawing.Point(6, 19);
            this.dogovorButton.Name = "dogovorButton";
            this.dogovorButton.Size = new System.Drawing.Size(75, 38);
            this.dogovorButton.TabIndex = 1;
            this.dogovorButton.Text = "Договор";
            this.dogovorButton.UseVisualStyleBackColor = false;
            this.dogovorButton.Click += new System.EventHandler(this.dogovorButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.itemsButton.Location = new System.Drawing.Point(87, 18);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Size = new System.Drawing.Size(75, 38);
            this.itemsButton.TabIndex = 2;
            this.itemsButton.Text = "Предметы залога";
            this.itemsButton.UseVisualStyleBackColor = false;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // salesButton
            // 
            this.salesButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.salesButton.Location = new System.Drawing.Point(168, 19);
            this.salesButton.Name = "salesButton";
            this.salesButton.Size = new System.Drawing.Size(75, 38);
            this.salesButton.TabIndex = 3;
            this.salesButton.Text = "Продажи";
            this.salesButton.UseVisualStyleBackColor = false;
            this.salesButton.Click += new System.EventHandler(this.salesButton_Click);
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(249, 19);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(75, 38);
            this.categoryButton.TabIndex = 4;
            this.categoryButton.Text = "Категории";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // clientsButton
            // 
            this.clientsButton.Location = new System.Drawing.Point(330, 19);
            this.clientsButton.Name = "clientsButton";
            this.clientsButton.Size = new System.Drawing.Size(75, 38);
            this.clientsButton.TabIndex = 5;
            this.clientsButton.Text = "Клиенты";
            this.clientsButton.UseVisualStyleBackColor = true;
            this.clientsButton.Click += new System.EventHandler(this.clientsButton_Click);
            // 
            // workersButton
            // 
            this.workersButton.Location = new System.Drawing.Point(411, 19);
            this.workersButton.Name = "workersButton";
            this.workersButton.Size = new System.Drawing.Size(75, 38);
            this.workersButton.TabIndex = 6;
            this.workersButton.Text = "Сотрудники";
            this.workersButton.UseVisualStyleBackColor = true;
            this.workersButton.Click += new System.EventHandler(this.workersButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 37);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(81, 19);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 37);
            this.changeButton.TabIndex = 8;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(156, 19);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 37);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // reqestButton
            // 
            this.reqestButton.Location = new System.Drawing.Point(286, 19);
            this.reqestButton.Name = "reqestButton";
            this.reqestButton.Size = new System.Drawing.Size(75, 37);
            this.reqestButton.TabIndex = 15;
            this.reqestButton.Text = "Запрос";
            this.reqestButton.UseVisualStyleBackColor = true;
            this.reqestButton.Click += new System.EventHandler(this.reqestButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dogovorButton);
            this.groupBox1.Controls.Add(this.itemsButton);
            this.groupBox1.Controls.Add(this.salesButton);
            this.groupBox1.Controls.Add(this.categoryButton);
            this.groupBox1.Controls.Add(this.clientsButton);
            this.groupBox1.Controls.Add(this.workersButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 66);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.changeButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Location = new System.Drawing.Point(511, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 66);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.requestСomboBox);
            this.groupBox3.Controls.Add(this.reqestButton);
            this.groupBox3.Location = new System.Drawing.Point(755, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 66);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Запросы";
            // 
            // requestСomboBox
            // 
            this.requestСomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.requestСomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.requestСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.requestСomboBox.FormattingEnabled = true;
            this.requestСomboBox.Location = new System.Drawing.Point(15, 28);
            this.requestСomboBox.Name = "requestСomboBox";
            this.requestСomboBox.Size = new System.Drawing.Size(255, 21);
            this.requestСomboBox.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 601);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainDataGridView);
            this.MinimumSize = new System.Drawing.Size(1160, 200);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных ломбарда";
            ((System.ComponentModel.ISupportInitialize)(this.mainDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button dogovorButton;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Button salesButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button clientsButton;
        private System.Windows.Forms.Button workersButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button reqestButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox requestСomboBox;
        public System.Windows.Forms.DataGridView mainDataGridView;
    }
}

