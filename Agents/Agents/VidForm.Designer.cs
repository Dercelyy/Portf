namespace Agents
{
    partial class VidForm
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
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.AddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UpdateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.VidBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Location = new System.Drawing.Point(12, 136);
            this.MainTable.Name = "MainTable";
            this.MainTable.Size = new System.Drawing.Size(127, 153);
            this.MainTable.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Depth = 0;
            this.AddButton.Icon = null;
            this.AddButton.Location = new System.Drawing.Point(203, 75);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.Primary = true;
            this.AddButton.Size = new System.Drawing.Size(94, 36);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateButton.Depth = 0;
            this.UpdateButton.Icon = null;
            this.UpdateButton.Location = new System.Drawing.Point(203, 136);
            this.UpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Primary = true;
            this.UpdateButton.Size = new System.Drawing.Size(94, 36);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(203, 253);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = true;
            this.DeleteButton.Size = new System.Drawing.Size(94, 36);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // VidBox
            // 
            this.VidBox.Depth = 0;
            this.VidBox.Hint = "";
            this.VidBox.Location = new System.Drawing.Point(12, 88);
            this.VidBox.MaxLength = 32767;
            this.VidBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.VidBox.Name = "VidBox";
            this.VidBox.PasswordChar = '\0';
            this.VidBox.SelectedText = "";
            this.VidBox.SelectionLength = 0;
            this.VidBox.SelectionStart = 0;
            this.VidBox.Size = new System.Drawing.Size(127, 23);
            this.VidBox.TabIndex = 4;
            this.VidBox.TabStop = false;
            this.VidBox.Text = "Введите вид";
            this.VidBox.UseSystemPasswordChar = false;
            // 
            // VidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 301);
            this.Controls.Add(this.VidBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MainTable);
            this.Name = "VidForm";
            this.Text = "Виды недвижимости";
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainTable;
        private MaterialSkin.Controls.MaterialRaisedButton AddButton;
        private MaterialSkin.Controls.MaterialRaisedButton UpdateButton;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField VidBox;
    }
}