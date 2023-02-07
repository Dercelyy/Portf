namespace Agents
{
    partial class ClassForm
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
            this.ClassBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.DeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UpdateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MainTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassBox
            // 
            this.ClassBox.Depth = 0;
            this.ClassBox.Hint = "";
            this.ClassBox.Location = new System.Drawing.Point(12, 85);
            this.ClassBox.MaxLength = 32767;
            this.ClassBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.PasswordChar = '\0';
            this.ClassBox.SelectedText = "";
            this.ClassBox.SelectionLength = 0;
            this.ClassBox.SelectionStart = 0;
            this.ClassBox.Size = new System.Drawing.Size(147, 23);
            this.ClassBox.TabIndex = 14;
            this.ClassBox.TabStop = false;
            this.ClassBox.Text = "Введите класс";
            this.ClassBox.UseSystemPasswordChar = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(203, 250);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = true;
            this.DeleteButton.Size = new System.Drawing.Size(85, 36);
            this.DeleteButton.TabIndex = 13;
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
            this.UpdateButton.Location = new System.Drawing.Point(203, 133);
            this.UpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Primary = true;
            this.UpdateButton.Size = new System.Drawing.Size(94, 36);
            this.UpdateButton.TabIndex = 12;
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
            this.AddButton.Location = new System.Drawing.Point(203, 72);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.Primary = true;
            this.AddButton.Size = new System.Drawing.Size(94, 36);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MainTable
            // 
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Location = new System.Drawing.Point(12, 133);
            this.MainTable.Name = "MainTable";
            this.MainTable.Size = new System.Drawing.Size(147, 153);
            this.MainTable.TabIndex = 10;
            // 
            // ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 299);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MainTable);
            this.Name = "ClassForm";
            this.Text = "Класс недвижимости";
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField ClassBox;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton UpdateButton;
        private MaterialSkin.Controls.MaterialRaisedButton AddButton;
        private System.Windows.Forms.DataGridView MainTable;
    }
}