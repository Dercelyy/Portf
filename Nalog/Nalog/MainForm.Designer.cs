namespace Nalog
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
            this.FizButton = new System.Windows.Forms.Button();
            this.UrButton = new System.Windows.Forms.Button();
            this.CityButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FizButton
            // 
            this.FizButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FizButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FizButton.Location = new System.Drawing.Point(6, 15);
            this.FizButton.Name = "FizButton";
            this.FizButton.Size = new System.Drawing.Size(101, 27);
            this.FizButton.TabIndex = 0;
            this.FizButton.Text = "Физ лица";
            this.FizButton.UseVisualStyleBackColor = false;
            this.FizButton.Click += new System.EventHandler(this.FizButton_Click);
            // 
            // UrButton
            // 
            this.UrButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UrButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UrButton.Location = new System.Drawing.Point(6, 15);
            this.UrButton.Name = "UrButton";
            this.UrButton.Size = new System.Drawing.Size(102, 27);
            this.UrButton.TabIndex = 0;
            this.UrButton.Text = "Юр лица";
            this.UrButton.UseVisualStyleBackColor = false;
            this.UrButton.Click += new System.EventHandler(this.UrButton_Click);
            // 
            // CityButton
            // 
            this.CityButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CityButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CityButton.Location = new System.Drawing.Point(274, 124);
            this.CityButton.Name = "CityButton";
            this.CityButton.Size = new System.Drawing.Size(86, 36);
            this.CityButton.TabIndex = 0;
            this.CityButton.Text = "Города";
            this.CityButton.UseVisualStyleBackColor = false;
            this.CityButton.Click += new System.EventHandler(this.CityButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.FizButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Физ лица";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(6, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 25);
            this.button4.TabIndex = 0;
            this.button4.Text = "Доходы физ лиц";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(113, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 27);
            this.button3.TabIndex = 0;
            this.button3.Text = "Источники доходов физ лиц";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(6, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "Виды налогов физ лиц";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(113, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Налоги физ лиц";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.UrButton);
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Юр лица";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(6, 75);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 25);
            this.button8.TabIndex = 0;
            this.button8.Text = "Доходы юр лиц";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(115, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(162, 27);
            this.button7.TabIndex = 0;
            this.button7.Text = "Деят юр лиц";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(6, 46);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 27);
            this.button6.TabIndex = 0;
            this.button6.Text = "Виды налогов юр лиц";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(115, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 27);
            this.button5.TabIndex = 0;
            this.button5.Text = "Налоги юр лиц";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(617, 172);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CityButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FizButton;
        private System.Windows.Forms.Button UrButton;
        private System.Windows.Forms.Button CityButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
    }
}

