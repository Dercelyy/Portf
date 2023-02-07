namespace Agents
{
    partial class CityForm
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
            this.CityBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UpdateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.SearchButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SearchBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CityBox
            // 
            this.CityBox.Depth = 0;
            this.CityBox.Hint = "";
            this.CityBox.Location = new System.Drawing.Point(12, 158);
            this.CityBox.MaxLength = 32767;
            this.CityBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CityBox.Name = "CityBox";
            this.CityBox.PasswordChar = '\0';
            this.CityBox.SelectedText = "";
            this.CityBox.SelectionLength = 0;
            this.CityBox.SelectionStart = 0;
            this.CityBox.Size = new System.Drawing.Size(157, 23);
            this.CityBox.TabIndex = 9;
            this.CityBox.TabStop = false;
            this.CityBox.Text = "Введите город";
            this.CityBox.UseSystemPasswordChar = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(203, 323);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = true;
            this.DeleteButton.Size = new System.Drawing.Size(85, 36);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateButton.Depth = 0;
            this.UpdateButton.Icon = null;
            this.UpdateButton.Location = new System.Drawing.Point(203, 206);
            this.UpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Primary = true;
            this.UpdateButton.Size = new System.Drawing.Size(94, 36);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Depth = 0;
            this.AddButton.Icon = null;
            this.AddButton.Location = new System.Drawing.Point(203, 145);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.Primary = true;
            this.AddButton.Size = new System.Drawing.Size(94, 36);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MainTable
            // 
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Location = new System.Drawing.Point(12, 206);
            this.MainTable.Name = "MainTable";
            this.MainTable.Size = new System.Drawing.Size(157, 153);
            this.MainTable.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Depth = 0;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(203, 73);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Primary = true;
            this.SearchButton.Size = new System.Drawing.Size(68, 36);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Depth = 0;
            this.SearchBox.Hint = "";
            this.SearchBox.Location = new System.Drawing.Point(12, 86);
            this.SearchBox.MaxLength = 32767;
            this.SearchBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.SelectedText = "";
            this.SearchBox.SelectionLength = 0;
            this.SearchBox.SelectionStart = 0;
            this.SearchBox.Size = new System.Drawing.Size(157, 23);
            this.SearchBox.TabIndex = 9;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Введите город";
            this.SearchBox.UseSystemPasswordChar = false;
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 372);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MainTable);
            this.Name = "CityForm";
            this.Text = "Города";
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField CityBox;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton UpdateButton;
        private MaterialSkin.Controls.MaterialRaisedButton AddButton;
        private System.Windows.Forms.DataGridView MainTable;
        private MaterialSkin.Controls.MaterialRaisedButton SearchButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField SearchBox;
    }
}