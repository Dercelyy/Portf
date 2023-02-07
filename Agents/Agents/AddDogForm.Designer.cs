namespace Agents
{
    partial class AddDogForm
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
            this.NedvishBox = new System.Windows.Forms.ComboBox();
            this.VladBox = new System.Windows.Forms.ComboBox();
            this.AgentBox = new System.Windows.Forms.ComboBox();
            this.ClientBox = new System.Windows.Forms.ComboBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
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
            this.CancelButton.Location = new System.Drawing.Point(320, 209);
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
            this.AcceptButton.Location = new System.Drawing.Point(14, 209);
            this.AcceptButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Primary = true;
            this.AcceptButton.Size = new System.Drawing.Size(84, 36);
            this.AcceptButton.TabIndex = 29;
            this.AcceptButton.Text = "Принять";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // NedvishBox
            // 
            this.NedvishBox.FormattingEnabled = true;
            this.NedvishBox.Location = new System.Drawing.Point(251, 174);
            this.NedvishBox.Name = "NedvishBox";
            this.NedvishBox.Size = new System.Drawing.Size(146, 21);
            this.NedvishBox.TabIndex = 27;
            // 
            // VladBox
            // 
            this.VladBox.FormattingEnabled = true;
            this.VladBox.Location = new System.Drawing.Point(251, 142);
            this.VladBox.Name = "VladBox";
            this.VladBox.Size = new System.Drawing.Size(146, 21);
            this.VladBox.TabIndex = 26;
            this.VladBox.SelectedIndexChanged += new System.EventHandler(this.VladBox_SelectedIndexChanged);
            // 
            // AgentBox
            // 
            this.AgentBox.FormattingEnabled = true;
            this.AgentBox.Location = new System.Drawing.Point(251, 109);
            this.AgentBox.Name = "AgentBox";
            this.AgentBox.Size = new System.Drawing.Size(146, 21);
            this.AgentBox.TabIndex = 25;
            // 
            // ClientBox
            // 
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Location = new System.Drawing.Point(251, 77);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(146, 21);
            this.ClientBox.TabIndex = 24;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.White;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(10, 176);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(189, 19);
            this.materialLabel11.TabIndex = 17;
            this.materialLabel11.Text = "Выберите недвижимость";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.White;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 111);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(128, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Выберите агента";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(10, 79);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(140, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Выберите клиента";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(10, 144);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(159, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Выберите владельца";
            // 
            // AddDogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 266);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.NedvishBox);
            this.Controls.Add(this.VladBox);
            this.Controls.Add(this.AgentBox);
            this.Controls.Add(this.ClientBox);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "AddDogForm";
            this.Text = "Добавление договора";
            this.Load += new System.EventHandler(this.AddDogForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton CancelButton;
        private MaterialSkin.Controls.MaterialRaisedButton AcceptButton;
        private System.Windows.Forms.ComboBox NedvishBox;
        private System.Windows.Forms.ComboBox VladBox;
        private System.Windows.Forms.ComboBox AgentBox;
        private System.Windows.Forms.ComboBox ClientBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}