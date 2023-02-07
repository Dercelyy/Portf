namespace Agents
{
    partial class VladForm
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
            this.SearchBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PhoneBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.FBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UpdateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SearchButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MainTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Depth = 0;
            this.SearchBox.Hint = "";
            this.SearchBox.Location = new System.Drawing.Point(4, 88);
            this.SearchBox.MaxLength = 32767;
            this.SearchBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.SelectedText = "";
            this.SearchBox.SelectionLength = 0;
            this.SearchBox.SelectionStart = 0;
            this.SearchBox.Size = new System.Drawing.Size(157, 23);
            this.SearchBox.TabIndex = 22;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Введите фамилию";
            this.SearchBox.UseSystemPasswordChar = false;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Depth = 0;
            this.PhoneBox.Hint = "";
            this.PhoneBox.Location = new System.Drawing.Point(4, 160);
            this.PhoneBox.MaxLength = 32767;
            this.PhoneBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.PasswordChar = '\0';
            this.PhoneBox.SelectedText = "";
            this.PhoneBox.SelectionLength = 0;
            this.PhoneBox.SelectionStart = 0;
            this.PhoneBox.Size = new System.Drawing.Size(157, 23);
            this.PhoneBox.TabIndex = 23;
            this.PhoneBox.TabStop = false;
            this.PhoneBox.Text = "Введите телефон";
            this.PhoneBox.UseSystemPasswordChar = false;
            // 
            // LBox
            // 
            this.LBox.Depth = 0;
            this.LBox.Hint = "";
            this.LBox.Location = new System.Drawing.Point(330, 131);
            this.LBox.MaxLength = 32767;
            this.LBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.LBox.Name = "LBox";
            this.LBox.PasswordChar = '\0';
            this.LBox.SelectedText = "";
            this.LBox.SelectionLength = 0;
            this.LBox.SelectionStart = 0;
            this.LBox.Size = new System.Drawing.Size(157, 23);
            this.LBox.TabIndex = 24;
            this.LBox.TabStop = false;
            this.LBox.Text = "Введите Отчество";
            this.LBox.UseSystemPasswordChar = false;
            // 
            // MBox
            // 
            this.MBox.Depth = 0;
            this.MBox.Hint = "";
            this.MBox.Location = new System.Drawing.Point(167, 131);
            this.MBox.MaxLength = 32767;
            this.MBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.MBox.Name = "MBox";
            this.MBox.PasswordChar = '\0';
            this.MBox.SelectedText = "";
            this.MBox.SelectionLength = 0;
            this.MBox.SelectionStart = 0;
            this.MBox.Size = new System.Drawing.Size(157, 23);
            this.MBox.TabIndex = 25;
            this.MBox.TabStop = false;
            this.MBox.Text = "Введите Имя";
            this.MBox.UseSystemPasswordChar = false;
            // 
            // FBox
            // 
            this.FBox.Depth = 0;
            this.FBox.Hint = "";
            this.FBox.Location = new System.Drawing.Point(4, 131);
            this.FBox.MaxLength = 32767;
            this.FBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.FBox.Name = "FBox";
            this.FBox.PasswordChar = '\0';
            this.FBox.SelectedText = "";
            this.FBox.SelectionLength = 0;
            this.FBox.SelectionStart = 0;
            this.FBox.Size = new System.Drawing.Size(157, 23);
            this.FBox.TabIndex = 26;
            this.FBox.TabStop = false;
            this.FBox.Text = "Введите Фамилию";
            this.FBox.UseSystemPasswordChar = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(515, 325);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = true;
            this.DeleteButton.Size = new System.Drawing.Size(85, 36);
            this.DeleteButton.TabIndex = 21;
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
            this.UpdateButton.Location = new System.Drawing.Point(515, 208);
            this.UpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Primary = true;
            this.UpdateButton.Size = new System.Drawing.Size(94, 36);
            this.UpdateButton.TabIndex = 20;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Depth = 0;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(195, 75);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Primary = true;
            this.SearchButton.Size = new System.Drawing.Size(68, 36);
            this.SearchButton.TabIndex = 18;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Depth = 0;
            this.AddButton.Icon = null;
            this.AddButton.Location = new System.Drawing.Point(515, 131);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.Primary = true;
            this.AddButton.Size = new System.Drawing.Size(94, 36);
            this.AddButton.TabIndex = 19;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MainTable
            // 
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Location = new System.Drawing.Point(4, 208);
            this.MainTable.Name = "MainTable";
            this.MainTable.Size = new System.Drawing.Size(483, 153);
            this.MainTable.TabIndex = 17;
            // 
            // VladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 382);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.LBox);
            this.Controls.Add(this.MBox);
            this.Controls.Add(this.FBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MainTable);
            this.Name = "VladForm";
            this.Text = "Владельцы";
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField SearchBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField PhoneBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField LBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField MBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField FBox;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton UpdateButton;
        private MaterialSkin.Controls.MaterialRaisedButton SearchButton;
        private MaterialSkin.Controls.MaterialRaisedButton AddButton;
        private System.Windows.Forms.DataGridView MainTable;
    }
}