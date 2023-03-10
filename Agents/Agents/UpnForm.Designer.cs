namespace Agents
{
    partial class UpnForm
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
            this.CancelButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AcceptButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ZalogBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.CityBox = new System.Windows.Forms.ComboBox();
            this.VidBox = new System.Windows.Forms.ComboBox();
            this.VladBox = new System.Windows.Forms.ComboBox();
            this.CostBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.FloorBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ComnBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.StreetBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PloshBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.NameBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton.Depth = 0;
            this.CancelButton.Icon = null;
            this.CancelButton.Location = new System.Drawing.Point(322, 423);
            this.CancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Primary = true;
            this.CancelButton.Size = new System.Drawing.Size(77, 36);
            this.CancelButton.TabIndex = 30;
            this.CancelButton.Text = "отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AcceptButton
            // 
            this.AcceptButton.AutoSize = true;
            this.AcceptButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AcceptButton.Depth = 0;
            this.AcceptButton.Icon = null;
            this.AcceptButton.Location = new System.Drawing.Point(16, 423);
            this.AcceptButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Primary = true;
            this.AcceptButton.Size = new System.Drawing.Size(84, 36);
            this.AcceptButton.TabIndex = 29;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // ZalogBox
            // 
            this.ZalogBox.AutoSize = true;
            this.ZalogBox.BackColor = System.Drawing.Color.White;
            this.ZalogBox.Depth = 0;
            this.ZalogBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.ZalogBox.Location = new System.Drawing.Point(253, 361);
            this.ZalogBox.Margin = new System.Windows.Forms.Padding(0);
            this.ZalogBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ZalogBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ZalogBox.Name = "ZalogBox";
            this.ZalogBox.Ripple = true;
            this.ZalogBox.Size = new System.Drawing.Size(26, 30);
            this.ZalogBox.TabIndex = 28;
            this.ZalogBox.UseVisualStyleBackColor = false;
            // 
            // ClassBox
            // 
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(253, 396);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(146, 21);
            this.ClassBox.TabIndex = 27;
            // 
            // CityBox
            // 
            this.CityBox.FormattingEnabled = true;
            this.CityBox.Location = new System.Drawing.Point(253, 219);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(146, 21);
            this.CityBox.TabIndex = 26;
            // 
            // VidBox
            // 
            this.VidBox.FormattingEnabled = true;
            this.VidBox.Location = new System.Drawing.Point(253, 114);
            this.VidBox.Name = "VidBox";
            this.VidBox.Size = new System.Drawing.Size(146, 21);
            this.VidBox.TabIndex = 25;
            // 
            // VladBox
            // 
            this.VladBox.FormattingEnabled = true;
            this.VladBox.Location = new System.Drawing.Point(253, 82);
            this.VladBox.Name = "VladBox";
            this.VladBox.Size = new System.Drawing.Size(146, 21);
            this.VladBox.TabIndex = 24;
            // 
            // CostBox
            // 
            this.CostBox.BackColor = System.Drawing.Color.White;
            this.CostBox.Depth = 0;
            this.CostBox.Hint = "";
            this.CostBox.Location = new System.Drawing.Point(253, 335);
            this.CostBox.MaxLength = 32767;
            this.CostBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CostBox.Name = "CostBox";
            this.CostBox.PasswordChar = '\0';
            this.CostBox.SelectedText = "";
            this.CostBox.SelectionLength = 0;
            this.CostBox.SelectionStart = 0;
            this.CostBox.Size = new System.Drawing.Size(146, 23);
            this.CostBox.TabIndex = 22;
            this.CostBox.TabStop = false;
            this.CostBox.UseSystemPasswordChar = false;
            // 
            // FloorBox
            // 
            this.FloorBox.BackColor = System.Drawing.Color.White;
            this.FloorBox.Depth = 0;
            this.FloorBox.Hint = "";
            this.FloorBox.Location = new System.Drawing.Point(253, 307);
            this.FloorBox.MaxLength = 32767;
            this.FloorBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.FloorBox.Name = "FloorBox";
            this.FloorBox.PasswordChar = '\0';
            this.FloorBox.SelectedText = "";
            this.FloorBox.SelectionLength = 0;
            this.FloorBox.SelectionStart = 0;
            this.FloorBox.Size = new System.Drawing.Size(146, 23);
            this.FloorBox.TabIndex = 21;
            this.FloorBox.TabStop = false;
            this.FloorBox.UseSystemPasswordChar = false;
            // 
            // ComnBox
            // 
            this.ComnBox.BackColor = System.Drawing.Color.White;
            this.ComnBox.Depth = 0;
            this.ComnBox.Hint = "";
            this.ComnBox.Location = new System.Drawing.Point(253, 278);
            this.ComnBox.MaxLength = 32767;
            this.ComnBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ComnBox.Name = "ComnBox";
            this.ComnBox.PasswordChar = '\0';
            this.ComnBox.SelectedText = "";
            this.ComnBox.SelectionLength = 0;
            this.ComnBox.SelectionStart = 0;
            this.ComnBox.Size = new System.Drawing.Size(146, 23);
            this.ComnBox.TabIndex = 20;
            this.ComnBox.TabStop = false;
            this.ComnBox.UseSystemPasswordChar = false;
            // 
            // StreetBox
            // 
            this.StreetBox.BackColor = System.Drawing.Color.White;
            this.StreetBox.Depth = 0;
            this.StreetBox.Hint = "";
            this.StreetBox.Location = new System.Drawing.Point(252, 246);
            this.StreetBox.MaxLength = 32767;
            this.StreetBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.PasswordChar = '\0';
            this.StreetBox.SelectedText = "";
            this.StreetBox.SelectionLength = 0;
            this.StreetBox.SelectionStart = 0;
            this.StreetBox.Size = new System.Drawing.Size(146, 23);
            this.StreetBox.TabIndex = 23;
            this.StreetBox.TabStop = false;
            this.StreetBox.UseSystemPasswordChar = false;
            // 
            // PloshBox
            // 
            this.PloshBox.BackColor = System.Drawing.Color.White;
            this.PloshBox.Depth = 0;
            this.PloshBox.Hint = "";
            this.PloshBox.Location = new System.Drawing.Point(253, 186);
            this.PloshBox.MaxLength = 32767;
            this.PloshBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PloshBox.Name = "PloshBox";
            this.PloshBox.PasswordChar = '\0';
            this.PloshBox.SelectedText = "";
            this.PloshBox.SelectionLength = 0;
            this.PloshBox.SelectionStart = 0;
            this.PloshBox.Size = new System.Drawing.Size(146, 23);
            this.PloshBox.TabIndex = 19;
            this.PloshBox.TabStop = false;
            this.PloshBox.UseSystemPasswordChar = false;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.White;
            this.NameBox.Depth = 0;
            this.NameBox.Hint = "";
            this.NameBox.Location = new System.Drawing.Point(253, 145);
            this.NameBox.MaxLength = 32767;
            this.NameBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameBox.Name = "NameBox";
            this.NameBox.PasswordChar = '\0';
            this.NameBox.SelectedText = "";
            this.NameBox.SelectionLength = 0;
            this.NameBox.SelectionStart = 0;
            this.NameBox.Size = new System.Drawing.Size(146, 23);
            this.NameBox.TabIndex = 18;
            this.NameBox.TabStop = false;
            this.NameBox.UseSystemPasswordChar = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.White;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(12, 398);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(235, 19);
            this.materialLabel11.TabIndex = 17;
            this.materialLabel11.Text = "Выберите класс недвижимости";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.White;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(12, 369);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(50, 19);
            this.materialLabel10.TabIndex = 16;
            this.materialLabel10.Text = "Залог";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.White;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(12, 339);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(148, 19);
            this.materialLabel9.TabIndex = 15;
            this.materialLabel9.Text = "Введите стоимость";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.White;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(12, 311);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(106, 19);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "Введите этаж";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.White;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(12, 281);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(212, 19);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Введите количество комнат";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.White;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 250);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(113, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Введите улицу";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.White;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 221);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(123, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Выберите город";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.White;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 190);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(136, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Введите площадь";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 149);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(140, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Введите название";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 116);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(221, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Выберите вид недвижимости";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 84);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(159, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Выберите владельца";
            // 
            // UpnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 471);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ZalogBox);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.VidBox);
            this.Controls.Add(this.VladBox);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.FloorBox);
            this.Controls.Add(this.ComnBox);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.PloshBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "UpnForm";
            this.Text = "UpnForm";
            this.Load += new System.EventHandler(this.UpnForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton CancelButton;
        private MaterialSkin.Controls.MaterialRaisedButton AcceptButton;
        private MaterialSkin.Controls.MaterialCheckBox ZalogBox;
        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.ComboBox CityBox;
        private System.Windows.Forms.ComboBox VidBox;
        private System.Windows.Forms.ComboBox VladBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField CostBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField FloorBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField ComnBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField StreetBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField PloshBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField NameBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}