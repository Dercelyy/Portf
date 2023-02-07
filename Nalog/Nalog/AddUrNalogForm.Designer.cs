namespace Nalog
{
    partial class AddUrNalogForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.VidBox = new System.Windows.Forms.ComboBox();
            this.InnBox = new System.Windows.Forms.ComboBox();
            this.SummBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateOplBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SummOplBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DateOBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.VidBox);
            this.groupBox1.Controls.Add(this.InnBox);
            this.groupBox1.Controls.Add(this.SummBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DateOplBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SummOplBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DateOBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 273);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление налога юр лица";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(244, 209);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // VidBox
            // 
            this.VidBox.FormattingEnabled = true;
            this.VidBox.Location = new System.Drawing.Point(198, 25);
            this.VidBox.Name = "VidBox";
            this.VidBox.Size = new System.Drawing.Size(126, 21);
            this.VidBox.TabIndex = 21;
            // 
            // InnBox
            // 
            this.InnBox.FormattingEnabled = true;
            this.InnBox.Location = new System.Drawing.Point(198, 52);
            this.InnBox.Name = "InnBox";
            this.InnBox.Size = new System.Drawing.Size(126, 21);
            this.InnBox.TabIndex = 21;
            // 
            // SummBox
            // 
            this.SummBox.Location = new System.Drawing.Point(198, 89);
            this.SummBox.Name = "SummBox";
            this.SummBox.Size = new System.Drawing.Size(126, 20);
            this.SummBox.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(249, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Location = new System.Drawing.Point(9, 235);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(185, 32);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Введите сумму оплаты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Выберите вид налога";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Введите дату получения извещения";
            // 
            // DateOplBox
            // 
            this.DateOplBox.Location = new System.Drawing.Point(198, 152);
            this.DateOplBox.Name = "DateOplBox";
            this.DateOplBox.Size = new System.Drawing.Size(126, 20);
            this.DateOplBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Выберите ИНН юр лица";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Введите облагаемую сумму";
            // 
            // SummOplBox
            // 
            this.SummOplBox.Location = new System.Drawing.Point(198, 183);
            this.SummOplBox.Name = "SummOplBox";
            this.SummOplBox.Size = new System.Drawing.Size(126, 20);
            this.SummOplBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Введите дату оплаты";
            // 
            // DateOBox
            // 
            this.DateOBox.Location = new System.Drawing.Point(198, 120);
            this.DateOBox.Name = "DateOBox";
            this.DateOBox.Size = new System.Drawing.Size(126, 20);
            this.DateOBox.TabIndex = 15;
            // 
            // AddUrNalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 296);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddUrNalogForm";
            this.Text = "AddUrNalogForm";
            this.Load += new System.EventHandler(this.AddUrNalogForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox VidBox;
        private System.Windows.Forms.ComboBox InnBox;
        private System.Windows.Forms.TextBox SummBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DateOplBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SummOplBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DateOBox;
    }
}