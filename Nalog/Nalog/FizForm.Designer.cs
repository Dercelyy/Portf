namespace Nalog
{
    partial class FizForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.AddButton = new System.Windows.Forms.Button();
            this.CityBox = new System.Windows.Forms.ComboBox();
            this.FiltrButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Введите Фамилию";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(123, 6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(126, 20);
            this.SearchBox.TabIndex = 16;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(514, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 41);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(433, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 41);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(257, 4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainTable
            // 
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Location = new System.Drawing.Point(12, 51);
            this.MainTable.Name = "MainTable";
            this.MainTable.Size = new System.Drawing.Size(885, 239);
            this.MainTable.TabIndex = 10;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(352, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 41);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CityBox
            // 
            this.CityBox.FormattingEnabled = true;
            this.CityBox.Location = new System.Drawing.Point(695, 14);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(121, 21);
            this.CityBox.TabIndex = 20;
            this.CityBox.SelectedIndexChanged += new System.EventHandler(this.CityBox_SelectedIndexChanged);
            // 
            // FiltrButton
            // 
            this.FiltrButton.Location = new System.Drawing.Point(822, 13);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrButton.TabIndex = 13;
            this.FiltrButton.Text = "Сбросить фильтр";
            this.FiltrButton.UseVisualStyleBackColor = true;
            this.FiltrButton.Click += new System.EventHandler(this.FiltrButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Выберите город";
            // 
            // FizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 304);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.FiltrButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MainTable);
            this.Name = "FizForm";
            this.Text = "FizForm";
            this.Load += new System.EventHandler(this.FizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView MainTable;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox CityBox;
        private System.Windows.Forms.Button FiltrButton;
        private System.Windows.Forms.Label label1;
    }
}