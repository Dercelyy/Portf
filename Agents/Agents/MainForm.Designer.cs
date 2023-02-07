namespace Agents
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
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.SearchButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SearchBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AddButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.UpdateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DeleteButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.vidButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cityButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.classButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.agentButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.VladButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ClientButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.DogovorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SoldButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.CityBox = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.sbrosButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Location = new System.Drawing.Point(12, 108);
            this.MainTable.Name = "MainTable";
            this.MainTable.Size = new System.Drawing.Size(1138, 330);
            this.MainTable.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Depth = 0;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(372, 66);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Primary = true;
            this.SearchButton.Size = new System.Drawing.Size(68, 36);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 74);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(222, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Введите фамилию Владельца";
            // 
            // SearchBox
            // 
            this.SearchBox.Depth = 0;
            this.SearchBox.Hint = "";
            this.SearchBox.Location = new System.Drawing.Point(236, 70);
            this.SearchBox.MaxLength = 32767;
            this.SearchBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.SelectedText = "";
            this.SearchBox.SelectionLength = 0;
            this.SearchBox.SelectionStart = 0;
            this.SearchBox.Size = new System.Drawing.Size(114, 23);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.TabStop = false;
            this.SearchBox.UseSystemPasswordChar = false;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Depth = 0;
            this.AddButton.Icon = null;
            this.AddButton.Location = new System.Drawing.Point(446, 66);
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
            this.UpdateButton.Location = new System.Drawing.Point(546, 66);
            this.UpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Primary = true;
            this.UpdateButton.Size = new System.Drawing.Size(94, 36);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(646, 66);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = true;
            this.DeleteButton.Size = new System.Drawing.Size(85, 36);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // vidButton
            // 
            this.vidButton.AutoSize = true;
            this.vidButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vidButton.Depth = 0;
            this.vidButton.Icon = null;
            this.vidButton.Location = new System.Drawing.Point(12, 444);
            this.vidButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.vidButton.Name = "vidButton";
            this.vidButton.Primary = true;
            this.vidButton.Size = new System.Drawing.Size(171, 36);
            this.vidButton.TabIndex = 1;
            this.vidButton.Text = "Вид недвижимости";
            this.vidButton.UseVisualStyleBackColor = true;
            this.vidButton.Click += new System.EventHandler(this.vidButton_Click);
            // 
            // cityButton
            // 
            this.cityButton.AutoSize = true;
            this.cityButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cityButton.Depth = 0;
            this.cityButton.Icon = null;
            this.cityButton.Location = new System.Drawing.Point(186, 444);
            this.cityButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cityButton.Name = "cityButton";
            this.cityButton.Primary = true;
            this.cityButton.Size = new System.Drawing.Size(67, 36);
            this.cityButton.TabIndex = 1;
            this.cityButton.Text = "Город";
            this.cityButton.UseVisualStyleBackColor = true;
            this.cityButton.Click += new System.EventHandler(this.cityButton_Click);
            // 
            // classButton
            // 
            this.classButton.AutoSize = true;
            this.classButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.classButton.Depth = 0;
            this.classButton.Icon = null;
            this.classButton.Location = new System.Drawing.Point(259, 444);
            this.classButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.classButton.Name = "classButton";
            this.classButton.Primary = true;
            this.classButton.Size = new System.Drawing.Size(188, 36);
            this.classButton.TabIndex = 1;
            this.classButton.Text = "Класс недвижимости";
            this.classButton.UseVisualStyleBackColor = true;
            this.classButton.Click += new System.EventHandler(this.classButton_Click);
            // 
            // agentButton
            // 
            this.agentButton.AutoSize = true;
            this.agentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agentButton.Depth = 0;
            this.agentButton.Icon = null;
            this.agentButton.Location = new System.Drawing.Point(453, 444);
            this.agentButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.agentButton.Name = "agentButton";
            this.agentButton.Primary = true;
            this.agentButton.Size = new System.Drawing.Size(76, 36);
            this.agentButton.TabIndex = 1;
            this.agentButton.Text = "Агенты";
            this.agentButton.UseVisualStyleBackColor = true;
            this.agentButton.Click += new System.EventHandler(this.agentButton_Click);
            // 
            // VladButton
            // 
            this.VladButton.AutoSize = true;
            this.VladButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VladButton.Depth = 0;
            this.VladButton.Icon = null;
            this.VladButton.Location = new System.Drawing.Point(535, 444);
            this.VladButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.VladButton.Name = "VladButton";
            this.VladButton.Primary = true;
            this.VladButton.Size = new System.Drawing.Size(107, 36);
            this.VladButton.TabIndex = 1;
            this.VladButton.Text = "Владельцы";
            this.VladButton.UseVisualStyleBackColor = true;
            this.VladButton.Click += new System.EventHandler(this.VladButton_Click);
            // 
            // ClientButton
            // 
            this.ClientButton.AutoSize = true;
            this.ClientButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientButton.Depth = 0;
            this.ClientButton.Icon = null;
            this.ClientButton.Location = new System.Drawing.Point(648, 444);
            this.ClientButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Primary = true;
            this.ClientButton.Size = new System.Drawing.Size(87, 36);
            this.ClientButton.TabIndex = 1;
            this.ClientButton.Text = "Клиенты";
            this.ClientButton.UseVisualStyleBackColor = true;
            this.ClientButton.Click += new System.EventHandler(this.ClientButton_Click);
            // 
            // DogovorButton
            // 
            this.DogovorButton.AutoSize = true;
            this.DogovorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DogovorButton.Depth = 0;
            this.DogovorButton.Icon = null;
            this.DogovorButton.Location = new System.Drawing.Point(741, 444);
            this.DogovorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DogovorButton.Name = "DogovorButton";
            this.DogovorButton.Primary = true;
            this.DogovorButton.Size = new System.Drawing.Size(85, 36);
            this.DogovorButton.TabIndex = 1;
            this.DogovorButton.Text = "Договор";
            this.DogovorButton.UseVisualStyleBackColor = true;
            this.DogovorButton.Click += new System.EventHandler(this.DogovorButton_Click);
            // 
            // SoldButton
            // 
            this.SoldButton.AutoSize = true;
            this.SoldButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SoldButton.Depth = 0;
            this.SoldButton.Icon = null;
            this.SoldButton.Location = new System.Drawing.Point(832, 444);
            this.SoldButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SoldButton.Name = "SoldButton";
            this.SoldButton.Primary = true;
            this.SoldButton.Size = new System.Drawing.Size(88, 36);
            this.SoldButton.TabIndex = 1;
            this.SoldButton.Text = "Продано";
            this.SoldButton.UseVisualStyleBackColor = true;
            this.SoldButton.Click += new System.EventHandler(this.SoldButton_Click);
            // 
            // CityBox
            // 
            this.CityBox.FormattingEnabled = true;
            this.CityBox.Location = new System.Drawing.Point(866, 72);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(121, 21);
            this.CityBox.TabIndex = 4;
            this.CityBox.SelectedIndexChanged += new System.EventHandler(this.CityBox_SelectedIndexChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(737, 74);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(123, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Выберите город";
            // 
            // sbrosButton
            // 
            this.sbrosButton.AutoSize = true;
            this.sbrosButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sbrosButton.Depth = 0;
            this.sbrosButton.Icon = null;
            this.sbrosButton.Location = new System.Drawing.Point(998, 66);
            this.sbrosButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sbrosButton.Name = "sbrosButton";
            this.sbrosButton.Primary = true;
            this.sbrosButton.Size = new System.Drawing.Size(152, 36);
            this.sbrosButton.TabIndex = 1;
            this.sbrosButton.Text = "сбросить фильтр";
            this.sbrosButton.UseVisualStyleBackColor = true;
            this.sbrosButton.Click += new System.EventHandler(this.sbrosButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 488);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.SoldButton);
            this.Controls.Add(this.DogovorButton);
            this.Controls.Add(this.ClientButton);
            this.Controls.Add(this.VladButton);
            this.Controls.Add(this.agentButton);
            this.Controls.Add(this.classButton);
            this.Controls.Add(this.cityButton);
            this.Controls.Add(this.vidButton);
            this.Controls.Add(this.sbrosButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MainTable);
            this.Name = "MainForm";
            this.Text = "Недвижимость";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainTable;
        private MaterialSkin.Controls.MaterialRaisedButton SearchButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField SearchBox;
        private MaterialSkin.Controls.MaterialRaisedButton AddButton;
        private MaterialSkin.Controls.MaterialRaisedButton UpdateButton;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteButton;
        private MaterialSkin.Controls.MaterialRaisedButton vidButton;
        private MaterialSkin.Controls.MaterialRaisedButton cityButton;
        private MaterialSkin.Controls.MaterialRaisedButton classButton;
        private MaterialSkin.Controls.MaterialRaisedButton agentButton;
        private MaterialSkin.Controls.MaterialRaisedButton VladButton;
        private MaterialSkin.Controls.MaterialRaisedButton ClientButton;
        private MaterialSkin.Controls.MaterialRaisedButton DogovorButton;
        private MaterialSkin.Controls.MaterialRaisedButton SoldButton;
        private System.Windows.Forms.ComboBox CityBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton sbrosButton;
    }
}

