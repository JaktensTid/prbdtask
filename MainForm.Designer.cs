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
            this.GetAlbumsByArtistButton = new System.Windows.Forms.Button();
            this.GetAlbumsByArtistTextBox = new System.Windows.Forms.TextBox();
            this.GetSongsByAlbumButton = new System.Windows.Forms.Button();
            this.GetSongsByAlbumTextBox = new System.Windows.Forms.TextBox();
            this.GetAllArtistButton = new System.Windows.Forms.Button();
            this.GetAllAlbumsButton = new System.Windows.Forms.Button();
            this.GetAllSongsButton = new System.Windows.Forms.Button();
            this.GetAllLabelsButton = new System.Windows.Forms.Button();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.TryInsertButton = new System.Windows.Forms.Button();
            this.GetAllPerformances = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(12, 42);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.Size = new System.Drawing.Size(482, 241);
            this.MainGrid.TabIndex = 0;
            // 
            // GetAlbumsByArtistButton
            // 
            this.GetAlbumsByArtistButton.Location = new System.Drawing.Point(12, 289);
            this.GetAlbumsByArtistButton.Name = "GetAlbumsByArtistButton";
            this.GetAlbumsByArtistButton.Size = new System.Drawing.Size(157, 28);
            this.GetAlbumsByArtistButton.TabIndex = 1;
            this.GetAlbumsByArtistButton.Text = "Get albums by artist";
            this.GetAlbumsByArtistButton.UseVisualStyleBackColor = true;
            this.GetAlbumsByArtistButton.Click += new System.EventHandler(this.GetAlbumsByArtistButton_Click);
            // 
            // GetAlbumsByArtistTextBox
            // 
            this.GetAlbumsByArtistTextBox.Location = new System.Drawing.Point(175, 294);
            this.GetAlbumsByArtistTextBox.Name = "GetAlbumsByArtistTextBox";
            this.GetAlbumsByArtistTextBox.Size = new System.Drawing.Size(187, 20);
            this.GetAlbumsByArtistTextBox.TabIndex = 2;
            // 
            // GetSongsByAlbumButton
            // 
            this.GetSongsByAlbumButton.Location = new System.Drawing.Point(12, 323);
            this.GetSongsByAlbumButton.Name = "GetSongsByAlbumButton";
            this.GetSongsByAlbumButton.Size = new System.Drawing.Size(157, 28);
            this.GetSongsByAlbumButton.TabIndex = 3;
            this.GetSongsByAlbumButton.Text = "Get songs by album";
            this.GetSongsByAlbumButton.UseVisualStyleBackColor = true;
            this.GetSongsByAlbumButton.Click += new System.EventHandler(this.GetSongsByAlbumButton_Click);
            // 
            // GetSongsByAlbumTextBox
            // 
            this.GetSongsByAlbumTextBox.Location = new System.Drawing.Point(175, 328);
            this.GetSongsByAlbumTextBox.Name = "GetSongsByAlbumTextBox";
            this.GetSongsByAlbumTextBox.Size = new System.Drawing.Size(187, 20);
            this.GetSongsByAlbumTextBox.TabIndex = 4;
            // 
            // GetAllArtistButton
            // 
            this.GetAllArtistButton.Location = new System.Drawing.Point(13, 13);
            this.GetAllArtistButton.Name = "GetAllArtistButton";
            this.GetAllArtistButton.Size = new System.Drawing.Size(93, 23);
            this.GetAllArtistButton.TabIndex = 5;
            this.GetAllArtistButton.Text = "Get all artists";
            this.GetAllArtistButton.UseVisualStyleBackColor = true;
            this.GetAllArtistButton.Click += new System.EventHandler(this.GetAllArtistButton_Click);
            // 
            // GetAllAlbumsButton
            // 
            this.GetAllAlbumsButton.Location = new System.Drawing.Point(112, 13);
            this.GetAllAlbumsButton.Name = "GetAllAlbumsButton";
            this.GetAllAlbumsButton.Size = new System.Drawing.Size(83, 23);
            this.GetAllAlbumsButton.TabIndex = 6;
            this.GetAllAlbumsButton.Text = "Get all albums";
            this.GetAllAlbumsButton.UseVisualStyleBackColor = true;
            this.GetAllAlbumsButton.Click += new System.EventHandler(this.GetAllAlbumsButton_Click);
            // 
            // GetAllSongsButton
            // 
            this.GetAllSongsButton.Location = new System.Drawing.Point(201, 12);
            this.GetAllSongsButton.Name = "GetAllSongsButton";
            this.GetAllSongsButton.Size = new System.Drawing.Size(91, 23);
            this.GetAllSongsButton.TabIndex = 7;
            this.GetAllSongsButton.Text = "Get all songs";
            this.GetAllSongsButton.UseVisualStyleBackColor = true;
            this.GetAllSongsButton.Click += new System.EventHandler(this.GetAllSongsButton_Click);
            // 
            // GetAllLabelsButton
            // 
            this.GetAllLabelsButton.Location = new System.Drawing.Point(298, 13);
            this.GetAllLabelsButton.Name = "GetAllLabelsButton";
            this.GetAllLabelsButton.Size = new System.Drawing.Size(101, 23);
            this.GetAllLabelsButton.TabIndex = 8;
            this.GetAllLabelsButton.Text = "Get all labels";
            this.GetAllLabelsButton.UseVisualStyleBackColor = true;
            this.GetAllLabelsButton.Click += new System.EventHandler(this.GetAllLabelsButton_Click);
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Location = new System.Drawing.Point(419, 289);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteRowButton.TabIndex = 9;
            this.DeleteRowButton.Text = "Delete row";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // TryInsertButton
            // 
            this.TryInsertButton.Location = new System.Drawing.Point(419, 318);
            this.TryInsertButton.Name = "TryInsertButton";
            this.TryInsertButton.Size = new System.Drawing.Size(75, 23);
            this.TryInsertButton.TabIndex = 10;
            this.TryInsertButton.Text = "Try insert";
            this.TryInsertButton.UseVisualStyleBackColor = true;
            this.TryInsertButton.Click += new System.EventHandler(this.TryInsertButton_Click);
            // 
            // GetAllPerformances
            // 
            this.GetAllPerformances.Location = new System.Drawing.Point(406, 12);
            this.GetAllPerformances.Name = "GetAllPerformances";
            this.GetAllPerformances.Size = new System.Drawing.Size(88, 23);
            this.GetAllPerformances.TabIndex = 11;
            this.GetAllPerformances.Text = "Get all perf";
            this.GetAllPerformances.UseVisualStyleBackColor = true;
            this.GetAllPerformances.Click += new System.EventHandler(this.GetAllPerformances_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 364);
            this.Controls.Add(this.GetAllPerformances);
            this.Controls.Add(this.TryInsertButton);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.GetAllLabelsButton);
            this.Controls.Add(this.GetAllSongsButton);
            this.Controls.Add(this.GetAllAlbumsButton);
            this.Controls.Add(this.GetAllArtistButton);
            this.Controls.Add(this.GetSongsByAlbumTextBox);
            this.Controls.Add(this.GetSongsByAlbumButton);
            this.Controls.Add(this.GetAlbumsByArtistTextBox);
            this.Controls.Add(this.GetAlbumsByArtistButton);
            this.Controls.Add(this.MainGrid);
            this.Name = "MainForm";
            this.Text = "Working with database";
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Button GetAlbumsByArtistButton;
        private System.Windows.Forms.TextBox GetAlbumsByArtistTextBox;
        private System.Windows.Forms.Button GetSongsByAlbumButton;
        private System.Windows.Forms.TextBox GetSongsByAlbumTextBox;
        private System.Windows.Forms.Button GetAllArtistButton;
        private System.Windows.Forms.Button GetAllAlbumsButton;
        private System.Windows.Forms.Button GetAllSongsButton;
        private System.Windows.Forms.Button GetAllLabelsButton;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.Button TryInsertButton;
        private System.Windows.Forms.Button GetAllPerformances;
    }
}

