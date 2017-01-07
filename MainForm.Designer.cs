namespace DatabasesProjectingTask1
{
    partial class MainForm
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
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.GetCompaniesByCandyButton = new System.Windows.Forms.Button();
            this.GetCompaniesByCandyTextBox = new System.Windows.Forms.TextBox();
            this.GetCompanyByPersonButton = new System.Windows.Forms.Button();
            this.GetCompanyByPersonTextBox = new System.Windows.Forms.TextBox();
            this.AddressesButton = new System.Windows.Forms.Button();
            this.CandiesButton = new System.Windows.Forms.Button();
            this.CompaniesButton = new System.Windows.Forms.Button();
            this.FactoriesButton = new System.Windows.Forms.Button();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.TryInsertButton = new System.Windows.Forms.Button();
            this.PersonsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(12, 42);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.Size = new System.Drawing.Size(633, 241);
            this.MainGrid.TabIndex = 0;
            // 
            // GetCompaniesByCandyButton
            // 
            this.GetCompaniesByCandyButton.Location = new System.Drawing.Point(12, 289);
            this.GetCompaniesByCandyButton.Name = "GetCompaniesByCandyButton";
            this.GetCompaniesByCandyButton.Size = new System.Drawing.Size(157, 28);
            this.GetCompaniesByCandyButton.TabIndex = 1;
            this.GetCompaniesByCandyButton.Text = "Get companies by candy";
            this.GetCompaniesByCandyButton.UseVisualStyleBackColor = true;
            this.GetCompaniesByCandyButton.Click += new System.EventHandler(this.GetCompaniesByCandyType);
            // 
            // GetCompaniesByCandyTextBox
            // 
            this.GetCompaniesByCandyTextBox.Location = new System.Drawing.Point(175, 294);
            this.GetCompaniesByCandyTextBox.Name = "GetCompaniesByCandyTextBox";
            this.GetCompaniesByCandyTextBox.Size = new System.Drawing.Size(237, 20);
            this.GetCompaniesByCandyTextBox.TabIndex = 2;
            // 
            // GetCompanyByPersonButton
            // 
            this.GetCompanyByPersonButton.Location = new System.Drawing.Point(12, 323);
            this.GetCompanyByPersonButton.Name = "GetCompanyByPersonButton";
            this.GetCompanyByPersonButton.Size = new System.Drawing.Size(157, 28);
            this.GetCompanyByPersonButton.TabIndex = 3;
            this.GetCompanyByPersonButton.Text = "Get company by person";
            this.GetCompanyByPersonButton.UseVisualStyleBackColor = true;
            this.GetCompanyByPersonButton.Click += new System.EventHandler(this.GetCompanyByPerson);
            // 
            // GetCompanyByPersonTextBox
            // 
            this.GetCompanyByPersonTextBox.Location = new System.Drawing.Point(175, 328);
            this.GetCompanyByPersonTextBox.Name = "GetCompanyByPersonTextBox";
            this.GetCompanyByPersonTextBox.Size = new System.Drawing.Size(237, 20);
            this.GetCompanyByPersonTextBox.TabIndex = 4;
            // 
            // AddressesButton
            // 
            this.AddressesButton.Location = new System.Drawing.Point(13, 13);
            this.AddressesButton.Name = "AddressesButton";
            this.AddressesButton.Size = new System.Drawing.Size(93, 23);
            this.AddressesButton.TabIndex = 5;
            this.AddressesButton.Text = "Addresses";
            this.AddressesButton.UseVisualStyleBackColor = true;
            this.AddressesButton.Click += new System.EventHandler(this.GetAllAddresses);
            // 
            // CandiesButton
            // 
            this.CandiesButton.Location = new System.Drawing.Point(145, 13);
            this.CandiesButton.Name = "CandiesButton";
            this.CandiesButton.Size = new System.Drawing.Size(83, 23);
            this.CandiesButton.TabIndex = 6;
            this.CandiesButton.Text = "Candies";
            this.CandiesButton.UseVisualStyleBackColor = true;
            this.CandiesButton.Click += new System.EventHandler(this.GetAllCandyTypes);
            // 
            // CompaniesButton
            // 
            this.CompaniesButton.Location = new System.Drawing.Point(271, 13);
            this.CompaniesButton.Name = "CompaniesButton";
            this.CompaniesButton.Size = new System.Drawing.Size(91, 23);
            this.CompaniesButton.TabIndex = 7;
            this.CompaniesButton.Text = "Companies";
            this.CompaniesButton.UseVisualStyleBackColor = true;
            this.CompaniesButton.Click += new System.EventHandler(this.GetAllCompanies);
            // 
            // FactoriesButton
            // 
            this.FactoriesButton.Location = new System.Drawing.Point(403, 13);
            this.FactoriesButton.Name = "FactoriesButton";
            this.FactoriesButton.Size = new System.Drawing.Size(101, 23);
            this.FactoriesButton.TabIndex = 8;
            this.FactoriesButton.Text = "Factories";
            this.FactoriesButton.UseVisualStyleBackColor = true;
            this.FactoriesButton.Click += new System.EventHandler(this.GetAllFactores);
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Location = new System.Drawing.Point(527, 291);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(118, 23);
            this.DeleteRowButton.TabIndex = 9;
            this.DeleteRowButton.Text = "Delete row";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // TryInsertButton
            // 
            this.TryInsertButton.Location = new System.Drawing.Point(527, 325);
            this.TryInsertButton.Name = "TryInsertButton";
            this.TryInsertButton.Size = new System.Drawing.Size(118, 23);
            this.TryInsertButton.TabIndex = 10;
            this.TryInsertButton.Text = "Try insert";
            this.TryInsertButton.UseVisualStyleBackColor = true;
            this.TryInsertButton.Click += new System.EventHandler(this.TryInsertButton_Click);
            // 
            // PersonsButton
            // 
            this.PersonsButton.Location = new System.Drawing.Point(540, 12);
            this.PersonsButton.Name = "PersonsButton";
            this.PersonsButton.Size = new System.Drawing.Size(105, 23);
            this.PersonsButton.TabIndex = 11;
            this.PersonsButton.Text = "Persons";
            this.PersonsButton.UseVisualStyleBackColor = true;
            this.PersonsButton.Click += new System.EventHandler(this.GetAllPersons);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 364);
            this.Controls.Add(this.PersonsButton);
            this.Controls.Add(this.TryInsertButton);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.FactoriesButton);
            this.Controls.Add(this.CompaniesButton);
            this.Controls.Add(this.CandiesButton);
            this.Controls.Add(this.AddressesButton);
            this.Controls.Add(this.GetCompanyByPersonTextBox);
            this.Controls.Add(this.GetCompanyByPersonButton);
            this.Controls.Add(this.GetCompaniesByCandyTextBox);
            this.Controls.Add(this.GetCompaniesByCandyButton);
            this.Controls.Add(this.MainGrid);
            this.Name = "MainForm";
            this.Text = "Working with database";
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Button GetCompaniesByCandyButton;
        private System.Windows.Forms.TextBox GetCompaniesByCandyTextBox;
        private System.Windows.Forms.Button GetCompanyByPersonButton;
        private System.Windows.Forms.TextBox GetCompanyByPersonTextBox;
        private System.Windows.Forms.Button AddressesButton;
        private System.Windows.Forms.Button CandiesButton;
        private System.Windows.Forms.Button CompaniesButton;
        private System.Windows.Forms.Button FactoriesButton;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.Button TryInsertButton;
        private System.Windows.Forms.Button PersonsButton;
    }
}

