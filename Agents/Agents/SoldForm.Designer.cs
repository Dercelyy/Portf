namespace Agents
{
    partial class SoldForm
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
            this.DeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.DogBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(252, 222);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = true;
            this.DeleteButton.Size = new System.Drawing.Size(85, 36);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Depth = 0;
            this.AddButton.Icon = null;
            this.AddButton.Location = new System.Drawing.Point(243, 79);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.Primary = true;
            this.AddButton.Size = new System.Drawing.Size(94, 36);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MainTable
            // 
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Location = new System.Drawing.Point(5, 139);
            this.MainTable.Name = "MainTable";
            this.MainTable.Size = new System.Drawing.Size(241, 119);
            this.MainTable.TabIndex = 14;
            // 
            // DogBox
            // 
            this.DogBox.Depth = 0;
            this.DogBox.Hint = "";
            this.DogBox.Location = new System.Drawing.Point(5, 92);
            this.DogBox.MaxLength = 32767;
            this.DogBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.DogBox.Name = "DogBox";
            this.DogBox.PasswordChar = '\0';
            this.DogBox.SelectedText = "";
            this.DogBox.SelectionLength = 0;
            this.DogBox.SelectionStart = 0;
            this.DogBox.Size = new System.Drawing.Size(194, 23);
            this.DogBox.TabIndex = 17;
            this.DogBox.TabStop = false;
            this.DogBox.Text = "Введите номер договора";
            this.DogBox.UseSystemPasswordChar = false;
            // 
            // SoldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 270);
            this.Controls.Add(this.DogBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MainTable);
            this.Name = "SoldForm";
            this.Text = "Продано";
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton DeleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton AddButton;
        private System.Windows.Forms.DataGridView MainTable;
        private MaterialSkin.Controls.MaterialSingleLineTextField DogBox;
    }
}